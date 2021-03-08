using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class DailyEvening
    {
        public Guid Id { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public DailyCheckStatus EE1 { get; set; }
        public DailyCheckStatus EE2 { get; set; }
        public DailyCheckStatus EE3 { get; set; }
        public DailyCheckStatus EE4 { get; set; }
        public DailyCheckStatus EE5 { get; set; }
        public DailyCheckStatus EE6 { get; set; }
        public DailyCheckStatus EE7 { get; set; }
        public DailyCheckStatus EE8 { get; set; }
        public DailyCheckStatus EE9 { get; set; }
        public DailyCheckStatus EE10 { get; set; }
        public DailyCheckStatus EE11 { get; set; }
        public DailyCheckStatus EB1 { get; set; }
        public DailyCheckStatus EB2 { get; set; }
        public DailyCheckStatus EB3 { get; set; }
        public DailyCheckStatus EB4 { get; set; }
        public DailyCheckStatus EB5 { get; set; }
        public DailyCheckStatus EB6 { get; set; }
        public DailyCheckStatus EB7 { get; set; }
        public DailyCheckStatus EI1 { get; set; }
        public DailyCheckStatus EI2 { get; set; }
        public DailyCheckStatus EI3 { get; set; }
        public DailyCheckStatus EI4 { get; set; }
        public DailyCheckStatus EI5 { get; set; }
        public DailyCheckStatus EI6 { get; set; }
        public DailyCheckStatus EI7 { get; set; }
        public DailyCheckStatus EI8 { get; set; }
        public DailyCheckStatus EI9 { get; set; }
        public DailyCheckStatus EI10 { get; set; }
        public DailyCheckStatus EI11 { get; set; }
        public DailyCheckStatus EI12 { get; set; }
        public DailyCheckStatus EI13 { get; set; }
        public DailyCheckStatus EI14 { get; set; }
        public DailyCheckStatus EI15 { get; set; }
        public DailyCheckStatus EI16 { get; set; }
        public DailyCheckStatus EI17 { get; set; }
        public DailyCheckStatus EI18 { get; set; }
        public DailyCheckStatus EI19 { get; set; }
        public DailyCheckStatus EI20 { get; set; }
        public DailyCheckStatus EI21 { get; set; }
        public DailyCheckStatus EI22 { get; set; }
        public DailyCheckStatus EI23 { get; set; }
        public DailyCheckStatus EA1 { get; set; }
        public DailyCheckStatus EA2 { get; set; }
        public DailyCheckStatus EA3 { get; set; }
        public DailyCheckStatus EA4 { get; set; }
        public DailyCheckStatus EA5 { get; set; }
        public DailyCheckStatus EA6 { get; set; }
        public DailyCheckStatus EG1 { get; set; }
        public DailyCheckStatus EG2 { get; set; }
        public DailyCheckStatus EG3 { get; set; }
        public DailyCheckStatus EG4 { get; set; }
        public DailyCheckStatus EG5 { get; set; }
        public DailyCheckStatus EG6 { get; set; }
        public string Remarks { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
