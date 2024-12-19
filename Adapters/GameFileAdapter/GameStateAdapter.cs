using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.GameFileAdapter
{
    public class GameStateAdapter : IGameFileAdapter
    {
        private readonly string _path = Directory.GetCurrentDirectory().Replace("Entrypoint", "DataStore\\data.json");

        public string FetchGameState()
        {
            return File.ReadAllText(_path);
        }
    }
}
