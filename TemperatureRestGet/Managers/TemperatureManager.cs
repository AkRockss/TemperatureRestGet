using SensorRestDBPoster.Models;
using System.Collections.Generic;
using System.Linq;
using TemperatureRestGet.Context;

namespace TemperatureRestGet.Managers
{
    public class TemperatureManager
    {
        private SensorContextGet _context;
       

        public TemperatureManager(SensorContextGet context)
        {
            _context = context;
        }

        public IEnumerable<Sensor> GetAll()
        {
            IEnumerable<Sensor> sensors = (from sensor in _context.SensorData
                                           where sensor.Temperature.Contains(string.Empty)
                                           orderby sensor.Date descending
                                           select sensor).Take(5);
 
            return sensors;
        }
    }
}

