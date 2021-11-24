using System.Collections.Generic;
using System.Linq;
using SensorRestDBPoster.Models;
using TemperatureRestGet.Context;

namespace TemperatureRestGet.Managers
{
    public class TemperatureManager 
    {
        private SensorContextGet _context;
        private static int _nextId = 1;

        public TemperatureManager(SensorContextGet context)
        {
            _context = context;
        }

      public IEnumerable<Sensor> GetAll(string temperature)
        {
            if (string.IsNullOrWhiteSpace(temperature)) 
            {
                IEnumerable<Sensor> sensors = from sensor in _context.SensorData
                                              where sensor.Temperature.Equals(temperature)
                                              select sensor;
                return sensors;
            }
            return _context.SensorData.ToList();
        }

    }
}
