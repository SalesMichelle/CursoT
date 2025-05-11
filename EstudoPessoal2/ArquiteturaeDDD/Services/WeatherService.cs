using TestAPI.Models;

namespace TestAPI.Services
{
    public class WeatherService : IWeatherService
    {
        public IEnumerable<WeatherForecast> GetForecast()
        {
            return new List<WeatherForecast>
            {
                new WeatherForecast { Date = DateTime.Now, TemperatureC = 28, Summary = "Ensolarado" },
                new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 25, Summary = "Nublado" }
            };
        }
    }
}
