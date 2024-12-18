using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.CategoryStatistics
{
    public class TaxStatistics : ICategoryStatistics
    {
        public required Dictionary<int, float> TaxBracket {  get; set; }
    }
}
