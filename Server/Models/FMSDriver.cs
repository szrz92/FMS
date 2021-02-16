using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSDriver
    {
        [Key]
        public Guid Id { get; set; }
        public Guid DriverId { get; set; }
        public string DriverName { get; set; }
        public int TotalTrips { get; set; }
        public string Location { get; set; }
        public string Station { get; set; }
        public string Status { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Violations { get; set; }
        public int Inicidents { get; set; }
        public int Score { get; set; }
        public int Ranking { get; set; }
        public DateTime LastSync { get; set; }
    }
}
