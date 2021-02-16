using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSEmergencyCheckImageVM
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public Guid FMSEmergencyCheckId { get; set; }
        public Guid FMSEmergencyId { get; set; }
        public Guid FMSVehicleId { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
