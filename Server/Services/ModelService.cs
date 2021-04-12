using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SOS.FMS.Server.Controllers;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public static class ModelService
    {
        #region Driver
        public static DriverVM FMSDriverViewModel(Driver d)
        {
            return new DriverVM()
            {
                Id = d.Id,
                Name = d.Name,
                Code = d.Code,
                Absents = d.Absents,
                Accidents = d.Accidents,
                Emergencies = d.Emergencies,
                Points = d.Points,
                Region = d.Region,
                SubRegion = d.SubRegion,
                Station=d.Station,
                Trips = d.Trips,
                VehicleNumber = d.VehicleNumber,
                Score = d.Score
            };
        }
        #endregion

        public static async Task<Crew> getCrewByVehicleNo(AppDbContext dbContext, string vehicleNo)
        {
            try
            {
                Crew crew = new Crew();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://dev-sos-apis.azurewebsites.net/api/Fms/");
                    var response = await client.GetAsync("GetActiveCrews");
                    var responseString = await response.Content.ReadAsStringAsync();
                    List<Crew> CrewData = JsonConvert.DeserializeObject<List<Crew>>(responseString);
                    crew = (from c in CrewData
                            where c.vehicle == vehicleNo
                            select c).SingleOrDefault();
                    foreach(var item in CrewData)
                    {

                    }
                }
                return crew;
            }
            catch (Exception ex)
            {
                return new Crew();
            }
        }
        public static async Task<string> GetUserRole(AppDbContext dbContext, string UserId)
        {
            try
            {
                string role = await (from r in dbContext.UserRoles
                                     where r.UserId.Equals(UserId)
                                     select r.RoleId).SingleOrDefaultAsync();
                return role;
            }
            catch (Exception)
            {
                return "Error";
            }
        }

    }
}
