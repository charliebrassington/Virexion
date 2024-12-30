using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewHandler.ActionViewer
{
    public interface IExternalActionViewer
    {
        public Dictionary<string, List<string>> GetExternalActions();
    }
}
