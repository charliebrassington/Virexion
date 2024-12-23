using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Actions.ExternalActionArguments
{
    public class ChangeTaxBracketArgument : IActionArgument
    {
        public required int Salary { get; set; }
        public required float TaxPercentage { get; set; }
    }
}
