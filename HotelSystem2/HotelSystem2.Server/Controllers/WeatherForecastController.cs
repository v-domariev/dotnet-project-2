using HotelSystem2.Server.Entities;
using HotelSystem2.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem2.Server.Controllers
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
        private IHotelService _hotelService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHotelService hotelService)
        {
            _logger = logger;
            _hotelService = hotelService;
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
        [HttpGet("hotel3")]
        public IEnumerable<Hotel> Gethotel3()
        {
            return this._hotelService.GetHotels1()
            .ToArray();
        }

        [HttpGet("/api/hotel2")]
        public async Task<IActionResult> GetHotelsAsync()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();

            var res = await _hotelService.GetHotelsAsync();
            return Ok(res.AsEnumerable());

        }
    }
}
