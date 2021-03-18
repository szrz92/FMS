using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class AccidentalBillDetail
    {
        public Guid Id { get; set; }
        public Guid CheckPointId { get; set; }
        public string ServiceType { get; set; }
        public string SubServiceType { get; set; }
        public string Amount { get; set; }
    }
}
