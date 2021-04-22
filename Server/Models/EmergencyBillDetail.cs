﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class EmergencyBillDetail
    {
        public Guid Id { get; set; }
        public Guid CheckPointId { get; set; }
        public string ServiceType { get; set; }
        public string SubServiceType { get; set; }
        public string Amount { get; set; }
        public string Odometer { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Station { get; set; }
        public string Ref { get; set; }
    }
}
