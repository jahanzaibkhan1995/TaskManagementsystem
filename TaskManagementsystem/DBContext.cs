using System.Data.Entity;

namespace TaskManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=TaskManagementDb") { }

        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
    }
}

