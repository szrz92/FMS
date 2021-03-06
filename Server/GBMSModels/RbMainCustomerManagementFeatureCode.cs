using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbMainCustomerManagementFeatureCode
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XFeatureName { get; set; }
        public string XFeatureNameDescription { get; set; }
        public string XFeatureDetailCodes { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
