using Domain.Commands;
using Domain.Models;
using Domain.Models.Actions;
using Domain.Models.Actions.ExternalActionArguments;
using Domain.ModelFactories.ArgumentFactories;
using Services.ManagerService.ActionConnectionManagerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Services.ActionHandler
{
    public abstract class AbstractActionHandler<T>(
        IArgumentFactory<T> argumentFactory, IConnectionManagerService connectionManagerService
    ) : IActionHandler where T : IActionArgument
    {
        private readonly IConnectionManagerService _connectionManagerService = connectionManagerService;
        private readonly IArgumentFactory<T> _argumentFactory = argumentFactory;
        public abstract string ActionName { get; }

        public abstract List<CompleteActionCmd> HandleAction(GameState gameState, T arguments);

        public List<CompleteActionCmd> Handle(GameState gameState, List<string> arguments)
        {
            return HandleAction(gameState, _argumentFactory.CreateArgument(arguments));
        }

        public List<CompleteActionCmd> GetConnectionActionList(List<string> arguments)
        {
            return _connectionManagerService.GetActionList(ActionName, arguments);
        }
    }
}
