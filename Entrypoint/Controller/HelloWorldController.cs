using Domain;
using Domain.Commands;
using Microsoft.AspNetCore.Mvc;
using Services.CommandHandler;


namespace Entrypoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController(AbstractCommandHandler<HelloWorldCmd> helloWorldHandler) : ControllerBase
    {
        private readonly AbstractCommandHandler<HelloWorldCmd> _helloWorldHandler = helloWorldHandler;

        [HttpGet(Name = "GetHelloWorld")]
        public void Get()
        {
            _helloWorldHandler.HandleCommand(new());
        }
    }
}
