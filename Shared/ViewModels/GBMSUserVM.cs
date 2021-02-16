using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class GBMSUserVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string OfficialEmail { get; set; }
    }
}

