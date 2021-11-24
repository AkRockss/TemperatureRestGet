﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SensorRestDBPoster.Context;
using SensorRestDBPoster.Models;
using TemperatureRestGet.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TemperatureRestGet.Controllers
{
    [Route("Sensor")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly TemperatureManager _manager;

        public TemperatureController(SensorContext context)
        {
            _manager = new TemperatureManager(context);
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Sensor> Get([FromQuery] string temperature)
        {
            return _manager.GetAll(temperature);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
    }
}
