using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbServiceChargesBaseChargesRule
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public decimal XStartingAmount { get; set; }
        public decimal XEndingAmount { get; set; }
        public decimal XBaseCharges { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
