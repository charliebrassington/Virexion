using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.SupportingEntityModels
{
    public class Skill : IEntityModel
    {
        public required string SkillName { get; set; }
    }
}
