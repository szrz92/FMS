﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class EmergencyBill
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CheckPointId { get; set; }
        public double BillAmount { get; set; }
        public string BillImage { get; set; }
    }
}
