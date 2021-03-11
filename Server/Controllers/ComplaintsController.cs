using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
                                                ComplaintDescription = c.ComplaintDescription,
                                                DriverName = c.DriverName,
                                                PointCode = c.PointCode,
                                                PointCodeDescription = c.PointCodeDescription,
                                                Region = c.Region,
                                                ReportTime = c.ReportTime,
                                                Subregion = c.Subregion,
                                                VehicleNumber = c.VehicleNumber
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
                                                ComplaintDescription = c.ComplaintDescription,
                                                DriverName = c.DriverName,
                                                PointCode = c.PointCode,
                                                PointCodeDescription = c.PointCodeDescription,
                                                Region = c.Region,
                                                ReportTime = c.ReportTime,
                                                Subregion = c.Subregion,
                                                VehicleNumber = c.VehicleNumber
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
    }
}
