using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbAtmServiceCharge
    {
        public string XCode { get; set; }
        public long? XrowId { get; set; }
        public string XSubCode { get; set; }
        public string XName { get; set; }
        public string XTripType { get; set; }
        public string XTripTypeDescription { get; set; }
        public string XStartDate { get; set; }
        public string XMeasureDistance { get; set; }
        public string XMeasureDistanceDescription { get; set; }
        public decimal XTripCharges { get; set; }
        public decimal XFromKms { get; set; }
        public decimal XToKms { get; set; }
        public decimal XRatePerKm { get; set; }
        public decimal XBaseDistance { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
