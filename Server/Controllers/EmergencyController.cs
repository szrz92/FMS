using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Enums;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmergencyController : ControllerBase
    {
        AppDbContext dbContext;
        public EmergencyController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("All")]
        public async Task<IActionResult> GetAllEmergencies()
        {
            try
            {
                List<FMSEmergencyVM> emergencyList = new List<FMSEmergencyVM>();
                List<FMSEmergency> emergencies = new List<FMSEmergency>();
                if (User.IsInRole("SA") || User.IsInRole("HMT"))
                {
                    emergencyList = await (from e in dbContext.FMSEmergencies
                                         join d in dbContext.FMSDrivers on e.DriverId equals d.Id
                                         join r in dbContext.Regions on e.RegionId equals r.Id
                                         join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                         join v in dbContext.FMSVehiclesDev on e.FMSVehicleId equals v.Id
                                         join gv in dbContext.Vehicles on v.VehicleId equals gv.Id
                                         select new FMSEmergencyVM()
                                         {
                                             Id = e.Id,
                                             Description = e.Description,
                                             Driver = d.DriverName,
                                             Region = r.XDescription,
                                             SubRegion = s.XDescription,
                                             VehicleNumber = gv.XDescription,
                                             MaintenanceStatus = e.MaintenanceStatus == MaintenanceStatus.Done ? "Complete" : "Not Initiated",
                                             ReportTime = e.TimeStamp,
                                             CarOperationalTime = e.CarOperationalTime,
                                             JobClosingTime = e.JobClosingTime,
                                             LastUpdated = e.LastUpdated
                                         }).ToListAsync();
                }
                else
                {
                    ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                    Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();

                    emergencyList = await (from e in dbContext.FMSEmergencies
                                           join d in dbContext.FMSDrivers on e.DriverId equals d.Id
                                           join r in dbContext.Regions on e.RegionId equals r.Id
                                           join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                           join v in dbContext.FMSVehiclesDev on e.FMSVehicleId equals v.Id
                                           join gv in dbContext.Vehicles on v.VehicleId equals gv.Id
                                           where e.RegionId == region.Id
                                           select new FMSEmergencyVM()
                                           {
                                               Id = e.Id,
                                               Description = e.Description,
                                               Driver = d.DriverName,
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               VehicleNumber = gv.XDescription,
                                               MaintenanceStatus = e.MaintenanceStatus == MaintenanceStatus.Done ? "Complete" : "Not Initiated",
                                               ReportTime = e.TimeStamp,
                                               CarOperationalTime = e.CarOperationalTime,
                                               JobClosingTime = e.JobClosingTime,
                                               LastUpdated = e.LastUpdated
                                           }).ToListAsync();
                }
                return Ok(emergencyList);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("Report")]
        public async Task<IActionResult> NewEmergency(FMSEmergencyVM emergency)
        {
            try
            {
                Guid emergencyId = Guid.NewGuid();
                Guid vehicleId = await (from v in dbContext.Vehicles where v.XDescription == emergency.VehicleNumber select v.Id).FirstOrDefaultAsync();
                FMSVehicleDev vehicle = await (from v in dbContext.FMSVehiclesDev where v.VehicleId == vehicleId select v).SingleOrDefaultAsync();
                FMSEmergency newEmergency = new FMSEmergency()
                {
                    Id = emergencyId,
                    Description = emergency.Description,
                    DriverId = vehicle.DriverId,
                    RegionId = vehicle.Region,
                    VehicleNumber = emergency.VehicleNumber,
                    SubRegionId = vehicle.SubRegion,
                    FMSVehicleId = vehicle.Id,
                    MaintenanceStatus = emergency.MaintenanceStatus == "Done" ? MaintenanceStatus.Done : MaintenanceStatus.NotInitiated,
                    TimeStamp = DateTime.Now,
                    LastUpdated = DateTime.Now
                };
                await dbContext.FMSEmergencies.AddAsync(newEmergency);
                await dbContext.SaveChangesAsync();
                vehicle.Status = "emergency";
                await dbContext.SaveChangesAsync();

                List<string> descriptionList = new List<string>()
                {
                    "Region/Control inform about vehicle incident",
                    "Vehicle Lifting / Movement Inform To Risk Department",
                    "Assigning Workshop",
                    "Driver & Controller Statement / Documents",
                    "Work Estimation & Surveyor of Insurance",
                    "Work Approval / Work Start",
                    "Vehicle Delivery Time",
                    "Work Done & Report",
                    "Bills Posting / Pics Uploading In System"
                };

                List<FMSEmergencyCheck> fmsEmergencyCheckList = new List<FMSEmergencyCheck>();
                foreach (var point in descriptionList)
                {
                    fmsEmergencyCheckList.Add(new FMSEmergencyCheck()
                    {
                        Id = Guid.NewGuid(),
                        Description = point,
                        FMSEmergencyId = emergencyId,
                        MaintenanceStatus = MaintenanceStatus.NotInitiated,
                        FMSVehicleId = vehicle.Id,
                        VehicleNumber = emergency.VehicleNumber,
                        LastUpdated = DateTime.Now,
                        CommentCount = 0,
                        ImageCount = 0
                    });
                }

                await dbContext.AddRangeAsync(fmsEmergencyCheckList);
                await dbContext.SaveChangesAsync();

                return Ok(fmsEmergencyCheckList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList")]
        public async Task<IActionResult> GetCheckListByVehicleNumber(ApiRequest request)
        {
            try
            {
                Vehicle vehicle = await (from v in dbContext.Vehicles where v.XDescription == request.VehicleNumber select v).FirstOrDefaultAsync();
                FMSVehicleDev fmsVehicle = await (from v in dbContext.FMSVehiclesDev where v.VehicleId == vehicle.Id && v.Status == "emergency" select v).SingleOrDefaultAsync();
                FMSEmergency fmsEmergency = await (from e in dbContext.FMSEmergencies where e.FMSVehicleId == fmsVehicle.Id && e.MaintenanceStatus == MaintenanceStatus.NotInitiated select e).FirstOrDefaultAsync();
                List<FMSEmergencyCheckVM> checkList = await (from c in dbContext.FMSEmergencyCheckList
                                                             where c.FMSEmergencyId == fmsEmergency.Id && c.FMSVehicleId == fmsVehicle.Id
                                                             select new FMSEmergencyCheckVM()
                                                             {
                                                                 Id = c.Id,
                                                                 Description = c.Description,
                                                                 LastUpdated = c.LastUpdated,
                                                                 MaintenanceStatus = c.MaintenanceStatus,
                                                                 CommentCount = c.CommentCount,
                                                                 FMSEmergencyId = c.FMSEmergencyId,
                                                                 FMSVehicleId = c.FMSVehicleId,
                                                                 ImageCount = c.ImageCount
                                                             }).ToListAsync();

                return Ok(checkList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList/Point")]
        public async Task<IActionResult> GetCheckListPointDetails(ApiRequest request)
        {
            try
            {
                FMSEmergencyCommentModalVM modal = new FMSEmergencyCommentModalVM();
                FMSEmergencyCheck check = await (from c in dbContext.FMSEmergencyCheckList where c.Id == request.FMSEmergencyCheckId select c).SingleOrDefaultAsync();
                modal.FMSEmergencyCheckId = check.Id;
                modal.FMSEmergencyId = check.FMSEmergencyId;
                modal.FMSVehicleId = check.FMSVehicleId;
                modal.CheckPointName = check.Description;
                modal.VehicleNumber = request.VehicleNumber;
                if (check.Description.Contains("Bills Posting")) modal.CommentModalType = CommentModalType.BillPosting;
                else if (check.Description.Contains("Assigning Workshop")) modal.CommentModalType = CommentModalType.AssignWorkshop;
                else modal.CommentModalType = CommentModalType.General;
                modal.Comments = await (from c in dbContext.FMSEmergencyCheckComments
                                        where c.FMSEmergencyCheckId == check.Id
                                        select new FMSEmergencyCheckCommentVM()
                                        {
                                            FMSEmergencyCheckId = c.FMSEmergencyCheckId,
                                            FMSEmergencyId = c.FMSEmergencyId,
                                            Comment = c.Comment,
                                            FMSVehicleId = c.FMSVehicleId,
                                            Id = c.Id,
                                            LastUpdated = c.LastUpdated,
                                            FMSUserId = c.FMSUserId,
                                            Mentions = c.Mentions,
                                            Name = (from u in dbContext.GBMSUsers where u.Id == c.FMSUserId select u.XName).SingleOrDefault(),
                                            VehicleNumber = c.VehicleNumber
                                        }).OrderByDescending(x => x.LastUpdated).ToListAsync();
                modal.Images = await (from i in dbContext.FMSEmergencyCheckImages
                                      where i.FMSEmergencyCheckId == check.Id
                                      select new FMSEmergencyCheckImageVM()
                                      {
                                          FMSEmergencyId = i.FMSEmergencyId,
                                          FMSEmergencyCheckId = i.FMSEmergencyCheckId,
                                          FMSVehicleId = i.FMSVehicleId,
                                          Id = i.Id,
                                          Image = i.Image,
                                          LastUpdated = i.LastUpdated
                                      }).ToListAsync();
                return Ok(modal);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList/Point/MarkDone")]
        public async Task<IActionResult> GetCheckListPointMarkDone(ApiRequest request)
        {
            try
            {
                FMSEmergencyCheck check = await dbContext.FMSEmergencyCheckList.Where(x => x.Id == request.FMSEmergencyCheckId).Select(x => x).SingleOrDefaultAsync();
                check.MaintenanceStatus = MaintenanceStatus.Done;
                await dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList/Point/Comment/Add")]
        public async Task<IActionResult> AddCheckListPointComment(FMSEmergencyCheckCommentVM comment)
        {
            try
            {
                FMSEmergencyCheckComment newComment = new FMSEmergencyCheckComment()
                {
                    Id = Guid.NewGuid(),
                    FMSEmergencyCheckId = comment.FMSEmergencyCheckId,
                    FMSEmergencyId = comment.FMSEmergencyId,
                    Comment = comment.Comment,
                    FMSUserId = comment.FMSUserId,
                    FMSVehicleId = comment.FMSVehicleId,
                    VehicleNumber = comment.VehicleNumber,
                    LastUpdated = DateTime.Now,
                    Mentions = comment.Mentions
                };
                await dbContext.FMSEmergencyCheckComments.AddAsync(newComment);
                await dbContext.SaveChangesAsync();

                FMSEmergencyCheck check = await (from a in dbContext.FMSEmergencyCheckList
                                                 where a.Id == comment.FMSEmergencyCheckId
                                                 select a).SingleOrDefaultAsync();
                check.CommentCount = await (from c in dbContext.FMSEmergencyCheckComments
                                            where c.FMSEmergencyCheckId == comment.FMSEmergencyCheckId
                                            select c).CountAsync();
                await dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/Demo/CloseJob")]
        public async Task<IActionResult> CloseJob(ApiRequest request)
        {
            try
            {
                Vehicle vehicle = (from v in dbContext.Vehicles
                                   where v.XDescription == request.VehicleNumber
                                   select v).FirstOrDefault();

                FMSVehicleDev fmsVehicle = (from v in dbContext.FMSVehiclesDev
                                            where v.VehicleId == vehicle.Id
                                            select v).SingleOrDefault();

                fmsVehicle.Status = "maintained";

                FMSEmergency emergency = await dbContext.FMSEmergencies
                    .Where(x => x.FMSVehicleId == fmsVehicle.Id && x.MaintenanceStatus == MaintenanceStatus.NotInitiated)
                    .SingleOrDefaultAsync();

                var checkList = await dbContext.FMSEmergencyCheckList.Where(x => x.FMSEmergencyId == emergency.Id).ToListAsync();
                checkList.ForEach(u => u.MaintenanceStatus = MaintenanceStatus.Done);

                emergency.MaintenanceStatus = MaintenanceStatus.Done;
                emergency.CarOperationalTime = PakistanDateTime.Now;
                emergency.JobClosingTime = PakistanDateTime.Now;
                emergency.LastUpdated = PakistanDateTime.Now;

                await dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
