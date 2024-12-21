using Domain.Models.CategoryStatistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategoryService.TaxCategoryService
{
    public interface ITaxCategoryService
    {
        public float GetTaxPercentageChange(TaxStatistics taxStatistics, int salary, float percentage);
    }
}
