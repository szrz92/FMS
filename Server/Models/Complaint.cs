using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class Complaint
    {
        public Guid Id { get; set; }
        public string PointCode { get; set; }
        public string PointCodeDescription { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Station { get; set; }

        public bool IsActive { get; set; }
        public DateTime ReportTime { get; set; }
        public DateTime ResolutionTime { get; set; }
    }
}