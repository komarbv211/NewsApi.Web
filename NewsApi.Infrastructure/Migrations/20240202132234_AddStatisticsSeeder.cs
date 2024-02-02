using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewsApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStatisticsSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "IpAddress", "NewsId", "VisitTime" },
                values: new object[,]
                {
                    { 1, "192.168.0.1", 1, new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1120) },
                    { 2, "192.168.0.2", 1, new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1197) },
                    { 3, "192.168.0.3", 1, new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1200) },
                    { 4, "192.168.0.4", 2, new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1203) },
                    { 5, "192.168.0.5", 2, new DateTime(2024, 2, 2, 15, 22, 33, 588, DateTimeKind.Local).AddTicks(1207) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
