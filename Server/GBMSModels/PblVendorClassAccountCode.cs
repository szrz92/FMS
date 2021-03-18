using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PblVendorClassAccountCode
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XNatureOfAccount { get; set; }
        public string XNatureOfAccountDescription { get; set; }
        public string XAccountCode { get; set; }
        public string XAccountCodeDescription { get; set; }
        public string XParticularsForGlEntry { get; set; }
        public string XRemrks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
