using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorRestDBPoster.Models
{
    /// <summary>
    /// Like the Sensor class, but without the Id. Used, so the Rest Service isn't expecting an Id to be sent. String Temperature, string Date, string Humidity and string RoomId.
    /// </summary>
    public class SensorLite
    {
        public double Temperature { get; set; }
        public string Date { get; set; }
        public string Humidity { get; set; }
        public string RoomId { get; set; }
    }
}
