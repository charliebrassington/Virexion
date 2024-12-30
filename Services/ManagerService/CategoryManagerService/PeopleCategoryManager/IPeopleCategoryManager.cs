
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ManagerService.CategoryManagerService.PeopleCategoryManager
{
    public interface IPeopleCategoryManager
    {
        public float CalculateTotalTax(GameState gameState);
    }
}
