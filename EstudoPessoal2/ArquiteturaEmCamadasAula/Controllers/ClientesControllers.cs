using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaCamadasDemo.Controllers
{

    [ApiController]      // Anotação para mostrar que é um controller
    [Route("[Controller]")]            // Rota
    public class ClientesController : ControllerBase        // Classe base e abstrata
    {
        [HttpGet]
        public IActionResult Listar()           // Quando chamar o get/ Classe Clientes, esse método será chamado
        {
            return Ok();
        }
    }
}