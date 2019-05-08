using System.Collections.Generic;

using Blazor.Fluxor;

using blazor_fluxor_todo_app.Shared;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class NetworkErrorReducer : Reducer<TodoState, NetworkErrorAction>
	{
		public override TodoState Reduce(TodoState state, NetworkErrorAction action)
		{
			return new TodoState(
				todoItems: state.TodoItems,
        errorMessage: action.Message
        );
		}
	}
}
