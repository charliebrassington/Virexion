using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommandHandler
{
    public interface ICommandHandler<T> where T : BaseCommand
    {
        public void HandleCommand(T cmd);
    }
}
