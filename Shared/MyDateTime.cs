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

        public static int GetMonthsBetween(DateTime from, DateTime to)
        {
            if (from > to) return GetMonthsBetween(to, from);

            var monthDiff = Math.Abs((to.Year * 12 + (to.Month - 1)) - (from.Year * 12 + (from.Month - 1)));

            if (from.AddMonths(monthDiff) > to || to.Day < from.Day)
            {
                return monthDiff - 1;
            }
            else
            {
                return monthDiff;
            }
        }
    }
}
