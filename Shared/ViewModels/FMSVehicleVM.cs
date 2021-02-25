using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class VehicleVM
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public string VehicleNumber { get; set; }
        public Guid DriverId { get; set; }
        public string DriverName { get; set; }
        public long IMEI { get; set; }
        public long SIM { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public bool Active { get; set; }
        public int Breakdowns { get; set; } = 0;
        public double FuelAverage { get; set; } = 0;
        public double CostThisMonth { get; set; } = 0;
        public int Ranking { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Type { get; set; }
    }
}
