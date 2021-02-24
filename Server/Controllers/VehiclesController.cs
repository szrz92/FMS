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
                List<VehicleVM> rbVehicles = await (from v in dbContext.Vehicles
                                                    select ModelService.VehicleViewModel(v)).ToListAsync();
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
                List<SelectListItem> items = await (from v in dbContext.Vehicles
                                                    select ModelService.SelectList(v)).ToListAsync();
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
                List<FMSVehicleVM> rbVehicles = new List<FMSVehicleVM>();
                List<FMSVehicleDev> vehicleDevs = new List<FMSVehicleDev>();
                if (User.Claims.Any())
                {
                    if (User.IsInRole("SA") || User.IsInRole("HMT"))
                    {
                        vehicleDevs = (from v in dbContext.FMSVehiclesDev
                                       select v).ToList();
                    }
                    else
                    {
                        ApplicationUser user = (from u in dbContext.Users where u.Email == User.Identity.Name select u).FirstOrDefault();
                        Region region = (from r in dbContext.Regions where r.XDescription == user.Region select r).FirstOrDefault();
                        vehicleDevs = (from v in dbContext.FMSVehiclesDev
                                       where v.Region == region.Id
                                       select v).ToList();
                    }
                    if (vehicleDevs.Count == 1)
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

                    foreach (var v in vehicleDevs)
                    {
                        double Latitude = 0;
                        double Longitude = 0;
                        string subRegion = (from r in dbContext.SubRegions where r.Id == v.SubRegion select r.XDescription).SingleOrDefault();
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
                        rbVehicles.Add(new FMSVehicleVM()
                        {
                            Active = v.Active,
                            FuelAverage = v.FuelAverage,
                            Breakdowns = v.Breakdowns,
                            CostThisMonth = v.CostThisMonth,
                            DriverId = v.DriverId,
                            DriverName = (from d in dbContext.Drivers where d.Id == v.DriverId select d.Name).SingleOrDefault(),
                            Id = v.Id,
                            IMEI = v.IMEI,
                            Ranking = v.Ranking,
                            Region = (from r in dbContext.Regions where r.Id == v.Region select r.XDescription).SingleOrDefault(),
                            SIM = v.SIM,
                            SubRegion = subRegion,
                            VehicleId = v.VehicleId,
                            VehicleNumber = (from r in dbContext.Vehicles where r.Id == v.VehicleId select r.XDescription).SingleOrDefault(),
                            Latitude = Latitude,
                            Longitude = Longitude,
                            Type = v.Status
                        });
                    }
                }
                return Ok(rbVehicles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/Demo/GetByNumber")]
        public IActionResult GetByNumber(FMSVehicleVM vehicle)
        {
            try
            {
                List<FMSVehicleVM> rbVehicles = new List<FMSVehicleVM>();
                List<FMSVehicleDev> vehicleDevs = (from v in dbContext.FMSVehiclesDev
                                                   select v).ToList();
                foreach (var v in vehicleDevs)
                {
                    double Latitude = 0;
                    double Longitude = 0;
                    string subRegion = (from r in dbContext.SubRegions where r.Id == v.SubRegion select r.XDescription).SingleOrDefault();
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
                    }
                    rbVehicles.Add(new FMSVehicleVM()
                    {
                        Active = v.Active,
                        FuelAverage = v.FuelAverage,
                        Breakdowns = v.Breakdowns,
                        CostThisMonth = v.CostThisMonth,
                        DriverId = v.DriverId,
                        DriverName = (from d in dbContext.Drivers where d.Id == v.DriverId select d.Name).SingleOrDefault(),
                        Id = v.Id,
                        IMEI = v.IMEI,
                        Ranking = v.Ranking,
                        Region = (from r in dbContext.Regions where r.Id == v.Region select r.XDescription).SingleOrDefault(),
                        SIM = v.SIM,
                        SubRegion = subRegion,
                        VehicleId = v.VehicleId,
                        VehicleNumber = (from r in dbContext.Vehicles where r.Id == v.VehicleId select r.XDescription).SingleOrDefault(),
                        Latitude = Latitude,
                        Longitude = Longitude,
                        Type = v.Status
                    });
                }
                return Ok(rbVehicles.Where(x => x.VehicleNumber == vehicle.VehicleNumber).SingleOrDefault());
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
                List<FMSVehicleVM> rbVehicles = await (from v in dbContext.FMSVehicles
                                                       join fv in dbContext.Vehicles on v.VehicleId equals fv.Id
                                                       join r in dbContext.Regions on v.Region equals r.Id
                                                       join sr in dbContext.SubRegions on v.SubRegion equals sr.Id
                                                       select ModelService.FMSVehicleViewModel(v, fv, r, sr)).ToListAsync();
                if (rbVehicles == null || rbVehicles.Count < 1)
                {
                    rbVehicles = new List<FMSVehicleVM>()
                    {
                        new FMSVehicleVM()
                        {
                            VehicleId = Guid.NewGuid(),
                            Active= true,
                            FuelAverage=0,
                            Breakdowns=0,
                            CostThisMonth=0,
                            IMEI=11111,
                            Ranking=0,
                            Region="XYZ",
                            SIM=090078601,
                            SubRegion="ABC",
                            VehicleNumber="ABC-123"
                        }
                    };
                }
                return Ok(rbVehicles);
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
                List<SelectListItem> items = await (from v in dbContext.FMSVehicles
                                                    join fv in dbContext.Vehicles on v.VehicleId equals fv.Id
                                                    select ModelService.FMSVehicleSelectList(fv)).ToListAsync();
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
                                                                join v in dbContext.Vehicles on s.VehicleId equals v.Id
                                                                select ModelService.FMSVehicleScoreCardViewModel(s, v)).ToListAsync();
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
                                                                join v in dbContext.Vehicles on s.VehicleId equals v.Id
                                                                where s.VehicleId == vehicleId
                                                                select ModelService.FMSVehicleScoreCardViewModel(s, v)).ToListAsync();
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
                                                              join v in dbContext.Vehicles on a.VehicleId equals v.Id
                                                              join d in dbContext.Drivers on a.DriverId equals d.Id
                                                              select new FMSVehicleAccidentVM()
                                                              {
                                                                  VehicleId = a.VehicleId,
                                                                  VehicleNumber = v.XDescription,
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
                                                              join v in dbContext.Vehicles on a.VehicleId equals v.Id
                                                              join d in dbContext.Drivers on a.DriverId equals d.Id
                                                              where a.VehicleId == vehicleId
                                                              select new FMSVehicleAccidentVM()
                                                              {
                                                                  VehicleId = a.VehicleId,
                                                                  VehicleNumber = v.XDescription,
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

    }
}
