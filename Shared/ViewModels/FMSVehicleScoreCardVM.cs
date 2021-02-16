using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSVehicleScoreCardVM
    {
        public Guid VehicleId { get; set; }
        public string VehicleNumber { get; set; }
        public int Breakdowns { get; set; } = 0;
        public double FuelAverage { get; set; } = 0;
        public double CostThisMonth { get; set; } = 0;
        public int Ranking { get; set; }
    }
}
