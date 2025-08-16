using Microsoft.AspNetCore.Mvc;
using ShopKeeper.Models;
using ShopKeeper.Services;

namespace ShopKeeper.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private readonly PersonService _personService;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(PersonService personService, ILogger<WeatherForecastController> logger)
    {
        _personService = personService;
        _logger = logger;
    }

    [HttpGet(Name = "GetAllPersons")]
    public ActionResult<List<Person>> Get() => _personService.GetAllPersonsAsync().Result;

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }
}
