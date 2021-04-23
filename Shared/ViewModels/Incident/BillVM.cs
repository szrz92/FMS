using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels.Incident
{
    public class BillVM
    {
        public string TotalAmount { get; set; }
        public string Remarks { get; set; }
    }
    public class BillDetailVM
    {
        public Guid CheckPointId { get; set; }
        public string ServiceType { get; set; }
        public string SubServiceType { get; set; }
        public int Amount { get; set; }
        public string Odometer { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Station { get; set; }
        public string Remarks { get; set; }
        public string Ref { get; set; }
        public DateTime Timestamp { get; set; }
    }
    public class ServicesList
    {
        public string ServiceType { get; set; }
        public string SubServiceType { get; set; }
    }
}
