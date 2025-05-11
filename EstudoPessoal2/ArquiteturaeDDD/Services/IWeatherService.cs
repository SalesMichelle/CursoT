using TestAPI.Models;
using System.Collections.Generic;

namespace TestAPI.Services
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetForecast();
    }
}