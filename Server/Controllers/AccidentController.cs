using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Hubs;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Enums;
using SOS.FMS.Shared.ViewModels;
using SOS.FMS.Shared.ViewModels.Accident;
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
        private readonly IHubContext<NotificationHub> hubContext;
        public AccidentController(AppDbContext dbContext, IHubContext<NotificationHub> hubContext)
        {
            this.dbContext = dbContext;
            this.hubContext = hubContext;
        }
        [HttpGet("All")]
        public async Task<IActionResult> GetAllAccidents()
        {
            try
            {
                List<FMSAccidentVM> accidentsList = new List<FMSAccidentVM>();
                List<FMSAccident> accidents = new List<FMSAccident>();
                if (User.IsInRole("SA") || User.IsInRole("HMT"))
                {
                    accidentsList = await (from a in dbContext.FMSAccidents 
                                       join d in dbContext.Drivers on a.DriverId equals d.Id
                                       join r in dbContext.Regions on a.RegionId equals r.Id
                                       join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                       join v in dbContext.Vehicles on a.FMSVehicleId equals v.Id
                                       join gv in dbContext.GBMSVehicles on v.VehicleNumber equals gv.Description
                                       select new FMSAccidentVM()
                                       {
                                           Id = a.Id,
                                           Description = a.Description,
                                           Driver = d.Name,
                                           Region = r.XDescription,
                                           SubRegion = s.XDescription,
                                           VehicleNumber = gv.Description,
                                           MaintenanceStatus = a.MaintenanceStatus == MaintenanceStatus.Done ? "Complete" : "Not Initiated",
                                           ReportTime = a.TimeStamp,
                                           CarOperationalTime = a.CarOperationalTime,
                                           JobClosingTime = a.JobClosingTime,
                                           LastUpdated = a.LastUpdated
                                       }).ToListAsync();
                }
                else
                {
                    ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                    Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();

                    accidentsList = await (from a in dbContext.FMSAccidents
                                           join d in dbContext.Drivers on a.DriverId equals d.Id
                                           join r in dbContext.Regions on a.RegionId equals r.Id
                                           join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                           join v in dbContext.Vehicles on a.FMSVehicleId equals v.Id
                                           join gv in dbContext.GBMSVehicles on v.VehicleNumber equals gv.Description
                                           where a.RegionId == region.Id
                                           select new FMSAccidentVM()
                                           {
                                               Id = a.Id,
                                               Description = a.Description,
                                               Driver = d.Name,
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               VehicleNumber = gv.Description,
                                               MaintenanceStatus = a.MaintenanceStatus == MaintenanceStatus.Done ? "Complete" : "Not Initiated",
                                               ReportTime = a.TimeStamp,
                                               CarOperationalTime = a.CarOperationalTime,
                                               JobClosingTime = a.JobClosingTime,
                                               LastUpdated = a.LastUpdated
                                           }).ToListAsync();
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
                Vehicle vehicle = await (from v in dbContext.Vehicles 
                                         where v.VehicleNumber == accident.VehicleNumber
                                         select v).SingleOrDefaultAsync();
                Driver driver = await (from d in dbContext.Drivers where d.VehicleNumber == accident.VehicleNumber select d).SingleOrDefaultAsync();
                vehicle.Score = vehicle.Score - 15;
                driver.Score = driver.Score - 20;
                vehicle.Breakdowns++;
                driver.Accidents++;

                FMSAccident newAccident = new FMSAccident()
                {
                    Id = accidentId,
                    Description = accident.Description,
                    DriverId = dbContext.Drivers.Where(x => x.VehicleNumber == accident.VehicleNumber).SingleOrDefault().Id,
                    RegionId = dbContext.Regions.Where(x => x.XDescription == vehicle.Region).SingleOrDefault().Id,
                    VehicleNumber = accident.VehicleNumber,
                    SubRegionId = dbContext.SubRegions.Where(x => x.XDescription == vehicle.SubRegion).SingleOrDefault().Id,
                    FMSVehicleId = vehicle.Id,
                    MaintenanceStatus = accident.MaintenanceStatus == "Done" ? MaintenanceStatus.Done : MaintenanceStatus.NotInitiated,
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
                        MaintenanceStatus = MaintenanceStatus.NotInitiated,
                        FMSVehicleId = vehicle.Id,
                        VehicleNumber = accident.VehicleNumber,
                        LastUpdated = DateTime.Now,
                        CommentCount = 0,
                        ImageCount = 0
                    });
                }

                await dbContext.AddRangeAsync(fmsAccidentalCheckList);
                await dbContext.SaveChangesAsync();

                string title = $"Accidental Job Vehicle Number {accident.VehicleNumber}";
                string notification = $"Vehicle Number {accident.VehicleNumber} marked as accidental";
                await hubContext.Clients.All.SendAsync("ReceiveMessageAllUsers",
                    User.Identity.Name,
                    title,
                    notification);

                return Ok(fmsAccidentalCheckList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("FMS/checkAccidentalStatus")]
        public async Task<IActionResult> checkAccidentalStatus(ApiRequest request)
        {
            try
            {
                Vehicle fmsVehicle =await (from v in dbContext.Vehicles
                                      where v.VehicleNumber == request.VehicleNumber
                                      select v).SingleOrDefaultAsync();


                FMSAccident accident = await dbContext.FMSAccidents
                    .Where(x => x.FMSVehicleId == fmsVehicle.Id && (x.MaintenanceStatus == MaintenanceStatus.NotInitiated || x.MaintenanceStatus == MaintenanceStatus.Operational))
                    .SingleOrDefaultAsync();
                if (accident != null)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
               
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("FMS/Demo/CarOperational")]
        public async Task<IActionResult> CarOperational(ApiRequest vehicle)
        {
            try
            {
                Vehicle fmsVehicle = (from v in dbContext.Vehicles
                                      where v.VehicleNumber == vehicle.VehicleNumber
                                      select v).SingleOrDefault();

                dbContext.SaveChanges();

                FMSAccident accident = (from a in dbContext.FMSAccidents 
                                        where a.FMSVehicleId == fmsVehicle.Id && a.MaintenanceStatus == MaintenanceStatus.NotInitiated
                                        select a).SingleOrDefault();

                accident.MaintenanceStatus = MaintenanceStatus.Operational;
                accident.CarOperationalTime = PakistanDateTime.Now;
                accident.LastUpdated = PakistanDateTime.Now;
                dbContext.SaveChanges();

                string title = $"Accidental Job Vehicle Number {vehicle.VehicleNumber}";
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
        [HttpPost("FMS/Demo/CloseJob")]
        public async Task<IActionResult> CloseJob(ApiRequest request)
        {
            try
            {

                Vehicle fmsVehicle = (from v in dbContext.Vehicles
                                      where v.VehicleNumber == request.VehicleNumber
                                      select v).SingleOrDefault();

                List<FMSAccident> accidents = await dbContext.FMSAccidents
                    .Where(x => x.FMSVehicleId == fmsVehicle.Id && (x.MaintenanceStatus == MaintenanceStatus.NotInitiated || x.MaintenanceStatus == MaintenanceStatus.Operational)).ToListAsync();
                if (accidents.Count == 0)
                {
                    return NoContent();
                }
                foreach (var accident in accidents)
                {
                    var checkList = await dbContext.FMSAccidentalCheckList.Where(x => x.FMSAccidentId == accident.Id).ToListAsync();
                    checkList.ForEach(u => u.MaintenanceStatus = MaintenanceStatus.Done);
                    if (accident.MaintenanceStatus != MaintenanceStatus.Operational)
                    {
                        accident.CarOperationalTime = PakistanDateTime.Now;
                    }
                    accident.MaintenanceStatus = MaintenanceStatus.Done;
                    accident.JobClosingTime = PakistanDateTime.Now;
                    accident.LastUpdated = PakistanDateTime.Now;
                }

                FMSEmergency emergencyCheck = await dbContext.FMSEmergencies
                   .Where(x => x.FMSVehicleId == fmsVehicle.Id && x.MaintenanceStatus == MaintenanceStatus.NotInitiated)
                   .SingleOrDefaultAsync();
                if (emergencyCheck != null)
                {
                    fmsVehicle.Status = "emergency";
                }
                else
                {
                    fmsVehicle.Status = "maintained";
                }
                await dbContext.SaveChangesAsync();

                string notification = $"Accidental Job with Vehicle Number {request.VehicleNumber} marked as closed";
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
        [HttpPost("FMS/CheckList")]
        public async Task<IActionResult> GetCheckListByVehicleNumber(ApiRequest request)
        {
            try
            {
                Vehicle fmsVehicle = await (from v in dbContext.Vehicles where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefaultAsync();
                FMSAccident fmsAccident = await (from a in dbContext.FMSAccidents where a.FMSVehicleId == fmsVehicle.Id && (a.MaintenanceStatus == MaintenanceStatus.NotInitiated || a.MaintenanceStatus == MaintenanceStatus.Operational) select a).FirstOrDefaultAsync();
                if (fmsAccident == null)
                {
                    return NotFound();
                }
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
                                            FMSUserName = (from u in dbContext.Users where u.Id == c.FMSUserId.ToString() select u.Name).SingleOrDefault(),
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
                                            FMSUserName = (from u in dbContext.Users where u.Id == c.FMSUserId.ToString() select u.Name).SingleOrDefault(),
                                            Mentions = c.Mentions,
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
                var currentUser = (from u in dbContext.Users
                                   where u.Email == User.Identity.Name
                                   select u).FirstOrDefault();
                FMSAccidentalCheckComment newComment = new FMSAccidentalCheckComment()
                {
                    Id = Guid.NewGuid(),
                    FMSAccidentalCheckId = comment.FMSAccidentalCheckId,
                    FMSAccidentId = comment.FMSAccidentId,
                    Comment = comment.Comment,
                    FMSUserId = new Guid((from u in dbContext.Users where u.Email == User.Identity.Name select u.Id).SingleOrDefault()),
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
                            $"{currentUser.Name} mentioned you in a comment under accidental check list point {check.Description}");
                    }
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("PostBill")]
        public async Task<IActionResult> PostBill(BillPostingVM bill)
        {
            try
            {
                var currentUser = (from u in dbContext.Users
                                   where u.Email == User.Identity.Name
                                   select u).FirstOrDefault();

                FMSAccidentalCheck check = (from c in dbContext.FMSAccidentalCheckList
                                            where c.Id == bill.CheckPointId
                                            select c).SingleOrDefault();

                FMSAccidentalCheckComment newComment = new FMSAccidentalCheckComment()
                {
                    Id = Guid.NewGuid(),
                    FMSAccidentalCheckId = check.Id,
                    FMSAccidentId = check.FMSAccidentId,
                    Comment = bill.TotalAmount.ToString(),
                    FMSUserId = new Guid((from u in dbContext.Users where u.Email == User.Identity.Name select u.Id).SingleOrDefault()),
                    FMSVehicleId = check.FMSVehicleId,
                    VehicleNumber = check.VehicleNumber,
                    LastUpdated = DateTime.Now,
                    Mentions = ""
                };
                await dbContext.FMSAccidentalCheckComments.AddAsync(newComment);
                await dbContext.SaveChangesAsync();

                check.CommentCount = await (from c in dbContext.FMSAccidentalCheckComments
                                            where c.FMSAccidentalCheckId == bill.CheckPointId
                                            select c).CountAsync();

                FMSAccident accident = await dbContext.FMSAccidents.Where(x => x.Id == check.FMSAccidentId).Select(x => x).SingleOrDefaultAsync();
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
