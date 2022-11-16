using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkSandbox.Migrations
{
    /// <inheritdoc />
    public partial class adjustfoodseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b559d96b-cd55-4bde-8814-225e815828bc"),
                columns: new[] { "Name", "Origin" },
                values: new object[] { "Cheese Cake", "Greece" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Name", "Origin" },
                values: new object[,]
                {
                    { new Guid("64d22bfd-0e55-487b-87fb-f96ce0cb7c1b"), "French Fries", "Belgium" },
                    { new Guid("b30085f2-522e-4200-885d-b662af6151c6"), "Sushi", "Asia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("64d22bfd-0e55-487b-87fb-f96ce0cb7c1b"));

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b30085f2-522e-4200-885d-b662af6151c6"));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b559d96b-cd55-4bde-8814-225e815828bc"),
                columns: new[] { "Name", "Origin" },
                values: new object[] { "Spaghetti", "Italy" });
        }
    }
}
