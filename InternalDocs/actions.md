# Actions
- The are two types of actions, internal and external actions. Internal actions are actions within the application not shown to the user. Whereas, external actions are actions shown to the user and the user can interact with such actions.

## How to add a new action
1. If it's an eternal action you'll need to update the ExternalActionsEnum if not skip
2. Create an action argument model for the action
3. Create the argument factory for the model just created
4. Create the action handler for the action
5. Add the dependencies as singletons in the entrypoint
6. Edit the connections.json if the action also leads to other actions

