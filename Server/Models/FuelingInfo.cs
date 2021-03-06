using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FuelingInfo
    {
        public Guid Id { get; set; }
        public string VehicleNumber { get; set; }
        public string Region { get; set; }
        public string DriverName { get; set; }
        public string Litres { get; set; }
        public string FillingStation { get; set; }
        public string FillingCity { get; set; }
        public string Rate { get; set; }
        public string Amount { get; set; }
        public string Odometer { get; set; }
        public string PreviousOdometer { get; set; }
        public string Milage { get; set; }
        public string PaymentType { get; set; }
        public string Remarks { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
