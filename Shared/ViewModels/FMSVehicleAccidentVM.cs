using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSVehicleAccidentVM
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public string VehicleNumber { get; set; }
        public Guid DriverId { get; set; }
        public string DriverName { get; set; }
        public string Description { get; set; }
        public Guid Region { get; set; }
        public string RegionName { get; set; }
        public Guid SubRegion { get; set; }
        public string SubRegionName { get; set; }
        public bool Status { get; set; }
        public Guid ReportedBy { get; set; }
        public string ReportedByName { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
