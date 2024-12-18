using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Actions.ExternalActions
{
    public interface IExternalAction
    {
        ExternalActionsEnum ActionType { get; }
        List<string> GetArguments();
    }
}
