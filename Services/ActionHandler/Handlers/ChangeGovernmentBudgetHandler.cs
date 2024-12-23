using Domain.Commands;
using Domain.Models.Actions.ExternalActionArguments;
using Domain.Models;
using Services.CategoryService.TaxCategoryService;
using Services.ManagerService.ActionConnectionManagerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ModelFactories.ArgumentFactories;
using Services.ManagerService.CategoryManagerService.PeopleCategoryManager;
using Domain.Models.Actions.InternalActionArguments;

namespace Services.ActionHandler.Handlers
{
    public class ChangeGovernmentBudgetHandler
    (
        IPeopleCategoryManager peopleCategoryManager,
        IArgumentFactory<ChangeGovernmentBudgetArgument> factory,
        IConnectionManagerService connectionManagerService
    ) : AbstractActionHandler<ChangeGovernmentBudgetArgument>(factory, connectionManagerService)
    {
        public override string ActionName => "ChangeGovernmentBudget";

        private readonly IPeopleCategoryManager _peopleCategoryManager = peopleCategoryManager;

        public override List<CompleteActionCmd> HandleAction(GameState gameState, ChangeGovernmentBudgetArgument arguments)
        {
            gameState.Government.OverallBudget = _peopleCategoryManager.CalculateTotalTax(gameState);
            return GetConnectionActionList([gameState.Government.OverallBudget.ToString()]);
        }
    }
}