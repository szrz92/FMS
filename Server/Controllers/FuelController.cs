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
        [HttpGet("[action]")]
        public async Task<IActionResult> All()
        {
            try
            {
                List<FuelingInfoVM> fuelingInfoList = await (from f in dbContext.FuelingInfo
                                                             select new FuelingInfoVM()
                                                             {
                                                                 Amount = f.Amount,
                                                                 DriverName = f.DriverName,
                                                                 FillingCity = f.FillingCity,
                                                                 FillingStation = f.FillingStation,
                                                                 Id = f.Id,
                                                                 Litres = f.Litres,
                                                                 Milage = f.Milage,
                                                                 Odometer = f.Odometer,
                                                                 PaymentType = f.PaymentType,
                                                                 Rate = f.Rate,
                                                                 Region = f.Region,
                                                                 Remarks = f.Remarks,
                                                                 Timestamp = f.Timestamp,
                                                                 VehicleNumber = f.VehicleNumber
                                                             }).ToListAsync();
                List<FuelingInfoVM> psoWorkSheetList = await (from p in dbContext.PSOWorksheets
                                                              select new FuelingInfoVM()
                                                              {
                                                                  Amount = p.TxnAmount,
                                                                  DriverName = "",
                                                                  FillingStation = p.MerchantName,
                                                                  FillingCity = p.MerchantCity,
                                                                  Id = p.Id,
                                                                  Litres = p.Qty,
                                                                  Odometer = "",
                                                                  Milage = "",
                                                                  PaymentType = "PSO Card",
                                                                  Rate = p.Rate,
                                                                  Region = "",
                                                                  Remarks = "",
                                                                  Timestamp = Convert.ToDateTime(p.Date),
                                                                  VehicleNumber = ""
                                                              }).ToListAsync();
                return Ok(fuelingInfoList.Union(psoWorkSheetList));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
