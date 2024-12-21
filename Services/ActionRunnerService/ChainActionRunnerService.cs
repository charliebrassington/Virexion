using Domain.Commands;
using Domain.Models;
using Services.ActionConnectionService;
using Services.ActionHandler;
using Services.ManagerService.ActionConnectionManagerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ActionRunnerService
{
    public class ChainActionRunnerService(IConnectionManagerService connectionManagerService, IEnumerable<IActionHandler> actionHandlers) : IActionRunnerService
    {
        private readonly IConnectionManagerService _connectionManagerService = connectionManagerService;

        private readonly Dictionary<string, IActionHandler> _actionHandlers = actionHandlers.ToDictionary(
            actionHandler => actionHandler.ActionName,
            actionHandler => actionHandler
        );

        public void StartRunner(CompleteActionCmd cmd, GameState gameState)
        {
            _actionHandlers[cmd.ActionName].Handle(gameState, cmd.Arguments)
                .ForEach(actionCmd => StartRunner(actionCmd, gameState));
        }
    }
}
