using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class InvDemandDecisionDocumentDetail
    {
        public int MasterId { get; set; }
        public int DetailId { get; set; }
        public decimal? XDemand { get; set; }
        public string XDate { get; set; }
        public string XItemCode { get; set; }
        public string XDescription { get; set; }
        public string XUom { get; set; }
        public decimal XQtyDemanded { get; set; }
        public decimal? XRejected { get; set; }
        public decimal? XToBeIssued { get; set; }
        public decimal? XToBeTransferred { get; set; }
        public decimal? XToBePurchased { get; set; }
        public string XDecisionStatus { get; set; }
        public string XTransferLocationsSelection { get; set; }
        public string XProject { get; set; }
        public string XProjectDescription { get; set; }
        public string XSpecifications { get; set; }
        public string XInstructions { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
