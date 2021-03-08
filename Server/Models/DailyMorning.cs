using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class DailyMorning
    {
        public Guid Id { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public DailyCheckStatus M1 { get; set; }
        public DailyCheckStatus M2 { get; set; }
        public DailyCheckStatus M3 { get; set; }
        public DailyCheckStatus M4 { get; set; }
        public DailyCheckStatus M5 { get; set; }
        public DailyCheckStatus M6 { get; set; }
        public DailyCheckStatus M7 { get; set; }
        public DailyCheckStatus M8 { get; set; }
        public DailyCheckStatus M9 { get; set; }
        public DailyCheckStatus M10 { get; set; }
        public DailyCheckStatus M11 { get; set; }
        public DailyCheckStatus M12 { get; set; }
        public DailyCheckStatus M13 { get; set; }
        public DailyCheckStatus M14 { get; set; }
        public DailyCheckStatus M15 { get; set; }
        public DailyCheckStatus M16 { get; set; }
        public DailyCheckStatus M17 { get; set; }
        public DailyCheckStatus M18 { get; set; }
        public DailyCheckStatus M19 { get; set; }
        public DailyCheckStatus M20 { get; set; }
        public DailyCheckStatus M21 { get; set; }
        public DailyCheckStatus M22 { get; set; }
        public DailyCheckStatus M23 { get; set; }
        public DailyCheckStatus M24 { get; set; }
        public DailyCheckStatus M25 { get; set; }
        public string Remarks { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
