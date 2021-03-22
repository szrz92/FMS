using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }
        public string VehicleNumber { get; set; }
        public long IMEI { get; set; }
        public long SIM { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public bool Active { get; set; }
        public int Breakdowns { get; set; } = 0;
        public double FuelAverage { get; set; } = 0;
        public double CostThisMonth { get; set; } = 0;
        public int Ranking { get; set; }
        public int Score { get; set; } = 135;
        public string Status { get; set; }
        public string CardNumber { get; set; }
        public string GasolineType { get; set; }
        public PeriodicMaintenanceStatus PeriodicStatus { get; set; }
        public AccidentalMaintenanceStatus AccidentalStatus { get; set; }
        public EmergencyMaintenanceStatus EmergencyStatus { get; set; }
        public double Distance { get; set; }
    }
}
