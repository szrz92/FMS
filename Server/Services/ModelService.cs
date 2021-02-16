using Microsoft.AspNetCore.Mvc.Rendering;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public static class ModelService
    {
        #region Vehicle
        public static VehicleVM VehicleViewModel(Vehicle v)
        {
            return new VehicleVM()
            {
                Id = v.Id,
                AddDate = v.AddDate,
                AddId = v.AddId,
                IpAdd = v.IpAdd,
                Capacity = v.XCapacity,
                ChasisNo = v.XChasisNo,
                Code = v.XCode,
                Description = v.XDescription,
                EngineNo = v.XEngineNo,
                GasolineType = v.XGasolineType,
                GasolineTypeDescription = v.XGasolineTypeDescription,
                IpMod = v.IpMod,
                LeasingCompany = v.XLeasingCompany,
                Location = v.XLocation,
                LocationDescription = v.XLocationDescription,
                Make = v.XMake,
                ModDate = v.ModDate,
                Model = v.XModel,
                ModId = v.ModId,
                Origin = v.XOrigin,
                OtherCosts = v.XOtherCosts,
                PurchaseDate = v.XPurchaseDate,
                PurchasePrice = v.XPurchasePrice,
                Registration = v.XRegistration,
                RegistrationCost = v.XRegistrationCost,
                Remarks = v.XRemarks,
                rowId = v.XrowId,
                Station = v.XStation,
                StationDescription = v.XStationDescription,
                TagNumber = v.XTagNumber,
                TotalCost = v.XTotalCost,
                VehicleType = v.XVehicleType,
                VehicleTypeDescription = v.XVehicleTypeDescription
            };
        }
        public static SelectListItem SelectList(Vehicle v)
        {
            return new SelectListItem()
            {
                Value = v.XCode,
                Text = v.XDescription
            };
        }
        public static FMSVehicleVM FMSVehicleViewModel(FMSVehicle v, Vehicle fv, Region r, SubRegion sr)
        {
            return new FMSVehicleVM()
            {
                VehicleId = v.VehicleId,
                Active = v.Active,
                IMEI = v.IMEI,
                Region = r.XDescription,
                SIM = v.SIM,
                SubRegion = sr.XDescription,
                VehicleNumber = fv.XDescription
            };
        }
        public static SelectListItem FMSVehicleSelectList(Vehicle fv)
        {
            return new SelectListItem()
            {
                Value = fv.XCode,
                Text = fv.XDescription
            };
        }
        public static FMSVehicleScoreCardVM FMSVehicleScoreCardViewModel(FMSVehicleScoreCard s, Vehicle v)
        {
            return new FMSVehicleScoreCardVM()
            {
                VehicleId = s.VehicleId,
                VehicleNumber = v.XDescription,
                FuelAverage = s.FuelAverage,
                Breakdowns = s.Breakdowns,
                CostThisMonth = s.CostThisMonth,
                Ranking = s.Ranking
            };
        }
        #endregion
        #region Driver
        public static FMSDriverVM FMSDriverViewModel(FMSDriver fd)
        {
            return new FMSDriverVM()
            {
                DriverId = fd.DriverId,
                DriverName = fd.DriverName,
                JoiningDate = fd.JoiningDate,
                Location = fd.Location,
                Station = fd.Station,
                Status = fd.Status,
                TotalTrips = fd.TotalTrips,
                Inicidents = fd.Inicidents,
                Ranking = fd.Ranking,
                Score = fd.Score,
                Violations = fd.Violations
            };
        }
        #endregion
    }
}
