﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SensorRestDBPoster.Models;
using TemperatureRestGet.Managers;
using TemperatureRestGet.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TemperatureRestGet.Controllers
{
    [Route("Sensor")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly TemperatureManager _manager;

        public TemperatureController(SensorContextGet context)
        {
            _manager = new TemperatureManager(context);
        }

        //GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Sensor> GetOne()
        {
            return _manager.GetOne();
        }

        //GET api/<ValuesController>/5
        [Route("/GetAll")]
        [HttpGet]
        public IEnumerable<Sensor> GetAll()
        {
            return _manager.GetAll();
        }

        [Route("/GetAverage")]
        [HttpGet]
        public IEnumerable<Sensor> GetAve()
        {
            return _manager.GetAverage();
        }



    }
}
