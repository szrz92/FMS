using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class PeriodicHistory
    {
        public Guid Id { get; set; }
        public Guid ConfigurationId { get; set; }
        public string Description { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string DriverCode { get; set; }
        public int LastCheckMonth { get; set; }
        public double LastCheckDistance { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
