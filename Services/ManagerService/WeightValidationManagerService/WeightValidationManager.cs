using Domain.Commands;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManagerService.WeightValidationManagerService
{
    public class WeightValidationManager : IWeightValidationManagerService
    {
        public bool IsValidWeight(List<RelationshipConnection> connectionList, ChangeConnectionWeight cmd)
        {
            return 1 >= connectionList
                .Where(connection => connection.ParentActionName == cmd.ParentActionName)
                .Sum(connection => connection.Weight);
        }
    }
}
