using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class Accident
    {
        public Guid Id { get; set; }
        public Guid FMSVehicleId { get; set; }
        public Guid DriverId { get; set; }
        public Guid RegionId { get; set; }
        public Guid SubRegionId { get; set; }
        public Guid StationId { get; set; }

        public string Description { get; set; }
        public string VehicleNumber { get; set; }
        public MaintenanceStatus MaintenanceStatus { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime JobClosingTime { get; set; }
        public DateTime CarOperationalTime { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
