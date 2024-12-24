using Domain.Models.SupportingEntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.EntityModels
{
    public class Person : IEntityModel
    {
        public required string Name { get; set; }
        public required int Age { get; set; }
        public required List<string> SkillsList { get; set; }
        public required List<string> JobList { get; set; }
    }
}
