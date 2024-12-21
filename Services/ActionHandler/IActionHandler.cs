using Domain.Commands;
using Domain.Models;
using Domain.Models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ActionHandler
{
    public interface IActionHandler
    {
        string ActionName { get; }
        public List<CompleteActionCmd> Handle(GameState gameState, List<string> arguments);
    }
}
