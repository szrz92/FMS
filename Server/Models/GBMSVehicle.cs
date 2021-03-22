using System;
using System.ComponentModel.DataAnnotations;

namespace SOS.FMS.Server.Models
{
    public class GBMSVehicle
    {
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string VehicleType { get; set; }
        public string GasolineType { get; set; }
        public string Location { get; set; }
        public string Station { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ChasisNo { get; set; }
        public string EngineNo { get; set; }
        public string PurchaseDate { get; set; }
        public DateTime LastSync { get; set; }
    }
}
