using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Actions.ExternalActions
{
    public class ChangeTaxBracketAction : IExternalAction
    {
        public ExternalActionsEnum ActionType => ExternalActionsEnum.ChangeTaxBracket;

        public List<string> GetArguments()
        {
            return ["incomeAmount", "taxPercentage"];
        }
    }
}
