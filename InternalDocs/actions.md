# Actions
- This doc will explain what actions are and guide you through the steps needed to add your own action or edit an action
- The are two types of actions, internal and external actions. Internal actions are actions within the application not shown to the user. Whereas, external actions are actions shown to the user and the user can interact with such actions.
- Some action handlers will require abstractions

## How to add a new action
1. If it's an external action you'll need to update the ExternalActionsEnum if not skip
2. Create an action argument model for the action
3. Create the argument factory for the model just created
4. Create the action handler for the action
5. Add the dependencies as singletons in the entrypoint
6. Edit the connections.json if the action also leads to other actions

## When an action handler requires abstraction
1. The action handler breaks single responsibility principle, starts do more than one thing
2. The action handler function inside the class starts to contain large amounts of code
3. The action handler function is starting to become unreadable
