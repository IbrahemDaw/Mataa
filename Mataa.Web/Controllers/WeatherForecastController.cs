using Domain.AppUser;
using Microsoft.AspNetCore.Mvc;

namespace Mataa.Web.Controllers
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
        private readonly IAppUserRepo appUserRepo;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IAppUserRepo appUserRepos)
        {
            _logger = logger;
            appUserRepo = appUserRepos;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("test")]
        public async Task<IActionResult> Gedt()
        {
            return Ok(await appUserRepo.Get());
        }
    }
}
