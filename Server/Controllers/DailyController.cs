using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Server.Services;
using SOS.FMS.Shared;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyController : ControllerBase
    {
        AppDbContext dbContext;
        public DailyController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("All")]
        public async Task<IActionResult> GetAllCheckLists()
        {
            List<FMSDailyCheckListVM> checklist = new List<FMSDailyCheckListVM>();

            try
            {
                List<string> vehicleNumbers = (from v in dbContext.Vehicles
                                               join gv in dbContext.GBMSVehicles on v.VehicleId equals gv.Id
                                               select gv.Description).ToList();
                foreach (var vehicleNumber in vehicleNumbers)
                {
                    IEnumerable <FMSDailyMorning> fMSDailyMornings = from m in dbContext.FMSDailyMorningChecks where m.VehicleNumber == vehicleNumber && m.LastUpdated.Date == (PakistanDateTime.Today) select m;
                    if (fMSDailyMornings.Any())
                    {
                        FMSDailyMorning dailyMorning = fMSDailyMornings.FirstOrDefault();
                        checklist.Add(CheckListService.DailyMorningCheckListToViewModel(dailyMorning));
                    }
                    else
                    {
                        Vehicle vehicle = (from f in dbContext.Vehicles
                                                 join v in dbContext.GBMSVehicles on f.VehicleId equals v.Id
                                                 where v.Description == vehicleNumber
                                                 select f).SingleOrDefault();
                        Region region = (from r in dbContext.Regions
                                         where r.Id == vehicle.Region
                                         select r).SingleOrDefault();
                        SubRegion subRegion = (from s in dbContext.SubRegions
                                               where s.Id == vehicle.SubRegion
                                               select s).SingleOrDefault();
                        string DriverName = (from f in dbContext.Vehicles
                                             join d in dbContext.Drivers on f.DriverId equals d.Id
                                             join v in dbContext.GBMSVehicles on f.VehicleId equals v.Id
                                             where v.Description == vehicleNumber
                                             select d.Name).SingleOrDefault();
                        FMSDailyMorning dailyMorning = new FMSDailyMorning();
                        dailyMorning.Id = Guid.NewGuid();
                        dailyMorning.LastUpdated = PakistanDateTime.Now;
                        dailyMorning.VehicleNumber = vehicleNumber;
                        dailyMorning.DriverName = DriverName;
                        dailyMorning.Region = region.XDescription;
                        dailyMorning.Subregion = subRegion.XDescription;
                        await dbContext.FMSDailyMorningChecks.AddAsync(dailyMorning);
                        await dbContext.SaveChangesAsync();

                        checklist.Add(CheckListService.DailyMorningCheckListToViewModel(dailyMorning));
                    }
                    IEnumerable<FMSDailyEvening> fMSDailyEvenings = from e in dbContext.FMSDailyEveningChecks where e.VehicleNumber == vehicleNumber && e.LastUpdated.Date == (PakistanDateTime.Today) select e;
                    if (fMSDailyEvenings.Any())
                    {
                        FMSDailyEvening dailyEvening = fMSDailyEvenings.FirstOrDefault();

                        checklist.Add(CheckListService.DailyEveningEngineCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningBodyCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningInteriorCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningAcCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningGeneralCheckListToViewModel(dailyEvening));
                    }
                    else
                    {
                        Vehicle vehicle = (from f in dbContext.Vehicles
                                                 join v in dbContext.GBMSVehicles on f.VehicleId equals v.Id
                                                 where v.Description == vehicleNumber
                                                 select f).SingleOrDefault();
                        Region region = (from r in dbContext.Regions
                                         where r.Id == vehicle.Region
                                         select r).SingleOrDefault();
                        SubRegion subRegion = (from s in dbContext.SubRegions
                                               where s.Id == vehicle.SubRegion
                                               select s).SingleOrDefault();
                        string DriverName = (from f in dbContext.Vehicles
                                             join d in dbContext.Drivers on f.DriverId equals d.Id
                                             join v in dbContext.GBMSVehicles on f.VehicleId equals v.Id
                                             where v.Description == vehicleNumber
                                             select d.Name).SingleOrDefault();
                        FMSDailyEvening dailyEvening = new FMSDailyEvening();
                        dailyEvening.Id = Guid.NewGuid();
                        dailyEvening.LastUpdated = PakistanDateTime.Now;
                        dailyEvening.VehicleNumber = vehicleNumber;
                        dailyEvening.DriverName = DriverName;
                        dailyEvening.Region = region.XDescription;
                        dailyEvening.Subregion = subRegion.XDescription;
                        await dbContext.FMSDailyEveningChecks.AddAsync(dailyEvening);
                        await dbContext.SaveChangesAsync();

                        checklist.Add(CheckListService.DailyEveningEngineCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningBodyCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningInteriorCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningAcCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningGeneralCheckListToViewModel(dailyEvening));
                    }
                }

                return Ok(checklist);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList")]
        public async Task<IActionResult> GetCheckListByVehicleNumber(ApiRequest request)
        {
            List<FMSDailyCheckListVM> checklist = new List<FMSDailyCheckListVM>();
            try
            {
                IEnumerable<FMSDailyMorning> fMSDailyMornings = from m in dbContext.FMSDailyMorningChecks where m.VehicleNumber == request.VehicleNumber && m.LastUpdated.Date == (PakistanDateTime.Today) select m;
                if (fMSDailyMornings.Any())
                {
                    FMSDailyMorning dailyMorning = fMSDailyMornings.FirstOrDefault();
                    checklist.Add(CheckListService.DailyMorningCheckListToViewModel(dailyMorning));
                }
                else
                {
                    Vehicle vehicle = (from f in dbContext.Vehicles
                                             join v in dbContext.GBMSVehicles on f.VehicleId equals v.Id
                                             where v.Description == request.VehicleNumber
                                             select f).SingleOrDefault();
                    Region region = (from r in dbContext.Regions
                                     where r.Id == vehicle.Region
                                     select r).SingleOrDefault();
                    SubRegion subRegion = (from s in dbContext.SubRegions
                                           where s.Id == vehicle.SubRegion
                                           select s).SingleOrDefault();
                    string DriverName = (from f in dbContext.Vehicles
                                         join d in dbContext.Drivers on f.DriverId equals d.Id
                                         join v in dbContext.GBMSVehicles on f.VehicleId equals v.Id
                                         where v.Description == request.VehicleNumber
                                         select d.Name).SingleOrDefault();
                    FMSDailyMorning dailyMorning = new FMSDailyMorning();
                    dailyMorning.Id = Guid.NewGuid();
                    dailyMorning.LastUpdated = PakistanDateTime.Now;
                    dailyMorning.VehicleNumber = request.VehicleNumber;
                    dailyMorning.DriverName = DriverName;
                    dailyMorning.Region = region.XDescription;
                    dailyMorning.Subregion = subRegion.XDescription;
                    await dbContext.FMSDailyMorningChecks.AddAsync(dailyMorning);
                    await dbContext.SaveChangesAsync();

                    checklist.Add(CheckListService.DailyMorningCheckListToViewModel(dailyMorning));
                }
                IEnumerable<FMSDailyEvening> fMSDailyEvenings = from e in dbContext.FMSDailyEveningChecks where e.VehicleNumber == request.VehicleNumber && e.LastUpdated.Date == (PakistanDateTime.Today) select e;
                if (fMSDailyEvenings.Any())
                {
                    FMSDailyEvening dailyEvening = fMSDailyEvenings.FirstOrDefault();

                    checklist.Add(CheckListService.DailyEveningEngineCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningBodyCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningInteriorCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningAcCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningGeneralCheckListToViewModel(dailyEvening));
                }
                else
                {
                    Vehicle vehicle = (from f in dbContext.Vehicles
                                             join v in dbContext.GBMSVehicles on f.VehicleId equals v.Id
                                             where v.Description == request.VehicleNumber
                                             select f).SingleOrDefault();
                    Region region = (from r in dbContext.Regions
                                     where r.Id == vehicle.Region
                                     select r).SingleOrDefault();
                    SubRegion subRegion = (from s in dbContext.SubRegions
                                           where s.Id == vehicle.SubRegion
                                           select s).SingleOrDefault();
                    string DriverName = (from f in dbContext.Vehicles
                                         join d in dbContext.Drivers on f.DriverId equals d.Id
                                         join v in dbContext.GBMSVehicles on f.VehicleId equals v.Id
                                         where v.Description == request.VehicleNumber
                                         select d.Name).SingleOrDefault();
                    FMSDailyEvening dailyEvening = new FMSDailyEvening();
                    dailyEvening.Id = Guid.NewGuid();
                    dailyEvening.LastUpdated = PakistanDateTime.Now;
                    dailyEvening.VehicleNumber = request.VehicleNumber;
                    dailyEvening.DriverName = DriverName;
                    dailyEvening.Region = region.XDescription;
                    dailyEvening.Subregion = subRegion.XDescription;
                    await dbContext.FMSDailyEveningChecks.AddAsync(dailyEvening);
                    await dbContext.SaveChangesAsync();

                    checklist.Add(CheckListService.DailyEveningEngineCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningBodyCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningInteriorCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningAcCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningGeneralCheckListToViewModel(dailyEvening));
                }
                return Ok(checklist);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList/Point/MarkDone")]
        public IActionResult GetCheckListPointMarkDone(ApiRequest request)
        {
            try
            {
                if (request.CheckListPointCode.StartsWith('E'))
                {
                    var parameter = Expression.Parameter(typeof(FMSDailyEvening));
                    var property = Expression.Property(parameter, $"{request.CheckListPointCode}");
                    var selector = Expression.Lambda<Func<FMSDailyEvening, bool>>(property, parameter);

                    SqlParameter vehiclenumber = new SqlParameter("@vehiclenumber", System.Data.SqlDbType.NVarChar)
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        Value = request.VehicleNumber
                    };

                    SqlParameter date = new SqlParameter("@date", System.Data.SqlDbType.DateTime2)
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        Value = PakistanDateTime.Today
                    };

                    SqlParameter now = new SqlParameter("@now", System.Data.SqlDbType.DateTime2)
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        Value = PakistanDateTime.Now
                    };

                    var rowsAffected = dbContext.Database.ExecuteSqlRaw($"UPDATE FMSDailyEveningChecks SET " + request.CheckListPointCode + " = 'true', LastUpdated = @now WHERE VehicleNumber = @vehiclenumber AND CAST(LastUpdated AS DATE) = CAST(@date AS DATE) ", vehiclenumber, date, now);
                }
                if (request.CheckListPointCode.StartsWith('M'))
                {
                    var parameter = Expression.Parameter(typeof(FMSDailyMorning));
                    var property = Expression.Property(parameter, $"{request.CheckListPointCode}");
                    var selector = Expression.Lambda<Func<FMSDailyMorning, bool>>(property, parameter);

                    SqlParameter vehiclenumber = new SqlParameter("@vehiclenumber", System.Data.SqlDbType.NVarChar)
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        Value = request.VehicleNumber
                    };

                    SqlParameter date = new SqlParameter("@date", System.Data.SqlDbType.DateTime2)
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        Value = PakistanDateTime.Today
                    };

                    SqlParameter now = new SqlParameter("@now", System.Data.SqlDbType.DateTime2)
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        Value = PakistanDateTime.Now
                    };

                    var rowsAffected = dbContext.Database.ExecuteSqlRaw($"UPDATE FMSDailyMorningChecks SET " + request.CheckListPointCode + " = 'true', LastUpdated = @now WHERE VehicleNumber = @vehiclenumber AND CAST(LastUpdated AS DATE) = CAST(@date AS DATE) ", vehiclenumber, date, now);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList/Remarks/Add")]
        public IActionResult AddRemarks(ApiRequest request)
        {
            try
            {
                FMSDailyMorning fMSDailyMorning = (from m in dbContext.FMSDailyMorningChecks where m.VehicleNumber == request.VehicleNumber && m.LastUpdated.Date == (PakistanDateTime.Today) select m).SingleOrDefault();
                FMSDailyEvening fMSDailyEvening = (from e in dbContext.FMSDailyEveningChecks where e.VehicleNumber == request.VehicleNumber && e.LastUpdated.Date == (PakistanDateTime.Today) select e).SingleOrDefault();
                fMSDailyEvening.Remarks += "* " + request.Remarks + " | " + PakistanDateTime.Now;
                fMSDailyMorning.Remarks += "* " + request.Remarks + " | " + PakistanDateTime.Now;
                dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
