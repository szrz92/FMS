using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbCustomerType
    {
        public string XCode { get; set; }
        public long? XrowId { get; set; }
        public string XDescription { get; set; }
        public string XAbbreviation { get; set; }
        public string XAccountCode { get; set; }
        public string XAccountCodeDescription { get; set; }
        public string XSalesCode { get; set; }
        public string XSalesCodeDescription { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
