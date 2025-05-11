using Microsoft.AspNetCore.Mvc;
using TestAPI.Services; // Você vai criar essa pasta e classe daqui a pouco

namespace TestAPI.Controllers
{
    [ApiController]             // informa que essa classe é um controlador de API.
    [Route("[controller]")]     // define que a rota será weather, baseada no nome da classe.
    public class WeatherController : ControllerBase     //  classe do controlador.
    {
        private readonly IWeatherService _weatherService;  //  é a interface da camada de serviço, que você ainda vai criar.

    // private Significa que só pode ser acessado dentro da própria classe. Nenhum código de fora (ou até mesmo de uma subclasse) consegue acessar diretamente esse campo.
    //readonly Significa que o valor só pode ser atribuído uma vez, normalmente no construtor da classe. Depois disso, ele não pode mais ser alterado.
        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IActionResult GetForecast()          // método que responde à rota GET /weather, chamando o serviço para obter uma previsão.
        {
            var result = _weatherService.GetForecast();
            return Ok(result);
        }
    }
}