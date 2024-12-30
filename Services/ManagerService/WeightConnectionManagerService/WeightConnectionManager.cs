using Domain.Commands;
using Domain.Models;
using Services.ActionConnectionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManagerService.WeightConnectionManagerService
{
    public class WeightConnectionManager : IWeightConnectionManagerService
    {
        public void ChangeConnectionWeights(List<RelationshipConnection> connectionList, ChangeConnectionWeight cmd)
        {
            connectionList
                .Where(connection =>
                    connection.ParentActionName == cmd.ParentActionName &&
                    connection.ChildActionName == cmd.ChildActionName
                )
                .ToList()
                .ForEach(connection => connection.Weight = cmd.NewWeight);
        }
    }
}
