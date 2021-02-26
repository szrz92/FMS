using Newtonsoft.Json;
using SOS.FMS.Shared.Traccar;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public static class TraccarService
    {
        public static async Task<bool> AddDevice(VehicleVM vehicle)
        {
            try
            {
                using var client = new HttpClient();
                var authToken = Encoding.ASCII.GetBytes($"admin:admin");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
                client.BaseAddress = new Uri("http://18.214.221.25:8082/api/");
                var response = await client.PostAsJsonAsync("devices", new Device()
                {
                    id = 0,
                    name = vehicle.VehicleNumber,
                    uniqueId = Convert.ToString(vehicle.IMEI),
                    contact = Convert.ToString(vehicle.SIM),
                    phone = Convert.ToString(vehicle.SIM),
                    attributes = new Attributes(),
                    category = "",
                    disabled = false,
                    geofenceIds = new List<int>(),
                    groupId = 0,
                    lastUpdate = DateTime.Now,
                    model = "",
                    positionId = 0,
                    status = ""
                });
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public static async Task<List<Device>> GetDevices()
        {
            try
            {
                using var client = new HttpClient();
                var authToken = Encoding.ASCII.GetBytes($"admin:admin");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
                client.BaseAddress = new Uri("http://18.214.221.25:8082/api/");
                var response = await client.GetAsync("devices");
                var responseString = await response.Content.ReadAsStringAsync();
                List<Device> devices = JsonConvert.DeserializeObject<List<Device>>(responseString);
                return devices;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static async Task<List<Position>> GetPositions()
        {
            try
            {
                using var client = new HttpClient();
                var authToken = Encoding.ASCII.GetBytes($"admin:admin");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
                client.BaseAddress = new Uri("http://18.214.221.25:8082/api/");
                var response = await client.GetAsync("positions");
                var responseString = await response.Content.ReadAsStringAsync();
                List<Position> positions = JsonConvert.DeserializeObject<List<Position>>(responseString);
                return positions;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
