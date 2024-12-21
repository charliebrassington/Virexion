using Domain.Commands;
using Domain.ModelFactories.ArgumentFactories;
using Domain.Models;
using Domain.Models.Actions;
using Domain.Models.Actions.ExternalActionArguments;
using Services.CategoryService.TaxCategoryService;
using Services.ManagerService.ActionConnectionManagerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ActionHandler.Handlers
{
    public class ChangeTaxBracketHandler(
        ITaxCategoryService taxCategoryService,
        IArgumentFactory<ChangeTaxBracketArgument> factory,
        IConnectionManagerService connectionManagerService
    ) : AbstractActionHandler<ChangeTaxBracketArgument>(factory, connectionManagerService)
    {
        public override string ActionName => "ChangeTaxBracket";

        private readonly ITaxCategoryService _taxCategoryService = taxCategoryService;

        public override List<CompleteActionCmd> HandleAction(GameState gameState, ChangeTaxBracketArgument arguments)
        {
            float change = _taxCategoryService.GetTaxPercentageChange(gameState.TaxStatistics, arguments.Salary, arguments.TaxPercentage);

            gameState.TaxStatistics.TaxBracket[arguments.Salary] = arguments.TaxPercentage;

            return GetConnectionActionList([change.ToString(), arguments.Salary.ToString()]);
        }
    }
}
