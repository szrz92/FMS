﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class InvProductMasterFileInventoryLevel
    {
        public string XCode { get; set; }
        public int DetailId { get; set; }
        public string XWarehouseCode { get; set; }
        public string XWarehouseCodeDescription { get; set; }
        public decimal? XMaximumBalance { get; set; }
        public decimal? XMinimumBalance { get; set; }
        public decimal? XReOrderQty { get; set; }
        public decimal? XLeadTime { get; set; }
        public decimal? XMaxOrderQty { get; set; }
        public decimal? XMinOrderQty { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
