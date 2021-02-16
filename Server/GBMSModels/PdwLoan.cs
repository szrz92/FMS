using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PdwLoan
    {
        public string XCode { get; set; }
        public long? XrowId { get; set; }
        public string XDescription { get; set; }
        public string XAbbreviation { get; set; }
        public string XLoanType { get; set; }
        public string XRemarks { get; set; }
        public string XDebitCode { get; set; }
        public string XDebitCodeDescription { get; set; }
        public string XCreditCode { get; set; }
        public string XCreditCodeDescription { get; set; }
        public string XGlVoucherParticulars { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
