using Domain.Commands;
using Domain.Models;
using Services.ActionConnectionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManagerService.ActionConnectionManagerService
{
    public class ConnectionManagerService(IActionConnectionService connectionService) : IConnectionManagerService
    {
        private readonly Dictionary<string, List<RelationshipConnection>> _connectionService = connectionService.GetActionConnections()
            .GroupBy(conn => conn.ParentActionName)
            .ToDictionary(connectionGroup => connectionGroup.Key, connectionGroup => connectionGroup.ToList());

        public List<RelationshipConnection> GetConnectionList(string action)
        {
            return _connectionService.GetValueOrDefault(action, []);
        }

        public List<CompleteActionCmd> GetActionList(string action, List<string> arguments)
        {
            return GetConnectionList(action)
                .Select(connection => new CompleteActionCmd() {
                    ActionName = connection.ChildActionName,
                    Arguments = [.. arguments, connection.Weight.ToString()]
                })
                .ToList();
        }
    }
}
