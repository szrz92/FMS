using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSVehicleAccident
    {
        [Key]
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public Guid DriverId { get; set; }
        public string Description { get; set; }
        public Guid Region { get; set; }
        public Guid SubRegion { get; set; }
        public bool Status { get; set; }
        public Guid ReportedBy { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
