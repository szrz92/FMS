using System;
using System.ComponentModel.DataAnnotations;

namespace SOS.FMS.Server.Models
{
    public class VehicleType
    {
        [Key]
        public Guid Id { get; set; }
        public string XCode { get; set; }
        public long? XrowId { get; set; }
        public string XDescription { get; set; }
        public string XAbbreviation { get; set; }
        public string XRemarks { get; set; }
        public string AddId { get; set; }
        public string ModId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string IpAdd { get; set; }
        public string IpMod { get; set; }
        public DateTime LastSync { get; set; }
    }
}
