using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared
{
    public static class PakistanDateTime
    {
        static TimeZoneInfo _cetZone = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
        public static DateTime Now => TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _cetZone);
        public static DateTime Today => TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _cetZone).Date;
        public static DateTime ToPsTime(this DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, _cetZone).Date;
        }
    }
}
