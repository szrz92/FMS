using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class VehicleConfigurationVM
    {
        public Guid Id { get; set; }
        public string ServiceType { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Distance { get; set; }
        [Required]
        public int Month { get; set; }
        [Required]
        public int PenalityPoints { get; set; }
    }
}
