using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.JsonFileAdapter
{
    public interface IJsonFileAdapter
    {
        public string FetchJsonData(string fileName);

        public void SaveNewJsonData(string fileName, object data);

        public string CreateFilePath(string fileName);
    }
}
