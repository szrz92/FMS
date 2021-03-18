using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class File
    {
        public Guid Id { get; set; }
        public Guid CheckPoint { get; set; }
        public string Name { get; set; }
    }
}
