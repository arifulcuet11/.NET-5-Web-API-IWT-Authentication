using DEAWebApi.Domain.Entities;
using DEAWebApi.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEAWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApplicationDbContext Context;  

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApplicationDbContext applicationDb)
        {
            _logger = logger;
            Context = applicationDb;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var rng = new Random();
            var result = new List<User>();
            result.Add(new User(){
                Email = "adsad",
                Id = 2,
            });
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            return result;
        }
    }
}
