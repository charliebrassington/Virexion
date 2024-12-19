using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ActionHandler
{
    public interface IActionHandler
    {
        void Handle(List<string> arguments);
    }
}
