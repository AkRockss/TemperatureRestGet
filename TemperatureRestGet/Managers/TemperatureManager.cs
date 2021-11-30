using System.Collections.Generic;
using System.Linq;
using SensorRestDBPoster.Models;
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

        public IEnumerable<Sensor> GetAll(string temperature/*, string sortBy = null*/)
        {
            if (string.IsNullOrWhiteSpace(temperature))
            {
                return _context.SensorData.ToList();
            }

            IEnumerable<Sensor> sensors = from sensor in _context.SensorData
                                          where sensor.Temperature.Contains(temperature)
                                          orderby sensor.Date ascending
                                          select sensor;


            //List<Sensor> ath = new List<Sensor>(sensors);

            //if (sortBy != null)
            //{
            //    switch (sortBy.ToLower())
            //    {
            //        case "temperature":
            //            ath = ath.OrderBy(ath => ath.Temperature).ToList();
            //            break;


            //    }


            //}

            return sensors;
        }
    }
}

