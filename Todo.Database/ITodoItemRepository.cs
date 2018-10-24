using System.Collections.Generic;
using System.Threading.Tasks;
using Todo.Database.Models;

namespace Todo.Database
{
    public interface ITodoItemRepository
    {
        Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync();
        Task<TodoItem> GetTodoItemByIdAsync(long todoId);
        Task CreateTodoItemAsync(TodoItem todoItem);
        Task UpdateTodoItemAsync(TodoItem dbTodoItem, TodoItem todoItem);
        Task DeleteTodoItemAsync(TodoItem todoItem);
    }
}