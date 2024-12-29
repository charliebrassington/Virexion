using Domain.Models.SupportingEntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.EntityModels
{
    public class Job : IEntityModel
    {
        public required float Salary { get; set; }
        public required float Workload { get; set; }
        public required List<string> SkillsRequired { get; set; }
        public required int VacancyCount { get; set; }
        public required float WorkQuality { get; set; }
    }
}