using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Server.Services;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Traccar;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        AppDbContext dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        public ReportsController(UserManager<ApplicationUser> userManager, AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            _userManager = userManager;
        }


        /// <summary>
        /// Request for all fueling data
        /// </summary>
        /// <returns>
        /// all information about fueling
        /// </returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> All()
        {
            try
            {
                var applicationUser = await _userManager.FindByNameAsync(User.Identity.Name);
                string role = await ModelService.GetUserRole(dbContext, applicationUser.Id);

                List<DailyFuelReport> fuelingInfoList = await (from f in dbContext.FuelingInfo
                                                               join g in dbContext.GBMSVehicles on f.VehicleNumber equals g.Description
                                                               where f.Litres != "0" && f.Milage != "0"
                                                               select new DailyFuelReport()
                                                               {
                                                                   Id = f.Id,
                                                                   VehicleNumber = f.VehicleNumber,
                                                                   Region = f.Region,
                                                                   //VehicleEnrollmentIn="Dummy Enrollment",
                                                                   VehicleOffRoad = false,

                                                                   Odometer = f.Odometer,
                                                                   PreviousOdometer = f.PreviousOdometer,
                                                                   Mileage = f.Milage,
                                                                   Average = (Convert.ToDouble(f.Milage) / Convert.ToDouble(f.Litres)).ToString(),
                                                                   CC = "Unknown",
                                                                   ACC = "Unknown",
                                                                   Driver = f.DriverName,
                                                                   Guard = "Unknown",

                                                                   FuelType = g.GasolineType,
                                                                   Litres = f.Litres,
                                                                   Rate = f.Rate,
                                                                   Amount = f.Amount,
                                                                   PaymentType = f.PaymentType,
                                                                   CostKm = Convert.ToString(Convert.ToDouble(f.Amount) / Convert.ToDouble(f.Milage)),

                                                                   Timestamp = f.Timestamp,
                                                                   Purchaser = f.DriverName,
                                                                   //InvoiceReference= "Unknown",
                                                                   Vendor = f.FillingStation,
                                                                   Make = g.Make,
                                                                   Model = g.Model,
                                                                   VehicleType = g.VehicleType
                                                                   //MTOfficer="Unknown",

                                                               }).ToListAsync();
                foreach (var item in fuelingInfoList)
                {
                    Crew crew = await ModelService.getCrewByVehicleNo(dbContext, item.VehicleNumber);
                    if (crew.members != null)
                    {
                        foreach(var c in crew.members)
                        {
                            if (c.designation == "CheifCrewAgent")
                            {
                                item.CC = c.name;
                            }
                            if (c.designation == "AssistantCrewAgent")
                            {
                                item.ACC = c.name;
                            }
                            if (c.designation == "CrewGuard")
                            {
                                item.Guard = c.name;
                            }
                        }
                    }
                }

                return Ok(fuelingInfoList);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Date wise Fuel Comparison data with respect to each vehicle
        /// </summary>
        /// <param name="fuelComparisonReport"></param>
        /// <returns>Fuel Comparison data</returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> FuelComparisonReport(FuelComparisonReport fuelComparisonReport)
        {
            try
            {
                var applicationUser = await _userManager.FindByNameAsync(User.Identity.Name);
                string role = await ModelService.GetUserRole(dbContext, applicationUser.Id);

                int days = DateTime.DaysInMonth(fuelComparisonReport.Date.Year, fuelComparisonReport.Date.Month);
                List<FuelComparisonReport> fuelingInfoList = new List<FuelComparisonReport>();
                List<string> Regions = new List<string>();
                if (fuelComparisonReport.Region != null)
                {
                    Regions.Add(fuelComparisonReport.Region);
                }
                else
                {
                    Regions = await RegionService.GetRegions(dbContext, role);
                }
                int j = 0;
                foreach (var region in Regions)
                {
                    fuelingInfoList.Add(new FuelComparisonReport() { Region = region, Date = new DateTime(fuelComparisonReport.Date.Year, fuelComparisonReport.Date.Month, 1) });
                    for (int i = 1; i <= days; i++)
                    {
                        decimal sumOfFuel = await (from f in dbContext.FuelingInfo
                                                   join v in dbContext.Vehicles on f.VehicleNumber equals v.VehicleNumber
                                                   join g in dbContext.GBMSVehicles on f.VehicleNumber equals g.Description
                                                   where v.Region == region 
                                                   && (string.IsNullOrEmpty(fuelComparisonReport.FuelType) || v.GasolineType == fuelComparisonReport.FuelType)
                                                   && (string.IsNullOrEmpty(fuelComparisonReport.PaymentType) || f.PaymentType == fuelComparisonReport.PaymentType)
                                                   && (string.IsNullOrEmpty(fuelComparisonReport.VehicleNumber) || f.VehicleNumber == fuelComparisonReport.VehicleNumber)
                                                   && (string.IsNullOrEmpty(fuelComparisonReport.VehicleType) || g.VehicleType== fuelComparisonReport.VehicleType)
                                                   && (string.IsNullOrEmpty(fuelComparisonReport.Make) || g.Make == fuelComparisonReport.Make)
                                                   && (string.IsNullOrEmpty(fuelComparisonReport.Model) || g.Model == fuelComparisonReport.Model)
                                                   && f.Timestamp.Day.Equals(i) && f.Timestamp.Month.Equals(fuelComparisonReport.Date.Month) && f.Timestamp.Year.Equals(fuelComparisonReport.Date.Year)
                                                   select Convert.ToDecimal(f.Litres)).SumAsync();

                        switch (i)
                        {
                            case 1:
                                fuelingInfoList[j].Totalfuel1 = sumOfFuel;
                                break;
                            case 2:
                                fuelingInfoList[j].Totalfuel2 = sumOfFuel;
                                break;
                            case 3:
                                fuelingInfoList[j].Totalfuel3 = sumOfFuel;
                                break;
                            case 4:
                                fuelingInfoList[j].Totalfuel4 = sumOfFuel;
                                break;
                            case 5:
                                fuelingInfoList[j].Totalfuel5 = sumOfFuel;
                                break;
                            case 6:
                                fuelingInfoList[j].Totalfuel6 = sumOfFuel;
                                break;
                            case 7:
                                fuelingInfoList[j].Totalfuel7 = sumOfFuel;
                                break;
                            case 8:
                                fuelingInfoList[j].Totalfuel8 = sumOfFuel;
                                break;
                            case 9:
                                fuelingInfoList[j].Totalfuel9 = sumOfFuel;
                                break;
                            case 10:
                                fuelingInfoList[j].Totalfuel10 = sumOfFuel;
                                break;
                            case 11:
                                fuelingInfoList[j].Totalfuel11 = sumOfFuel;
                                break;
                            case 12:
                                fuelingInfoList[j].Totalfuel12 = sumOfFuel;
                                break;
                            case 13:
                                fuelingInfoList[j].Totalfuel13 = sumOfFuel;
                                break;
                            case 14:
                                fuelingInfoList[j].Totalfuel14 = sumOfFuel;
                                break;
                            case 15:
                                fuelingInfoList[j].Totalfuel15 = sumOfFuel;
                                break;
                            case 16:
                                fuelingInfoList[j].Totalfuel16 = sumOfFuel;
                                break;
                            case 17:
                                fuelingInfoList[j].Totalfuel17 = sumOfFuel;
                                break;
                            case 18:
                                fuelingInfoList[j].Totalfuel18 = sumOfFuel;
                                break;
                            case 19:
                                fuelingInfoList[j].Totalfuel19 = sumOfFuel;
                                break;
                            case 20:
                                fuelingInfoList[j].Totalfuel20 = sumOfFuel;
                                break;
                            case 21:
                                fuelingInfoList[j].Totalfuel21 = sumOfFuel;
                                break;
                            case 22:
                                fuelingInfoList[j].Totalfuel22 = sumOfFuel;
                                break;
                            case 23:
                                fuelingInfoList[j].Totalfuel23 = sumOfFuel;
                                break;
                            case 24:
                                fuelingInfoList[j].Totalfuel24 = sumOfFuel;
                                break;
                            case 25:
                                fuelingInfoList[j].Totalfuel25 = sumOfFuel;
                                break;
                            case 26:
                                fuelingInfoList[j].Totalfuel26 = sumOfFuel;
                                break;
                            case 27:
                                fuelingInfoList[j].Totalfuel27 = sumOfFuel;
                                break;
                            case 28:
                                fuelingInfoList[j].Totalfuel28 = sumOfFuel;
                                break;
                            case 29:
                                fuelingInfoList[j].Totalfuel29 = sumOfFuel;
                                break;
                            case 30:
                                fuelingInfoList[j].Totalfuel30 = sumOfFuel;
                                break;
                            case 31:
                                fuelingInfoList[j].Totalfuel31 = sumOfFuel;
                                break;
                        }
                    }
                    j++;
                }

                return Ok(fuelingInfoList);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// All Regions request
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetRegions()
        {
            try
            {
                return Ok(await RegionService.GetRegions(dbContext,"SA"));
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Filtered vehicles list with repect to the object passed in parameter
        /// </summary>
        /// <param name="fuelComparisonReport"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetVehicleList(FuelComparisonReport fuelComparisonReport)
        {
            try
            {
                List<string> vehicleList = await(from f in dbContext.FuelingInfo
                                                 join v in dbContext.Vehicles on f.VehicleNumber equals v.VehicleNumber
                                                 join g in dbContext.GBMSVehicles on f.VehicleNumber equals g.Description
                                                 where v.Region == fuelComparisonReport.Region
                                                 && (string.IsNullOrEmpty(fuelComparisonReport.FuelType) || v.GasolineType == fuelComparisonReport.FuelType)
                                                 && (string.IsNullOrEmpty(fuelComparisonReport.PaymentType) || f.PaymentType == fuelComparisonReport.PaymentType)
                                                 && (string.IsNullOrEmpty(fuelComparisonReport.VehicleNumber) || f.VehicleNumber == fuelComparisonReport.VehicleNumber)
                                                 && (string.IsNullOrEmpty(fuelComparisonReport.VehicleType) || g.VehicleType == fuelComparisonReport.VehicleType)
                                                 && (string.IsNullOrEmpty(fuelComparisonReport.Make) || g.Make == fuelComparisonReport.Make)
                                                 && (string.IsNullOrEmpty(fuelComparisonReport.Model) || g.Model == fuelComparisonReport.Model)
                                                 && f.Timestamp.Month.Equals(fuelComparisonReport.Date.Month) && f.Timestamp.Year.Equals(fuelComparisonReport.Date.Year)
                                                 select v.VehicleNumber).Distinct().ToListAsync();
                
                return Ok(vehicleList);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Filtered vehicle types list with repect to the object passed in parameter
        /// </summary>
        /// <param name="fuelComparisonReport"></param>
        /// <returns></returns>

        [HttpPost("[action]")]
        public async Task<IActionResult> GetVehicleTypeList(FuelComparisonReport fuelComparisonReport)
        {
            try
            {
                List<string> vehicleList = await (from f in dbContext.FuelingInfo
                                                  join v in dbContext.Vehicles on f.VehicleNumber equals v.VehicleNumber
                                                  join g in dbContext.GBMSVehicles on f.VehicleNumber equals g.Description
                                                  where v.Region == fuelComparisonReport.Region
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.FuelType) || v.GasolineType == fuelComparisonReport.FuelType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.PaymentType) || f.PaymentType == fuelComparisonReport.PaymentType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.VehicleNumber) || f.VehicleNumber == fuelComparisonReport.VehicleNumber)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.VehicleType) || g.VehicleType == fuelComparisonReport.VehicleType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.Make) || g.Make == fuelComparisonReport.Make)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.Model) || g.Model == fuelComparisonReport.Model)
                                                  && f.Timestamp.Month.Equals(fuelComparisonReport.Date.Month) && f.Timestamp.Year.Equals(fuelComparisonReport.Date.Year)
                                                  select g.VehicleType).Distinct().ToListAsync();

                return Ok(vehicleList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Filtered vehicle makes list with repect to the object passed in parameter
        /// </summary>
        /// <param name="fuelComparisonReport"></param>
        /// <returns></returns>

        [HttpPost("[action]")]
        public async Task<IActionResult> GetMakeList(FuelComparisonReport fuelComparisonReport)
        {
            try
            {
                List<string> vehicleList = await (from f in dbContext.FuelingInfo
                                                  join v in dbContext.Vehicles on f.VehicleNumber equals v.VehicleNumber
                                                  join g in dbContext.GBMSVehicles on f.VehicleNumber equals g.Description
                                                  where v.Region == fuelComparisonReport.Region
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.FuelType) || v.GasolineType == fuelComparisonReport.FuelType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.PaymentType) || f.PaymentType == fuelComparisonReport.PaymentType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.VehicleNumber) || f.VehicleNumber == fuelComparisonReport.VehicleNumber)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.VehicleType) || g.VehicleType == fuelComparisonReport.VehicleType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.Make) || g.Make == fuelComparisonReport.Make)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.Model) || g.Model == fuelComparisonReport.Model)
                                                  && f.Timestamp.Month.Equals(fuelComparisonReport.Date.Month) && f.Timestamp.Year.Equals(fuelComparisonReport.Date.Year)
                                                  select g.Make).Distinct().ToListAsync();

                return Ok(vehicleList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Filtered vehicle models list with repect to the object passed in parameter
        /// </summary>
        /// <param name="fuelComparisonReport"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetModelList(FuelComparisonReport fuelComparisonReport)
        {
            try
            {
                List<string> vehicleList = await (from f in dbContext.FuelingInfo
                                                  join v in dbContext.Vehicles on f.VehicleNumber equals v.VehicleNumber
                                                  join g in dbContext.GBMSVehicles on f.VehicleNumber equals g.Description
                                                  where v.Region == fuelComparisonReport.Region
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.FuelType) || v.GasolineType == fuelComparisonReport.FuelType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.PaymentType) || f.PaymentType == fuelComparisonReport.PaymentType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.VehicleNumber) || f.VehicleNumber == fuelComparisonReport.VehicleNumber)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.VehicleType) || g.VehicleType == fuelComparisonReport.VehicleType)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.Make) || g.Make == fuelComparisonReport.Make)
                                                  && (string.IsNullOrEmpty(fuelComparisonReport.Model) || g.Model == fuelComparisonReport.Model)
                                                  && f.Timestamp.Month.Equals(fuelComparisonReport.Date.Month) && f.Timestamp.Year.Equals(fuelComparisonReport.Date.Year)
                                                  select g.Model).Distinct().ToListAsync();

                return Ok(vehicleList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Traccar data summary between two dates
        /// </summary>
        /// <param name="reportRequest"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetSummaries(ReportRequest reportRequest)
        {
            try
            {
                return Ok(await TraccarService.GetSummaries(reportRequest.FromDate, reportRequest.ToDate));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Traccar stops data summary between two dates
        /// </summary>
        /// <param name="reportRequest"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetStops(ReportRequest reportRequest)
        {
            try
            {
                return Ok(await TraccarService.GetStops(reportRequest.FromDate, reportRequest.ToDate));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Traccar trips data summary between two dates
        /// </summary>
        /// <param name="reportRequest"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> GetTrips(ReportRequest reportRequest)
        {
            try
            {
                return Ok(await TraccarService.GetTrips(reportRequest.FromDate, reportRequest.ToDate));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
