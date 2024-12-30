using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.EntityModels
{
    public class Government : IEntityModel
    {
        public required Dictionary<int, float> TaxBracket {  get; set; }
        public required float OverallBudget { get; set; }
    }
}
