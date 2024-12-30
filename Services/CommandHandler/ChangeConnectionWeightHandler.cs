using Domain.Commands;
using Domain.Models;
using Services.ActionConnectionService;
using Services.ManagerService.WeightConnectionManagerService;
using Services.ManagerService.WeightValidationManagerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommandHandler
{
    public class ChangeConnectionWeightHandler(
        IActionConnectionService actionConnectionService, 
        IWeightConnectionManagerService weightManagerService,
        IWeightValidationManagerService weightValidationManager
    ) : ICommandHandler<ChangeConnectionWeight>
    {
        private readonly IActionConnectionService _actionConnectionService = actionConnectionService;
        private readonly IWeightConnectionManagerService _weightManagerService = weightManagerService;
        private readonly IWeightValidationManagerService _weightValidationManager = weightValidationManager;

        public void HandleCommand(ChangeConnectionWeight cmd)
        {
            List<RelationshipConnection> connectionList = _actionConnectionService.GetActionConnections();

            _weightManagerService.ChangeConnectionWeights(connectionList, cmd);

            if (_weightValidationManager.IsValidWeight(connectionList, cmd)) 
            {
                _actionConnectionService.SaveActionConnections(connectionList);
            }
        }
    }
}
