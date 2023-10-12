using Microsoft.EntityFrameworkCore;
using soufianeBlog.Models;

namespace soufianeBlog.Data
{
    public class BlogContext: DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("Blog").HasData(
                               new Blog("My first blog", "This is my first blog", "Soufiane",
                               new System.DateTime(2020, 12, 12)));
        }   
    }
}
