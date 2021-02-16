using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbGuardingContract
    {
        public string XCode { get; set; }
        public long? XrowId { get; set; }
        public string XSubCode { get; set; }
        public string XName { get; set; }
        public string XStartDate { get; set; }
        public string XCustomer { get; set; }
        public string XCustomerDescription { get; set; }
        public string XBranchCode { get; set; }
        public string XBranchCodeDescription { get; set; }
        public decimal XTotalGuards { get; set; }
        public decimal? XMorningShift { get; set; }
        public decimal? XEveningShift { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
