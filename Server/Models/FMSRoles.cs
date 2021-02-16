using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSRole
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
