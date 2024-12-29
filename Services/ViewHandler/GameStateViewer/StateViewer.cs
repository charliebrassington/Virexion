using Domain.Models;
using Services.GameStateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewHandler.GameStateViewer
{
    public class StateViewer(IGameStateService gameStateService) : IGameStateViewer
    {
        private readonly IGameStateService _gameStateService = gameStateService;

        public GameState ViewGameState()
        {
            return _gameStateService.GetGameState();
        }
    }
}
