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
    public class AccidentController : ControllerBase
    {
        AppDbContext dbContext;
        public AccidentController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("All")]
        public async Task<IActionResult> GetAllAccidents()
        {
            try
            {
                List<FMSAccidentVM> accidentsList = new List<FMSAccidentVM>();
                List<FMSAccident> accidents = await (from a in dbContext.FMSAccidents select a).ToListAsync();
                foreach (var accident in accidents)
                {
                    string driverName = await (from d in dbContext.FMSDrivers where d.Id == accident.DriverId select d.DriverName).SingleOrDefaultAsync();
                    string regionName = await (from r in dbContext.Regions where r.Id == accident.RegionId select r.XDescription).SingleOrDefaultAsync();
                    string subRegionName = await (from s in dbContext.SubRegions where s.Id == accident.SubRegionId select s.XDescription).SingleOrDefaultAsync();
                    Guid vehicleId = await (from v in dbContext.FMSVehiclesDev where v.Id == accident.FMSVehicleId select v.VehicleId).SingleOrDefaultAsync();
                    string vehicleNumber = await (from v in dbContext.Vehicles where v.Id == vehicleId select v.XDescription).SingleOrDefaultAsync();
                    accidentsList.Add(new FMSAccidentVM()
                    {
                        Id = accident.Id,
                        Description = accident.Description,
                        Driver = driverName,
                        Region = regionName,
                        SubRegion = subRegionName,
                        VehicleNumber = vehicleNumber,
                        MaintenanceStatus = accident.MaintenanceStatus == MaintenanceStatus.Done ? "Complete" : "Pending",
                        ReportTime = accident.TimeStamp,
                        CarOperationalTime = accident.CarOperationalTime,
                        JobClosingTime = accident.JobClosingTime,
                        LastUpdated = accident.LastUpdated
                    });
                }
                return Ok(accidentsList);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("Report")]
        public async Task<IActionResult> NewAccident(FMSAccidentVM accident)
        {
            try
            {
                Guid accidentId = Guid.NewGuid();
                Guid vehicleId = await (from v in dbContext.Vehicles where v.XDescription == accident.VehicleNumber select v.Id).FirstOrDefaultAsync();
                FMSVehicleDev vehicle = await (from v in dbContext.FMSVehiclesDev where v.VehicleId == vehicleId select v).SingleOrDefaultAsync();
                FMSAccident newAccident = new FMSAccident()
                {
                    Id = accidentId,
                    Description = accident.Description,
                    DriverId = vehicle.DriverId,
                    RegionId = vehicle.Region,
                    VehicleNumber = accident.VehicleNumber,
                    SubRegionId = vehicle.SubRegion,
                    FMSVehicleId = vehicle.Id,
                    MaintenanceStatus = accident.MaintenanceStatus == "Done" ? MaintenanceStatus.Done : MaintenanceStatus.InProgress,
                    TimeStamp = DateTime.Now,
                    LastUpdated = DateTime.Now
                };
                await dbContext.FMSAccidents.AddAsync(newAccident);
                await dbContext.SaveChangesAsync();
                vehicle.Status = "accidental";
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

                List<FMSAccidentalCheck> fmsAccidentalCheckList = new List<FMSAccidentalCheck>();
                foreach (var point in descriptionList)
                {
                    fmsAccidentalCheckList.Add(new FMSAccidentalCheck()
                    {
                        Id = Guid.NewGuid(),
                        Description = point,
                        FMSAccidentId = accidentId,
                        MaintenanceStatus = MaintenanceStatus.InProgress,
                        FMSVehicleId = vehicle.Id,
                        VehicleNumber = accident.VehicleNumber,
                        LastUpdated = DateTime.Now,
                        CommentCount = 0,
                        ImageCount = 0
                    });
                }

                await dbContext.AddRangeAsync(fmsAccidentalCheckList);
                await dbContext.SaveChangesAsync();

                return Ok(fmsAccidentalCheckList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/Demo/CarOperational")]
        public IActionResult CarOperational(FMSVehicleVM vehicle)
        {
            try
            {
                Vehicle vehicle1 = (from v in dbContext.Vehicles
                                    where v.XDescription == vehicle.VehicleNumber
                                    select v).FirstOrDefault();

                FMSVehicleDev fmsVehicle = (from v in dbContext.FMSVehiclesDev
                                            where v.VehicleId == vehicle1.Id
                                            select v).SingleOrDefault();

                fmsVehicle.Status = "maintained";
                dbContext.SaveChanges();

                FMSAccident accident = (from a in dbContext.FMSAccidents 
                                        where a.FMSVehicleId == fmsVehicle.Id && a.MaintenanceStatus == MaintenanceStatus.InProgress 
                                        select a).SingleOrDefault();

                accident.MaintenanceStatus = MaintenanceStatus.Done;
                accident.CarOperationalTime = PakistanDateTime.Now;
                accident.LastUpdated = PakistanDateTime.Now;
                dbContext.SaveChanges();

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

                FMSAccident accident = await dbContext.FMSAccidents
                    .Where(x => x.FMSVehicleId == fmsVehicle.Id && x.MaintenanceStatus == MaintenanceStatus.InProgress)
                    .SingleOrDefaultAsync();
                
                var checkList = await dbContext.FMSAccidentalCheckList.Where(x => x.FMSAccidentId == accident.Id).ToListAsync();
                checkList.ForEach(u => u.MaintenanceStatus = MaintenanceStatus.Done);

                accident.MaintenanceStatus = MaintenanceStatus.Done;
                accident.CarOperationalTime = PakistanDateTime.Now;
                accident.JobClosingTime = PakistanDateTime.Now;
                accident.LastUpdated = PakistanDateTime.Now;

                await dbContext.SaveChangesAsync();

                return Ok();
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
                FMSVehicleDev fmsVehicle = await (from v in dbContext.FMSVehiclesDev where v.VehicleId == vehicle.Id && v.Status == "accidental" select v).SingleOrDefaultAsync();
                FMSAccident fmsAccident = await (from a in dbContext.FMSAccidents where a.FMSVehicleId == fmsVehicle.Id && a.MaintenanceStatus == MaintenanceStatus.InProgress select a).FirstOrDefaultAsync();
                List<FMSAccidentalCheckVM> checkList = await (from c in dbContext.FMSAccidentalCheckList
                                                              where c.FMSAccidentId == fmsAccident.Id && c.FMSVehicleId == fmsVehicle.Id
                                                              select new FMSAccidentalCheckVM()
                                                              {
                                                                  Id = c.Id,
                                                                  Description = c.Description,
                                                                  LastUpdated = c.LastUpdated,
                                                                  MaintenanceStatus = c.MaintenanceStatus,
                                                                  CommentCount = c.CommentCount,
                                                                  FMSAccidentId = c.FMSAccidentId,
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
                FMSAccidentalCommentModalVM modal = new FMSAccidentalCommentModalVM();
                FMSAccidentalCheck check = await (from c in dbContext.FMSAccidentalCheckList where c.Id == request.FMSAccidentalCheckId select c).SingleOrDefaultAsync();
                modal.FMSAccidentalCheckId = check.Id;
                modal.FMSAccidentId = check.FMSAccidentId;
                modal.FMSVehicleId = check.FMSVehicleId;
                modal.CheckPointName = check.Description;
                modal.VehicleNumber = request.VehicleNumber;
                if (check.Description.Contains("Bills Posting")) modal.CommentModalType = CommentModalType.BillPosting;
                else if (check.Description.Contains("Assigning Workshop")) modal.CommentModalType = CommentModalType.AssignWorkshop;
                else modal.CommentModalType = CommentModalType.General;
                modal.Comments = await (from c in dbContext.FMSAccidentalCheckComments
                                        where c.FMSAccidentalCheckId == check.Id
                                        select new FMSAccidentalCheckCommentVM()
                                        {
                                            FMSAccidentalCheckId = c.FMSAccidentalCheckId,
                                            FMSAccidentId = c.FMSAccidentId,
                                            Comment = c.Comment,
                                            FMSVehicleId = c.FMSVehicleId,
                                            Id = c.Id,
                                            LastUpdated = c.LastUpdated,
                                            FMSUserId = c.FMSUserId,
                                            Mentions = c.Mentions,
                                            Name = (from u in dbContext.GBMSUsers where u.Id == c.FMSUserId select u.XName).SingleOrDefault(),
                                            VehicleNumber = c.VehicleNumber
                                        }).OrderByDescending(x => x.LastUpdated).ToListAsync();
                modal.Images = await (from i in dbContext.FMSAccidentalCheckImages
                                      where i.FMSAccidentalCheckId == check.Id
                                      select new FMSAccidentalCheckImageVM()
                                      {
                                          FMSAccidentId = i.FMSAccidentId,
                                          FMSAccidentalCheckId = i.FMSAccidentalCheckId,
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
                FMSAccidentalCheck check = await dbContext.FMSAccidentalCheckList.Where(x => x.Id == request.FMSAccidentalCheckId).Select(x => x).SingleOrDefaultAsync();
                FMSAccident accident = await dbContext.FMSAccidents.Where(x => x.Id == check.FMSAccidentId).Select(x => x).SingleOrDefaultAsync();
                check.MaintenanceStatus = MaintenanceStatus.Done;
                accident.LastUpdated = PakistanDateTime.Now;
                await dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList/Point/Comment/All")]
        public async Task<IActionResult> GetCheckListPointAllComments(ApiRequest request)
        {
            try
            {
                List<FMSAccidentalCheckCommentVM> Comments = await (from c in dbContext.FMSAccidentalCheckComments
                                        where c.FMSAccidentalCheckId == request.FMSAccidentalCheckId
                                        select new FMSAccidentalCheckCommentVM()
                                        {
                                            FMSAccidentalCheckId = c.FMSAccidentalCheckId,
                                            FMSAccidentId = c.FMSAccidentId,
                                            Comment = c.Comment,
                                            FMSVehicleId = c.FMSVehicleId,
                                            Id = c.Id,
                                            LastUpdated = c.LastUpdated,
                                            FMSUserId =c.FMSUserId,
                                            Mentions =c.Mentions,
                                            Name = (from u in dbContext.GBMSUsers where u.Id == c.FMSUserId select u.XName).SingleOrDefault(),
                                            VehicleNumber = c.VehicleNumber
                                        }).ToListAsync();
                return Ok(Comments);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList/Point/Comment/Add")]
        public async Task<IActionResult> AddCheckListPointComment(FMSAccidentalCheckCommentVM comment)
        {
            try
            {
                FMSAccidentalCheckComment newComment = new FMSAccidentalCheckComment()
                {
                    Id = Guid.NewGuid(),
                    FMSAccidentalCheckId = comment.FMSAccidentalCheckId,
                    FMSAccidentId = comment.FMSAccidentId,
                    Comment = comment.Comment,
                    FMSUserId = comment.FMSUserId,
                    FMSVehicleId = comment.FMSVehicleId,
                    VehicleNumber = comment.VehicleNumber,
                    LastUpdated = DateTime.Now,
                    Mentions = comment.Mentions
                };
                await dbContext.FMSAccidentalCheckComments.AddAsync(newComment);
                await dbContext.SaveChangesAsync();

                FMSAccidentalCheck check = await (from a in dbContext.FMSAccidentalCheckList
                                                  where a.Id == comment.FMSAccidentalCheckId
                                                  select a).SingleOrDefaultAsync();
                check.CommentCount = await (from c in dbContext.FMSAccidentalCheckComments
                                            where c.FMSAccidentalCheckId == comment.FMSAccidentalCheckId
                                            select c).CountAsync();

                FMSAccident accident = await dbContext.FMSAccidents.Where(x => x.Id == comment.FMSAccidentId).Select(x => x).SingleOrDefaultAsync();
                accident.LastUpdated = PakistanDateTime.Now;
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
