using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels.Accident
{
    public class BillPostingVM
    {
        [Required]
        public Guid CheckPointId { get; set; }
        [Required]
        [Range(1, Int32.MaxValue)]
        public int TotalAmount { get; set; }

        public IList<string> images = new List<string>();
    }

}
