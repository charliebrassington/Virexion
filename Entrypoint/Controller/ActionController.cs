using Domain.Commands;
using Domain.Models.Actions;
using Microsoft.AspNetCore.Mvc;
using Services.CommandHandler;
using Services.ViewHandler.ActionViewer;
using System.Linq;

namespace Entrypoint.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ActionController(
        ICommandHandler<CompleteActionCmd> actionServiceHandler, IExternalActionViewer externalActionViewer
    ) : ControllerBase
    {
        private readonly ICommandHandler<CompleteActionCmd> _actionServiceHandler = actionServiceHandler;
        private readonly Dictionary<string, List<string>> _actions = externalActionViewer.GetExternalActions();

        [HttpGet(Name = "ViewActions")]
        public Dictionary<string, List<string>> ViewExternalActions()
        {
            return _actions;
        }

        [HttpPost(Name = "CompleteAction")]
        public void CompleteExternalAction([FromBody] CompleteActionCmd actionCmd)
        {
            if (!_actions.TryGetValue(actionCmd.ActionName, out List<string>? value) || value.Count != actionCmd.Arguments.Count) 
            {
                return;
            }

            _actionServiceHandler.HandleCommand(actionCmd);
        }
    }
}
