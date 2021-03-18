﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class InvSiteDemand
    {
        public int MasterId { get; set; }
        public string DocumentStatus { get; set; }
        public string WorkflowStatus { get; set; }
        public string UserId { get; set; }
        public string YearCode { get; set; }
        public string YearName { get; set; }
        public string PeriodCode { get; set; }
        public string PeriodName { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public decimal XNumber { get; set; }
        public string XDate { get; set; }
        public string XDemandType { get; set; }
        public string XDemandTypeDescription { get; set; }
        public string XStation { get; set; }
        public string XStationDescription { get; set; }
        public string XComments { get; set; }
        public string XDocStatus { get; set; }
        public string XDocStatusDescription { get; set; }
        public string XDemandDescription { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
