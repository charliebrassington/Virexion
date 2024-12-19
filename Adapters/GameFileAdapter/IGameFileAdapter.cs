using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.GameFileAdapter
{
    public interface IGameFileAdapter
    {
        string FetchGameState();
    }
}
