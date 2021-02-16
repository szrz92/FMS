using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSUserVM
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}
