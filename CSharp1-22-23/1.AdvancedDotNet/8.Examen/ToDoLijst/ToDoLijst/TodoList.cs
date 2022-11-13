using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLijst
{
    public class TodoList<T> where T : TodoItem
    {
        public List<T> Todos { get; set; }
        public TodoList()
        {
            Todos = new List<T>();
        }

        internal void AddTodo(T todo)
        {
            Todos.Add(todo);
        }
    }
}
