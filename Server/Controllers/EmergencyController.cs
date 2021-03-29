using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Hubs;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Enums;
using SOS.FMS.Shared.ViewModels;
using SOS.FMS.Shared.ViewModels.Emergency;
using SOS.FMS.Shared.ViewModels.Incident;
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
        readonly AppDbContext dbContext;
        private readonly IHubContext<NotificationHub> hubContext;
        public EmergencyController(AppDbContext dbContext, IHubContext<NotificationHub> hubContext)
        {
            this.dbContext = dbContext;
            this.hubContext = hubContext;
        }
        [HttpGet("All")]
        public async Task<IActionResult> GetAllEmergencies()
        {
            try
            {
                List<FMSEmergencyVM> emergencyList = new();
                List<Emergency> emergencies = new();
                if (User.IsInRole("SA") || User.IsInRole("HMT"))
                {
                    emergencyList = await (from e in dbContext.Emergencies
                                         join d in dbContext.Drivers on e.DriverId equals d.Id
                                         join r in dbContext.Regions on e.RegionId equals r.Id
                                         join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                         join v in dbContext.Vehicles on e.FMSVehicleId equals v.Id
                                         select new FMSEmergencyVM()
                                         {
                                             Id = e.Id,
                                             Description = e.Description,
                                             Driver = d.Name,
                                             Region = r.XDescription,
                                             SubRegion = s.XDescription,
                                             VehicleNumber = v.VehicleNumber,
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

                    emergencyList = await (from e in dbContext.Emergencies
                                           join d in dbContext.Drivers on e.DriverId equals d.Id
                                           join r in dbContext.Regions on e.RegionId equals r.Id
                                           join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                           join v in dbContext.Vehicles on e.FMSVehicleId equals v.Id
                                           where e.RegionId == region.Id
                                           select new FMSEmergencyVM()
                                           {
                                               Id = e.Id,
                                               Description = e.Description,
                                               Driver = d.Name,
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               VehicleNumber = v.VehicleNumber,
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
                Vehicle fmsVehicle = (from v in dbContext.Vehicles
                                      where v.VehicleNumber == emergency.VehicleNumber
                                      select v).SingleOrDefault();

                Guid emergencyId = Guid.NewGuid();
                Vehicle vehicle = await (from v in dbContext.Vehicles where v.VehicleNumber == emergency.VehicleNumber select v).SingleOrDefaultAsync();
                Driver driver = await (from d in dbContext.Drivers where d.VehicleNumber == emergency.VehicleNumber select d).SingleOrDefaultAsync();

                vehicle.Breakdowns++;
                driver.Emergencies++;

                vehicle.EmergencyStatus = EmergencyMaintenanceStatus.Pending;

                Emergency newEmergency = new()
                {
                    Id = emergencyId,
                    Description = emergency.Description,
                    DriverId =driver.Id,
                    RegionId = dbContext.Regions.Where(x => x.XDescription == vehicle.Region).SingleOrDefault().Id,
                    VehicleNumber = emergency.VehicleNumber,
                    SubRegionId = dbContext.SubRegions.Where(x => x.XDescription == vehicle.SubRegion).SingleOrDefault().Id,
                    FMSVehicleId = vehicle.Id,
                    MaintenanceStatus = MaintenanceStatus.NotInitiated,
                    TimeStamp = DateTime.Now,
                    LastUpdated = DateTime.Now

                };
                await dbContext.Emergencies.AddAsync(newEmergency);
                await dbContext.SaveChangesAsync();
                vehicle.Status = "emergency";
                await dbContext.SaveChangesAsync();

                List<string> descriptionList = new()
                {
                    "a. Region/Control inform about vehicle incident",
                    "b. Vehicle Lifting / Movement Inform To Risk Department",
                    "c. Assigning Workshop",
                    "d. Driver & Controller Statement / Documents",
                    "e. Work Estimation & Surveyor of Insurance",
                    "f. Work Approval / Work Start",
                    "g. Vehicle Delivery Time",
                    "h. Work Done & Report",
                    "i. Bills Posting / Pics Uploading In System"
                };

                List<FMSEmergencyCheck> fmsEmergencyCheckList = new();
                foreach (var point in descriptionList)
                {
                    fmsEmergencyCheckList.Add(new FMSEmergencyCheck()
                    {
                        Id = Guid.NewGuid(),
                        Description = point,
                        FMSEmergencyId = emergencyId,
                        MaintenanceStatus = CheckMaintenanceStatus.NotInitiated,
                        FMSVehicleId = vehicle.Id,
                        VehicleNumber = emergency.VehicleNumber,
                        LastUpdated = DateTime.Now,
                        CommentCount = 0,
                        ImageCount = 0
                    });
                }

                await dbContext.AddRangeAsync(fmsEmergencyCheckList);
                await dbContext.SaveChangesAsync();

                string title = $"Emergency Job Vehicle Number {emergency.VehicleNumber}";
                string notification = $"Vehicle Number {emergency.VehicleNumber} marked as emergency";
                await hubContext.Clients.All.SendAsync("ReceiveMessageAllUsers",
                    User.Identity.Name,
                    title,
                    notification);

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
                Vehicle fmsVehicle = await (from v in dbContext.Vehicles where v.VehicleNumber == request.VehicleNumber && (v.Status == "emergency" || v.Status == "accidental") select v).SingleOrDefaultAsync();
                Emergency fmsEmergency = await (from e in dbContext.Emergencies where e.FMSVehicleId == fmsVehicle.Id && e.MaintenanceStatus == MaintenanceStatus.NotInitiated select e).FirstOrDefaultAsync();
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

                return Ok(checkList.OrderBy(x => x.Description).ToList());
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
                FMSEmergencyCommentModalVM modal = new();
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
                                            Name = (from u in dbContext.Users where u.Id == c.FMSUserId.ToString() select u.Name).SingleOrDefault(),
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
                Emergency emergency = await dbContext.Emergencies.Where(x => x.Id == check.FMSEmergencyId).SingleOrDefaultAsync();
                check.MaintenanceStatus = CheckMaintenanceStatus.Done;
                emergency.LastUpdated = PakistanDateTime.Now;
                await dbContext.SaveChangesAsync();
                string title = $"Accidental Job Vehicle Number {check.VehicleNumber}";
                string notification = $"Check Point {check.Description} marked as done";
                await hubContext.Clients.All.SendAsync("ReceiveMessageAllUsers",
                    User.Identity.Name,
                    title,
                    notification);

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
                var currentUser = (from u in dbContext.Users
                                   where u.Email == User.Identity.Name
                                   select u).FirstOrDefault();
                FMSEmergencyCheckComment newComment = new()
                {
                    Id = Guid.NewGuid(),
                    FMSEmergencyCheckId = comment.FMSEmergencyCheckId,
                    FMSEmergencyId = comment.FMSEmergencyId,
                    Comment = comment.Comment,
                    FMSUserId = new Guid((from u in dbContext.Users where u.Email == User.Identity.Name select u.Id).SingleOrDefault()),
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
                check.MaintenanceStatus = CheckMaintenanceStatus.InProgress;
                await dbContext.SaveChangesAsync();


                if (!string.IsNullOrEmpty(comment.Mentions))
                {
                    string[] mentions = comment.Mentions.Split(',');
                    foreach (var mention in mentions)
                    {
                        ApplicationUser user = (from u in dbContext.Users
                                                where u.Id == mention
                                                select u).FirstOrDefault();

                        await hubContext.Clients.All.SendAsync("ReceiveMessage",
                            user.Email,
                            $"Notification for Vehicle Number {check.VehicleNumber}",
                            $"{currentUser.Name} mentioned you in a comment under emergency check list point {check.Description}");
                    }
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("CarOperational")]
        public async Task<IActionResult> CarOperational(ApiRequest vehicle)
        {
            try
            {
                Vehicle fmsVehicle = (from v in dbContext.Vehicles
                                      where v.VehicleNumber == vehicle.VehicleNumber
                                      select v).SingleOrDefault();
                fmsVehicle.Status = "maintained";
                fmsVehicle.EmergencyStatus = EmergencyMaintenanceStatus.Done;

                dbContext.SaveChanges();

                Emergency emergency = (from a in dbContext.Emergencies
                                        where a.FMSVehicleId == fmsVehicle.Id && a.MaintenanceStatus == MaintenanceStatus.NotInitiated
                                        select a).SingleOrDefault();

                emergency.MaintenanceStatus = MaintenanceStatus.Operational;
                emergency.CarOperationalTime = PakistanDateTime.Now;
                emergency.LastUpdated = PakistanDateTime.Now;
                dbContext.SaveChanges();

                string title = $"Emergency Job Vehicle Number {vehicle.VehicleNumber}";
                string notification = $"Vehicle Number {vehicle.VehicleNumber} marked as operational";
                await hubContext.Clients.All.SendAsync("ReceiveMessageAllUsers",
                    User.Identity.Name,
                    title,
                    notification);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("CloseJob")]
        public async Task<IActionResult> CloseJob(ApiRequest request)
        {
            try
            {
                Vehicle fmsVehicle = (from v in dbContext.Vehicles
                                            where v.VehicleNumber == request.VehicleNumber
                                      select v).SingleOrDefault();

                List<Emergency> emergencies = await dbContext.Emergencies
                    .Where(x => x.FMSVehicleId == fmsVehicle.Id && (x.MaintenanceStatus == MaintenanceStatus.NotInitiated || x.MaintenanceStatus == MaintenanceStatus.Operational)).ToListAsync();
                foreach (var emergency in emergencies)
                {
                    var checkList = await dbContext.FMSEmergencyCheckList.Where(x => x.FMSEmergencyId == emergency.Id).ToListAsync();
                    checkList.ForEach(u => u.MaintenanceStatus = CheckMaintenanceStatus.Done);

                    emergency.MaintenanceStatus = MaintenanceStatus.Done;
                    emergency.CarOperationalTime = PakistanDateTime.Now;
                    emergency.JobClosingTime = PakistanDateTime.Now;
                    emergency.LastUpdated = PakistanDateTime.Now;
                }
                fmsVehicle.EmergencyStatus = EmergencyMaintenanceStatus.Done;
                if (fmsVehicle.AccidentalStatus == AccidentalMaintenanceStatus.Pending)
                {
                    fmsVehicle.Status = "accidental";
                }
                else
                    if (fmsVehicle.PeriodicStatus == PeriodicMaintenanceStatus.Pending)
                {
                    fmsVehicle.Status = "periodic";
                }
                else
                {
                    fmsVehicle.Status = "maintained";
                }

                await dbContext.SaveChangesAsync();

                string notification = $"Emergency Job with Vehicle Number {request.VehicleNumber} marked as closed";
                await hubContext.Clients.All.SendAsync("ReceiveMessageAllUsers",
                    User.Identity.Name,
                    "Notification",
                    notification);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("FMS/checkEmergencyStatus")]
        public async Task<IActionResult> CheckEmergencyStatus(ApiRequest request)
        {
            try
            {
                Vehicle fmsVehicle = (from v in dbContext.Vehicles
                                      where v.VehicleNumber == request.VehicleNumber
                                      select v).SingleOrDefault();

                Emergency emergency = await dbContext.Emergencies
                    .Where(x => x.FMSVehicleId == fmsVehicle.Id && x.MaintenanceStatus == MaintenanceStatus.NotInitiated)
                    .SingleOrDefaultAsync();
                if (emergency != null)
                {
                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("PostBill")]
        public async Task<IActionResult> PostBill(EmergencyBill bill)
        {
            try
            {
                var currentUser = (from u in dbContext.Users
                                   where u.Email == User.Identity.Name
                                   select u).FirstOrDefault();

                FMSEmergencyCheck check = (from c in dbContext.FMSEmergencyCheckList
                                            where c.Id == bill.CheckPointId
                                            select c).SingleOrDefault();
                check.MaintenanceStatus = CheckMaintenanceStatus.InProgress;
                FMSEmergencyCheckComment newComment = new()
                {
                    Id = Guid.NewGuid(),
                    FMSEmergencyCheckId = check.Id,
                    FMSEmergencyId = check.FMSEmergencyId,
                    Comment = bill.BillAmount.ToString(),
                    FMSUserId = new Guid((from u in dbContext.Users where u.Email == User.Identity.Name select u.Id).SingleOrDefault()),
                    FMSVehicleId = check.FMSVehicleId,
                    VehicleNumber = check.VehicleNumber,
                    LastUpdated = DateTime.Now,
                    Mentions = ""
                };

                await dbContext.FMSEmergencyCheckComments.AddAsync(newComment);
                await dbContext.SaveChangesAsync();

                bill.Id = new Guid();
                await dbContext.EmergencyBills.AddAsync(bill);
                await dbContext.SaveChangesAsync();

                check.CommentCount = await (from c in dbContext.FMSEmergencyCheckComments
                                            where c.FMSEmergencyCheckId == bill.CheckPointId
                                            select c).CountAsync();
                Emergency emergency = await dbContext.Emergencies.Where(x => x.Id == check.FMSEmergencyId).Select(x => x).SingleOrDefaultAsync();
                emergency.LastUpdated = PakistanDateTime.Now;
                await dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("GetBills")]
        public async Task<IActionResult> GetBills(ApiRequest request)
        {
            try
            {
                List<EmergencyBill> Bills = await (from b in dbContext.EmergencyBills
                                                  where b.CheckPointId == request.FMSEmergencyCheckId
                                                  select b).ToListAsync();
                return Ok(Bills);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost("GetBillDetails")]
        public async Task<IActionResult> GetBillDetails(ApiRequest request)
        {
            try
            {
                List<BillDetailVM> details = await (from b in dbContext.EmergencyBillDetails
                                                    where b.CheckPointId == request.FMSEmergencyCheckId
                                                    select new BillDetailVM()
                                                    {
                                                        CheckPointId = b.CheckPointId,
                                                        ServiceType = b.ServiceType,
                                                        SubServiceType = b.SubServiceType,
                                                        Amount = Convert.ToInt32(b.Amount)
                                                    }).ToListAsync();
                return Ok(details);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("PostBillDetail")]
        public async Task<IActionResult> PostBillDetail(BillDetailVM billDetail)
        {
            try
            {
                FMSEmergencyCheck check = (from c in dbContext.FMSEmergencyCheckList
                                            where c.Id == billDetail.CheckPointId
                                            select c).SingleOrDefault();
                check.MaintenanceStatus = CheckMaintenanceStatus.InProgress;

                EmergencyBillDetail detail = new()
                {
                    Id = Guid.NewGuid(),
                    CheckPointId = billDetail.CheckPointId,
                    ServiceType = billDetail.ServiceType,
                    SubServiceType = billDetail.SubServiceType,
                    Amount = Convert.ToString(billDetail.Amount)
                };

                await dbContext.EmergencyBillDetails.AddAsync(detail);
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
