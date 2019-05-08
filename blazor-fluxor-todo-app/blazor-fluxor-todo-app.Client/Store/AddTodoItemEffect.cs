using Blazor.Fluxor;
using blazor_fluxor_todo_app.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class AddTodoItemEffect : Effect<AddTodoItemAction>
	{
		private readonly HttpClient HttpClient;

		public AddTodoItemEffect(HttpClient httpClient)
		{
			HttpClient = httpClient;
		}

		protected async override Task HandleAsync(AddTodoItemAction action, IDispatcher dispatcher)
		{
			TodoItem todoItem = new TodoItem() { Title = action.Title, Priority = action.Priority };
			try
			{
				todoItem = await HttpClient.PostJsonAsync<TodoItem>("api/todoitem", todoItem);
			}
			catch
			{
				dispatcher.Dispatch(new NetworkErrorAction("通信エラーが発生しました"));
				return;
			}
			var completeAction = new AddTodoItemCompleteAction(todoItem);
			dispatcher.Dispatch(completeAction);
		}
	}
}
