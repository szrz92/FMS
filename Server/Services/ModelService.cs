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
        #region Driver
        public static DriverVM FMSDriverViewModel(Driver d)
        {
            return new DriverVM()
            {
                Id = d.Id,
                Name = d.Name,
                Code = d.Code,
                Absents = d.Absents,
                Accidents = d.Accidents,
                Emergencies = d.Emergencies,
                Points = d.Points,
                Region = d.Region,
                SubRegion = d.SubRegion,
                Station=d.Station,
                Trips = d.Trips,
                VehicleNumber = d.VehicleNumber,
                Score = d.Score
            };
        }
        #endregion
    }
}
