using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Electricity.Api.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Spreadsheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hour00 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour01 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour02 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour03 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour04 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour05 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour06 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour07 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour08 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour09 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour10 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour11 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour12 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour13 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour14 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour15 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour16 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour17 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour18 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour19 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour20 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour21 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour22 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Hour23 = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spreadsheets", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    ZoneKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Київ" },
                    { 2, "Львів" },
                    { 3, "Одеса" },
                    { 4, "Дніпро" },
                    { 5, "Харків" }
                });

            migrationBuilder.InsertData(
                table: "Spreadsheets",
                columns: new[] { "Id", "CityId", "Date", "DateName", "GroupId", "Hour00", "Hour01", "Hour02", "Hour03", "Hour04", "Hour05", "Hour06", "Hour07", "Hour08", "Hour09", "Hour10", "Hour11", "Hour12", "Hour13", "Hour14", "Hour15", "Hour16", "Hour17", "Hour18", "Hour19", "Hour20", "Hour21", "Hour22", "Hour23" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Monday", 1, false, false, false, false, true, true, true, false, false, false, true, true, false, false, false, false, true, true, false, false, true, true, false, false },
                    { 2, 1, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Monday", 2, true, true, false, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false },
                    { 3, 1, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Tuesday", 1, false, false, false, false, true, true, true, false, false, false, true, true, false, false, false, false, true, true, false, false, true, true, false, false },
                    { 4, 1, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Local), "Tuesday", 2, true, true, false, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false },
                    { 5, 1, new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Wednesday", 1, false, false, false, false, true, true, true, false, false, false, true, true, false, false, false, false, true, true, false, false, true, true, false, false },
                    { 6, 1, new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "Wednesday", 2, true, true, false, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false },
                    { 7, 1, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Thursday", 1, false, false, false, false, true, true, true, false, false, false, true, true, false, false, false, false, true, true, false, false, true, true, false, false },
                    { 8, 1, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "Thursday", 2, true, true, false, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false },
                    { 9, 1, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Friday", 1, false, false, false, false, true, true, true, false, false, false, true, true, false, false, false, false, true, true, false, false, true, true, false, false },
                    { 10, 1, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "Friday", 2, true, true, false, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false },
                    { 11, 1, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Saturday", 1, false, false, false, false, true, true, true, false, false, false, true, true, false, false, false, false, true, true, false, false, true, true, false, false },
                    { 12, 1, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Local), "Saturday", 2, true, true, false, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false },
                    { 13, 1, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Sunday", 1, false, false, false, false, true, true, true, false, false, false, true, true, false, false, false, false, true, true, false, false, true, true, false, false },
                    { 14, 1, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Local), "Sunday", 2, true, true, false, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false, false, true, true, false }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "CityId", "ZoneKey" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 1 },
                    { 4, 2, 2 },
                    { 5, 3, 1 },
                    { 6, 3, 2 },
                    { 7, 4, 1 },
                    { 8, 4, 2 },
                    { 9, 5, 1 },
                    { 10, 5, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Spreadsheets");

            migrationBuilder.DropTable(
                name: "Zones");
        }
    }
}
