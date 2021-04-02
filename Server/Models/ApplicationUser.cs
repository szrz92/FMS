using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string SubRegion { get; set; }
        public string Region { get; set; }
        public string Station { get; set; }

    }
}
