using Domain.Commands;
using Domain.Models;
using Services.CategoryService.TaxCategoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ModelFactories.ArgumentFactories;
using Services.ManagerService.ActionConnectionManagerService;
using Domain.Models.Actions.InternalActionArguments;

namespace Services.ActionHandler.Handlers
{
    public class ChangeEducationBudgetHandler(
        IArgumentFactory<ChangeEducationBudgetArgument> factory,
        IConnectionManagerService connectionManagerService
    ) : AbstractActionHandler<ChangeEducationBudgetArgument>(factory, connectionManagerService)
    {
        public override string ActionName => "ChangeEducationBudget";

        public override List<CompleteActionCmd> HandleAction(GameState gameState, ChangeEducationBudgetArgument arguments)
        {
            Console.WriteLine("Handling change education budget");
            return [];
        }
    }
}
