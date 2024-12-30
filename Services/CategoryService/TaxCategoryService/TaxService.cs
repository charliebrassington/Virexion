using Domain.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategoryService.TaxCategoryService
{
    public class TaxService : ITaxCategoryService
    {
        public float GetTaxPercentageChange(Government government, int salary, float percentage)
        {
            return percentage - government.TaxBracket.GetValueOrDefault(salary, 0);
        }

        public float GetTaxPercentagePay(Government government, int salary)
        {
            return government.TaxBracket.MaxBy(pair => salary >= pair.Key).Value;
        }
    }
}
