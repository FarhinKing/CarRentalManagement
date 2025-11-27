using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 10, 11, 39, 206, DateTimeKind.Local).AddTicks(9799), new DateTime(2025, 11, 27, 10, 11, 39, 206, DateTimeKind.Local).AddTicks(9814), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 10, 11, 39, 206, DateTimeKind.Local).AddTicks(9817), new DateTime(2025, 11, 27, 10, 11, 39, 206, DateTimeKind.Local).AddTicks(9818), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(27), new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(28), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(31), new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(31), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(161), new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(162), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(164), new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(165), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(167), new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(168), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 11, 27, 10, 11, 39, 207, DateTimeKind.Local).AddTicks(170), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
