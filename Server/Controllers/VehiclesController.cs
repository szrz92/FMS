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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        [HttpGet("FMS/Demo/All")]
        public IActionResult GetAllDemoFMS()
        {
            try
            {
                List<VehicleVM> rbVehicles = new List<VehicleVM>();
                return Ok(rbVehicles);
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
                                            Type = v.Status
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
            try
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
                List<VehicleVM> rbVehicles = await (from v in dbContext.Vehicles
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
                                                        Ranking = v.Ranking
                                                    }).ToListAsync();
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
                               TotalDistance = p.totalDistance,
                               Hours = p.hours,
                               NumberOfTripsToday = TraccarService.GetNumberOfTripsTodayByDeviceId(p.id).Result,
                               Score = v.Score,
                               FuelAverage = v.FuelAverage,
                               Breakdowns = v.Breakdowns,
                               CostThisMonth = v.CostThisMonth,
                               Ranking = v.Ranking
                           };
                return Ok(list);
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
                                    Score = vehicle.Score
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
