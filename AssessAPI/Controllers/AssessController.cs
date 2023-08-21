using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssessAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class AssessController : ControllerBase
    {
        /*private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AssessController> _logger;

        public AssessController(ILogger<AssessController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }*/

        [AllowAnonymous]
        [HttpGet]
        [Route("hello")]
        public string GetHello()
        {
            return "{'msg' : 'hello'}";
        }

        [Authorize]
        [HttpPost]
        [Route("handshake")]
        public string GetHandshake()
        {
            return "{'msg' : 'handshake'}";
        }
    }
}