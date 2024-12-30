using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewHandler.GameStateViewer
{
    public interface IGameStateViewer
    {
        public GameState ViewGameState();
    }
}
