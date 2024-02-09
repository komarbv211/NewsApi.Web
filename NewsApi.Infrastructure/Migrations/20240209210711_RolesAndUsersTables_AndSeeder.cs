using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewsApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RolesAndUsersTables_AndSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Redactor" },
                    { 3, "Writer" }
                });

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitTime",
                value: new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitTime",
                value: new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitTime",
                value: new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "VisitTime",
                value: new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "VisitTime",
                value: new DateTime(2024, 2, 9, 23, 7, 10, 235, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "FullName", "PhoneNumber", "RolesId" },
                values: new object[,]
                {
                    { 1, "123 Main St", "john@example.com", "John Doe", "123456789", 1 },
                    { 2, "456 Oak St", "jane@example.com", "Jane Smith", "987654321", 2 },
                    { 3, "789 Elm St", "alice@example.com", "Alice Johnson", "555666777", 3 },
                    { 4, "101 Pine St", "bob@example.com", "Bob Anderson", "111222333", 2 },
                    { 5, "202 Maple St", "eva@example.com", "Eva Davis", "999888777", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitTime",
                value: new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitTime",
                value: new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitTime",
                value: new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "VisitTime",
                value: new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "VisitTime",
                value: new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1207));
        }
    }
}
