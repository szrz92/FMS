using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
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
        readonly AppDbContext dbContext;
        public JobsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("All/Completed/SinceLastMonth")]
        public async Task<IActionResult> CompletedSinceLastMonth()
        {
            try
            {
                int AccidentsCount = 0;
                int EmergencyCount = 0;
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        AccidentsCount = (from a in dbContext.Accidents where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done select a).Count();
                        EmergencyCount = (from e in dbContext.Emergencies where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done select e).Count();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        AccidentsCount = (from a in dbContext.Accidents
                                          where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done
                                          && a.RegionId == region.Id
                                          select a).Count();
                        EmergencyCount = (from e in dbContext.Emergencies
                                          where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done
                                          && e.RegionId == region.Id
                                          select e).Count();
                    }
                }
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
                int AccidentsCount = 0;
                int EmergencyCount = 0;
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        AccidentsCount = (from a in dbContext.Accidents where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.NotInitiated select a).Count();
                        EmergencyCount = (from e in dbContext.Emergencies where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.NotInitiated select e).Count();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        AccidentsCount = (from a in dbContext.Accidents
                                          where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.NotInitiated
                                          && a.RegionId == region.Id
                                          select a).Count();
                        EmergencyCount = (from e in dbContext.Emergencies
                                          where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.NotInitiated
                                          && e.RegionId == region.Id
                                          select e).Count();
                    }
                }
                int total = AccidentsCount + EmergencyCount;
                return Ok(total.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("All/PendingSoon")]
        public IActionResult PendingSoon()
        {
            try
            {
                int PeriodicCount = 0;
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        PeriodicCount = (from a in dbContext.Vehicles where a.PeriodicStatus == Shared.Enums.PeriodicMaintenanceStatus.Pending select a).Count();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        PeriodicCount = (from a in dbContext.Vehicles
                                          where a.PeriodicStatus == Shared.Enums.PeriodicMaintenanceStatus.Pending
                                          && a.Region == region.XDescription
                                          select a).Count();
                    }
                }
                int total = PeriodicCount;
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
            List<FMSJobsVM> Jobs = new();
            try
            {
                var Accidents = new List<FMSJobsVM>();
                var Emergencies = new List<FMSJobsVM>();
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        Accidents = await (from a in dbContext.Accidents
                                           join r in dbContext.Regions on a.RegionId equals r.Id
                                           join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                           join st in dbContext.Stations on a.StationId equals st.Id
                                           join d in dbContext.Drivers on a.DriverId equals d.Id
                                           where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done
                                           select new FMSJobsVM()
                                           {
                                               Driver = d.Name,
                                               Description = a.Description,
                                               MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               Station = st.XDescription,
                                               VehicleNumber = a.VehicleNumber,
                                               JobType = "Accidental",
                                               LastUpdated = a.LastUpdated
                                           }).ToListAsync();
                        Emergencies = await (from e in dbContext.Emergencies
                                             join r in dbContext.Regions on e.RegionId equals r.Id
                                             join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                             join st in dbContext.Stations on e.StationId equals st.Id
                                             join d in dbContext.Drivers on e.DriverId equals d.Id
                                             where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done
                                             select new FMSJobsVM()
                                             {
                                                 Driver = d.Name,
                                                 Description = e.Description,
                                                 MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                                 Region = r.XDescription,
                                                 SubRegion = s.XDescription,
                                                 Station= st.XDescription,
                                                 VehicleNumber = e.VehicleNumber,
                                                 JobType = "Emergency",
                                                 LastUpdated = e.LastUpdated
                                             }).ToListAsync();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        Accidents = await (from a in dbContext.Accidents
                                           join r in dbContext.Regions on a.RegionId equals r.Id
                                           join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                           join st in dbContext.Stations on a.StationId equals st.Id
                                           join d in dbContext.Drivers on a.DriverId equals d.Id
                                           where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done
                                           && a.RegionId == region.Id
                                           select new FMSJobsVM()
                                           {
                                               Driver = d.Name,
                                               Description = a.Description,
                                               MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               Station=st.XDescription,
                                               VehicleNumber = a.VehicleNumber,
                                               JobType = "Accidental",
                                               LastUpdated = a.LastUpdated
                                           }).ToListAsync();
                        Emergencies = await (from e in dbContext.Emergencies
                                             join r in dbContext.Regions on e.RegionId equals r.Id
                                             join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                             join st in dbContext.Stations on e.StationId equals st.Id
                                             join d in dbContext.Drivers on e.DriverId equals d.Id
                                             where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done
                                           && e.RegionId == region.Id
                                             select new FMSJobsVM()
                                             {
                                                 Driver = d.Name,
                                                 Description = e.Description,
                                                 MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                                 Region = r.XDescription,
                                                 SubRegion = s.XDescription,
                                                 Station=st.XDescription,
                                                 VehicleNumber = e.VehicleNumber,
                                                 JobType = "Emergency",
                                                 LastUpdated = e.LastUpdated
                                             }).ToListAsync();
                    }
                }
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
            List<FMSJobsVM> Jobs = new();
            try
            {
                var Accidents = new List<FMSJobsVM>();
                var Emergencies = new List<FMSJobsVM>();
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        Accidents = await (from a in dbContext.Accidents
                                           join r in dbContext.Regions on a.RegionId equals r.Id
                                           join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                           join st in dbContext.Stations on a.StationId equals st.Id
                                           join d in dbContext.Drivers on a.DriverId equals d.Id
                                           where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.NotInitiated
                                           select new FMSJobsVM()
                                           {
                                               Driver = d.Name,
                                               Description = a.Description,
                                               MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               Station=st.XDescription,
                                               VehicleNumber = a.VehicleNumber,
                                               JobType = "Accidental",
                                               LastUpdated = a.LastUpdated
                                           }).ToListAsync();
                        Emergencies = await (from e in dbContext.Emergencies
                                             join r in dbContext.Regions on e.RegionId equals r.Id
                                             join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                             join st in dbContext.Stations on e.StationId equals st.Id
                                             join d in dbContext.Drivers on e.DriverId equals d.Id
                                             where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.NotInitiated
                                             select new FMSJobsVM()
                                             {
                                                 Driver = d.Name,
                                                 Description = e.Description,
                                                 MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                                 Region = r.XDescription,
                                                 SubRegion = s.XDescription,
                                                 Station=st.XDescription,
                                                 VehicleNumber = e.VehicleNumber,
                                                 JobType = "Emergency",
                                                 LastUpdated = e.LastUpdated
                                             }).ToListAsync();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        Accidents = await (from a in dbContext.Accidents
                                           join r in dbContext.Regions on a.RegionId equals r.Id
                                           join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                           join st in dbContext.Stations on a.StationId equals st.Id
                                           join d in dbContext.Drivers on a.DriverId equals d.Id
                                           where a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.NotInitiated
                                           && a.RegionId == region.Id
                                           select new FMSJobsVM()
                                           {
                                               Driver = d.Name,
                                               Description = a.Description,
                                               MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               Station=st.XDescription,
                                               VehicleNumber = a.VehicleNumber,
                                               JobType = "Accidental",
                                               LastUpdated = a.LastUpdated
                                           }).ToListAsync();
                        Emergencies = await (from e in dbContext.Emergencies
                                             join r in dbContext.Regions on e.RegionId equals r.Id
                                             join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                             join st in dbContext.Stations on e.StationId equals st.Id
                                             join d in dbContext.Drivers on e.DriverId equals d.Id
                                             where e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.NotInitiated
                                           && e.RegionId == region.Id
                                             select new FMSJobsVM()
                                             {
                                                 Driver = d.Name,
                                                 Description = e.Description,
                                                 MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                                 Region = r.XDescription,
                                                 SubRegion = s.XDescription,
                                                 Station=st.XDescription,
                                                 VehicleNumber = e.VehicleNumber,
                                                 JobType = "Emergency",
                                                 LastUpdated = e.LastUpdated
                                             }).ToListAsync();
                    }
                }
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
            List<FMSJobsVM> Jobs = new();
            try
            {
                var Accidents = new List<FMSJobsVM>();
                var Emergencies = new List<FMSJobsVM>();
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        Accidents = await (from a in dbContext.Accidents
                                           join r in dbContext.Regions on a.RegionId equals r.Id
                                           join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                           join st in dbContext.Stations on a.StationId equals st.Id
                                           join d in dbContext.Drivers on a.DriverId equals d.Id
                                           select new FMSJobsVM()
                                           {
                                               Driver = d.Name,
                                               Description = a.Description,
                                               MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               Station = st.XDescription,
                                               VehicleNumber = a.VehicleNumber,
                                               JobType = "Accidental",
                                               LastUpdated = a.LastUpdated
                                           }).ToListAsync();
                        Emergencies = await (from e in dbContext.Emergencies
                                             join r in dbContext.Regions on e.RegionId equals r.Id
                                             join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                             join st in dbContext.Stations on e.StationId equals st.Id
                                             join d in dbContext.Drivers on e.DriverId equals d.Id
                                             select new FMSJobsVM()
                                             {
                                                 Driver = d.Name,
                                                 Description = e.Description,
                                                 MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                                 Region = r.XDescription,
                                                 SubRegion = s.XDescription,
                                                 Station = st.XDescription,
                                                 VehicleNumber = e.VehicleNumber,
                                                 JobType = "Emergency",
                                                 LastUpdated = e.LastUpdated
                                             }).ToListAsync();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        Accidents = await (from a in dbContext.Accidents
                                           join r in dbContext.Regions on a.RegionId equals r.Id
                                           join s in dbContext.SubRegions on a.SubRegionId equals s.Id
                                           join st in dbContext.Stations on a.StationId equals st.Id
                                           join d in dbContext.Drivers on a.DriverId equals d.Id
                                           where a.RegionId == region.Id
                                           select new FMSJobsVM()
                                           {
                                               Driver = d.Name,
                                               Description = a.Description,
                                               MaintenanceStatus = a.MaintenanceStatus.ToString(),
                                               Region = r.XDescription,
                                               SubRegion = s.XDescription,
                                               Station = st.XDescription,
                                               VehicleNumber = a.VehicleNumber,
                                               JobType = "Accidental",
                                               LastUpdated = a.LastUpdated
                                           }).ToListAsync();
                        Emergencies = await (from e in dbContext.Emergencies
                                             join r in dbContext.Regions on e.RegionId equals r.Id
                                             join s in dbContext.SubRegions on e.SubRegionId equals s.Id
                                             join st in dbContext.Stations on e.StationId equals st.Id
                                             join d in dbContext.Drivers on e.DriverId equals d.Id
                                             where e.RegionId == region.Id
                                             select new FMSJobsVM()
                                             {
                                                 Driver = d.Name,
                                                 Description = e.Description,
                                                 MaintenanceStatus = e.MaintenanceStatus.ToString(),
                                                 Region = r.XDescription,
                                                 SubRegion = s.XDescription,
                                                 Station=st.XDescription,
                                                 VehicleNumber = e.VehicleNumber,
                                                 JobType = "Emergency",
                                                 LastUpdated = e.LastUpdated
                                             }).ToListAsync();
                    }
                }
                Jobs = Accidents.Union(Emergencies).ToList();
                return Ok(Jobs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("History")]
        public async Task<IActionResult> HistoryByVehicleNumber(ApiRequest request)
        {
            List<HistoryVM> history = new();
            try
            {
                var Accidents = new List<HistoryVM>();
                var Emergencies = new List<HistoryVM>();

                Accidents = await (from a in dbContext.Accidents
                                   where a.VehicleNumber == request.VehicleNumber
                                   select new HistoryVM()
                                   {
                                       Description = a.Description,
                                       Type = "Accidental",
                                       Status = (a.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done) ? "Done" : "Pending",
                                       LastUpdated = a.LastUpdated
                                   }).ToListAsync();
                Emergencies = await (from e in dbContext.Emergencies
                                     where e.VehicleNumber == request.VehicleNumber
                                     select new HistoryVM()
                                     {
                                         Description = e.Description,
                                         Type = "Emergency",
                                         Status = (e.MaintenanceStatus == Shared.Enums.MaintenanceStatus.Done) ? "Done" : "Pending",
                                         LastUpdated = e.LastUpdated
                                     }).ToListAsync();

                history = Accidents.Union(Emergencies).OrderByDescending(x => x.LastUpdated).ToList();
                return Ok(history);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
