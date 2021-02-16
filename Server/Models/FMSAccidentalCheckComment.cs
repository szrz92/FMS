using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSAccidentalCheckComment
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public Guid FMSAccidentalCheckId { get; set; }
        public Guid FMSAccidentId { get; set; }
        public Guid FMSVehicleId { get; set; }
        public string VehicleNumber { get; set; }
        public string Mentions { get; set; }
        public Guid FMSUserId { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
