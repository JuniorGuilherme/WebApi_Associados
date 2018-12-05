using Microsoft.EntityFrameworkCore;
using ToDoList.Domain;

namespace ToDoList.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {}

        public DbSet<User> Users { get; set; }
    }
}