using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSEmergencyCheck
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public MaintenanceStatus MaintenanceStatus { get; set; }
        public int CommentCount { get; set; }
        public int ImageCount { get; set; }
        public Guid FMSEmergencyId { get; set; }
        public Guid FMSVehicleId { get; set; }
        public string VehicleNumber { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
