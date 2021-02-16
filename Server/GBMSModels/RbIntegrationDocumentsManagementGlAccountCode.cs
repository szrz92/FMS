using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbIntegrationDocumentsManagementGlAccountCode
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XNatureOfAmount { get; set; }
        public string XNatureOfAmountDescription { get; set; }
        public string XGeneralRemarks { get; set; }
        public string XCreditAccount { get; set; }
        public string XCreditAccountDescription { get; set; }
        public string XParticularsForDebitEntry { get; set; }
        public string XDebitAccount { get; set; }
        public string XDebitAccountDescription { get; set; }
        public string XParticularsForCreditEntry { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
