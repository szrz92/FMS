using System;
using System.Collections.Generic;

namespace SOS.FMS.Shared.Traccar
{
    public class Attributes
    {
        public int speedLimit { get; set; }
        public int deviceInactivityPeriod { get; set; }
    }

    public class DeviceResponse
    {
        public int id { get; set; }
        public Attributes attributes { get; set; }
        public int groupId { get; set; }
        public string name { get; set; }
        public string uniqueId { get; set; }
        public string status { get; set; }
        public DateTime? lastUpdate { get; set; }
        public int positionId { get; set; }
        public List<int> geofenceIds { get; set; }
        public string phone { get; set; }
        public string model { get; set; }
        public string contact { get; set; }
        public object category { get; set; }
        public bool disabled { get; set; }
    }
}
