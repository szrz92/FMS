using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbGuardingContractGuardCostRate
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XServiceType { get; set; }
        public string XServiceTypeDescription { get; set; }
        public decimal XMonthlyRate { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
