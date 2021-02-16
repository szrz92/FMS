using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSDailyMorning
    {
        public Guid Id { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public bool M1 { get; set; }
        public bool M2 { get; set; }
        public bool M3 { get; set; }
        public bool M4 { get; set; }
        public bool M5 { get; set; }
        public bool M6 { get; set; }
        public bool M7 { get; set; }
        public bool M8 { get; set; }
        public bool M9 { get; set; }
        public bool M10 { get; set; }
        public bool M11 { get; set; }
        public bool M12 { get; set; }
        public bool M13 { get; set; }
        public bool M14 { get; set; }
        public bool M15 { get; set; }
        public bool M16 { get; set; }
        public bool M17 { get; set; }
        public bool M18 { get; set; }
        public bool M19 { get; set; }
        public bool M20 { get; set; }
        public bool M21 { get; set; }
        public bool M22 { get; set; }
        public bool M23 { get; set; }
        public bool M24 { get; set; }
        public bool M25 { get; set; }
        public string Remarks { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
