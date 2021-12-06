using Microsoft.EntityFrameworkCore;
using SensorRestDBPoster.Models;

namespace TemperatureRestGet.Context
{
    // Initializes Dbset with Sensor
    public class SensorContextGet : DbContext
    {
        public SensorContextGet(DbContextOptions<SensorContextGet> options) : base(options) { }
        public DbSet<Sensor> SensorData { get; set; }
    }
}