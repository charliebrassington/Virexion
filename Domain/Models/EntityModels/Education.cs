using Domain.Models.SupportingEntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.EntityModels
{
    public class Education : IEntityModel
    {
        public required List<string> SkillsTaught { get; set; }
        public required string TeacherJob { get; set; }
        public required float Budget { get; set; }
    }
}
