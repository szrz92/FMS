using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Enums;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintsController : ControllerBase
    {
        AppDbContext dbContext;
        public ComplaintsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("All/Active/Count")]
        public IActionResult AllActiveSinceLastMonthCount()
        {
            try
            {
                int ComplaintsCount = 0;
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        ComplaintsCount = (from c in dbContext.Complaints where c.IsActive select c).Count();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        ComplaintsCount = (from c in dbContext.Complaints
                                           where c.IsActive
                                           && c.Region == region.XDescription
                                           select c).Count();
                    }
                }
                return Ok(ComplaintsCount.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("All/Active")]
        public async Task<IActionResult> AllActiveSinceLastMonth()
        {
            try
            {
                List<ComplaintVM> complaints = new List<ComplaintVM>();
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        complaints = await (from c in dbContext.Complaints
                                            where c.IsActive
                                            select new ComplaintVM()
                                            {
                                                Id = c.Id,
                                                IsActive = c.IsActive,
                                                ComplaintDescription = c.Description,
                                                DriverName = c.DriverName,
                                                PointCode = c.PointCode,
                                                PointCodeDescription = c.PointCodeDescription,
                                                Region = c.Region,
                                                ReportTime = c.ReportTime,
                                                Subregion = c.Subregion,
                                                Station = c.Station,

                                                VehicleNumber = c.VehicleNumber,
                                                Status = (c.IsActive) ? "Active" : "Resolved" 
                                            }).ToListAsync();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        complaints = await (from c in dbContext.Complaints
                                            where c.IsActive
                                            && c.Region == region.XDescription
                                            select new ComplaintVM()
                                            {
                                                Id = c.Id,
                                                IsActive = c.IsActive,
                                                ComplaintDescription = c.Description,
                                                DriverName = c.DriverName,
                                                PointCode = c.PointCode,
                                                PointCodeDescription = c.PointCodeDescription,
                                                Region = c.Region,
                                                ReportTime = c.ReportTime,
                                                Subregion = c.Subregion,
                                                Station = c.Station,

                                                VehicleNumber = c.VehicleNumber,
                                                Status = (c.IsActive) ? "Active" : "Resolved"
                                            }).ToListAsync();
                    }
                }
                return Ok(complaints);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("All")]
        public async Task<IActionResult> AllSinceLastMonth()
        {
            try
            {
                List<ComplaintVM> complaints = new List<ComplaintVM>();
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        complaints = await (from c in dbContext.Complaints
                                            select new ComplaintVM()
                                            {
                                                Id = c.Id,
                                                IsActive = c.IsActive,
                                                ComplaintDescription = c.Description,
                                                DriverName = c.DriverName,
                                                PointCode = c.PointCode,
                                                PointCodeDescription = c.PointCodeDescription,
                                                Region = c.Region,
                                                ReportTime = c.ReportTime,
                                                Subregion = c.Subregion,
                                                Station = c.Station,

                                                VehicleNumber = c.VehicleNumber,
                                                Status = (c.IsActive) ? "Active" : "Resolved"
                                            }).ToListAsync();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        complaints = await (from c in dbContext.Complaints
                                            where c.Region == region.XDescription
                                            select new ComplaintVM()
                                            {
                                                Id = c.Id,
                                                IsActive = c.IsActive,
                                                ComplaintDescription = c.Description,
                                                DriverName = c.DriverName,
                                                PointCode = c.PointCode,
                                                PointCodeDescription = c.PointCodeDescription,
                                                Region = c.Region,
                                                ReportTime = c.ReportTime,
                                                Subregion = c.Subregion,
                                                Station = c.Station,

                                                VehicleNumber = c.VehicleNumber,
                                                Status = (c.IsActive) ? "Active" : "Resolved"
                                            }).ToListAsync();
                    }
                }
                return Ok(complaints);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("Resolve")]
        public async Task<IActionResult> Resolve(ApiRequest request)
        {
            try
            {
                Complaint complaint = await dbContext.Complaints.Where(x => x.IsActive && x.PointCode == request.CheckListPointCode && x.VehicleNumber == request.VehicleNumber).SingleOrDefaultAsync();
                complaint.IsActive = false;
                complaint.Resolution = request.Remarks;
                complaint.ResolutionTime = PakistanDateTime.Now;
                if (await dbContext.SaveChangesAsync() > 0)
                {
                    if (request.CheckListPointCode.StartsWith("M"))
                    {
                        var parameter = Expression.Parameter(typeof(DailyMorning));
                        var property = Expression.Property(parameter, $"{request.CheckListPointCode}");
                        var selector = Expression.Lambda<Func<DailyMorning, DailyCheckStatus>>(property, parameter);

                        SqlParameter vehiclenumber = new SqlParameter("@vehiclenumber", System.Data.SqlDbType.NVarChar)
                        {
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.VehicleNumber
                        };

                        SqlParameter date = new SqlParameter("@date", System.Data.SqlDbType.DateTime2)
                        {
                            Direction = System.Data.ParameterDirection.Input,
                            Value = PakistanDateTime.Today
                        };

                        SqlParameter now = new SqlParameter("@now", System.Data.SqlDbType.DateTime2)
                        {
                            Direction = System.Data.ParameterDirection.Input,
                            Value = PakistanDateTime.Now
                        };

                        var rowsAffected = dbContext.Database.ExecuteSqlRaw($"UPDATE DailyMorningChecks SET " + request.CheckListPointCode + " = '" + (int)DailyCheckStatus.Checked + "', LastUpdated = @now WHERE VehicleNumber = @vehiclenumber AND CAST(LastUpdated AS DATE) = CAST(@date AS DATE) ", vehiclenumber, date, now);
                        if (rowsAffected > 0)
                        {
                            return Ok($"Complaint registered against point {complaint.PointCodeDescription} for vehicle number {complaint.VehicleNumber} marked as resolved.");
                        }
                        else
                        {
                            return BadRequest("Complaint resolution failed, Please try again.");
                        }
                    }
                    else if (request.CheckListPointCode.StartsWith('E'))
                    {
                        var parameter = Expression.Parameter(typeof(DailyEvening));
                        var property = Expression.Property(parameter, $"{request.CheckListPointCode}");
                        var selector = Expression.Lambda<Func<DailyEvening, DailyCheckStatus>>(property, parameter);

                        SqlParameter vehiclenumber = new SqlParameter("@vehiclenumber", System.Data.SqlDbType.NVarChar)
                        {
                            Direction = System.Data.ParameterDirection.Input,
                            Value = request.VehicleNumber
                        };

                        SqlParameter date = new SqlParameter("@date", System.Data.SqlDbType.DateTime2)
                        {
                            Direction = System.Data.ParameterDirection.Input,
                            Value = PakistanDateTime.Today
                        };

                        SqlParameter now = new("@now", System.Data.SqlDbType.DateTime2)
                        {
                            Direction = System.Data.ParameterDirection.Input,
                            Value = PakistanDateTime.Now
                        };

                        var rowsAffected = dbContext.Database.ExecuteSqlRaw($"UPDATE DailyEveningChecks SET " + request.CheckListPointCode + " = '" + (int)DailyCheckStatus.Checked + "', LastUpdated = @now WHERE VehicleNumber = @vehiclenumber AND CAST(LastUpdated AS DATE) = CAST(@date AS DATE) ", vehiclenumber, date, now);
                        if (rowsAffected > 0)
                        {
                            return Ok($"Complaint registered against point {complaint.PointCodeDescription} for vehicle number {complaint.VehicleNumber} marked as resolved.");
                        }
                        else
                        {
                            return BadRequest("Complaint resolution failed, Please try again.");
                        }
                    }
                    else
                    {
                        return NotFound("Invalid Request!");
                    }
                }
                else
                {
                    return BadRequest("Complaint resolution failed, Please try again.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
