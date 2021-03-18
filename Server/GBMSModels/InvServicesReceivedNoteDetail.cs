﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class InvServicesReceivedNoteDetail
    {
        public int MasterId { get; set; }
        public int DetailId { get; set; }
        public string XServiceCode { get; set; }
        public string XDescription { get; set; }
        public string XUom { get; set; }
        public string XProject { get; set; }
        public string XProjectDescription { get; set; }
        public decimal XReceived { get; set; }
        public decimal XAccepted { get; set; }
        public decimal? XRejected { get; set; }
        public string XRejectionReason { get; set; }
        public string XRejectionReasonDescription { get; set; }
        public decimal XRate { get; set; }
        public decimal XValue { get; set; }
        public decimal? XSalesTax { get; set; }
        public decimal? XFurtherTax { get; set; }
        public decimal? XFreight { get; set; }
        public decimal? XUnloading { get; set; }
        public decimal? XOtherCosts { get; set; }
        public decimal XNetValue { get; set; }
        public string XDepartment { get; set; }
        public string XDepartmentDescription { get; set; }
        public string XEmployee { get; set; }
        public string XEmployeeDescription { get; set; }
        public string XAsset { get; set; }
        public string XAssetDescription { get; set; }
        public string XInspectionDetails { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
