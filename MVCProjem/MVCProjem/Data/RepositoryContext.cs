using Microsoft.EntityFrameworkCore;
using MVCProjem.Data.Config;
using MVCProjem.Models;

namespace MVCProjem.Data
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
        }
    }
}
