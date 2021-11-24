using Microsoft.EntityFrameworkCore;
using SensorRestDBPoster.Models;

namespace TemperatureRestGet.Context
{
    public class SensorContextGet : DbContext
    {
        public SensorContextGet(DbContextOptions<SensorContextGet> options) : base(options) { }
        public DbSet<Sensor> SensorData { get; set; }
    }
}