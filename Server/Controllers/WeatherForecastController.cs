using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SOS.FMS.Server.GBMSModels;
using SOS.FMS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOS.FMS.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        SOS_VIEWSContext _gbmsContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, SOS_VIEWSContext gbmsContext)
        {
            _logger = logger;
            _gbmsContext = gbmsContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet]
        public IActionResult GetString()
        {
            try
            {
                var vehicles = (from v in _gbmsContext.RbVehicles select v).ToList();
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
