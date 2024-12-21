using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Actions.InternalActionArguments
{
    public class ChangeEducationBudgetArgument : BaseInternalActionArgument
    {
        public required float TaxPercentageChange { get; set; }
        public required float SalaryBracket {  get; set; }
    }
}
