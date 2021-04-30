using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        /// <summary>
        /// Saving new fueling information
        /// </summary>
        /// <param name="fuelingInfo"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> Save(FuelingInfoVM fuelingInfo)
        {
            try
            {
                
                double lastOdometer = await dbContext.FuelingInfo
                    .Where(x => x.VehicleNumber == fuelingInfo.VehicleNumber)
                    .Select(x => new FuelingInfo() { Odometer = x.Odometer, Timestamp = x.Timestamp })
                    .OrderByDescending(x => x.Timestamp)
                    .Select(x => Convert.ToDouble(x.Odometer)).FirstOrDefaultAsync();

                if (Convert.ToDouble(fuelingInfo.Odometer) > lastOdometer)
                {
                    FuelingInfo info = new()
                    {
                        Id = Guid.NewGuid(),
                        Amount = fuelingInfo.Amount,
                        DriverName = dbContext.Drivers.Where(x => x.VehicleNumber == fuelingInfo.VehicleNumber).FirstOrDefault().Name,
                        FillingCity = fuelingInfo.FillingCity,
                        FillingStation = fuelingInfo.FillingStation,
                        Litres = fuelingInfo.Litres,
                        Milage = (Convert.ToDouble(fuelingInfo.Odometer) - lastOdometer).ToString(),
                        Odometer = fuelingInfo.Odometer,
                        PreviousOdometer = lastOdometer.ToString(),
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
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Retrieve all fueling information entered to the system
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public async Task<IActionResult> All()
        {
            try
            {
                List<FuelingInfoVM> fuelingInfoList = await (from f in dbContext.FuelingInfo
                                                             select new FuelingInfoVM()
                                                             {
                                                                 //Amount = f.Amount,
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

                List < FuelingInfoVM > psoWorkSheetList = await (from p in dbContext.PSOWorksheets
                                                                 join v in dbContext.Vehicles on p.CardNumber equals v.CardNumber
                                                                 join d in dbContext.Drivers on v.VehicleNumber equals d.VehicleNumber
                                                                 select new FuelingInfoVM()
                                                                 {
                                                                     //Amount = p.TxnAmount,
                                                                     DriverName = d.Name,
                                                                     FillingStation = p.MerchantName,
                                                                     FillingCity = p.MerchantCity,
                                                                     Id = p.Id,
                                                                     Litres = p.Qty,
                                                                     Odometer = Functions.ToLongString(v.Distance), //Convert.ToString(v.Distance),
                                                                     Milage = "",
                                                                     PaymentType = "PSO Card",
                                                                     Rate = p.Rate,
                                                                     Region = v.Region,
                                                                     Remarks = "",
                                                                     Timestamp = Convert.ToDateTime(p.Date),
                                                                     VehicleNumber = v.VehicleNumber
                                                                 }).ToListAsync();
                return Ok(fuelingInfoList.Union(psoWorkSheetList));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }

    public static class Functions
    {
        public static string ToLongString(double input)
        {
            string strOrig = input.ToString();
            string str = strOrig.ToUpper();

            // if string representation was collapsed from scientific notation, just return it:
            if (!str.Contains("E")) return strOrig;

            bool negativeNumber = false;

            if (str[0] == '-')
            {
                str = str.Remove(0, 1);
                negativeNumber = true;
            }

            string sep = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            char decSeparator = sep.ToCharArray()[0];

            string[] exponentParts = str.Split('E');
            string[] decimalParts = exponentParts[0].Split(decSeparator);

            // fix missing decimal point:
            if (decimalParts.Length == 1) decimalParts = new string[] { exponentParts[0], "0" };

            int exponentValue = int.Parse(exponentParts[1]);

            string newNumber = decimalParts[0] + decimalParts[1];

            string result;

            if (exponentValue > 0)
            {
                result =
                    newNumber +
                    GetZeros(exponentValue - decimalParts[1].Length);
            }
            else // negative exponent
            {
                result =
                    "0" +
                    decSeparator +
                    GetZeros(exponentValue + decimalParts[0].Length) +
                    newNumber;

                result = result.TrimEnd('0');
            }

            if (negativeNumber)
                result = "-" + result;

            return result;
        }

        public static string GetZeros(int zeroCount)
        {
            if (zeroCount < 0)
                zeroCount = Math.Abs(zeroCount);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < zeroCount; i++) sb.Append("0");

            return sb.ToString();
        }
    }
}
