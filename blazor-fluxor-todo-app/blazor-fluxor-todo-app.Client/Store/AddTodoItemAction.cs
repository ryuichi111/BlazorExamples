using Blazor.Fluxor;
using blazor_fluxor_todo_app.Shared;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class AddTodoItemAction : IAction
	{
    public readonly string Title;
    public readonly Priority Priority = Priority.Normal;

    public AddTodoItemAction() 
    {

    }
    public AddTodoItemAction(string title, Priority priority)
    {
      this.Title = title;
      this.Priority = priority;
    }
	}
}
