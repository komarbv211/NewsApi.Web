using Microsoft.EntityFrameworkCore;
using NewsApi.Core.Entities;
namespace NewsApi.Infrastructure.Context
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.SeedCategory();
            //modelBuilder.SeedNews();
        }

        public DbSet<Category> Categories { get; set; }
    }
}
