using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Server.Services;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        AppDbContext dbContext;
        public DriversController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("FMS/All")]
        public async Task<IActionResult> GetAllFMS()
        {
            try
            {
                if (User.Claims.Any())
                {
                    if (User.IsInRole("RMTO"))
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();

                        List<DriverVM> rbVehicles = await (from fd in dbContext.Drivers
                                                           where fd.Region == region.XDescription
                                                           select ModelService.FMSDriverViewModel(fd)).ToListAsync();
                        return Ok(rbVehicles);
                    }
                    else
                    {

                        List<DriverVM> rbVehicles = await (from fd in dbContext.Drivers
                                                           select ModelService.FMSDriverViewModel(fd)).ToListAsync();
                        return Ok(rbVehicles);
                    }
                }
                else
                {
                    return Ok(new List<DriverVM>());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("Summary")]
        public async Task<IActionResult> GetSummary()
        {
            try
            {
                if (User.Claims.Any())
                {
                    if (User.IsInRole("RMTO"))
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        List<SummaryVM> summaries = await (from s in dbContext.VehicleSummaries
                                                           join d in dbContext.Drivers on s.DriverCode equals d.Code
                                                           where d.Region == region.XDescription
                                                           select new SummaryVM()
                                                           {
                                                               Id = s.Id,
                                                               AssignmentDate = s.AssignmentDate,
                                                               DriverCode = s.DriverCode,
                                                               DriverName = s.DriverName,
                                                               LastUpdate = s.LastUpdate,
                                                               LeavingDate = s.LeavingDate,
                                                               VehicleNumber = s.VehicleNumber
                                                           }).OrderByDescending(x => x.LastUpdate).ToListAsync();
                        return Ok(summaries);
                    }
                    else
                    {
                        List<SummaryVM> summaries = await (from s in dbContext.VehicleSummaries
                                                           select new SummaryVM()
                                                           {
                                                               Id = s.Id,
                                                               AssignmentDate = s.AssignmentDate,
                                                               DriverCode = s.DriverCode,
                                                               DriverName = s.DriverName,
                                                               LastUpdate = s.LastUpdate,
                                                               LeavingDate = s.LeavingDate,
                                                               VehicleNumber = s.VehicleNumber
                                                           }).OrderByDescending(x => x.LastUpdate).ToListAsync();
                        return Ok(summaries);
                    }
                }
                else
                {
                    return Ok(new List<SummaryVM>());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
