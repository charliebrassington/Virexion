using Domain.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategoryService.TaxCategoryService
{
    public interface ITaxCategoryService : ICategoryService
    {
        public float GetTaxPercentageChange(Government government, int salary, float percentage);
        public float GetTaxPercentagePay(Government government, int salary);
    }
}
