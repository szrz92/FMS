using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbMainCustomerManagementCitRatesMapping
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XServiceId { get; set; }
        public string XServiceIdDescription { get; set; }
        public string XRegionalOffice { get; set; }
        public string XRegionalOfficeDescription { get; set; }
        public string XStation { get; set; }
        public string XStationDescription { get; set; }
        public string XBranch { get; set; }
        public string XBranchDescription { get; set; }
        public string XValidFrom { get; set; }
        public string XValidTo { get; set; }
        public string XStatus { get; set; }
        public string XStatusDescription { get; set; }
        public string XDoubleRate { get; set; }
        public string XDoubleRateDescription { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
