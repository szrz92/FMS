using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class InvUnBilledGoodsReceivedNote
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
        public string XSupplier { get; set; }
        public string XName { get; set; }
        public string XPoNumber { get; set; }
        public string XPoDate { get; set; }
        public string XBillNumber { get; set; }
        public string XBillDate { get; set; }
        public string XDcNumber { get; set; }
        public string XDcDate { get; set; }
        public string XIgpNumber { get; set; }
        public string XIgpDate { get; set; }
        public decimal? XFreight { get; set; }
        public decimal? XUnloading { get; set; }
        public decimal? XOthers { get; set; }
        public decimal? XDiscount { get; set; }
        public string XTransporterName { get; set; }
        public string XDriverName { get; set; }
        public string XBiltyNumber { get; set; }
        public string XVehicleNumber { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
