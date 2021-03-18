using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PblOtherGrnSupplierPaymentVoucher
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
        public string XProject { get; set; }
        public string XProjectDescription { get; set; }
        public string XSupplier { get; set; }
        public string XName { get; set; }
        public string XPaymentType { get; set; }
        public string XPaymentTypeDescription { get; set; }
        public decimal XAmount { get; set; }
        public decimal? XAdvITax { get; set; }
        public decimal? XAdvSTax { get; set; }
        public decimal? XAnyDeductions { get; set; }
        public decimal XNetPayment { get; set; }
        public string XPayAllDocuments { get; set; }
        public string XManualRefNo { get; set; }
        public string XAccount { get; set; }
        public string XBankOrCashDescription { get; set; }
        public string XInstrumentType { get; set; }
        public string XInstrumentTypeDescription { get; set; }
        public string XInstrumentNo { get; set; }
        public string XInstDate { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
