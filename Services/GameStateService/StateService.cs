using Adapters.GameFileAdapter;
using Domain.Models;
using Domain.Errors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.GameStateService
{
    public class StateService(IGameFileAdapter gameFileAdapter) : IGameStateService
    {
        private readonly IGameFileAdapter _gameStateService = gameFileAdapter;

        public GameState GetGameState()
        {
            GameState? gameState = JsonConvert.DeserializeObject<GameState>(_gameStateService.FetchGameState());
            return gameState ?? throw new InvalidGameStateData();
        }
    }
}
