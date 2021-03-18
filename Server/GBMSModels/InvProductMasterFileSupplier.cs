using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class InvProductMasterFileSupplier
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XSupplier { get; set; }
        public string XSupplierDescription { get; set; }
        public string XSupplierItemCode { get; set; }
        public decimal? XPackingSize { get; set; }
        public decimal? XPackingSize2 { get; set; }
        public decimal? XPackingSize3 { get; set; }
        public decimal? XSupplierRate { get; set; }
        public string XCountryOfOrigin { get; set; }
        public string XCountryOfOriginDescription { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
