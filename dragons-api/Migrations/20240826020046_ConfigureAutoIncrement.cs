using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DragonsAPI.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureAutoIncrement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Targaryen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "House Targaryen");
        }
    }
}
