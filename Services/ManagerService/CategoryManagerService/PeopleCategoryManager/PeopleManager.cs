using Domain.Models;
using Domain.Models.EntityModels;
using Newtonsoft.Json.Linq;
using Services.CategoryService.PeopleCategoryService;
using Services.CategoryService.TaxCategoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManagerService.CategoryManagerService.PeopleCategoryManager
{
    public class PeopleManager(
        IPeopleCategoryService peopleCategoryService, ITaxCategoryService taxCategoryService
    ) : IPeopleCategoryManager
    {
        private readonly IPeopleCategoryService _peopleCategoryService = peopleCategoryService;
        private readonly ITaxCategoryService _taxCategoryService = taxCategoryService;

        public float CalculateTotalTax(GameState gameState)
        {
            return gameState.People.Values.ToList()
                .Select(person => _peopleCategoryService.GetTotalSalary(person, gameState.Jobs))
                .Select(salary => salary * _taxCategoryService.GetTaxPercentagePay(gameState.Government, salary))
                .Sum();
        }
    }
}
