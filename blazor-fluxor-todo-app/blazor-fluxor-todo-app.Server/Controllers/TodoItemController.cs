using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using blazor_fluxor_todo_app.Shared;

namespace blazor_fluxor_todo_app.Server.Controllers
{
    [Route("api/[controller]")]
    public class TodoItemController : Controller
    {
        private static List<TodoItem> _TodoItems = new List<TodoItem>();

        static TodoItemController()
        {
          _TodoItems.Add(new TodoItem() { ID = 1, Title = "Blazorを調べる", Priority = Priority.High } );
          _TodoItems.Add(new TodoItem() { ID = 2, Title = "ASP.NET Coreで遊ぶ", Priority = Priority.Normal } );
          _TodoItems.Add(new TodoItem() { ID = 3, Title = "flutterでもふもふする", Priority = Priority.Normal } );
          _TodoItems.Add(new TodoItem() { ID = 4, Title = ".NET Framework 3を葬る", Priority = Priority.Low } );
          _TodoItems.Add(new TodoItem() { ID = 5, Title = "Durable Functionsする", Priority = Priority.Normal } );
        }

        [HttpGet("")]
        public IEnumerable<TodoItem> AllTodoItems()
        {
            return _TodoItems;
        }

        [HttpPost]
        public TodoItem AddTodoItem([FromBody] TodoItem todoItem)
        {
            todoItem.ID = _TodoItems.Count + 1;
            _TodoItems.Add(todoItem);
            return todoItem;
        }
    }
}
