using Microsoft.EntityFrameworkCore;
using SensorRestDBPoster.Models;

namespace TemperatureRestGet.Context
{
    public class SensorContext : DbContext
    {
        public SensorContext(DbContextOptions<SensorContext> options) : base(options) { }
        public DbSet<Sensor> Table { get; set; }
    }
}