using SensorRestDBPoster.Models;
using System.Collections.Generic;
using System.Linq;
using TemperatureRestGet.Context;

namespace TemperatureRestGet.Managers
{
    public class TemperatureManager
    {
        //Instancefield
        private SensorContextGet _context;

        // Initializes connection string into _context;
        public TemperatureManager(SensorContextGet context)
        {
            _context = context;
        }

        //Method gets 5 objects from Database
        public IEnumerable<Sensor> GetFive()
        {
            IEnumerable<Sensor> sensors = (from sensor in _context.SensorData
                                           orderby sensor.Date descending
                                           select sensor).Take(5);

            return sensors;

        }

        // Method gets 144 objets from database and is used for average calculation in frontend. 
        public IEnumerable<Sensor> GetAverage()
        {
            IEnumerable<Sensor> sensors = (from sensor in _context.SensorData
                orderby sensor.Date descending
                select sensor).Take(144);

            return sensors;

        }


        // This method gets all objects from database
        public IEnumerable<Sensor> GetAll()
        {
            IEnumerable<Sensor> sensors1 = from sensor in _context.SensorData
                                            orderby sensor.Date descending
                                            select sensor;


            return sensors1;


        }


    }
}



