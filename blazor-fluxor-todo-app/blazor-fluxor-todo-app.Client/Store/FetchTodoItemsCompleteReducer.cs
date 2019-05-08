using Blazor.Fluxor;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class FetchTodoItemsCompleteReducer : Reducer<TodoState, FetchTodoItemsCompleteAction>
	{
		public override TodoState Reduce(TodoState state, FetchTodoItemsCompleteAction action)
		{
			return new TodoState(
				todoItems: action.TodoItems,
				errorMessage: ""
        );
		}
	}
}
