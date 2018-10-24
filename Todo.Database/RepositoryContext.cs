using Microsoft.EntityFrameworkCore;
using Todo.Database.Models;

namespace Todo.Database
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
