using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbWarehouse
    {
        public string XCode { get; set; }
        public long? XrowId { get; set; }
        public string XWhCode { get; set; }
        public string XMasterLocation { get; set; }
        public string XMasterLocationDescription { get; set; }
        public string XDescription { get; set; }
        public string XAbbrevation { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
