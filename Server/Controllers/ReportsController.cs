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
    public class ReportsController : ControllerBase
    {
        AppDbContext dbContext;
        public ReportsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> All()
        {
            try
            {
                List<DailyFuelReport> fuelingInfoList = await (from f in dbContext.FuelingInfo
                                                               join v in dbContext.Vehicles on f.VehicleNumber equals v.VehicleNumber
                                                             select new DailyFuelReport()
                                                             {
                                                                 Id = f.Id,
                                                                 VehicleNumber = f.VehicleNumber,
                                                                 Region = f.Region,
                                                                 VehicleEnrollmentIn="Dummy Enrollment",
                                                                 VehicleOffRoad=false,

                                                                 Odometer = f.Odometer,
                                                                 PreviousOdometer=f.Odometer,
                                                                 Mileage = f.Milage,
                                                                 CC="Unknown",
                                                                 ACC = "Unknown",
                                                                 Driver = f.DriverName,
                                                                 Guard="Unknown",

                                                                 FuelType=v.GasolineType,
                                                                 Litres = f.Litres,
                                                                 Rate = f.Rate,
                                                                 Amount = f.Amount,
                                                                 PaymentType = f.PaymentType,

                                                                 Timestamp = f.Timestamp,
                                                                 Purchaser=f.DriverName,
                                                                 InvoiceReference= "Unknown",
                                                                 Vendor= f.FillingStation,
                                                                 MTOfficer="Unknown",
                                                             }).ToListAsync();

                return Ok(fuelingInfoList);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
