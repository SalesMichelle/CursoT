using ArquiteturaeDDD.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArquiteturaeDDD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        public string Get()
        {
            return _helloService.SayHello();
        }
    }
}