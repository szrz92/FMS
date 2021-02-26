using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string VehicleNumber { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public int Trips { get; set; }
        public int Points { get; set; }
        public int Accidents { get; set; }
        public int Emergencies { get; set; }
        public int Absents { get; set; }
        public int Violations { get; set; }
        public int Ranking { get; set; }
        public int Score { get; set; } = 100;
        public DateTime LastSync { get; set; }
    }
}
