using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PdwDeduction
    {
        public string XCode { get; set; }
        public long? XrowId { get; set; }
        public string XDescription { get; set; }
        public string XType { get; set; }
        public string XTypeDescription { get; set; }
        public string XAbbreviation { get; set; }
        public string XTaxable { get; set; }
        public string XTaxableDescription { get; set; }
        public string XHeading1 { get; set; }
        public string XHeading2 { get; set; }
        public string XHeading3 { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
