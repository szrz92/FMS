using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PblServicesReceivedNoteDetail
    {
        public int MasterId { get; set; }
        public int DetailId { get; set; }
        public string XServiceCode { get; set; }
        public string XServiceCodeDescription { get; set; }
        public string XProject { get; set; }
        public string XProjectDescription { get; set; }
        public decimal? XValue { get; set; }
        public decimal? XSalesTax { get; set; }
        public decimal? XFurtherTax { get; set; }
        public decimal? XOtherCosts { get; set; }
        public decimal XNetValue { get; set; }
        public string XServiceDetails { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
