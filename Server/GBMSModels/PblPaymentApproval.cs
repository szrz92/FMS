using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class PblPaymentApproval
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
        public string XProjectWorkOrder { get; set; }
        public string XProjectWorkOrderDescription { get; set; }
        public string XSupplier { get; set; }
        public string XName { get; set; }
        public string XPaymentType { get; set; }
        public string XPaymentTypeDescription { get; set; }
        public decimal XAmount { get; set; }
        public decimal? XWht { get; set; }
        public decimal? XStwh { get; set; }
        public decimal? XDbnDed { get; set; }
        public decimal XNetPayment { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
