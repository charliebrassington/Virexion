using Domain.Commands;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManagerService.WeightValidationManagerService
{
    public interface IWeightValidationManagerService
    {
        public bool IsValidWeight(List<RelationshipConnection> connectionList, ChangeConnectionWeight cmd);
    }
}
