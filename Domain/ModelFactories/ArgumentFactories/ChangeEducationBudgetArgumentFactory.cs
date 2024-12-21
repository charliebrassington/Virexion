using Domain.Models.Actions.InternalActionArguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelFactories.ArgumentFactories
{
    public class ChangeEducationBudgetArgumentFactory : IArgumentFactory<ChangeEducationBudgetArgument>
    {
        public ChangeEducationBudgetArgument CreateArgument(List<string> arguments)
        {
            return new()
            {
                TaxPercentageChange = float.Parse(arguments[0]),
                SalaryBracket = Convert.ToInt32(arguments[1]),
                Weight = float.Parse(arguments[2])
            };
        }
    }
}
