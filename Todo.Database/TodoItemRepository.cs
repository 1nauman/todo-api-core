using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Database.Models;

namespace Todo.Database
{
    public class TodoItemRepository : RepositoryBase<TodoItem>, ITodoItemRepository
    {
        public TodoItemRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync()
        {
            var todoItems = await FindAllAsync();
            return todoItems.OrderBy(o => o.Name);
        }

        public async Task<TodoItem> GetTodoItemByIdAsync(long todoId)
        {
            var todoItem = await FindByConditionAsync(o => o.Id.Equals(todoId));
            return todoItem.DefaultIfEmpty(new TodoItem()).FirstOrDefault();
        }

        public async Task CreateTodoItemAsync(TodoItem todoItem)
        {
            Create(todoItem);
            await SaveAsync();
        }

        public async Task UpdateTodoItemAsync(TodoItem dbTodoItem, TodoItem todoItem)
        {
            Update(todoItem);
            await SaveAsync();
        }

        public async Task DeleteTodoItemAsync(TodoItem todoItem)
        {
            Delete(todoItem);
            await SaveAsync();
        }
    }
}