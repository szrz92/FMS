using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSDriverVM
    {
        public Guid DriverId { get; set; }
        public string DriverName { get; set; }
        public int TotalTrips { get; set; }
        public string Location { get; set; }
        public string Station { get; set; }
        public string Status { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Violations { get; set; }
        public int Inicidents { get; set; }
        public int Score { get; set; }
        public int Ranking { get; set; }
    }
}
