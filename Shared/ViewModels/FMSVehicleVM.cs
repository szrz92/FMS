using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class VehicleVM
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        [Required]
        public string VehicleNumber { get; set; }
        public Guid DriverId { get; set; }
        public string DriverName { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{15}(,[0-9]{15})*$", ErrorMessage = "Invalid IMEI Number.")]
        public long IMEI { get; set; }
        [Required]
        //[RegularExpression(@"03[0-9]{2}-(?!1234567)(?!1111111)(?!7654321)[0-9]{7}", ErrorMessage = "Invalid Sim Number.")]
        public long SIM { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string SubRegion { get; set; }
        [Required]
        public string GasolineType { get; set; }
        [Required]
        public string CardNumber { get; set; }
        public bool Active { get; set; }
        public int Breakdowns { get; set; } = 0;
        public double FuelAverage { get; set; } = 0;
        public double CostThisMonth { get; set; } = 0;
        public int Ranking { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Type { get; set; }
        public int Odometer { get; set; }
        public double Distance { get; set; }
        public double TotalDistance { get; set; }
        public int Hours { get; set; }
        public int NumberOfTripsToday { get; set; }
        public int Score { get; set; }
        public string PeriodicRemarks { get; set; }
    }
}
