using Domain.Commands;
using Microsoft.AspNetCore.Mvc;
using Services.CommandHandler;


namespace Entrypoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController(ICommandHandler<HelloWorldCmd> helloWorldHandler) : ControllerBase
    {
        private readonly ICommandHandler<HelloWorldCmd> _helloWorldHandler = helloWorldHandler;

        [HttpGet(Name = "GetHelloWorld")]
        public void Get()
        {
            _helloWorldHandler.HandleCommand(new());
        }
    }
}
