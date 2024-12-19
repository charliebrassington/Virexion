using Domain.Commands;
using Services.GameStateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommandHandler
{
    public class ActionServiceHandler : ICommandHandler<CompleteActionCmd>
    {
        public void HandleCommand(CompleteActionCmd cmd)
        {
            Console.WriteLine($"Got action to complete {cmd.ActionName}");
        }
    }
}
