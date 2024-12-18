using Domain.Models.EntityStatistics;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Models.CategoryStatistics
{
    public class EducationStatistics : ICategoryStatistics
    {
        public required JobStatistics TeachersStatistics {  get; set; }
        public required List<SkillsEntity> SkillsTaught { get; set; }
        public required bool IsFree { get; set; }
        public required int Budget { get; set; }
    }
}
