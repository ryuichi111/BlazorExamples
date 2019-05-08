using System;
using System.Collections.Generic;
using System.Linq;

using blazor_fluxor_todo_app.Shared;

namespace blazor_fluxor_todo_app.Client.Store {
  public class TodoState {
    public TodoItem[] TodoItems { get; private set; }

    public string ErrorMessage { get; private set; }

    public TodoState() {
      this.TodoItems = Array.Empty<TodoItem>();
      this.ErrorMessage = "";
    }

    public TodoState(IEnumerable<TodoItem> todoItems, string errorMessage) {
      this.TodoItems = todoItems?.ToArray() ?? Array.Empty<TodoItem>();
      this.ErrorMessage = errorMessage;
    }
  }
}