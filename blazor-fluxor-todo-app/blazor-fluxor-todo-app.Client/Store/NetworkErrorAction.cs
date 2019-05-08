using Blazor.Fluxor;

namespace blazor_fluxor_todo_app.Client.Store
{
	public class NetworkErrorAction : IAction
	{
    public readonly string Message;

    public NetworkErrorAction()
    {

    }

    public NetworkErrorAction(string message)
    {
      this.Message = message;
    }
	}
}
