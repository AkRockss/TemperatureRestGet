using System.Collections.Generic;
using System.Linq;
using SensorRestDBPoster.Models;
using TemperatureRestGet.Context;

namespace TemperatureRestGet.Managers
{
    public class TemperatureManager 
    {
        private SensorContext _context;
        private static int _nextId = 1;

        public TemperatureManager(SensorContext context)
        {
            _context = context;
        }

      public IEnumerable<Sensor> GetAll(string temperature)
        {
            if (string.IsNullOrWhiteSpace(temperature))
            {
                return _context.Table.ToList();
            }
            IEnumerable<Sensor> sensors = from sensor in _context.Table
                                          where sensor.Temperature.Equals(temperature)
                                          select sensor;
            return sensors;
        }

    }
}
