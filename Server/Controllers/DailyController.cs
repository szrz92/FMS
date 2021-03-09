using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Server.Services;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Enums;
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
                                               join gv in dbContext.GBMSVehicles on v.VehicleNumber equals gv.Description
                                               select gv.Description).ToList();
                foreach (var vehicleNumber in vehicleNumbers)
                {
                    IEnumerable <DailyMorning> fMSDailyMornings = from m in dbContext.DailyMorningChecks where m.VehicleNumber == vehicleNumber && m.LastUpdated.Date == (PakistanDateTime.Today) select m;
                    if (fMSDailyMornings.Any())
                    {
                        DailyMorning dailyMorning = fMSDailyMornings.FirstOrDefault();
                        checklist.Add(CheckListService.DailyMorningCheckListToViewModel(dailyMorning));
                    }
                    else
                    {
                        Vehicle vehicle = (from f in dbContext.Vehicles
                                                 join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                                 where v.Description == vehicleNumber
                                                 select f).SingleOrDefault();
                        Region region = (from r in dbContext.Regions
                                         where r.XDescription == vehicle.Region
                                         select r).SingleOrDefault();
                        SubRegion subRegion = (from s in dbContext.SubRegions
                                               where s.XDescription == vehicle.SubRegion
                                               select s).SingleOrDefault();
                        string DriverName = (from f in dbContext.Vehicles
                                             join d in dbContext.Drivers on f.VehicleNumber equals d.VehicleNumber
                                             join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                             where v.Description == vehicleNumber
                                             select d.Name).SingleOrDefault();
                        DailyMorning dailyMorning = new();
                        dailyMorning.Id = Guid.NewGuid();
                        dailyMorning.LastUpdated = PakistanDateTime.Now;
                        dailyMorning.VehicleNumber = vehicleNumber;
                        dailyMorning.DriverName = DriverName;
                        dailyMorning.Region = region.XDescription;
                        dailyMorning.Subregion = subRegion.XDescription;
                        await dbContext.DailyMorningChecks.AddAsync(dailyMorning);
                        await dbContext.SaveChangesAsync();

                        checklist.Add(CheckListService.DailyMorningCheckListToViewModel(dailyMorning));
                    }
                    IEnumerable<DailyEvening> fMSDailyEvenings = from e in dbContext.DailyEveningChecks where e.VehicleNumber == vehicleNumber && e.LastUpdated.Date == (PakistanDateTime.Today) select e;
                    if (fMSDailyEvenings.Any())
                    {
                        DailyEvening dailyEvening = fMSDailyEvenings.FirstOrDefault();

                        checklist.Add(CheckListService.DailyEveningEngineCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningBodyCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningInteriorCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningAcCheckListToViewModel(dailyEvening));
                        checklist.Add(CheckListService.DailyEveningGeneralCheckListToViewModel(dailyEvening));
                    }
                    else
                    {
                        Vehicle vehicle = (from f in dbContext.Vehicles
                                           join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                           where v.Description == vehicleNumber
                                           select f).SingleOrDefault();
                        Region region = (from r in dbContext.Regions
                                         where r.XDescription == vehicle.Region
                                         select r).SingleOrDefault();
                        SubRegion subRegion = (from s in dbContext.SubRegions
                                               where s.XDescription == vehicle.SubRegion
                                               select s).SingleOrDefault();
                        string DriverName = (from f in dbContext.Vehicles
                                             join d in dbContext.Drivers on f.VehicleNumber equals d.VehicleNumber
                                             join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                             where v.Description == vehicleNumber
                                             select d.Name).SingleOrDefault();
                        DailyEvening dailyEvening = new DailyEvening();
                        dailyEvening.Id = Guid.NewGuid();
                        dailyEvening.LastUpdated = PakistanDateTime.Now;
                        dailyEvening.VehicleNumber = vehicleNumber;
                        dailyEvening.DriverName = DriverName;
                        dailyEvening.Region = region.XDescription;
                        dailyEvening.Subregion = subRegion.XDescription;
                        await dbContext.DailyEveningChecks.AddAsync(dailyEvening);
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
                IEnumerable<DailyMorning> fMSDailyMornings = from m in dbContext.DailyMorningChecks where m.VehicleNumber == request.VehicleNumber && m.LastUpdated.Date == (PakistanDateTime.Today) select m;
                if (fMSDailyMornings.Any())
                {
                    DailyMorning dailyMorning = fMSDailyMornings.FirstOrDefault();
                    checklist.Add(CheckListService.DailyMorningCheckListToViewModel(dailyMorning));
                }
                else
                {
                    Vehicle vehicle = (from f in dbContext.Vehicles
                                             join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                             where v.Description == request.VehicleNumber
                                             select f).SingleOrDefault();
                    Region region = (from r in dbContext.Regions
                                     where r.XDescription == vehicle.Region
                                     select r).SingleOrDefault();
                    SubRegion subRegion = (from s in dbContext.SubRegions
                                           where s.XDescription == vehicle.SubRegion
                                           select s).SingleOrDefault();
                    string DriverName = (from f in dbContext.Vehicles
                                         join d in dbContext.Drivers on f.VehicleNumber equals d.VehicleNumber
                                         join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                         where v.Description == request.VehicleNumber
                                         select d.Name).SingleOrDefault();
                    DailyMorning dailyMorning = new DailyMorning();
                    dailyMorning.Id = Guid.NewGuid();
                    dailyMorning.LastUpdated = PakistanDateTime.Now;
                    dailyMorning.VehicleNumber = request.VehicleNumber;
                    dailyMorning.DriverName = DriverName;
                    dailyMorning.Region = region.XDescription;
                    dailyMorning.Subregion = subRegion.XDescription;
                    await dbContext.DailyMorningChecks.AddAsync(dailyMorning);
                    await dbContext.SaveChangesAsync();

                    checklist.Add(CheckListService.DailyMorningCheckListToViewModel(dailyMorning));
                }
                IEnumerable<DailyEvening> fMSDailyEvenings = from e in dbContext.DailyEveningChecks where e.VehicleNumber == request.VehicleNumber && e.LastUpdated.Date == (PakistanDateTime.Today) select e;
                if (fMSDailyEvenings.Any())
                {
                    DailyEvening dailyEvening = fMSDailyEvenings.FirstOrDefault();

                    checklist.Add(CheckListService.DailyEveningEngineCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningBodyCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningInteriorCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningAcCheckListToViewModel(dailyEvening));
                    checklist.Add(CheckListService.DailyEveningGeneralCheckListToViewModel(dailyEvening));
                }
                else
                {
                    Vehicle vehicle = (from f in dbContext.Vehicles
                                             join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                             where v.Description == request.VehicleNumber
                                             select f).SingleOrDefault();
                    Region region = (from r in dbContext.Regions
                                     where r.XDescription == vehicle.Region
                                     select r).SingleOrDefault();
                    SubRegion subRegion = (from s in dbContext.SubRegions
                                           where s.XDescription == vehicle.SubRegion
                                           select s).SingleOrDefault();
                    string DriverName = (from f in dbContext.Vehicles
                                         join d in dbContext.Drivers on f.VehicleNumber equals d.VehicleNumber
                                         join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                         where v.Description == request.VehicleNumber
                                         select d.Name).SingleOrDefault();
                    DailyEvening dailyEvening = new DailyEvening();
                    dailyEvening.Id = Guid.NewGuid();
                    dailyEvening.LastUpdated = PakistanDateTime.Now;
                    dailyEvening.VehicleNumber = request.VehicleNumber;
                    dailyEvening.DriverName = DriverName;
                    dailyEvening.Region = region.XDescription;
                    dailyEvening.Subregion = subRegion.XDescription;
                    await dbContext.DailyEveningChecks.AddAsync(dailyEvening);
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
                    var parameter = Expression.Parameter(typeof(DailyEvening));
                    var property = Expression.Property(parameter, $"{request.CheckListPointCode}");
                    var selector = Expression.Lambda<Func<DailyEvening, DailyCheckStatus>>(property, parameter);

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

                    SqlParameter now = new("@now", System.Data.SqlDbType.DateTime2)
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        Value = PakistanDateTime.Now
                    };

                    var rowsAffected = dbContext.Database.ExecuteSqlRaw($"UPDATE DailyEveningChecks SET " + request.CheckListPointCode + " = '" + (int)DailyCheckStatus.Checked + "', LastUpdated = @now WHERE VehicleNumber = @vehiclenumber AND CAST(LastUpdated AS DATE) = CAST(@date AS DATE) ", vehiclenumber, date, now);
                }
                if (request.CheckListPointCode.StartsWith('M'))
                {
                    var parameter = Expression.Parameter(typeof(DailyMorning));
                    var property = Expression.Property(parameter, $"{request.CheckListPointCode}");
                    var selector = Expression.Lambda<Func<DailyMorning, DailyCheckStatus>>(property, parameter);

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

                    var rowsAffected = dbContext.Database.ExecuteSqlRaw($"UPDATE DailyMorningChecks SET " + request.CheckListPointCode + " = '" + (int)DailyCheckStatus.Checked + "', LastUpdated = @now WHERE VehicleNumber = @vehiclenumber AND CAST(LastUpdated AS DATE) = CAST(@date AS DATE) ", vehiclenumber, date, now);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("FMS/CheckList/Point/MarkNotOk")]
        public IActionResult GetCheckListPointMarkNotOk(ApiRequest request)
        {
            try
            {
                if (request.CheckListPointCode.StartsWith('E'))
                {
                    var parameter = Expression.Parameter(typeof(DailyEvening));
                    var property = Expression.Property(parameter, $"{request.CheckListPointCode}");
                    var selector = Expression.Lambda<Func<DailyEvening, DailyCheckStatus>>(property, parameter);

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

                    SqlParameter now = new("@now", System.Data.SqlDbType.DateTime2)
                    {
                        Direction = System.Data.ParameterDirection.Input,
                        Value = PakistanDateTime.Now
                    };

                    var rowsAffected = dbContext.Database.ExecuteSqlRaw($"UPDATE DailyEveningChecks SET " + request.CheckListPointCode + " = '" + (int)DailyCheckStatus.NotOk + "', LastUpdated = @now WHERE VehicleNumber = @vehiclenumber AND CAST(LastUpdated AS DATE) = CAST(@date AS DATE) ", vehiclenumber, date, now);
                    if (rowsAffected > 0)
                    {
                        Complaint complaint = new Complaint() 
                        {
                            Id = Guid.NewGuid(),
                            VehicleNumber = request.VehicleNumber,
                            DriverName = dbContext.Drivers.Where(x=>x.VehicleNumber == request.VehicleNumber).SingleOrDefault().Name,
                            ComplaintDescription = request.Remarks,
                            PointCode = request.CheckListPointCode,
                            PointCodeDescription = request.CheckListPoint,
                            ReportTime = PakistanDateTime.Now
                        };
                        dbContext.Complaints.Add(complaint);
                        dbContext.SaveChanges();
                    }
                }
                if (request.CheckListPointCode.StartsWith('M'))
                {
                    var parameter = Expression.Parameter(typeof(DailyMorning));
                    var property = Expression.Property(parameter, $"{request.CheckListPointCode}");
                    var selector = Expression.Lambda<Func<DailyMorning, DailyCheckStatus>>(property, parameter);

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

                    var rowsAffected = dbContext.Database.ExecuteSqlRaw($"UPDATE DailyMorningChecks SET " + request.CheckListPointCode + " = '" + (int)DailyCheckStatus.NotOk + "', LastUpdated = @now WHERE VehicleNumber = @vehiclenumber AND CAST(LastUpdated AS DATE) = CAST(@date AS DATE) ", vehiclenumber, date, now);
                    if (rowsAffected > 0)
                    {
                        Complaint complaint = new Complaint()
                        {
                            Id = Guid.NewGuid(),
                            VehicleNumber = request.VehicleNumber,
                            DriverName = dbContext.Drivers.Where(x => x.VehicleNumber == request.VehicleNumber).SingleOrDefault().Name,
                            ComplaintDescription = request.Remarks,
                            PointCode = request.CheckListPointCode,
                            PointCodeDescription = request.CheckListPoint,
                            ReportTime = PakistanDateTime.Now
                        };
                        dbContext.Complaints.Add(complaint);
                        dbContext.SaveChanges();
                    }
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
                DailyMorning fMSDailyMorning = (from m in dbContext.DailyMorningChecks where m.VehicleNumber == request.VehicleNumber && m.LastUpdated.Date == (PakistanDateTime.Today) select m).SingleOrDefault();
                DailyEvening fMSDailyEvening = (from e in dbContext.DailyEveningChecks where e.VehicleNumber == request.VehicleNumber && e.LastUpdated.Date == (PakistanDateTime.Today) select e).SingleOrDefault();
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
