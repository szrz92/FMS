using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class ComplaintVM
    {
        public Guid Id { get; set; }
        public string PointCode { get; set; }
        public string PointCodeDescription { get; set; }
        public string ComplaintDescription { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Station { get; set; }

        public bool IsActive { get; set; }
        public string Status { get;set;}
        public DateTime ReportTime { get; set; }
    }
}
