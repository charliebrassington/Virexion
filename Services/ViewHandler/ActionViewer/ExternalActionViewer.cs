using Domain.Models.Actions;
using Domain.Models.Actions.ExternalActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewHandler.ActionViewer
{
    public class ExternalActionViewer(IEnumerable<IExternalAction> externalActions) : IExternalActionViewer
    {
        private readonly IEnumerable<IExternalAction> _externalActions = externalActions;

        public Dictionary<string, List<string>> GetExternalActions()
        {
            return _externalActions.ToDictionary(
                action => action.ActionType.ToString(),
                action => action.GetArguments()
            );
        }
    }
}
