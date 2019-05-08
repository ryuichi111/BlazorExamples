using Blazor.Fluxor;
using blazor_fluxor_todo_app.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class FetchTodoItemsEffect : Effect<FetchTodoItemsAction>
	{
		private readonly HttpClient HttpClient;

		public FetchTodoItemsEffect(HttpClient httpClient)
		{
			HttpClient = httpClient;
		}

		protected async override Task HandleAsync(FetchTodoItemsAction action, IDispatcher dispatcher)
		{
			TodoItem[] todoItems = Array.Empty<TodoItem>();
			try
			{
				todoItems = await HttpClient.GetJsonAsync<TodoItem[]>("api/todoitem");
			}
			catch
			{
				dispatcher.Dispatch(new NetworkErrorAction("通信エラーが発生しました"));
				return;
			}
			var completeAction = new FetchTodoItemsCompleteAction(todoItems);
			dispatcher.Dispatch(completeAction);
		}
	}
}
