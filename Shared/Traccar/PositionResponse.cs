using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.Traccar.PositionResponse
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Attributes
    {
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("sat")]
        public int Sat { get; set; }

        [JsonPropertyName("event")]
        public int Event { get; set; }

        [JsonPropertyName("ignition")]
        public bool Ignition { get; set; }

        [JsonPropertyName("motion")]
        public bool Motion { get; set; }

        [JsonPropertyName("rssi")]
        public int Rssi { get; set; }

        [JsonPropertyName("io200")]
        public int Io200 { get; set; }

        [JsonPropertyName("gpsStatus")]
        public int GpsStatus { get; set; }

        [JsonPropertyName("pdop")]
        public double Pdop { get; set; }

        [JsonPropertyName("hdop")]
        public double Hdop { get; set; }

        [JsonPropertyName("power")]
        public double Power { get; set; }

        [JsonPropertyName("io24")]
        public int Io24 { get; set; }

        [JsonPropertyName("battery")]
        public double Battery { get; set; }

        [JsonPropertyName("io68")]
        public int Io68 { get; set; }

        [JsonPropertyName("operator")]
        public int Operator { get; set; }

        [JsonPropertyName("odometer")]
        public int Odometer { get; set; }

        [JsonPropertyName("distance")]
        public double Distance { get; set; }

        [JsonPropertyName("totalDistance")]
        public double TotalDistance { get; set; }

        [JsonPropertyName("hours")]
        public int Hours { get; set; }
    }

    public class PositionResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("deviceId")]
        public int DeviceId { get; set; }

        [JsonPropertyName("type")]
        public object Type { get; set; }

        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        [JsonPropertyName("serverTime")]
        public DateTime ServerTime { get; set; }

        [JsonPropertyName("deviceTime")]
        public DateTime DeviceTime { get; set; }

        [JsonPropertyName("fixTime")]
        public DateTime FixTime { get; set; }

        [JsonPropertyName("outdated")]
        public bool Outdated { get; set; }

        [JsonPropertyName("valid")]
        public bool Valid { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("altitude")]
        public double Altitude { get; set; }

        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("course")]
        public double Course { get; set; }

        [JsonPropertyName("address")]
        public object Address { get; set; }

        [JsonPropertyName("accuracy")]
        public double Accuracy { get; set; }

        [JsonPropertyName("network")]
        public object Network { get; set; }
    }
}
