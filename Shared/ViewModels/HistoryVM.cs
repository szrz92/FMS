using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class HistoryVM
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
