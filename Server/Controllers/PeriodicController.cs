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
    public class PeriodicController : ControllerBase
    {
        readonly AppDbContext dbContext;
        public PeriodicController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost("Status")]
        public async Task<IActionResult> GetCurrentStatus(ApiRequest request)
        {
            List<PeriodicHistory> histories;
            List<PeriodicVM> periodicHistory = new();
            try
            {
                Vehicle vehicle = (from v in dbContext.Vehicles where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefault();
                Driver driver = (from v in dbContext.Drivers where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefault();

                histories = (from p in dbContext.PeriodicHistories
                             where p.VehicleNumber == request.VehicleNumber
                             select p).ToList();

                if (histories.Any())
                {
                    foreach (var h in histories)
                    {
                        VehicleConfiguration configuration = (from v in dbContext.VehicleConfigurations where v.Id == h.ConfigurationId select v).SingleOrDefault();

                        double CurrentKMS = vehicle.Distance - h.LastCheckDistance;
                        int CurrentMonths = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now , h.LastCheckTime);

                        List<PeriodicMaintenanceStatus> statusList = new();
                        string status;

                        if (CurrentMonths > configuration.Month)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                        else if (CurrentMonths < configuration.Month)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Done);
                        }
                        else if (CurrentMonths == configuration.Month)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }

                        if (CurrentKMS > configuration.Distance)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                        else if (CurrentKMS < configuration.Distance)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Done);
                        }
                        else if (CurrentKMS == configuration.Distance)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }


                        if (statusList.Contains(PeriodicMaintenanceStatus.Pending))
                        {
                            status = "Not Maintained";
                        }
                        else
                        {
                            status = "Maintained";
                        }

                        periodicHistory.Add(new PeriodicVM()
                        {
                            Id = h.Id,
                            ConfigurationId = h.ConfigurationId,
                            Description = h.Description,
                            CurrentDistance = vehicle.Distance,
                            CurrentMonth = CurrentMonths,
                            DistanceLimit = configuration.Distance,
                            DriverCode = driver.Code,
                            DriverName = driver.Name,
                            LastCheckDistance = h.LastCheckDistance,
                            LastCheckTime = h.LastCheckTime,
                            MonthLimit = configuration.Month,
                            VehicleNumber = vehicle.VehicleNumber,
                            Region = driver.Region,
                            SubRegion = driver.SubRegion,
                            Station=driver.Station,
                            Status = status
                        });
                    }
                    return Ok(periodicHistory);
                }
                else
                {
                    histories = new List<PeriodicHistory>();
                    List<VehicleConfiguration> configurations = (from c in dbContext.VehicleConfigurations
                                                                 select c).ToList();
                    foreach (var c in configurations)
                    {
                        histories.Add(new PeriodicHistory() 
                        {
                            Id = Guid.NewGuid(),
                            ConfigurationId = c.Id,
                            Description = c.Description,
                            DriverCode = driver.Code,
                            DriverName = driver.Name,
                            LastCheckDistance = 0,
                            LastCheckTime = DateTime.MinValue,
                            VehicleNumber = request.VehicleNumber,
                            Timestamp = PakistanDateTime.Now
                        });
                    }
                    await dbContext.PeriodicHistories.AddRangeAsync(histories);
                    if (await dbContext.SaveChangesAsync() > 0)
                    {
                        histories = (from p in dbContext.PeriodicHistories
                                     where p.VehicleNumber == request.VehicleNumber
                                     select p).ToList();
                    foreach (var h in histories)
                    {
                        VehicleConfiguration configuration = (from v in dbContext.VehicleConfigurations where v.Id == h.ConfigurationId select v).SingleOrDefault();
                        periodicHistory.Add(new PeriodicVM()
                        {
                            Id = h.Id,
                            ConfigurationId = h.ConfigurationId,
                            Description = h.Description,
                            CurrentDistance = vehicle.Distance,
                            CurrentMonth = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now, h.LastCheckTime),
                            DistanceLimit = configuration.Distance,
                            DriverCode = driver.Code,
                            DriverName = driver.Name,
                            LastCheckDistance = h.LastCheckDistance,
                            LastCheckTime = h.LastCheckTime,
                            MonthLimit = configuration.Month,
                            VehicleNumber = vehicle.VehicleNumber,
                            Region = driver.Region,
                            SubRegion = driver.SubRegion,
                            Station=driver.Station
                        });
                    }
                    return Ok(periodicHistory);
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("Status/Last")]
        public async Task<IActionResult> GetLastStatus(ApiRequest request)
        {
            List<PeriodicHistory> histories;
            List<PeriodicVM> periodicHistory = new();
            try
            {
                Vehicle vehicle = (from v in dbContext.Vehicles where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefault();
                Driver driver = (from v in dbContext.Drivers where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefault();
                List<VehicleConfiguration> configurations = (from v in dbContext.VehicleConfigurations select v).ToList();

                histories = (from p in dbContext.PeriodicHistories
                             where p.VehicleNumber == request.VehicleNumber
                             select p).ToList();

                if (histories.Any())
                {
                    foreach (var c in configurations)
                    {
                        var history = histories.Where(x => x.Description == c.Description).OrderByDescending(x => x.Timestamp)
                            .Select(h => new PeriodicVM()
                            {
                                Id = h.Id,
                                ConfigurationId = h.ConfigurationId,
                                Description = h.Description,
                                CurrentDistance = vehicle.Distance,
                                CurrentMonth = PakistanDateTime.GetMonthsBetween(DateTime.Now, h.LastCheckTime),
                                DistanceLimit = c.Distance,
                                DriverCode = driver.Code,
                                DriverName = driver.Name,
                                LastCheckDistance = h.LastCheckDistance,
                                LastCheckTime = h.LastCheckTime,
                                MonthLimit = c.Month,
                                VehicleNumber = vehicle.VehicleNumber,
                                Region = driver.Region,
                                SubRegion = driver.SubRegion,
                                Station = driver.Station
                            }).FirstOrDefault();
                        if (history != null)
                        {
                            periodicHistory.Add(history);
                        }
                        else
                        {
                            var newHistory = new PeriodicVM()
                            {
                                Id = Guid.NewGuid(),
                                ConfigurationId = c.Id,
                                Description = c.Description,
                                CurrentDistance = vehicle.Distance,
                                CurrentMonth = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now, DateTime.MinValue),
                                DistanceLimit = c.Distance,
                                DriverCode = driver.Code,
                                DriverName = driver.Name,
                                LastCheckDistance = 0,
                                LastCheckTime = DateTime.MinValue,
                                MonthLimit = c.Month,
                                VehicleNumber = vehicle.VehicleNumber,
                                Region = driver.Region,
                                SubRegion = driver.SubRegion,
                                Station = driver.Station
                            };
                            periodicHistory.Add(newHistory);
                        }
                    }
                    foreach (var p in periodicHistory)
                    {
                        double CurrentKMS = vehicle.Distance - p.LastCheckDistance;
                        int CurrentMonths = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now, p.LastCheckTime);

                        List<PeriodicMaintenanceStatus> statusList = new();

                        if (CurrentMonths > p.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                        else if (CurrentMonths < p.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Done);
                        }
                        else if (CurrentMonths == p.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }

                        if (CurrentKMS > p.DistanceLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                        else if (CurrentKMS < p.DistanceLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Done);
                        }
                        else if (CurrentKMS == p.DistanceLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }


                        if (statusList.Contains(PeriodicMaintenanceStatus.Pending))
                        {
                            p.Status = "Not Maintained";
                        }
                        else
                        {
                            p.Status = "Maintained";
                        }
                    }
                    return Ok(periodicHistory);
                }
                else
                {
                    histories = new List<PeriodicHistory>();
                    foreach (var c in configurations)
                    {
                        histories.Add(new PeriodicHistory()
                        {
                            Id = Guid.NewGuid(),
                            ConfigurationId = c.Id,
                            Description = c.Description,
                            DriverCode = driver.Code,
                            DriverName = driver.Name,
                            LastCheckDistance = 0,
                            LastCheckTime = DateTime.MinValue,
                            VehicleNumber = request.VehicleNumber,
                            Timestamp = PakistanDateTime.Now
                        });
                    }
                    await dbContext.PeriodicHistories.AddRangeAsync(histories);
                    if (await dbContext.SaveChangesAsync() > 0)
                    {
                        histories = (from p in dbContext.PeriodicHistories
                                     where p.VehicleNumber == request.VehicleNumber
                                     select p).ToList();
                        foreach (var h in histories)
                        {
                            VehicleConfiguration configuration = (from v in dbContext.VehicleConfigurations where v.Id == h.ConfigurationId select v).SingleOrDefault();
                            periodicHistory.Add(new PeriodicVM()
                            {
                                Id = h.Id,
                                ConfigurationId = h.ConfigurationId,
                                Description = h.Description,
                                CurrentDistance = vehicle.Distance,
                                CurrentMonth = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now, h.LastCheckTime),
                                DistanceLimit = configuration.Distance,
                                DriverCode = driver.Code,
                                DriverName = driver.Name,
                                LastCheckDistance = h.LastCheckDistance,
                                LastCheckTime = h.LastCheckTime,
                                MonthLimit = configuration.Month,
                                VehicleNumber = vehicle.VehicleNumber,
                                Region = driver.Region,
                                SubRegion = driver.SubRegion,
                                Station = driver.Station
                            });
                        }
                    }
                    return Ok(periodicHistory);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("Maintain")]
        public async Task<IActionResult> Maintain(ApiRequest request)
        {
            try
            {
                Vehicle vehicle = (from v in dbContext.Vehicles where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefault();
                Driver driver = (from v in dbContext.Drivers where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefault();
                VehicleConfiguration configuration = (from v in dbContext.VehicleConfigurations where v.Description == request.Remarks select v).SingleOrDefault();
                PeriodicHistory lastMaintenance = (from p in dbContext.PeriodicHistories where p.Description == request.Remarks && p.VehicleNumber == request.VehicleNumber select p)
                    .OrderByDescending(x => x.LastCheckTime).FirstOrDefault();
                PeriodicHistory periodicHistory = new()
                {
                    Id = Guid.NewGuid(),
                    ConfigurationId = configuration.Id,
                    Description = request.Remarks,
                    DriverCode = driver.Code,
                    DriverName = driver.Name,
                    LastCheckDistance = vehicle.Distance,
                    LastCheckTime = PakistanDateTime.Now,
                    Timestamp = PakistanDateTime.Now,
                    VehicleNumber = request.VehicleNumber
                };
                await dbContext.PeriodicHistories.AddAsync(periodicHistory);
                await dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("Status/AllVehicles")]
        public async Task<IActionResult> GetCurrentStatusAll()
        {
            IEnumerable<PeriodicHistory> histories;
            List<PeriodicVM> periodicHistory = new();
            try
            {
                IEnumerable<Vehicle> vehicles = from v in dbContext.Vehicles
                                                select v;
                foreach (var vehicle in vehicles)
                {
                    Driver driver = await (from v in dbContext.Drivers where v.VehicleNumber == vehicle.VehicleNumber select v).SingleOrDefaultAsync();

                    histories = from p in dbContext.PeriodicHistories
                                 where p.VehicleNumber == vehicle.VehicleNumber
                                 select p;

                    if (histories.Any())
                    {
                        foreach (var h in histories)
                        {
                            VehicleConfiguration configuration = await (from v in dbContext.VehicleConfigurations where v.Id == h.ConfigurationId select v).SingleOrDefaultAsync();

                            double CurrentKMS = vehicle.Distance - h.LastCheckDistance;
                            int CurrentMonths = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now, h.LastCheckTime);

                            List<PeriodicMaintenanceStatus> statusList = new();
                            string status;

                            if (CurrentMonths > configuration.Month)
                            {
                                statusList.Add(PeriodicMaintenanceStatus.Pending);
                            }
                            else if (CurrentMonths < configuration.Month)
                            {
                                statusList.Add(PeriodicMaintenanceStatus.Done);
                            }
                            else if (CurrentMonths == configuration.Month)
                            {
                                statusList.Add(PeriodicMaintenanceStatus.Pending);
                            }

                            if (CurrentKMS > configuration.Distance)
                            {
                                statusList.Add(PeriodicMaintenanceStatus.Pending);
                            }
                            else if (CurrentKMS < configuration.Distance)
                            {
                                statusList.Add(PeriodicMaintenanceStatus.Done);
                            }
                            else if (CurrentKMS == configuration.Distance)
                            {
                                statusList.Add(PeriodicMaintenanceStatus.Pending);
                            }


                            if (statusList.Contains(PeriodicMaintenanceStatus.Pending))
                            {
                                status = "Not Maintained";
                            }
                            else
                            {
                                status = "Maintained";
                            }

                            periodicHistory.Add(new PeriodicVM()
                            {
                                Id = h.Id,
                                ConfigurationId = h.ConfigurationId,
                                Description = h.Description,
                                CurrentDistance = vehicle.Distance,
                                CurrentMonth = CurrentMonths,
                                DistanceLimit = configuration.Distance,
                                DriverCode = driver.Code,
                                DriverName = driver.Name,
                                LastCheckDistance = h.LastCheckDistance,
                                LastCheckTime = h.LastCheckTime,
                                MonthLimit = configuration.Month,
                                VehicleNumber = vehicle.VehicleNumber,
                                Region = driver.Region,
                                SubRegion = driver.SubRegion,
                                Station = driver.Station,
                                Status = status
                            });
                        }
                    }
                    else
                    {
                        var newHistory = new List<PeriodicHistory>();
                        IEnumerable<VehicleConfiguration> configurations = from c in dbContext.VehicleConfigurations
                                                                           select c;
                        foreach (var c in configurations)
                        {
                            newHistory.Add(new PeriodicHistory()
                            {
                                Id = Guid.NewGuid(),
                                ConfigurationId = c.Id,
                                Description = c.Description,
                                DriverCode = driver.Code,
                                DriverName = driver.Name,
                                LastCheckDistance = 0,
                                LastCheckTime = DateTime.MinValue,
                                VehicleNumber = vehicle.VehicleNumber,
                                Timestamp = PakistanDateTime.Now
                            });
                        }
                        await dbContext.PeriodicHistories.AddRangeAsync(newHistory);
                        if (await dbContext.SaveChangesAsync() > 0)
                        {
                            histories = from p in dbContext.PeriodicHistories
                                         where p.VehicleNumber == vehicle.VehicleNumber
                                         select p;
                            foreach (var h in histories)
                            {
                                VehicleConfiguration configuration = await (from v in dbContext.VehicleConfigurations where v.Id == h.ConfigurationId select v).SingleOrDefaultAsync();
                                periodicHistory.Add(new PeriodicVM()
                                {
                                    Id = h.Id,
                                    ConfigurationId = h.ConfigurationId,
                                    Description = h.Description,
                                    CurrentDistance = vehicle.Distance,
                                    CurrentMonth = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now, h.LastCheckTime),
                                    DistanceLimit = configuration.Distance,
                                    DriverCode = driver.Code,
                                    DriverName = driver.Name,
                                    LastCheckDistance = h.LastCheckDistance,
                                    LastCheckTime = h.LastCheckTime,
                                    MonthLimit = configuration.Month,
                                    VehicleNumber = vehicle.VehicleNumber,
                                    Region = driver.Region,
                                    SubRegion = driver.SubRegion,
                                    Station = driver.Station
                                });
                            }
                        }
                        else
                        {
                            return BadRequest();
                        }
                    }
                }

                return Ok(periodicHistory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
