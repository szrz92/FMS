using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class SubRegionVM
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public long? rowId { get; set; }
        public string Description { get; set; }
        public string Abbrevation { get; set; }
        public string Region { get; set; }
        public string RegionDescription { get; set; }
        public string RevenueAuthroity { get; set; }
        public string RevenueAuthroityDescription { get; set; }
        public string Remarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
    }
}
