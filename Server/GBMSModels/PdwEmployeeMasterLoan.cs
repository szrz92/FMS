using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PdwEmployeeMasterLoan
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XLoanSelection { get; set; }
        public string XLoanSelectionDescription { get; set; }
        public string XDescription { get; set; }
        public string XStatus { get; set; }
        public string XDate { get; set; }
        public string XEffectiveDate { get; set; }
        public decimal XPrincipal { get; set; }
        public decimal XInstallment { get; set; }
        public decimal? XInterest { get; set; }
        public decimal? XPaidBack { get; set; }
        public decimal? XLumpSum { get; set; }
        public decimal? XBalance { get; set; }
        public string XApprovalNumber { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
