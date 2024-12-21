using Domain.Commands;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ActionRunnerService
{
    public interface IActionRunnerService
    {
        void StartRunner(CompleteActionCmd cmd, GameState gameState);
    }
}
