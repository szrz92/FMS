using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PdwAllowancesToggle
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XToggleCode { get; set; }
        public string XDescription { get; set; }
        public string XShortHeading { get; set; }
        public string XType { get; set; }
        public decimal? XAmount { get; set; }
        public decimal? XFormula { get; set; }
        public string XTaxable { get; set; }
        public string XAttendanceFactor { get; set; }
        public string XExpiryDate { get; set; }
        public decimal? XMinimum { get; set; }
        public decimal? XMaximum { get; set; }
        public decimal? XPercent { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
