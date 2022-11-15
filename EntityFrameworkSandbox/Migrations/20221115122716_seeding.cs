using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkSandbox.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Name", "Origin" },
                values: new object[] { new Guid("b559d96b-cd55-4bde-8814-225e815828bc"), "Spaghetti", "Italy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: new Guid("b559d96b-cd55-4bde-8814-225e815828bc"));
        }
    }
}
