using HotelSystem2.Server.Context;
using HotelSystem2.Server.Entities;
using HotelSystem2.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem2.Server.Controllers
{
    [ApiController]
    [Route("api/hotel")]
    public class HotelController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        private IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        [HttpGet]
        /*
        public async Task<IEnumerable<WeatherForecast>> GetHotelsAsync()
        {
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();

            var res = await _hotelService.GetHotelsAsync();
            return Ok(res?.ToArray());

        }*/
        ///*
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
        //*/
    }
}
