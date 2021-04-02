using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class PeriodicVM
    {
        public Guid Id { get; set; }
        public Guid ConfigurationId { get; set; }
        public string Description { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverCode { get; set; }
        public int CurrentMonth { get; set; }
        public double CurrentDistance { get; set; }
        public DateTime LastCheckTime { get; set; }
        public double LastCheckDistance { get; set; }
        public int MonthLimit { get; set; }
        public double DistanceLimit { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public string Station { get; set; }

        public string Status { get; set; }
    }
}
