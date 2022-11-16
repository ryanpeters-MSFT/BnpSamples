using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class adddescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Dogs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Daisy is a cute dog with short black hair and loves people.");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Large dog with big feet. Loves to chew shoes.");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Great at playing fetch!");

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Big girl who loves the couch. Needs lots of space to play. Loves eating socks and tennis balls.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Dogs");
        }
    }
}
