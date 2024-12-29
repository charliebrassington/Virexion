using Domain.Commands;
using Domain.Models;
using Services.GameStateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommandHandler
{
    public class SimulateGameDayHandler(IGameStateService gameStateService) : ICommandHandler<SimulateGameDay>
    {
        private readonly IGameStateService _gameStateService = gameStateService;
        public void HandleCommand(SimulateGameDay cmd)
        {
            GameState game = _gameStateService.GetGameState();

            game.GameAge += 1;

            _gameStateService.SaveCurrentGameState(game);
        }
    }
}
