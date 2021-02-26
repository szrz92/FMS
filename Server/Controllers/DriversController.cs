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
                List<DriverVM> rbVehicles = await (from fd in dbContext.Drivers
                                                      select ModelService.FMSDriverViewModel(fd)).ToListAsync();
                return Ok(rbVehicles);
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
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
