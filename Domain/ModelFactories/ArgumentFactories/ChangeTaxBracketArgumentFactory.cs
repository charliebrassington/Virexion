using Domain.Models.Actions.ExternalActionArguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelFactories.ArgumentFactories
{
    public class ChangeTaxBracketArgumentFactory : IArgumentFactory<ChangeTaxBracketArgument>
    {
        public ChangeTaxBracketArgument CreateArgument(List<string> arguments)
        {
            return new()
            {
                Salary = Convert.ToInt32(arguments[0]),
                TaxPercentage = float.Parse(arguments[1])
            };
        }
    }
}
