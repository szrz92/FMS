using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbGuardingContractGuardingInvoiceRate
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XServiceCode { get; set; }
        public string XServiceCodeDescription { get; set; }
        public decimal XQuantity { get; set; }
        public decimal XRate { get; set; }
        public decimal XAmount { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
