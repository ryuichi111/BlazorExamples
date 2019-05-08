using Blazor.Fluxor;
using blazor_fluxor_todo_app.Shared;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class FetchTodoItemsCompleteAction : IAction
	{
		public readonly TodoItem[] TodoItems;

		public FetchTodoItemsCompleteAction(TodoItem[] todoItems)
		{
			this.TodoItems = todoItems;
		}
	}
}
