using System;

namespace SOS.FMS.Shared.ViewModels
{
    public class GBMSVehicleVM
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string VehicleType { get; set; }
        public string GasolineType { get; set; }
        public string Station { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ChasisNo { get; set; }
        public string EngineNo { get; set; }
        public string PurchaseDate { get; set; }
        public DateTime LastSync { get; set; }
    }
}
