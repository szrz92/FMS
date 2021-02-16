using System;

namespace SOS.FMS.Shared.ViewModels
{
    public class VehicleVM
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public long? rowId { get; set; }
        public string Description { get; set; }
        public string VehicleType { get; set; }
        public string VehicleTypeDescription { get; set; }
        public string GasolineType { get; set; }
        public string GasolineTypeDescription { get; set; }
        public string Location { get; set; }
        public string LocationDescription { get; set; }
        public string Station { get; set; }
        public string StationDescription { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Capacity { get; set; }
        public string Origin { get; set; }
        public string ChasisNo { get; set; }
        public string EngineNo { get; set; }
        public string Registration { get; set; }
        public string LeasingCompany { get; set; }
        public string TagNumber { get; set; }
        public string PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? RegistrationCost { get; set; }
        public decimal? OtherCosts { get; set; }
        public decimal? TotalCost { get; set; }
        public string Remarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
