using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSAccidentalCheckImage
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public Guid FMSAccidentalCheckId { get; set; }
        public Guid FMSAccidentId { get; set; }
        public Guid FMSVehicleId { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
