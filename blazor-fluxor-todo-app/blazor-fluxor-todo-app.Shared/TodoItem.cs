namespace blazor_fluxor_todo_app.Shared {
  public enum Priority
  {
    High,
    Normal,
    Low
  }

  public class TodoItem {
    public int ID { get; set; }
    public Priority Priority { get; set; }
    public string Title { get; set; }
  }
}