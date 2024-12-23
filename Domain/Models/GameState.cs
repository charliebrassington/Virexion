using Domain.Models.CategoryStatistics;
using Domain.Models.EntityModels;
using Domain.Models.SupportingEntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GameState
    {
        public required Government Government { get; set; }
        public required Education Education { get; set; }
        public required Dictionary<string, Person> People { get; set; }
        public required Dictionary<string, Job> Jobs { get; set; }
        public required Dictionary<string, Skill> Skills { get; set; }
    }
}
