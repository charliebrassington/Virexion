using Domain.Commands;
using Services.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommandHandler
{
    public class HelloWorldServiceHandler(IHelloWorldService helloWorldService) : AbstractCommandHandler<HelloWorldCmd>
    {
        private readonly IHelloWorldService _helloWorldService = helloWorldService;

        public override void HandleCommand(HelloWorldCmd cmd)
        {
            _helloWorldService.Hello();
        }
    }
}
