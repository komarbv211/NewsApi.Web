using Microsoft.EntityFrameworkCore;
using NewsApi.Core.Entities;
using NewsApi.Infrastructure.Initializers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            modelBuilder.SeedNews();
            modelBuilder.SeedAuthor();
            modelBuilder.SeedStatistics();
            modelBuilder.SeedRole();
            modelBuilder.SeedUsers();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Authors> Author { get; set; }
        public DbSet<News> News { get; set; }

        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
