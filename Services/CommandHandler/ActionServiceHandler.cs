using Domain.Commands;
using Domain.Models;
using Domain.Models.Actions;
using Services.ActionHandler;
using Services.ActionRunnerService;
using Services.GameStateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommandHandler
{
    public class ActionServiceHandler(
        IGameStateService gameStateService, IActionRunnerService actionRunnerService
    ) : ICommandHandler<CompleteActionCmd>
    {
        private readonly IGameStateService _gameStateService = gameStateService;
        private readonly IActionRunnerService _actionRunnerService = actionRunnerService;

        public void HandleCommand(CompleteActionCmd cmd)
        {
            GameState gameState = _gameStateService.GetGameState();

            _actionRunnerService.StartRunner(cmd, gameState);

            _gameStateService.SaveCurrentGameState(gameState);
        }
    }
}
