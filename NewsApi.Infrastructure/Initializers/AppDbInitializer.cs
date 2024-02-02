using Microsoft.EntityFrameworkCore;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Infrastructure.Initializers
{
    internal static class AppDbInitializer
    {
        public static async Task SeedCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
                {
                    new Category() { Id = 1, Name = "Sport" , Description = "Category about sport" },
                    new Category() { Id = 2, Name = "Cience" , Description = "Category about cience" }
                }
            );
        }
        public static async Task SeedAuthor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>().HasData(new Authors[]
                {
                    new Authors() { Id = 1, FullName = "Chij Vika" , Pseudonym = "Victory" },
                    new Authors() { Id = 2, FullName = "Goch Petro" , Pseudonym = "Piter" }
                }
            );
        }

    }
}
