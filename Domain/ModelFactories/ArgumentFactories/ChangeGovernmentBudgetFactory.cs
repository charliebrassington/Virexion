using Domain.Models.Actions.InternalActionArguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelFactories.ArgumentFactories
{
    public class ChangeGovernmentBudgetFactory : IArgumentFactory<ChangeGovernmentBudgetArgument>
    {
        public ChangeGovernmentBudgetArgument CreateArgument(List<string> arguments)
        {
            return new();
        }
    }
}
