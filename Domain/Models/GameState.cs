using Domain.Models.CategoryStatistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GameState
    {
        public required EducationStatistics EducationStatistics { get; set; }
        public required TaxStatistics TaxStatistics { get; set; }
    }
}
