using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Actions.ExternalActionArguments
{
    public class ChangeTaxBracketArgument : IActionArgument
    {
        public int Salary { get; set; }
        public float TaxPercentage { get; set; }
    }
}
