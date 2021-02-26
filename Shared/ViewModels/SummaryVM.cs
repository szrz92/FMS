using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class SummaryVM
    {
        public Guid Id { get; set; }
        public string DriverCode { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime LeavingDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
