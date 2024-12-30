using Domain.Commands;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.CommandHandler;
using Services.ViewHandler.GameStateViewer;

namespace Entrypoint.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class GameStateController(
        IGameStateViewer gameStateViewer,
        ICommandHandler<SimulateGameDay> commandHandler
    ) : ControllerBase
    {
        private readonly IGameStateViewer _gameStateViewer = gameStateViewer;
        private readonly ICommandHandler<SimulateGameDay> _commandHandler = commandHandler;

        [HttpGet(Name = "ViewGameState")]
        public GameState GetGameState()
        {
            return _gameStateViewer.ViewGameState();
        }

        [HttpPost(Name = "SimulateNewGameDay")]
        public void SimulateGameDay()
        {
            _commandHandler.HandleCommand(new());
        }
    }
}
