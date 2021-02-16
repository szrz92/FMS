using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSAccount
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Role { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid FMSUserId { get; set; }
    }
}
