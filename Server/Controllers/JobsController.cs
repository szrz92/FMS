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
        [HttpGet("All/Completed")]
        public async Task<IActionResult> CompletedJobs()
        {
            List<FMSJobsVM> Jobs = new List<FMSJobsVM>();
            try
            {
                var Accidents = await (from a in dbContext.FMSAccidents
                                       join r in dbContext.Regions on a.RegionId equals r.Id
                                       join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                       join d in dbContext.FMSDrivers on a.DriverId equals d.Id
                                       where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done
                                       select new FMSJobsVM()
                                       {
                                           Driver = d.DriverName,
                                           Description = a.Description,
                                           MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                           Region = r.XDescription,
                                           SubRegion = s.XDescription,
                                           VehicleNumber = a.VehicleNumber,
                                           JobType = "Accidental",
                                           LastUpdated = a.LastUpdated
                                       }).ToListAsync();
                var Emergencies = await (from e in dbContext.FMSEmergencies
                                         join r in dbContext.Regions on e.RegionId equals r.Id
                                         join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                         join d in dbContext.FMSDrivers on e.DriverId equals d.Id
                                         where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done
                                         select new FMSJobsVM()
                                         {
                                             Driver = d.DriverName,
                                             Description = e.Description,
                                             MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                             Region = r.XDescription,
                                             SubRegion = s.XDescription,
                                             VehicleNumber = e.VehicleNumber,
                                             JobType = "Emergency",
                                             LastUpdated = e.LastUpdated
                                         }).ToListAsync();
                Jobs = Accidents.Union(Emergencies).ToList();
                return Ok(Jobs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("All/Pending")]
        public async Task<IActionResult> PendingJobs()
        {
            List<FMSJobsVM> Jobs = new List<FMSJobsVM>();
            try
            {
                var Accidents = await (from a in dbContext.FMSAccidents 
                                       join r in dbContext.Regions on a.RegionId equals r.Id
                                       join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                       join d in dbContext.FMSDrivers on a.DriverId equals d.Id
                                       where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.InProgress 
                                       select new FMSJobsVM()
                                       {
                                           Driver = d.DriverName,
                                           Description = a.Description,
                                           MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                           Region = r.XDescription,
                                           SubRegion = s.XDescription,
                                           VehicleNumber = a.VehicleNumber,
                                           JobType = "Accidental",
                                           LastUpdated = a.LastUpdated
                                       }).ToListAsync();
                var Emergencies = await (from e in dbContext.FMSEmergencies
                                       join r in dbContext.Regions on e.RegionId equals r.Id
                                       join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                       join d in dbContext.FMSDrivers on e.DriverId equals d.Id
                                       where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.InProgress
                                       select new FMSJobsVM()
                                       {
                                           Driver = d.DriverName,
                                           Description = e.Description,
                                           MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                           Region = r.XDescription,
                                           SubRegion = s.XDescription,
                                           VehicleNumber = e.VehicleNumber,
                                           JobType = "Emergency",
                                           LastUpdated = e.LastUpdated
                                       }).ToListAsync();
                Jobs = Accidents.Union(Emergencies).ToList();
                return Ok(Jobs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("All")]
        public async Task<IActionResult> AllJobs()
        {
            List<FMSJobsVM> Jobs = new List<FMSJobsVM>();
            try
            {
                var Accidents = await (from a in dbContext.FMSAccidents
                                       join r in dbContext.Regions on a.RegionId equals r.Id
                                       join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                       join d in dbContext.FMSDrivers on a.DriverId equals d.Id
                                       select new FMSJobsVM()
                                       {
                                           Driver = d.DriverName,
                                           Description = a.Description,
                                           MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                           Region = r.XDescription,
                                           SubRegion = s.XDescription,
                                           VehicleNumber = a.VehicleNumber,
                                           JobType = "Accidental",
                                           LastUpdated = a.LastUpdated
                                       }).ToListAsync();
                var Emergencies = await (from e in dbContext.FMSEmergencies
                                         join r in dbContext.Regions on e.RegionId equals r.Id
                                         join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                         join d in dbContext.FMSDrivers on e.DriverId equals d.Id
                                         select new FMSJobsVM()
                                         {
                                             Driver = d.DriverName,
                                             Description = e.Description,
                                             MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                             Region = r.XDescription,
                                             SubRegion = s.XDescription,
                                             VehicleNumber = e.VehicleNumber,
                                             JobType = "Emergency",
                                             LastUpdated = e.LastUpdated
                                         }).ToListAsync();
                Jobs = Accidents.Union(Emergencies).ToList();
                return Ok(Jobs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
