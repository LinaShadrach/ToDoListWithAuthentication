
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace ToDoList.Models
{
    public class ToDoListDbContext : IdentityDbContext<AppUser>
    {
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=todolist;uid=root;pwd=root;");
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options)
        {
        }

        public ToDoListDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

