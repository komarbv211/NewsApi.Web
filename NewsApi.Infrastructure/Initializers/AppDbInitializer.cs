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
        public static async Task SeedNews(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasData(new News[]
                {
                    new News() { Id = 1, Title = "У родині Усиків поповнення: український боксер вчетверте став батьком" ,
                        Description = "Український боксер надважкої ваги Олександр Усик 29 січня вчетверте став батьком." +
                        " Його дружина Катерина в одному з пологових будинків Києва народила дівчинку.\r\n\r\nПро це у своєму Youtube-каналі повідомив шоумен та ведучий Слава Дьомін.",
                    FullText = "Український боксер надважкої ваги Олександр Усик 29 січня вчетверте став батьком. Його дружина Катерина в одному з пологових будинків Києва народила дівчинку.\r\n\r\nПро це у своєму Youtube-каналі повідомив шоумен та ведучий Слава Дьомін.\r\n\r\nНовонароджена донька Олександра важить п'ять кілограмів і має 58 сантиметрів зросту. Дівчинці вже дали ім'я — Марія.\r\n\r\nВарто зазначити, що в Олександра і Катерини вже є троє дітей: дочка Єлизавета та сини Михайло і Кирило.\r\n\r\nЦікаво, що 17 лютого відбудеться бій за звання абсолютного чемпіона світу Усик — Ф’юрі. Поєдинок пройде в Саудівській Аравії.,",
                    CategoryId = 1, AuthorsId = 2
                    },
                    new News() { Id = 2, Title = "Вирощені на орбіті овочі становлять небезпеку для здоров’я астронавтів" ,
                        Description = "Під час обідньої перерви у космосі варто утриматися від салату. До такого висновку дійшли дослідники Делаверського університету в США. Вчені виростили різні овочі в умовах мікрогравітації на Землі та виявили, що салати важко борються зі шкідливими бактеріями в космічному середовищі.",
                    FullText = "Салат на Міжнародній космічній станції (МКС) — це справжній хіт. Астронавти вирощують овочі у межах різних експериментів, причому частину врожаю вони навіть споживають, що є здоровою альтернативою сублімованим та консервованим продуктам. Проте результати нових досліджень доводять, що рослини, вирощені в умовах мікрогравітації, більш вразливі до інфекцій, таких як кишкова паличка чи сальмонела.\r\n\r\nУ науковій статті, що з’явилася в Scientific Reports, рослини вирощували у пристрої, який їх обертав, і виявили, що в умовах мікрогравітації їхній природний захист ставав менш ефективним. Рослини втрачають орієнтацію в гравітації, що впливає на їхній розвиток і, як наслідок, на реакцію на стрес.",
                    CategoryId = 2, AuthorsId = 1
                    },
                }
            );
        }
        public static async Task SeedStatistics(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Statistics>().HasData(new Statistics[]
                {
            new Statistics() { Id = 1, VisitTime = DateTime.Now, NewsId = 1, IpAddress = "192.168.0.1" },
            new Statistics() { Id = 2, VisitTime = DateTime.Now, NewsId = 1, IpAddress = "192.168.0.2" },
            new Statistics() { Id = 3, VisitTime = DateTime.Now, NewsId = 1, IpAddress = "192.168.0.3" },
            new Statistics() { Id = 4, VisitTime = DateTime.Now, NewsId = 2, IpAddress = "192.168.0.4" },
            new Statistics() { Id = 5, VisitTime = DateTime.Now, NewsId = 2, IpAddress = "192.168.0.5" }
                }
            );
        }
        public static async Task SeedRole(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Roles>().HasData(new Roles[]
                {
                    new Roles() { Id = 1, Name = "Admin"  },
                    new Roles() { Id = 2, Name = "Redactor" },
                    new Roles() { Id = 3, Name = "Writer" }
                }
            );
        }
        public static async Task SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(new Users[]
                {
            new Users() { Id = 1, FullName = "John Doe", Email = "john@example.com", PhoneNumber = "123456789", Address = "123 Main St", RolesId = 1 },
            new Users() { Id = 2, FullName = "Jane Smith", Email = "jane@example.com", PhoneNumber = "987654321", Address = "456 Oak St", RolesId = 2 },
            new Users() { Id = 3, FullName = "Alice Johnson", Email = "alice@example.com", PhoneNumber = "555666777", Address = "789 Elm St", RolesId = 3 },
            new Users() { Id = 4, FullName = "Bob Anderson", Email = "bob@example.com", PhoneNumber = "111222333", Address = "101 Pine St", RolesId = 2 },
            new Users() { Id = 5, FullName = "Eva Davis", Email = "eva@example.com", PhoneNumber = "999888777", Address = "202 Maple St", RolesId = 1 }
                }
            );
        }


    }
}
