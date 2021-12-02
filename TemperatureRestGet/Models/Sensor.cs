using System;
using System.ComponentModel.DataAnnotations;

namespace SensorRestDBPoster.Models
{
    /// <summary>
    /// The Sensor Class. Has an int Id (internally set in the Database, don't try and set it), string Temperature, string Date, string Humidity and string RoomId.
    /// </summary> 
    public class Sensor
    {
        [Key]
        public int Id { get; set; }
        public double Temperature { get; set; }
        public string Date { get; set; }
        public string Humidity { get; set; }
        public string RoomId { get; set; }
    }
}
