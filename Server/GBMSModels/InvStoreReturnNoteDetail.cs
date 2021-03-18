using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class InvStoreReturnNoteDetail
    {
        public int MasterId { get; set; }
        public int DetailId { get; set; }
        public string XItemCode { get; set; }
        public string XDescription { get; set; }
        public string XUom { get; set; }
        public decimal XQuantityReturned { get; set; }
        public string XRateType { get; set; }
        public decimal? XRate { get; set; }
        public decimal? XValue { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
