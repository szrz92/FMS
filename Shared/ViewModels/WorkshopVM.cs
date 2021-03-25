using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class WorkshopVM
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public Guid IncidentId { get; set; }
    }
}
