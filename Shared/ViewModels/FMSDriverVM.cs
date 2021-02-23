using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class DriverVM
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string VehicleNumber { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public int Trips { get; set; }
        public int Points { get; set; }
        public int Accidents { get; set; }
        public int Emergencies { get; set; }
        public int Incidents { get { return Accidents + Emergencies; } }
        public int Absents { get; set; }
        public int Ranking { get; set; }
        public bool Status { get; set; }
        public int Violations { get; set; }
    }
}
