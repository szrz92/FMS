using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class VehicleConfiguration
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Distance { get; set; }
        public int Month { get; set; }
        public int PenalityPoints { get; set; }
    }
}
