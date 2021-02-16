using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbMainCustomerManagementContactPerson
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XName { get; set; }
        public string XDesignation { get; set; }
        public string XCnic { get; set; }
        public string XCellNo { get; set; }
        public string XLandline { get; set; }
        public string XAddress { get; set; }
        public string XEmailId { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
