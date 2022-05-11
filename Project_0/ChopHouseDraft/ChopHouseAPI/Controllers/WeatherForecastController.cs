using Microsoft.AspNetCore.Mvc;
//types and derived types are used to serve HTTP API responses controllers decorated with this attribute are configured with features and behaviors 
//for improving developer experience for building APIs 

//When decorated on an assembly all controllers in the assembly will be treated as contrillers with API behavior.

namespace ChopHouseAPI.Controllers
{
    [ApiController]// decorator/ attribute : its like processing before the class or method
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase// base class for MVC controller without view support controller inherits from
                                                           // controller base with all the methods attributes in []. Base class has the logic to interact with HTTP
                                                           // and communication with client

                                                            
        

    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get() //Action method what kind of http method are we applying for 
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}