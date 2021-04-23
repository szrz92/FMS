﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.Traccar
{
    public class Summary
    {
        public int deviceId { get; set; }
        public string deviceName { get; set; }
        public double distance { get; set; }
        public double averageSpeed { get; set; }
        public double maxSpeed { get; set; }
        public double spentFuel { get; set; }
        public double startOdometer { get; set; }
        public double endOdometer { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int engineHours { get; set; }
    }
}