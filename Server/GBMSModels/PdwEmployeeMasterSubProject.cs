using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PdwEmployeeMasterSubProject
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XProjectCode { get; set; }
        public string XProjectCodeDescription { get; set; }
        public string XStatus { get; set; }
        public string XStartingDate { get; set; }
        public string XEndingDate { get; set; }
        public decimal XPercentage { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
