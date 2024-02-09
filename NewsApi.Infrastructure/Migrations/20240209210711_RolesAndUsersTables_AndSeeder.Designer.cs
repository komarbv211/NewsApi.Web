﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsApi.Infrastructure.Context;

#nullable disable

namespace NewsApi.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240209210711_RolesAndUsersTables_AndSeeder")]
    partial class RolesAndUsersTables_AndSeeder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewsApi.Core.Entities.Authors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudonym")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Chij Vika",
                            Pseudonym = "Victory"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Goch Petro",
                            Pseudonym = "Piter"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Category about sport",
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Category about cience",
                            Name = "Cience"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorsId = 2,
                            CategoryId = 1,
                            Description = "Український боксер надважкої ваги Олександр Усик 29 січня вчетверте став батьком. Його дружина Катерина в одному з пологових будинків Києва народила дівчинку.\r\n\r\nПро це у своєму Youtube-каналі повідомив шоумен та ведучий Слава Дьомін.",
                            FullText = "Український боксер надважкої ваги Олександр Усик 29 січня вчетверте став батьком. Його дружина Катерина в одному з пологових будинків Києва народила дівчинку.\r\n\r\nПро це у своєму Youtube-каналі повідомив шоумен та ведучий Слава Дьомін.\r\n\r\nНовонароджена донька Олександра важить п'ять кілограмів і має 58 сантиметрів зросту. Дівчинці вже дали ім'я — Марія.\r\n\r\nВарто зазначити, що в Олександра і Катерини вже є троє дітей: дочка Єлизавета та сини Михайло і Кирило.\r\n\r\nЦікаво, що 17 лютого відбудеться бій за звання абсолютного чемпіона світу Усик — Ф’юрі. Поєдинок пройде в Саудівській Аравії.,",
                            Title = "У родині Усиків поповнення: український боксер вчетверте став батьком"
                        },
                        new
                        {
                            Id = 2,
                            AuthorsId = 1,
                            CategoryId = 2,
                            Description = "Під час обідньої перерви у космосі варто утриматися від салату. До такого висновку дійшли дослідники Делаверського університету в США. Вчені виростили різні овочі в умовах мікрогравітації на Землі та виявили, що салати важко борються зі шкідливими бактеріями в космічному середовищі.",
                            FullText = "Салат на Міжнародній космічній станції (МКС) — це справжній хіт. Астронавти вирощують овочі у межах різних експериментів, причому частину врожаю вони навіть споживають, що є здоровою альтернативою сублімованим та консервованим продуктам. Проте результати нових досліджень доводять, що рослини, вирощені в умовах мікрогравітації, більш вразливі до інфекцій, таких як кишкова паличка чи сальмонела.\r\n\r\nУ науковій статті, що з’явилася в Scientific Reports, рослини вирощували у пристрої, який їх обертав, і виявили, що в умовах мікрогравітації їхній природний захист ставав менш ефективним. Рослини втрачають орієнтацію в гравітації, що впливає на їхній розвиток і, як наслідок, на реакцію на стрес.",
                            Title = "Вирощені на орбіті овочі становлять небезпеку для здоров’я астронавтів"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Redactor"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Writer"
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Statistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VisitTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Statistics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IpAddress = "192.168.0.1",
                            NewsId = 1,
                            VisitTime = new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8440)
                        },
                        new
                        {
                            Id = 2,
                            IpAddress = "192.168.0.2",
                            NewsId = 1,
                            VisitTime = new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8520)
                        },
                        new
                        {
                            Id = 3,
                            IpAddress = "192.168.0.3",
                            NewsId = 1,
                            VisitTime = new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8524)
                        },
                        new
                        {
                            Id = 4,
                            IpAddress = "192.168.0.4",
                            NewsId = 2,
                            VisitTime = new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8527)
                        },
                        new
                        {
                            Id = 5,
                            IpAddress = "192.168.0.5",
                            NewsId = 2,
                            VisitTime = new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8530)
                        });
                });

            modelBuilder.Entity("NewsApi.Core.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            Email = "john@example.com",
                            FullName = "John Doe",
                            PhoneNumber = "123456789",
                            RolesId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak St",
                            Email = "jane@example.com",
                            FullName = "Jane Smith",
                            PhoneNumber = "987654321",
                            RolesId = 2
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Elm St",
                            Email = "alice@example.com",
                            FullName = "Alice Johnson",
                            PhoneNumber = "555666777",
                            RolesId = 3
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Pine St",
                            Email = "bob@example.com",
                            FullName = "Bob Anderson",
                            PhoneNumber = "111222333",
                            RolesId = 2
                        },
                        new
                        {
                            Id = 5,
                            Address = "202 Maple St",
                            Email = "eva@example.com",
                            FullName = "Eva Davis",
                            PhoneNumber = "999888777",
                            RolesId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
