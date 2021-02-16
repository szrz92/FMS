using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class RbCitShipment
    {
        public int MasterId { get; set; }
        public string DocumentStatus { get; set; }
        public string WorkflowStatus { get; set; }
        public string YearCode { get; set; }
        public string YearName { get; set; }
        public string PeriodCode { get; set; }
        public string PeriodName { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public decimal XNumber { get; set; }
        public string XDate { get; set; }
        public DateTime DDate { get; set; }
        public string XShipmentNo { get; set; }
        public string XShipmentType { get; set; }
        public string XShipmentTypeDescription { get; set; }
        public string XMainCustomer { get; set; }
        public string XMainCustomerDescription { get; set; }
        public string XCollection { get; set; }
        public string XCollectionDescription { get; set; }
        public string XDelivery { get; set; }
        public string XDeliveryDescription { get; set; }
        public string XBillBranch { get; set; }
        public string XBillBranchDescription { get; set; }
        public string XCustomer { get; set; }
        public string XBillingCustomerName { get; set; }
        public string XRevenueRegion { get; set; }
        public string XRevenueRegionDescription { get; set; }
        public string XVehicle { get; set; }
        public string XVehicleDescription { get; set; }
        public string XPickDate { get; set; }
        public DateTime? DPickDate { get; set; }
        public string XPickTime { get; set; }
        public DateTime? DPickTime { get; set; }
        public string XDeliveryDate { get; set; }
        public DateTime? DDeliveryDate { get; set; }
        public string XDeliveryTime { get; set; }
        public DateTime? DDeliveryTime { get; set; }
        public decimal XNoOfBags { get; set; }
        public decimal XNoOfSeals { get; set; }
        public decimal XAmountCarried { get; set; }
        public decimal XDistanceKms { get; set; }
        public decimal? XTollTax { get; set; }
        public decimal? XWaitingMins { get; set; }
        public decimal? XAdditional { get; set; }
        public decimal? XVaultNights { get; set; }
        public string XAutoBilling { get; set; }
        public string XRateId { get; set; }
        public string XRateIdDescription { get; set; }
        public decimal? XFixedAmount { get; set; }
        public string XFcValue { get; set; }
        public decimal XBaseCharges { get; set; }
        public decimal XSurCharge { get; set; }
        public decimal XSealCharges { get; set; }
        public decimal XVaultCharges { get; set; }
        public decimal? XDistance { get; set; }
        public decimal? XWaiting { get; set; }
        public decimal? XAmount { get; set; }
        public decimal? XDebits { get; set; }
        public decimal? XCredits { get; set; }
        public decimal XNetAmount { get; set; }
        public string XPortalReference { get; set; }
        public string XBillDate { get; set; }
        public DateTime? DBillDate { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
