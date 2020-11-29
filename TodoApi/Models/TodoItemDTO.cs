using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    /// <summary>
    /// DTO for the <see cref="TodoItem"/> model.
    /// </summary>
    public class TodoItemDTO
    {
        public TodoItemDTO()
        {
        }
        public TodoItemDTO(TodoItem todoItem)
        {
            Id = todoItem.Id;
            Name = todoItem.Name;
            IsComplete = todoItem.IsComplete;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { set; get; }
        public TodoItem getTodoItem()
        {
            var todoItem = new TodoItem();
            todoItem.Id = Id;
            todoItem.Name = Name;
            todoItem.IsComplete = IsComplete;
            return todoItem;
        }
    }
}
