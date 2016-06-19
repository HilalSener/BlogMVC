using System.Data.Entity;
using BlogMVC.Core;

namespace BlogMVC.DataModel
{
    public class DataContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
   
    }
}
