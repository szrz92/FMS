using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PdwEmployeeMasterAllowance
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XAllowanceSelection { get; set; }
        public string XAllowanceSelectionDescription { get; set; }
        public string XApplyToggle { get; set; }
        public string XToggleSelection { get; set; }
        public string XToggleSelectionDescription { get; set; }
        public decimal? XAmount { get; set; }
        public string XAttfactor { get; set; }
        public string XApplyDates { get; set; }
        public string XStartingDate { get; set; }
        public string XEndingDate { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
