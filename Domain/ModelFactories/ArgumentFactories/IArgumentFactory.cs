using Domain.Models.Actions;
using Domain.Models.Actions.ExternalActionArguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelFactories.ArgumentFactories
{
    public interface IArgumentFactory<T> where T : IActionArgument
    {
        public T CreateArgument(List<string> arguments);
    }
}
