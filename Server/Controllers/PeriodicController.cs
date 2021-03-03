using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        AppDbContext dbContext;
        public PeriodicController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost("Status")]
        public async Task<IActionResult> GetCurrentStatus(ApiRequest request)
        {
            List<PeriodicHistory> histories;
            List<PeriodicVM> periodicHistory = new List<PeriodicVM>();
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

                        List<PeriodicMaintenanceStatus> statusList = new List<PeriodicMaintenanceStatus>();
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
                            SubRegion = driver.SubRegion
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
            List<PeriodicVM> periodicHistory = new List<PeriodicVM>();
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
                            .Select(h=>new PeriodicVM()
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
                                SubRegion = driver.SubRegion
                            }).FirstOrDefault();
                        periodicHistory.Add(history);
                    }
                    foreach (var p in periodicHistory)
                    {
                        double CurrentKMS = vehicle.Distance - p.LastCheckDistance;
                        int CurrentMonths = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now, p.LastCheckTime);

                        List<PeriodicMaintenanceStatus> statusList = new List<PeriodicMaintenanceStatus>();

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
                    return Ok(periodicHistory);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("Status/All")]
        public async Task<IActionResult> GetCurrentStatusAllVehicles()
        {
            List<PeriodicHistory> histories;
            List<PeriodicVM> periodicHistory = new List<PeriodicVM>();

            try
            {
                List<Vehicle> vehicles = (from v in dbContext.Vehicles
                                          select v).ToList();
                foreach (var v in vehicles)
                {
                    Driver driver = (from d in dbContext.Drivers where d.VehicleNumber == v.VehicleNumber select d).SingleOrDefault();

                    histories = (from p in dbContext.PeriodicHistories
                                 where p.VehicleNumber == v.VehicleNumber
                                 select p).ToList();

                    if (histories.Any())
                    {
                        List<VehicleConfiguration> configurations = (from c in dbContext.VehicleConfigurations
                                                                     select c).ToList();
                        if (histories.Count == configurations.Count)
                        {
                            foreach (var h in histories)
                            {
                                VehicleConfiguration configuration = (from vc in dbContext.VehicleConfigurations where vc.Id == h.ConfigurationId select vc).SingleOrDefault();
                                periodicHistory.Add(new PeriodicVM()
                                {
                                    Id = h.Id,
                                    ConfigurationId = h.ConfigurationId,
                                    Description = h.Description,
                                    CurrentDistance = v.Distance,
                                    CurrentMonth = 0,
                                    DistanceLimit = configuration.Distance,
                                    DriverCode = driver.Code,
                                    DriverName = driver.Name,
                                    LastCheckDistance = h.LastCheckDistance,
                                    LastCheckTime = h.LastCheckTime,
                                    MonthLimit = configuration.Month,
                                    VehicleNumber = v.VehicleNumber,
                                    Region = driver.Region,
                                    SubRegion = driver.SubRegion
                                });
                            }
                        }
                        else
                            if (histories.Count > configurations.Count)
                        {
                            List<Guid> historyIds = (from hi in histories select hi.ConfigurationId).ToList();
                            List<Guid> configurationIds = (from ci in configurations select ci.Id).ToList();
                            List<Guid> difference = historyIds.Except(configurationIds).ToList();
                            foreach (var d in difference)
                            {
                                IEnumerable<PeriodicHistory> periodicHistories = from p in dbContext.PeriodicHistories
                                                                                 where p.ConfigurationId == d
                                                                                 select p;
                                dbContext.RemoveRange(periodicHistories);
                                if (await dbContext.SaveChangesAsync() > 0)
                                {
                                    histories = (from p in dbContext.PeriodicHistories
                                                 where p.VehicleNumber == v.VehicleNumber
                                                 select p).ToList();
                                    foreach (var h in histories)
                                    {
                                        VehicleConfiguration configuration = (from vc in dbContext.VehicleConfigurations where vc.Id == h.ConfigurationId select vc).SingleOrDefault();
                                        periodicHistory.Add(new PeriodicVM()
                                        {
                                            Id = h.Id,
                                            ConfigurationId = h.ConfigurationId,
                                            Description = h.Description,
                                            CurrentDistance = v.Distance,
                                            CurrentMonth = 0,
                                            DistanceLimit = configuration.Distance,
                                            DriverCode = driver.Code,
                                            DriverName = driver.Name,
                                            LastCheckDistance = h.LastCheckDistance,
                                            LastCheckTime = h.LastCheckTime,
                                            MonthLimit = configuration.Month,
                                            VehicleNumber = v.VehicleNumber,
                                            Region = driver.Region,
                                            SubRegion = driver.SubRegion
                                        });
                                    }
                                }
                                else
                                {
                                    return BadRequest();
                                }
                            }
                        }
                        else
                            if (histories.Count < configurations.Count)
                        {
                            List<Guid> historyIds = (from hi in histories select hi.ConfigurationId).ToList();
                            List<Guid> configurationIds = (from ci in configurations select ci.Id).ToList();
                            List<Guid> difference = configurationIds.Except(historyIds).ToList(); 
                            foreach (var c in difference)
                            {
                                VehicleConfiguration configuration = (from vc in dbContext.VehicleConfigurations where vc.Id == c select vc).SingleOrDefault();
                                histories = new List<PeriodicHistory>();
                                histories.Add(new PeriodicHistory()
                                {
                                    Id = Guid.NewGuid(),
                                    ConfigurationId = configuration.Id,
                                    Description = configuration.Description,
                                    DriverCode = driver.Code,
                                    DriverName = driver.Name,
                                    LastCheckDistance = 0,
                                    LastCheckTime = DateTime.MinValue,
                                    VehicleNumber = v.VehicleNumber,
                                    Timestamp = PakistanDateTime.Now
                                });
                            }
                            await dbContext.PeriodicHistories.AddRangeAsync(histories);
                            if (await dbContext.SaveChangesAsync() > 0)
                            {
                                histories = (from p in dbContext.PeriodicHistories
                                             where p.VehicleNumber == v.VehicleNumber
                                             select p).ToList();
                                foreach (var h in histories)
                                {
                                    VehicleConfiguration configuration = (from vc in dbContext.VehicleConfigurations where vc.Id == h.ConfigurationId select vc).SingleOrDefault();
                                    periodicHistory.Add(new PeriodicVM()
                                    {
                                        Id = Guid.NewGuid(),
                                        ConfigurationId = h.ConfigurationId,
                                        Description = h.Description,
                                        CurrentDistance = v.Distance,
                                        CurrentMonth = 0,
                                        DistanceLimit = configuration.Distance,
                                        DriverCode = driver.Code,
                                        DriverName = driver.Name,
                                        LastCheckDistance = h.LastCheckDistance,
                                        LastCheckTime = h.LastCheckTime,
                                        MonthLimit = configuration.Month,
                                        VehicleNumber = v.VehicleNumber,
                                        Region = driver.Region,
                                        SubRegion = driver.SubRegion
                                    });
                                }
                            }
                            else
                            {
                                return BadRequest();
                            }
                        }
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
                                VehicleNumber = v.VehicleNumber,
                                Timestamp = PakistanDateTime.Now
                            });
                        }
                        await dbContext.PeriodicHistories.AddRangeAsync(histories);
                        if (await dbContext.SaveChangesAsync() > 0)
                        {
                            histories = (from p in dbContext.PeriodicHistories
                                         where p.VehicleNumber == v.VehicleNumber
                                         select p).ToList();
                            foreach (var h in histories)
                            {
                                VehicleConfiguration configuration = (from vc in dbContext.VehicleConfigurations where vc.Id == h.ConfigurationId select vc).SingleOrDefault();
                                periodicHistory.Add(new PeriodicVM()
                                {
                                    Id = h.Id,
                                    ConfigurationId = h.ConfigurationId,
                                    Description = h.Description,
                                    CurrentDistance = v.Distance,
                                    CurrentMonth = 0,
                                    DistanceLimit = configuration.Distance,
                                    DriverCode = driver.Code,
                                    DriverName = driver.Name,
                                    LastCheckDistance = h.LastCheckDistance,
                                    LastCheckTime = h.LastCheckTime,
                                    MonthLimit = configuration.Month,
                                    VehicleNumber = v.VehicleNumber,
                                    Region = driver.Region,
                                    SubRegion = driver.SubRegion
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
                PeriodicHistory periodicHistory = new PeriodicHistory()
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

    }
}
