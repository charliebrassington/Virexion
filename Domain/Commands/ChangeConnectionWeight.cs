using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public class ChangeConnectionWeight : BaseCommand
    {
        public required string ParentActionName { get; set; }
        public required string ChildActionName { get; set; }
        public required float NewWeight { get; set; }
    }
}
