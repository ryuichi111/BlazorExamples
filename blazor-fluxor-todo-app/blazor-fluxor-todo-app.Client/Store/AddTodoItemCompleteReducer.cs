using System.Collections.Generic;

using Blazor.Fluxor;

using blazor_fluxor_todo_app.Shared;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class AddTodoItemCompleteReducer : Reducer<TodoState, AddTodoItemCompleteAction>
	{
		public override TodoState Reduce(TodoState state, AddTodoItemCompleteAction action)
		{
      List<TodoItem> newTodoItems = new List<TodoItem>();
      foreach(var todoItem in state.TodoItems)
      {
        newTodoItems.Add(new TodoItem() { ID = todoItem.ID, Title = todoItem.Title, Priority = todoItem.Priority } );
      }
      newTodoItems.Add(action.TodoItem);

			return new TodoState(
				todoItems: newTodoItems,
				errorMessage: ""
        );
		}
	}
}
