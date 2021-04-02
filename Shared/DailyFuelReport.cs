using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared
{
    public class DailyFuelReport
    {
        public Guid Id { get; set; }
        public string VehicleNumber { get; set; }
        public string Region { get; set; }
        public string VehicleEnrollmentIn { get; set; }
        public bool VehicleOffRoad { get; set;}



        public string Odometer { get; set; }
        public string PreviousOdometer { get; set; }
        public string Mileage { get; set; }
        public string CC { get; set; }
        public string ACC { get; set; }
        public string Driver { get; set; }
        public string Guard { get; set; }


        public string FuelType { get; set; }
        public string Litres { get; set; }
        public string Rate { get; set; }
        public string Amount { get; set; }
        public string PaymentType { get; set; }


        public DateTime Timestamp { get; set; }
        public string Purchaser { get; set; }
        public string InvoiceReference { get; set; }
        public string Vendor { get; set; }
        public string MTOfficer { get; set; }
        public string PetrolPumpNo { get; set; }
    }
}
