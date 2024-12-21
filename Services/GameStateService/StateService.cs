using Domain.Models;
using Domain.Errors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapters.JsonFileAdapter;

namespace Services.GameStateService
{
    public class StateService(IJsonFileAdapter gameStateAdapter) : IGameStateService
    {
        private readonly IJsonFileAdapter _gameStateAdapter = gameStateAdapter;

        public GameState GetGameState()
        {
            GameState? gameState = JsonConvert.DeserializeObject<GameState>(_gameStateAdapter.FetchJsonData("data"));
            return gameState ?? throw new InvalidGameStateData();
        }

        public void SaveCurrentGameState(GameState gameState)
        {
            _gameStateAdapter.SaveNewJsonData("data", JsonConvert.SerializeObject(gameState, Formatting.Indented));
        }
    }
}
