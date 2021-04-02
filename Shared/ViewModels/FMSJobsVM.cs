using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSJobsVM
    {
        public string VehicleNumber { get; set; }
        public string Driver { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public string Station{ get; set; }

        public string Description { get; set; }
        public string MaintenanceStatus { get; set; }
        public string JobType { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
