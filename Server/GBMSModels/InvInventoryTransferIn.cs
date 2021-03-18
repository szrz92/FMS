using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class InvInventoryTransferIn
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
        public string XFromLocation { get; set; }
        public string XFromLocationDescription { get; set; }
        public string XSecurityRegisterNo { get; set; }
        public string XVehicleType { get; set; }
        public string XRentedVehicleNumber { get; set; }
        public string XVehicle { get; set; }
        public string XVehicleDescription { get; set; }
        public string XDriverName { get; set; }
        public decimal? XFreightOwned { get; set; }
        public decimal? XFreightRented { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
