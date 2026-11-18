using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ForumAppDbContext : DbContext 
    {
        public ForumAppDbContext()
        {
            
        }

        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
