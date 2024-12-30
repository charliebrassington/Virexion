using Domain.Commands;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManagerService.ActionConnectionManagerService
{
    public interface IConnectionManagerService
    {
        public List<RelationshipConnection> GetConnectionList(string action);
        public List<CompleteActionCmd> GetActionList(string action, List<string> arguments);
    }
}
