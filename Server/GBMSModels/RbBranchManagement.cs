using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbBranchManagement
    {
        public string BrCode { get; set; }
        public string BrName { get; set; }
        public string SregCode { get; set; }
        public string SregDesc { get; set; }
        public string StatCode { get; set; }
        public string StatDesc { get; set; }
        public string CpcCode { get; set; }
        public string CpcDesc { get; set; }
        public string CpcYn { get; set; }
        public string McmCode { get; set; }
        public string McmName { get; set; }
        public string BrType { get; set; }
        public string BrTypeName { get; set; }
    }
}
