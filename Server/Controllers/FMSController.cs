using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SOS.FMS.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FMSController : ControllerBase
    {
        AppDbContext dbContext;
        public FMSController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("CrewDrivers/Sync")]
        public async Task<IActionResult> SyncCrewDrivers()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://dev-sos-apis.azurewebsites.net/api/Fms/");
                    var response = await client.GetAsync("GetActiveCrews");
                    var responseString = await response.Content.ReadAsStringAsync();
                    List<Crew> CrewData = JsonConvert.DeserializeObject<List<Crew>>(responseString);

                    foreach (var crew in CrewData)
                    {
                        foreach (var member in crew.members)
                        {
                            if (member.designation.Contains("Driver"))
                            {
                                Driver driver = dbContext.Drivers.Where(x => x.Code.Equals(member.code)).FirstOrDefault();
                                if (driver == null)
                                {
                                    driver = new Driver()
                                    {
                                        Name = member.name,
                                        Code = member.code,
                                        VehicleNumber = crew.vehicle,
                                        Region = dbContext.Vehicles.Where(x=>x.VehicleNumber == crew.vehicle).FirstOrDefault().Region,
                                        SubRegion = dbContext.Vehicles.Where(x => x.VehicleNumber == crew.vehicle).FirstOrDefault().SubRegion,
                                        Station = dbContext.Vehicles.Where(x => x.VehicleNumber == crew.vehicle).FirstOrDefault().Station,

                                        Score = 100
                                    };
                                    await dbContext.Drivers.AddAsync(driver);

                                    VehicleSummary vehicleSummary = new VehicleSummary()
                                    {
                                        Id = Guid.NewGuid(),
                                        AssignmentDate = DateTime.Now,
                                        DriverCode = member.code,
                                        DriverName = member.name,
                                        VehicleNumber = crew.vehicle,
                                        LeavingDate = DateTime.MinValue
                                    };
                                    await dbContext.VehicleSummaries.AddAsync(vehicleSummary);
                                }
                                else
                                {
                                    if (driver.VehicleNumber == crew.vehicle)
                                    {
                                        VehicleSummary vehicleSummary = (from v in dbContext.VehicleSummaries
                                                                         where v.DriverCode == driver.Code && v.VehicleNumber == crew.vehicle
                                                                         select v).OrderByDescending(x => x.LastUpdate).FirstOrDefault();
                                        if (vehicleSummary == null)
                                        {
                                            VehicleSummary newVehicleSummary = new VehicleSummary()
                                            {
                                                Id = Guid.NewGuid(),
                                                AssignmentDate = DateTime.Now,
                                                DriverCode = member.code,
                                                DriverName = member.name,
                                                VehicleNumber = crew.vehicle,
                                                LeavingDate = DateTime.MinValue
                                            };
                                            await dbContext.VehicleSummaries.AddAsync(newVehicleSummary);
                                        }

                                    }
                                    else
                                    {
                                        VehicleSummary vehicleSummary = (from v in dbContext.VehicleSummaries
                                                                         where v.DriverCode == driver.Code
                                                                         select v).OrderByDescending(x => x.LastUpdate).FirstOrDefault();
                                        if (vehicleSummary != null)
                                        {
                                            vehicleSummary.LeavingDate = DateTime.Now;

                                            VehicleSummary newVehicleSummary = new VehicleSummary()
                                            {
                                                Id = Guid.NewGuid(),
                                                AssignmentDate = DateTime.Now,
                                                DriverCode = member.code,
                                                DriverName = member.name,
                                                VehicleNumber = crew.vehicle,
                                                LeavingDate = DateTime.MinValue
                                            };
                                            await dbContext.VehicleSummaries.AddAsync(newVehicleSummary);
                                        }
                                    }
                                    if(driver.Score==0)
                                    {
                                        driver.Score = 100;
                                    }
                                    driver.VehicleNumber = crew.vehicle;
                                    driver.Region = (from v in dbContext.GBMSVehicles
                                                     join s in dbContext.SubRegions on v.Location equals s.XDescription
                                                     where v.Description == crew.vehicle
                                                     select s.XRegionDescription).SingleOrDefault();
                                    driver.SubRegion = (from v in dbContext.GBMSVehicles
                                                        join s in dbContext.SubRegions on v.Location equals s.XDescription
                                                        where v.Description == crew.vehicle
                                                        select s.XDescription).SingleOrDefault();

                                    driver.Station = (from v in dbContext.GBMSVehicles
                                                        join s in dbContext.Stations on v.Station equals s.XDescription
                                                        where v.Description == crew.vehicle
                                                        select s.XDescription).SingleOrDefault();
                                }
                            }
                        }
                    }
                    await dbContext.SaveChangesAsync();
                }
                return Ok("Synchronized successfully!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPut("CrewDrivers/Update")]
        public async Task<IActionResult> UpdateCrewDriver(string Code, string VehicleNumber)
        {
            try
            {
                Driver driver = dbContext.Drivers.Where(x => x.Code.Equals(Code)).FirstOrDefault();
                driver.VehicleNumber = VehicleNumber;

                //Update Summary

                VehicleSummary vehicleSummary = (from v in dbContext.VehicleSummaries
                                                 where v.DriverCode == driver.Code
                                                 select v).OrderByDescending(x=>x.LastUpdate).FirstOrDefault();

                if (vehicleSummary.VehicleNumber == VehicleNumber)
                {
                }
                else
                {
                    vehicleSummary.LeavingDate = DateTime.Now;

                    VehicleSummary newVehicleSummary = new VehicleSummary()
                    {
                        Id = Guid.NewGuid(),
                        AssignmentDate = DateTime.Now,
                        DriverCode = driver.Code,
                        DriverName = driver.Name,
                        VehicleNumber = VehicleNumber,
                        LeavingDate = DateTime.MinValue
                    };
                    await dbContext.VehicleSummaries.AddAsync(newVehicleSummary);
                }

                await dbContext.SaveChangesAsync();
                return Ok("Driver updated!");
            }
            catch (Exception ex)
            {
                return BadRequest("Driver not updated!");
            }
        }
        //[HttpGet("Test")]
        //public async Task<IActionResult> Test()
        //{
        //    try
        //    {
        //        return Ok(dbContext.Testviews.ToList());
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest();
        //    }
        //}
    }
    public class Member
    {
        public string designation { get; set; }
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Crew
    {
        public string crew { get; set; }
        public string vehicle { get; set; }
        public List<Member> members { get; set; }
    }
}
