using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PandoGReact.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobViewPredictions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobViewPredictions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobViews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "jobViewPredictions",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 35, 869, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 374, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 330, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 352, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 275, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 308, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 275, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 352, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 209, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 253, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 275, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 231, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 143, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 66, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 22, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 220, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 396, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 198, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 418, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 429, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 814, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 781, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 693, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 649, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 572, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 572, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 594, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 869, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 539, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 484, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 429, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 374, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 385, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 396, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 506, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "jobViews",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 19, 380, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 360, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 350, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 340, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 390, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 440, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 490, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "jobViews",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 26, 460, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 590, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 520, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 520, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 630, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 710, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 740, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 790, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 540, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 790, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 390, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 320, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 20, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 60, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 130, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 210, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 360, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 230, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 200, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 250, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 180, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 250, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 280, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 250, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 320, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 300, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 340, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 190, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 15, 34, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 30, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 32, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 25, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 28, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 25, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 6, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 19, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 20, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 23, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 25, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 21, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 13, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 32, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "jobs",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 9, 18, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 36, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 46, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 38, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 79, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 79, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 74, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 71, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 63, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 59, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 52, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 52, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 54, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 49, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 44, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 39, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 34, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 35, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 36, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 39, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "jobViewPredictions");

            migrationBuilder.DropTable(
                name: "jobViews");
        }
    }
}
