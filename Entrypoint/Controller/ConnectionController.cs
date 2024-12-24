using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.ViewHandler.ConnectionViewer;

namespace Entrypoint.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionController(IConnectionViewer connectionViewer) : ControllerBase
    {
        private readonly IConnectionViewer _connectionViewer = connectionViewer;

        [HttpGet(Name = "ViewConnections")]
        public List<RelationshipConnection> ViewConnectionList()
        {
            return _connectionViewer.ViewConnectionList();
        }
    }
}
