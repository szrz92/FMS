using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FuelingInfoVM
    {
        public Guid Id { get; set; }
        public string VehicleNumber { get; set; }
        public string Region { get; set; }
        public string DriverName { get; set; }
        public string Litres { get; set; }
        public string FillingStation { get; set; }
        public string FillingCity { get; set; }
        public string Rate { get; set; }
        public string Amount { get { return Convert.ToString(Convert.ToDouble(Rate) * Convert.ToDouble(Litres)); } }
        public string Odometer { get; set; }
        public string Milage { get; set; }
        public string PaymentType { get; set; }
        public string Remarks { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
