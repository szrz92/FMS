﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbDoubleRateTimingsTimingException
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XNature { get; set; }
        public string XNatureDescription { get; set; }
        public string XMonday { get; set; }
        public string XTuesday { get; set; }
        public string XWednesday { get; set; }
        public string XThursday { get; set; }
        public string XFriday { get; set; }
        public string XSaturday { get; set; }
        public string XSunday { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
