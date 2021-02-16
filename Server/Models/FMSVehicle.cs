﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSVehicle
    {
        [Key]
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public Guid DriverId { get; set; }
        public int IMEI { get; set; }
        public int SIM { get; set; }
        public Guid Region { get; set; }
        public Guid SubRegion { get; set; }
        public bool Active { get; set; }
        public int Breakdowns { get; set; } = 0;
        public double FuelAverage { get; set; } = 0;
        public double CostThisMonth { get; set; } = 0;
        public int Ranking { get; set; }
    }
}
