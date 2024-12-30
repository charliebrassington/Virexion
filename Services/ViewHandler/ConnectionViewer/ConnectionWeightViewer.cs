using Domain.Models;
using Services.ActionConnectionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewHandler.ConnectionViewer
{
    public class ConnectionWeightViewer(IActionConnectionService actionConnectionService) : IConnectionViewer
    {
        private readonly IActionConnectionService _actionConnectionService = actionConnectionService;

        public List<RelationshipConnection> ViewConnectionList()
        {
            return _actionConnectionService.GetActionConnections();
        }
    }
}
