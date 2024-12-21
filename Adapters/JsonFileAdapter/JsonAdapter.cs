using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.JsonFileAdapter
{
    public class JsonAdapter : IJsonFileAdapter
    {

        public string CreateFilePath(string fileName)
        {
            return Directory.GetCurrentDirectory().Replace("Entrypoint", $"DataStore\\{fileName}.json");
        }

        public string FetchJsonData(string fileName)
        {
            return File.ReadAllText(CreateFilePath(fileName));
        }

        public void SaveNewJsonData(string fileName, string data)
        {
            File.WriteAllText(CreateFilePath(fileName), data);
        }
    }
}
