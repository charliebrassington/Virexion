using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommandHandler
{
    public abstract class AbstractCommandHandler<T> where T : BaseCommand
    {
        public abstract void HandleCommand(T cmd);
    }
}
