using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.GameStateService
{
    public interface IGameStateService
    {
        GameState GetGameState();
        public void SaveCurrentGameState(GameState gameState);
    }
}
