using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PblCreditNote
    {
        public int MasterId { get; set; }
        public string DocumentStatus { get; set; }
        public string WorkflowStatus { get; set; }
        public string UserId { get; set; }
        public string YearCode { get; set; }
        public string YearName { get; set; }
        public string PeriodCode { get; set; }
        public string PeriodName { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public decimal XNumber { get; set; }
        public string XDate { get; set; }
        public string XSupplier { get; set; }
        public string XName { get; set; }
        public string XRefNo { get; set; }
        public string XRefDate { get; set; }
        public string XAccount { get; set; }
        public string XSupplierControlAccount { get; set; }
        public decimal? XSTaxPercent { get; set; }
        public decimal? XSedPercent { get; set; }
        public decimal? XFTaxPercent { get; set; }
        public decimal? XExtraTaxPercent { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
