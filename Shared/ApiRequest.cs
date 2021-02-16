using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared
{
    public class ApiRequest
    {
        public Guid VehicleId { get; set; }
        public Guid FMSAccidentalCheckId { get; set; }
        public Guid FMSAccidentId { get; set; }
        public Guid FMSEmergencyCheckId { get; set; }
        public Guid FMSEmergencyId { get; set; }
        public Guid FMSVehicleId { get; set; }
        public string VehicleNumber { get; set; }
        public string CheckListPointCode { get; set; }
        public string Remarks { get; set; }
        public string UserName { get; set; }
    }
}
