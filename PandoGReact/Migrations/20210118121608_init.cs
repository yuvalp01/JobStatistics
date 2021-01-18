using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PandoGReact.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "stats");

            migrationBuilder.CreateTable(
                name: "JobLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateClose = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobStats",
                schema: "stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "predictionStats",
                schema: "stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_predictionStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViewLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "viewStats",
                schema: "stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_viewStats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "JobLines",
                columns: new[] { "Id", "DateClose", "DateOpen", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Occaecati quasi ullam." },
                    { 28, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatibus qui nam." },
                    { 29, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores optio autem." },
                    { 30, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas dolor eos." },
                    { 31, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "In itaque delectus." },
                    { 32, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt sed est." },
                    { 33, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihil quia rem." },
                    { 34, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum qui amet." },
                    { 35, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisquam cumque veniam." },
                    { 36, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos unde quod." },
                    { 37, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuga non ad." },
                    { 27, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quod perspiciatis hic." },
                    { 39, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optio sed dolor." },
                    { 41, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui voluptatem perspiciatis." },
                    { 42, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestiae sit suscipit." },
                    { 43, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestias doloribus error." },
                    { 44, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eveniet qui dolor." },
                    { 45, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisci est sit." },
                    { 46, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nulla quas eum." },
                    { 47, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libero qui quidem." },
                    { 48, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptate voluptatem occaecati." },
                    { 49, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa distinctio quia." },
                    { 50, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur itaque et." },
                    { 40, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et numquam sed." },
                    { 26, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut eum vero." },
                    { 38, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vero qui molestias." },
                    { 24, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint incidunt molestiae." },
                    { 25, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molestias quo culpa." },
                    { 2, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex incidunt dolores." },
                    { 3, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velit provident omnis." },
                    { 4, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pariatur inventore possimus." },
                    { 5, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velit quod nihil." },
                    { 6, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est nobis reprehenderit." },
                    { 7, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellendus voluptas consequatur." },
                    { 9, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sequi magni quia." },
                    { 10, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id assumenda qui." },
                    { 11, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui impedit sint." },
                    { 12, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequuntur harum omnis." },
                    { 8, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et qui soluta." },
                    { 23, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facere quis et." },
                    { 14, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum et autem." },
                    { 15, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cum fugiat pariatur." }
                });

            migrationBuilder.InsertData(
                table: "JobLines",
                columns: new[] { "Id", "DateClose", "DateOpen", "Title" },
                values: new object[,]
                {
                    { 16, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos dolor velit." },
                    { 17, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "At quis distinctio." },
                    { 18, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recusandae quo necessitatibus." },
                    { 19, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint dolores ducimus." },
                    { 20, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ipsum sapiente laboriosam." },
                    { 21, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numquam in velit." },
                    { 22, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut vel quibusdam." },
                    { 13, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unde et consectetur." }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 80, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 79, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 78, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 77, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 76, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 71, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 74, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 73, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 72, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 81, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 75, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 82, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 94, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 84, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 85, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 86, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 87, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 88, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 89, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 90, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 91, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 92, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 93, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 70, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 83, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 69, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 44, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 67, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 43, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 95, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 45, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 46, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 47, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 48, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 49, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 50, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 51, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 52, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 53, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 68, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 54, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 57, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 58, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 59, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 60, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 61, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 62, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 63, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 64, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 65, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 66, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 55, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 96, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 121, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 98, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 127, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 128, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 129, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 130, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 131, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 132, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 133, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 134, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 135, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 136, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 137, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 126, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 138, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 140, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 141, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 142, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 143, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 144, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 145, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 146, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 147, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 148, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 149, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 150, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 139, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 97, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 125, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 123, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 99, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 100, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 101, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 102, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 103, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 104, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 105, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 106, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 107, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 108, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 109, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 124, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 110, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 112, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 113, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 114, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 115, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 116, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 117, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 118, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 119, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 120, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 42, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 122, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 111, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 41, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 33, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 39, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 16, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 14, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 13, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 12, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 11, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 10, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 9, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 8, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 7, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 6, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 5, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 4, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 2, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 40, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 19, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 3, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 21, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 20, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 37, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 35, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 34, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 38, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 31, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 30, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 28, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 27, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 26, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 25, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 24, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 23, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 29, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 22, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "jobStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 20, 21, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 20, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 19, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 20, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 20, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 21, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 22, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 20, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 22, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 24, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "jobStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 31, 24, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 24, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 20, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 24, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 19, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 17, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 17, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 27, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 8, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 9, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 10, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 12, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 11, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 14, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 13, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 18, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 27, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "predictionStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 3, 77, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 22, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 418, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 440, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 440, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 462, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 429, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 495, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 451, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 484, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 528, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 539, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 528, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 605, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 594, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 44, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 539, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "predictionStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 20, 462, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 440, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 374, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 99, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 451, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 143, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 176, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 154, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 220, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 220, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 209, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 275, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 242, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 319, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 297, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 385, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 396, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 264, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "viewStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 20, 420, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 420, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 410, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 380, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 400, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 400, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 390, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 480, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 450, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 440, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 490, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 480, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 490, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 410, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 400, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 340, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 40, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 350, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 550, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 20, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 70, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 90, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 130, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 160, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "viewStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 7, 140, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 190, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 200, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 200, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 240, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 250, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 220, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 290, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 270, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 360, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 540, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobLines");

            migrationBuilder.DropTable(
                name: "jobStats",
                schema: "stats");

            migrationBuilder.DropTable(
                name: "predictionStats",
                schema: "stats");

            migrationBuilder.DropTable(
                name: "ViewLines");

            migrationBuilder.DropTable(
                name: "viewStats",
                schema: "stats");
        }
    }
}
