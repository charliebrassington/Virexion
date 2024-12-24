using Domain.Commands;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManagerService.WeightConnectionManagerService
{
    public interface IWeightConnectionManagerService
    {
        public void ChangeConnectionWeights(List<RelationshipConnection> connectionList, ChangeConnectionWeight cmd);
    }
}
