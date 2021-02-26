using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.Traccar
{
    public class Attributes
    {
        public int speedLimit { get; set; }
        public int deviceInactivityPeriod { get; set; }
        public int priority { get; set; }
        public int sat { get; set; }
        public bool ignition { get; set; }
        public bool motion { get; set; }
        public int rssi { get; set; }
        public int io200 { get; set; }
        public int gpsStatus { get; set; }
        public double pdop { get; set; }
        public double hdop { get; set; }
        public double power { get; set; }
        public int io24 { get; set; }
        public double battery { get; set; }
        public int io68 { get; set; }
        public int odometer { get; set; }
        public double distance { get; set; }
        public double totalDistance { get; set; }
        public int hours { get; set; }
    }
    public class Position
    {
        public int id { get; set; }
        public Attributes attributes { get; set; }
        public int deviceId { get; set; }
        public object type { get; set; }
        public string protocol { get; set; }
        public DateTime serverTime { get; set; }
        public DateTime deviceTime { get; set; }
        public DateTime fixTime { get; set; }
        public bool outdated { get; set; }
        public bool valid { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double altitude { get; set; }
        public double speed { get; set; }
        public double course { get; set; }
        public object address { get; set; }
        public double accuracy { get; set; }
        public object network { get; set; }
    }
    public class Device
    {
        public int id { get; set; }
        public string name { get; set; }
        public string uniqueId { get; set; }
        public string status { get; set; }
        public bool disabled { get; set; }
        public DateTime lastUpdate { get; set; }
        public int positionId { get; set; }
        public int groupId { get; set; }
        public string phone { get; set; }
        public string model { get; set; }
        public string contact { get; set; }
        public string category { get; set; }
        public List<int> geofenceIds { get; set; }
        public Attributes attributes { get; set; }
    }
    public class DevicePosition
    {
        public int id { get; set; }
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int odometer { get; set; }
        public double distance { get; set; }
        public double totalDistance { get; set; }
        public int hours { get; set; }
    }
}
