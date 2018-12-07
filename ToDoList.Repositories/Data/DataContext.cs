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
        public DbSet<Associated> Associated { get; set; }
        public DbSet<Dependente> Dependente { get; set; }
    }
}