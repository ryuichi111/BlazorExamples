using Blazor.Fluxor;
using blazor_fluxor_todo_app.Shared;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class AddTodoItemCompleteAction : IAction
	{
		public readonly TodoItem TodoItem;

		public AddTodoItemCompleteAction(TodoItem todoItem)
		{
			this.TodoItem = todoItem;
		}
	}
}
