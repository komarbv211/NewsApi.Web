using Microsoft.EntityFrameworkCore;
using NewsApi.Core.Entities;
using NewsApi.Infrastructure.Initializers;
namespace NewsApi.Infrastructure.Context
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedCategory();
            modelBuilder.SeedAuthor();
            modelBuilder.SeedNews();
            modelBuilder.SeedStatistics();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
    }
}
