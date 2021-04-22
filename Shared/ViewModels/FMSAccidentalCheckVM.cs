using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSAccidentalCheckVM
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public CheckMaintenanceStatus MaintenanceStatus { get; set; }
        public int CommentCount { get; set; }
        public int ImageCount { get; set; }
        public Guid FMSAccidentId { get; set; }
        public Guid FMSVehicleId { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Remarks { get; set; }
        public string AccidentRef { get; set; }
    }
}
