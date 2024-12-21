using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Actions.InternalActionArguments
{
    public interface IInternalActionArgument : IActionArgument
    {
        public float Weight { get; set; }
    }
}
