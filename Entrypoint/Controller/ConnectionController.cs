using Domain.Commands;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.CommandHandler;
using Services.ViewHandler.ConnectionViewer;

namespace Entrypoint.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionController(
        ICommandHandler<ChangeConnectionWeight> commandHandler, IConnectionViewer connectionViewer
    ) : ControllerBase
    {
        private readonly ICommandHandler<ChangeConnectionWeight> _commandHandler = commandHandler;
        private readonly IConnectionViewer _connectionViewer = connectionViewer;

        [HttpGet(Name = "ViewConnections")]
        public List<RelationshipConnection> ViewConnectionList()
        {
            return _connectionViewer.ViewConnectionList();
        }

        [HttpPost(Name = "ChangeWeight")]
        public void ChangeConnectionWeight([FromBody] ChangeConnectionWeight changeWeightCmd)
        {
            if (1 < changeWeightCmd.NewWeight || changeWeightCmd.NewWeight < 0)
            {
                return;
            }

            _commandHandler.HandleCommand(changeWeightCmd);
        }
    }
}
