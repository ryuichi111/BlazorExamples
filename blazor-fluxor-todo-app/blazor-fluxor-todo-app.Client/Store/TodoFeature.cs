using Blazor.Fluxor;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class TodoFeature : Feature<TodoState>
	{
		public override string GetName() => "Todo";
		protected override TodoState GetInitialState() => new TodoState();
	}
}