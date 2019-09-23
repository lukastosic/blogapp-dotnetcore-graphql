using Microsoft.EntityFrameworkCore;

namespace BlogApp.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }       

        public DbSet<Person> People { get; set; }        
    }
}
