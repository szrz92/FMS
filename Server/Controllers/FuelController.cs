using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class FuelController : ControllerBase
    {
        AppDbContext dbContext;
        public FuelController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Save(FuelingInfoVM fuelingInfo)
        {
            try
            {
                FuelingInfo info = new FuelingInfo()
                {
                    Id = Guid.NewGuid(),
                    Amount = fuelingInfo.Amount,
                    DriverName = dbContext.Drivers.Where(x => x.VehicleNumber == fuelingInfo.VehicleNumber).FirstOrDefault().Name,
                    FillingCity = fuelingInfo.FillingCity,
                    FillingStation = fuelingInfo.FillingStation,
                    Litres = fuelingInfo.Litres,
                    Milage = fuelingInfo.Milage,
                    Odometer = fuelingInfo.Odometer,
                    PaymentType = fuelingInfo.PaymentType,
                    Rate = fuelingInfo.Rate,
                    Region = dbContext.Vehicles.Where(x => x.VehicleNumber == fuelingInfo.VehicleNumber).FirstOrDefault().Region,
                    Remarks = fuelingInfo.Remarks,
                    Timestamp = PakistanDateTime.Now,
                    VehicleNumber = fuelingInfo.VehicleNumber
                };
                await dbContext.FuelingInfo.AddAsync(info);
                await dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
