using Adapters.JsonFileAdapter;
using Domain.Errors;
using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ActionConnectionService
{
    public class ConnectionService(IJsonFileAdapter actionConnectionAdapter) : IActionConnectionService
    {

        private readonly IJsonFileAdapter _actionConnectionAdapter = actionConnectionAdapter;

        public List<RelationshipConnection> GetActionConnections()
        {
            string jsonData = _actionConnectionAdapter.FetchJsonData("connections");
            List<RelationshipConnection>? connectionList = JsonConvert.DeserializeObject<List<RelationshipConnection>>(jsonData);

            return connectionList ?? throw new InvalidActionConnectionData();
        }
    }
}
