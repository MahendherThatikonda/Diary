using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went Hiking with Joe", new DateTime(2025, 11, 29, 18, 2, 33, 524, DateTimeKind.Local).AddTicks(9698), "Went to Hiking" },
                    { 2, "Went Hiking with Moe", new DateTime(2025, 11, 29, 18, 2, 33, 525, DateTimeKind.Local).AddTicks(47), "Came Back to Hiking" },
                    { 3, "Went Diving with Moe", new DateTime(2025, 11, 29, 18, 2, 33, 525, DateTimeKind.Local).AddTicks(52), "Came Back to Hiking" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
