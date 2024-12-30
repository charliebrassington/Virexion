using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ActionConnectionService
{
    public interface IActionConnectionService
    {
        public List<RelationshipConnection> GetActionConnections();
        public void SaveActionConnections(List<RelationshipConnection> connections);
    }
}
