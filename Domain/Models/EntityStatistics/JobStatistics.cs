using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.EntityStatistics
{
    public class JobStatistics : IEntityStatistics
    {
        public required float Salary { get; set; }
        public required int Workload { get; set; }
        public required List<SkillsEntity> SkillsRequired { get; set; }
        public required int Quality { get; set; }
        public required int Supply { get; set; }
        public required int Demand { get; set; }
    }
}
