using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DragonsAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dragons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Size = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Temperament = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DateOfDeath = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dragons", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_houses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "riders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DateOfDeath = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_riders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_riders_houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dragon_riders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RiderId = table.Column<int>(type: "int", nullable: false),
                    DragonId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsCurrent = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dragon_riders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dragon_riders_dragons_DragonId",
                        column: x => x.DragonId,
                        principalTable: "dragons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dragon_riders_riders_RiderId",
                        column: x => x.RiderId,
                        principalTable: "riders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "dragons",
                columns: new[] { "Id", "Color", "DateOfBirth", "DateOfDeath", "Height", "Name", "Size", "Status", "Temperament", "Weight" },
                values: new object[,]
                {
                    { 1, "Black", null, null, 25m, "Balerion", "Gigantic", "Dead", "Aggressive", 7000m },
                    { 2, "Green", null, null, 23m, "Vhagar", "Large", "Alive", "Fierce", 6000m },
                    { 3, "Silver", null, null, 22m, "Meraxes", "Large", "Dead", "Calm", 5000m }
                });

            migrationBuilder.InsertData(
                table: "houses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "House Targaryen" });

            migrationBuilder.InsertData(
                table: "riders",
                columns: new[] { "Id", "DateOfBirth", "DateOfDeath", "HouseId", "Name", "Status" },
                values: new object[,]
                {
                    { 1, null, null, 1, "Aegon I Targaryen", "Dead" },
                    { 2, null, null, 1, "Visenya Targaryen", "Dead" },
                    { 3, null, null, 1, "Rhaenys Targaryen", "Dead" }
                });

            migrationBuilder.InsertData(
                table: "dragon_riders",
                columns: new[] { "Id", "DragonId", "EndDate", "IsCurrent", "RiderId", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(37, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(50, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(10, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dragon_riders_DragonId",
                table: "dragon_riders",
                column: "DragonId");

            migrationBuilder.CreateIndex(
                name: "IX_dragon_riders_RiderId",
                table: "dragon_riders",
                column: "RiderId");

            migrationBuilder.CreateIndex(
                name: "IX_riders_HouseId",
                table: "riders",
                column: "HouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dragon_riders");

            migrationBuilder.DropTable(
                name: "dragons");

            migrationBuilder.DropTable(
                name: "riders");

            migrationBuilder.DropTable(
                name: "houses");
        }
    }
}
