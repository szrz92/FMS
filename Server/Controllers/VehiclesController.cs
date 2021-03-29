using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOS.FMS.Server.GBMSModels;
using SOS.FMS.Server.Models;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using SOS.FMS.Server.Services;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using SOS.FMS.Shared.Traccar;
using SOS.FMS.Shared;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        AppDbContext dbContext;
        public VehiclesController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("All")]
        public async Task<IActionResult> GetAllGBMS()
        {
            try
            {
                List<GBMSVehicleVM> rbVehicles = await (from v in dbContext.GBMSVehicles
                                                        join s in dbContext.SubRegions on v.Location equals s.XDescription
                                                    select new GBMSVehicleVM()
                                                    {
                                                        Id = v.Id,
                                                        Code = v.Code,
                                                        ChasisNo = v.ChasisNo,
                                                        Description = v.Description,
                                                        EngineNo = v.EngineNo,
                                                        GasolineType = v.GasolineType,
                                                        LastSync = v.LastSync,
                                                        Region = s.XRegionDescription,
                                                        Subregion = v.Location,
                                                        Make = v.Make,
                                                        Model = v.Model,
                                                        PurchaseDate = v.PurchaseDate,
                                                        Station = v.Station,
                                                        VehicleType = v.VehicleType
                                                    }).ToListAsync();
                return Ok(rbVehicles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("SelectList")]
        public async Task<IActionResult> GetSelectList()
        {
            try
            {
                List<Shared.SelectListItem> items = await (from v in dbContext.GBMSVehicles
                                                    select new Shared.SelectListItem()
                                                    {
                                                        Text = v.Description,
                                                        Value = v.Description
                                                    }).ToListAsync();
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/Demo/GetByNumber")]
        public IActionResult GetByNumber(ApiRequest vehicle)
        {
            try
            {
                VehicleVM rbVehicles = (from v in dbContext.Vehicles
                                        join d in dbContext.Drivers on v.VehicleNumber equals d.VehicleNumber
                                        where v.VehicleNumber == vehicle.VehicleNumber
                                        select new VehicleVM()
                                        {
                                            VehicleId = v.Id,
                                            Active = v.Active,
                                            DriverName = d.Name,
                                            IMEI = v.IMEI,
                                            Region = v.Region,
                                            SIM = v.SIM,
                                            SubRegion = v.SubRegion,
                                            VehicleNumber = v.VehicleNumber,
                                            Type = v.Status,
                                            GasolineType = v.GasolineType,
                                            CardNumber = v.CardNumber,
                                            PeriodicRemarks = v.PeriodicStatus == Shared.Enums.PeriodicMaintenanceStatus.Done ? "Periodically Maintained" : "Periodic Maintenance Pending",
                                            AccidentalStatus = v.AccidentalStatus,
                                            EmergencyStatus = v.EmergencyStatus,
                                            PeriodicStatus = v.PeriodicStatus
                                        }).SingleOrDefault();
                return Ok(rbVehicles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("FMS/All")]
        public async Task<IActionResult> GetAllFMS()
        {
            List<VehicleVM> rbVehicles = new List<VehicleVM>();
            try
            {
                if (User.Claims.Any())
                {
                    List<Position> positions = await TraccarService.GetPositions();
                    List<Device> devices = await TraccarService.GetDevices();
                    IEnumerable<DevicePosition> devicePositions = from d in devices
                                                                  join p in positions on d.id equals p.deviceId
                                                                  select new DevicePosition()
                                                                  {
                                                                      id = d.id,
                                                                      name = d.name,
                                                                      latitude = p.latitude,
                                                                      longitude = p.longitude,
                                                                      distance = p.attributes.distance,
                                                                      hours = p.attributes.hours,
                                                                      odometer = p.attributes.odometer,
                                                                      totalDistance = p.attributes.totalDistance
                                                                  };
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        rbVehicles = await (from v in dbContext.Vehicles
                                            join d in dbContext.Drivers on v.VehicleNumber equals d.VehicleNumber
                                            select new VehicleVM()
                                            {
                                                VehicleId = v.Id,
                                                Active = v.Active,
                                                DriverName = d.Name,
                                                IMEI = v.IMEI,
                                                Region = v.Region,
                                                SIM = v.SIM,
                                                SubRegion = v.SubRegion,
                                                VehicleNumber = v.VehicleNumber,
                                                Type = v.Status,
                                                Score = v.Score,
                                                FuelAverage = v.FuelAverage,
                                                Breakdowns = v.Breakdowns,
                                                CostThisMonth = v.CostThisMonth,
                                                Ranking = v.Ranking,
                                                PeriodicRemarks = v.PeriodicStatus == Shared.Enums.PeriodicMaintenanceStatus.Done ? "Periodically Maintained" : "Periodic Maintenance Pending"
                                            }).ToListAsync();
                    }
                    else
                        if (User.IsInRole("RMTO"))
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();

                        rbVehicles = await (from v in dbContext.Vehicles
                                            join d in dbContext.Drivers on v.VehicleNumber equals d.VehicleNumber
                                            where v.Region == region.XDescription
                                            select new VehicleVM()
                                            {
                                                VehicleId = v.Id,
                                                Active = v.Active,
                                                DriverName = d.Name,
                                                IMEI = v.IMEI,
                                                Region = v.Region,
                                                SIM = v.SIM,
                                                SubRegion = v.SubRegion,
                                                VehicleNumber = v.VehicleNumber,
                                                Type = v.Status,
                                                Score = v.Score,
                                                FuelAverage = v.FuelAverage,
                                                Breakdowns = v.Breakdowns,
                                                CostThisMonth = v.CostThisMonth,
                                                Ranking = v.Ranking,
                                                PeriodicRemarks = v.PeriodicStatus == Shared.Enums.PeriodicMaintenanceStatus.Done ? "Periodically Maintained" : "Periodic Maintenance Pending"
                                            }).ToListAsync();
                    }
                    else
                    {
                        rbVehicles = await (from v in dbContext.Vehicles
                                            join d in dbContext.Drivers on v.VehicleNumber equals d.VehicleNumber
                                            select new VehicleVM()
                                            {
                                                VehicleId = v.Id,
                                                Active = v.Active,
                                                DriverName = d.Name,
                                                IMEI = v.IMEI,
                                                Region = v.Region,
                                                SIM = v.SIM,
                                                SubRegion = v.SubRegion,
                                                VehicleNumber = v.VehicleNumber,
                                                Type = v.Status,
                                                Score = v.Score,
                                                FuelAverage = v.FuelAverage,
                                                Breakdowns = v.Breakdowns,
                                                CostThisMonth = v.CostThisMonth,
                                                Ranking = v.Ranking,
                                                PeriodicRemarks = v.PeriodicStatus == Shared.Enums.PeriodicMaintenanceStatus.Done ? "Periodically Maintained" : "Periodic Maintenance Pending"
                                            }).ToListAsync();
                    }
                    var list = from v in rbVehicles
                               join p in devicePositions on v.VehicleNumber equals p.name
                               select new VehicleVM()
                               {
                                   VehicleId = v.Id,
                                   Active = v.Active,
                                   DriverName = v.DriverName,
                                   IMEI = v.IMEI,
                                   Region = v.Region,
                                   SIM = v.SIM,
                                   SubRegion = v.SubRegion,
                                   VehicleNumber = v.VehicleNumber,
                                   Type = v.Type,
                                   Latitude = p.latitude,
                                   Longitude = p.longitude,
                                   Odometer = p.odometer,
                                   Distance = p.distance,
                                   TotalDistance = p.totalDistance / 1000,
                                   Hours = p.hours,
                                   NumberOfTripsToday = TraccarService.GetNumberOfTripsTodayByDeviceId(p.id).Result,
                                   Score = v.Score,
                                   FuelAverage = v.FuelAverage,
                                   Breakdowns = v.Breakdowns,
                                   CostThisMonth = v.CostThisMonth,
                                   Ranking = v.Ranking,
                                   PeriodicRemarks = v.PeriodicRemarks
                               };

                    foreach (var l in list)
                    {
                        Vehicle vehicle = (from v in dbContext.Vehicles
                                           where v.VehicleNumber == l.VehicleNumber
                                           select v).SingleOrDefault();
                        vehicle.Distance = l.TotalDistance;
                    }
                    await dbContext.SaveChangesAsync();
                    return Ok(list);
                }
                else
                {
                    return BadRequest("User not logged in.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("FMS/SelectList")]
        public async Task<IActionResult> GetSelectListFMS()
        {
            try
            {
                List<Shared.SelectListItem> items = await (from v in dbContext.Vehicles
                                                    select new Shared.SelectListItem()
                                                    {
                                                        Value = v.VehicleNumber,
                                                        Text = v.VehicleNumber
                                                    }).ToListAsync();
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("FMS/Scorecard/All")]
        public async Task<IActionResult> GetAllScorecards()
        {
            try
            {
                List<FMSVehicleScoreCardVM> scoreCards = await (from s in dbContext.FMSVehicleScoreCards
                                                                join v in dbContext.GBMSVehicles on s.VehicleId equals v.Id
                                                                select new FMSVehicleScoreCardVM()
                                                                {
                                                                    VehicleId = s.VehicleId,
                                                                    VehicleNumber = v.Description,
                                                                    FuelAverage = s.FuelAverage,
                                                                    Breakdowns = s.Breakdowns,
                                                                    CostThisMonth = s.CostThisMonth,
                                                                    Ranking = s.Ranking
                                                                }).ToListAsync();
                return Ok(scoreCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("FMS/Demo/All")]
        public IActionResult GetAllDemoFMS()
        {
            try
            {
                List<VehicleVM> rbVehicles = new List<VehicleVM>();
                List<Vehicle> vehicles = new List<Vehicle>();
                if (User.IsInRole("SA") || User.IsInRole("HMT"))
                {
                    vehicles = (from v in dbContext.Vehicles
                                   select v).ToList();
                    if (vehicles == null || vehicles.Count == 0)
                    {
                        vehicles = new List<Vehicle>()
                        {
                            new Vehicle()
                            {
                                Id = Guid.NewGuid(),
                                Active = true,
                                FuelAverage = 0,
                                Breakdowns = 0,
                                CostThisMonth = 0,
                                Distance = 0,
                                IMEI = "111222333444555",
                                PeriodicStatus = Shared.Enums.PeriodicMaintenanceStatus.Pending,
                                Ranking = 0,
                                Region = "North Region-1",
                                SubRegion = "Islamabad",
                                Score = 135,
                                SIM = "0320000000",
                                Status = "maintained",
                                VehicleNumber = "MNS-18-946"
                            },
                                new Vehicle()
                            {
                                Id = Guid.NewGuid(),
                                Active = true,
                                FuelAverage = 0,
                                Breakdowns = 0,
                                CostThisMonth = 0,
                                Distance = 0,
                                IMEI = "111222333444555",
                                PeriodicStatus = Shared.Enums.PeriodicMaintenanceStatus.Pending,
                                Ranking = 0,
                                Region = "Central Region-6",
                                SubRegion = "Lahore",
                                Score = 135,
                                SIM = "0320000000",
                                Status = "maintained",
                                VehicleNumber = "MNS-19-9009"
                            }
                        };
                        dbContext.Vehicles.AddRange(vehicles);
                        dbContext.SaveChanges();
                    }
                }
                else
                {
                    ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                    Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                    vehicles = (from v in dbContext.Vehicles
                                   select v).ToList();
                    if (vehicles == null)
                    {
                        vehicles = new List<Vehicle>()
                        {
                            new Vehicle()
                            {
                                Id = Guid.NewGuid(),
                                Active = true,
                                FuelAverage = 0,
                                Breakdowns = 0,
                                CostThisMonth = 0,
                                Distance = 0,
                                IMEI = "111222333444555",
                                PeriodicStatus = Shared.Enums.PeriodicMaintenanceStatus.Pending,
                                Ranking = 0,
                                Region = "North Region-1",
                                SubRegion = "Islamabad",
                                Score = 135,
                                SIM = "0320000000",
                                Status = "maintained",
                                VehicleNumber = "MNS-18-946"
                            },
                                new Vehicle()
                            {
                                Id = Guid.NewGuid(),
                                Active = true,
                                FuelAverage = 0,
                                Breakdowns = 0,
                                CostThisMonth = 0,
                                Distance = 0,
                                IMEI = "111222333444555",
                                PeriodicStatus = Shared.Enums.PeriodicMaintenanceStatus.Pending,
                                Ranking = 0,
                                Region = "Central Region-6",
                                SubRegion = "Lahore",
                                Score = 135,
                                SIM = "0320000000",
                                Status = "maintained",
                                VehicleNumber = "MNS-19-9009"
                            }
                        };
                        dbContext.Vehicles.AddRange(vehicles);
                        dbContext.SaveChanges();
                    }
                }
                if (vehicles.Count == 1)
                {
                    //FMSVehicleDev vehicleDev = new FMSVehicleDev();
                    //vehicleDev.Id = Guid.NewGuid();
                    //vehicleDev.VehicleId = new Guid("C5704B36-57E4-489A-B7CB-1C676F97AB3B");
                    //vehicleDev.DriverId = new Guid("D5B09BF7-24B1-44D2-8AFE-10EC44AC4FA1");
                    //vehicleDev.IMEI = 100010001000100;
                    //vehicleDev.SIM = 923331001000;
                    //vehicleDev.Region = new Guid("C192434E-142F-4666-AD8C-E62B81208DDC");
                    //vehicleDev.SubRegion = new Guid("2B63422E-30F6-4A8B-9199-B89CCE45BC0A");
                    //vehicleDev.Active = true;
                    //vehicleDev.Breakdowns = 0;
                    //vehicleDev.CostThisMonth = 0;
                    //vehicleDev.FuelAverage = 0;
                    //vehicleDev.Ranking = 0;
                    //vehicleDev.Status = "maintained";
                    //dbContext.FMSVehiclesDev.Add(vehicleDev);
                    //dbContext.SaveChanges();
                }
                foreach (var v in vehicles)
                {
                    double Latitude = 0;
                    double Longitude = 0;
                    string subRegion = (from r in dbContext.SubRegions where r.XDescription == v.SubRegion select r.XDescription).SingleOrDefault();
                    var driver = dbContext.Drivers.Where(x => x.VehicleNumber == v.VehicleNumber).FirstOrDefault();
                    switch (subRegion)
                    {
                        case "Karachi":
                            Latitude = 24.8607;
                            Longitude = 67.0011;
                            break;
                        case "Quetta":
                            Latitude = 30.1798;
                            Longitude = 66.9750;
                            break;
                        case "Lahore":
                            Latitude = 31.5204;
                            Longitude = 74.3587;
                            break;
                        case "Rawalpindi":
                            Latitude = 33.6844;
                            Longitude = 73.0479;
                            break;
                        case "Islamabad":
                            Latitude = 33.6844;
                            Longitude = 73.0479;
                            break;
                    }
                    rbVehicles.Add(new VehicleVM()
                    {
                        Active = v.Active,
                        FuelAverage = v.FuelAverage,
                        Breakdowns = v.Breakdowns,
                        CostThisMonth = v.CostThisMonth,
                        DriverId = driver.Id,
                        DriverName = driver.Name,
                        Id = v.Id,
                        IMEI = v.IMEI,
                        Ranking = v.Ranking,
                        Region = v.Region,
                        SIM = v.SIM,
                        SubRegion = subRegion,
                        VehicleId = v.Id,
                        VehicleNumber = v.VehicleNumber,
                        Latitude = Latitude,
                        Longitude = Longitude,
                        Type = v.Status,
                        PeriodicRemarks = v.PeriodicStatus == Shared.Enums.PeriodicMaintenanceStatus.Done ? "Periodically Maintained" : "Periodic Maintenance Pending"
                    });
                }
                return Ok(rbVehicles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/Scorecard/{vehicleId}")]
        public async Task<IActionResult> GetScorecard(Guid vehicleId)
        {
            try
            {
                List<FMSVehicleScoreCardVM> scoreCards = await (from s in dbContext.FMSVehicleScoreCards
                                                                join v in dbContext.GBMSVehicles on s.VehicleId equals v.Id
                                                                where s.VehicleId == vehicleId
                                                                select new FMSVehicleScoreCardVM()
                                                                {
                                                                    VehicleId = s.VehicleId,
                                                                    VehicleNumber = v.Description,
                                                                    FuelAverage = s.FuelAverage,
                                                                    Breakdowns = s.Breakdowns,
                                                                    CostThisMonth = s.CostThisMonth,
                                                                    Ranking = s.Ranking
                                                                }).ToListAsync();
                return Ok(scoreCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("FMS/Accidents/All")]
        public async Task<IActionResult> GetAllAccidents()
        {
            try
            {
                List<FMSVehicleAccidentVM> accidents = await (from a in dbContext.FMSVehicleAccidents
                                                              join v in dbContext.GBMSVehicles on a.VehicleId equals v.Id
                                                              join d in dbContext.Drivers on a.DriverId equals d.Id
                                                              select new FMSVehicleAccidentVM()
                                                              {
                                                                  VehicleId = a.VehicleId,
                                                                  VehicleNumber = v.Description,
                                                                  DriverId = a.DriverId,
                                                                  DriverName = d.Name,
                                                                  TimeStamp = a.TimeStamp,
                                                                  Description = a.Description
                                                              }).ToListAsync();
                if (accidents == null || accidents.Count < 1)
                {
                    accidents = new List<FMSVehicleAccidentVM>()
                    {
                        new FMSVehicleAccidentVM()
                        {
                            DriverName="Demo Driver",
                            TimeStamp= DateTime.Today,
                            Description="Demo Description of this Accident",
                            VehicleNumber="ABC-123"
                        }
                    };
                }
                return Ok(accidents);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("FMS/Accidents/{vehicleId}")]
        public async Task<IActionResult> GetAccidents(Guid vehicleId)
        {
            try
            {
                List<FMSVehicleAccidentVM> accidents = await (from a in dbContext.FMSVehicleAccidents
                                                              join v in dbContext.GBMSVehicles on a.VehicleId equals v.Id
                                                              join d in dbContext.Drivers on a.DriverId equals d.Id
                                                              where a.VehicleId == vehicleId
                                                              select new FMSVehicleAccidentVM()
                                                              {
                                                                  VehicleId = a.VehicleId,
                                                                  VehicleNumber = v.Description,
                                                                  DriverId = a.DriverId,
                                                                  DriverName = d.Name,
                                                                  TimeStamp = a.TimeStamp,
                                                                  Description = a.Description
                                                              }).ToListAsync();
                return Ok(accidents);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddVehicle(VehicleVM vehicle)
        {
            try
            {
                List<Device> devices = await TraccarService.GetDevices();
                if (devices != null)
                {
                    if (devices.Where(x => x.name == vehicle.VehicleNumber).Any())
                    {
                        return BadRequest($"A device with vehicle number {vehicle.VehicleNumber} already exists");
                    }
                    else
                    {
                        Driver driver = (from d in dbContext.Drivers where d.VehicleNumber == vehicle.VehicleNumber select d).SingleOrDefault();
                        if (driver != null)
                        {
                            if (await TraccarService.AddDevice(vehicle))
                            {
                                Vehicle newVehicle = new Vehicle()
                                {
                                    Id = Guid.NewGuid(),
                                    Active = true,
                                    FuelAverage = 0,
                                    Breakdowns = 0,
                                    CostThisMonth = 0,
                                    IMEI = vehicle.IMEI,
                                    Ranking = 0,
                                    Region = vehicle.Region,
                                    SIM = vehicle.SIM,
                                    Status = "maintained",
                                    SubRegion = vehicle.SubRegion,
                                    VehicleNumber = vehicle.VehicleNumber,
                                    Score = vehicle.Score,
                                    CardNumber = vehicle.CardNumber,
                                    GasolineType = vehicle.GasolineType
                                };
                                await dbContext.Vehicles.AddAsync(newVehicle);
                                if (await dbContext.SaveChangesAsync() > 0)
                                {
                                    return Ok($"Device is successfully added with vehicle number {vehicle.VehicleNumber}");
                                }
                                else
                                {
                                    return BadRequest($"A device with vehicle number {vehicle.VehicleNumber} could not be added to FMS.");
                                }
                            }
                            else
                            {
                                return BadRequest($"A device could not be added with vehicle number {vehicle.VehicleNumber}");
                            }
                        }
                        else
                        {
                            return BadRequest($"Please assign driver to vehicle number {vehicle.VehicleNumber}");
                        }
                    }
                }
                else
                {
                    return BadRequest($"A device could not be added with vehicle number {vehicle.VehicleNumber}. It seems some temporary problem. Please try again. If problem persists, contact support staff for assistance.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
