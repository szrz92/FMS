using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOS.FMS.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        AppDbContext dbContext;
        public JobsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("All/Completed/SinceLastMonth")]
        public async Task<IActionResult> CompletedSinceLastMonth()
        {
            try
            {
                int AccidentsCount = (from a in dbContext.FMSAccidents where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done select a).Count();
                int EmergencyCount = (from e in dbContext.FMSEmergencies where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done select e).Count();
                int total = AccidentsCount + EmergencyCount;
                return Ok(total.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("All/Pending/SinceLastMonth")]
        public async Task<IActionResult> PendingSinceLastMonth()
        {
            try
            {
                int AccidentsCount = (from a in dbContext.FMSAccidents where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.InProgress select a).Count();
                int EmergencyCount = (from e in dbContext.FMSEmergencies where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.InProgress select e).Count();
                int total = AccidentsCount + EmergencyCount;
                return Ok(total.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
