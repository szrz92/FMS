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
                                        VehicleNumber = crew.vehicle
                                    };
                                    await dbContext.Drivers.AddAsync(driver);
                                }
                                else
                                {
                                    driver.VehicleNumber = crew.vehicle;
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
                await dbContext.SaveChangesAsync();
                return Ok("Driver updated!");
            }
            catch (Exception ex)
            {
                return BadRequest("Driver not updated!");
            }
        }
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
