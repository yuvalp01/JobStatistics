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
                    { 1, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est vero iusto." },
                    { 28, new DateTime(2020, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Error eligendi rem." },
                    { 29, new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sequi mollitia voluptas." },
                    { 30, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facere et ullam." },
                    { 31, new DateTime(2020, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos exercitationem hic." },
                    { 32, new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut delectus in." },
                    { 33, new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et sit et." },
                    { 34, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam quas aut." },
                    { 35, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soluta et ipsum." },
                    { 36, new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ipsa aut et." },
                    { 37, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem tenetur nemo." },
                    { 27, new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ipsum itaque culpa." },
                    { 39, new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et alias ut." },
                    { 41, new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut quis voluptatem." },
                    { 42, new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et ut et." },
                    { 43, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quos earum sunt." },
                    { 44, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atque cumque neque." },
                    { 45, new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem et vel." },
                    { 46, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Distinctio repellendus magni." },
                    { 47, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloremque incidunt nihil." },
                    { 48, new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id sed similique." },
                    { 49, new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blanditiis delectus inventore." },
                    { 50, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos est nam." },
                    { 40, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam cumque ut." },
                    { 26, new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisci velit autem." },
                    { 38, new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Architecto voluptas ullam." },
                    { 24, new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non voluptas sed." },
                    { 25, new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corrupti aspernatur quia." },
                    { 2, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Itaque nihil est." },
                    { 3, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et beatae tenetur." },
                    { 4, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem quis molestiae." },
                    { 5, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porro libero non." },
                    { 6, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aperiam provident dolores." },
                    { 7, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ad sequi debitis." },
                    { 9, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et incidunt nulla." },
                    { 10, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laudantium odit fuga." },
                    { 11, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullam atque non." },
                    { 12, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "In reiciendis dolores." },
                    { 8, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earum dicta dolore." },
                    { 23, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maiores assumenda vero." },
                    { 14, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Itaque rerum et." },
                    { 15, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commodi consequatur saepe." }
                });

            migrationBuilder.InsertData(
                table: "JobLines",
                columns: new[] { "Id", "DateClose", "DateOpen", "Title" },
                values: new object[,]
                {
                    { 16, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum dolore asperiores." },
                    { 17, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum incidunt dolor." },
                    { 18, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos quia molestiae." },
                    { 19, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quae neque vel." },
                    { 20, new DateTime(2020, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id praesentium at." },
                    { 21, new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem inventore dolores." },
                    { 22, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed fuga repellendus." },
                    { 13, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut mollitia unde." }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 80, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 79, new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 78, new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 77, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 76, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 71, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 74, new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 73, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 72, new DateTime(2020, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 81, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 75, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 82, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 94, new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 84, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 85, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 86, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 87, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 88, new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 89, new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 90, new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 91, new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 92, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 93, new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 70, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 83, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 69, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 44, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 67, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 43, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 95, new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 45, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 46, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 48, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 49, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 50, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 51, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 52, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 53, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 68, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 54, new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 56, new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 57, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 58, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 59, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 60, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 61, new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 62, new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 63, new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 64, new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 65, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 66, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 55, new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 96, new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 121, new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 98, new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 127, new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 128, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 129, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 130, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 131, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 132, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 133, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 134, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 135, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 136, new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 137, new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 126, new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 138, new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 140, new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 141, new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 142, new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 143, new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 144, new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 145, new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 146, new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 147, new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 148, new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 149, new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 150, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 139, new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 97, new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 125, new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 123, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 99, new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 100, new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 101, new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 102, new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 103, new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 104, new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 105, new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 106, new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 107, new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 108, new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 109, new DateTime(2020, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 124, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 110, new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 112, new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 113, new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 114, new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 115, new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 116, new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 117, new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 118, new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 119, new DateTime(2020, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 120, new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 42, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 122, new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 111, new DateTime(2020, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 41, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 33, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 39, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 17, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 16, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 15, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 14, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 13, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 12, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 11, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 10, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 9, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 8, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 7, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 6, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 5, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 4, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 2, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 40, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 18, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 19, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 3, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 21, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 20, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 37, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 35, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 34, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 38, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 32, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 31, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 30, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 36, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 28, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 26, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 25, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 24, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 23, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 29, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 22, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "jobStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 20, 21, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 25, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 24, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 27, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 30, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 34, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 43, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 38, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 39, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 44, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "jobStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 31, 43, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 45, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 21, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 48, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 35, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 22, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 11, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 20, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 0, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 46, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 7, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 7, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 8, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 7, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 6, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 7, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 12, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 10, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 12, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 15, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 16, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 21, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 47, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "predictionStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 3, 165, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 88, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 528, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 605, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 671, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 759, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 781, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 869, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 550, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 946, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 957, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 990, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 1056, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 1023, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 1045, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 11, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 979, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "predictionStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 20, 473, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 836, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 495, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 154, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 462, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 187, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 165, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 143, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 165, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 253, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 187, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 231, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 264, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 330, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 363, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 451, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 473, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 264, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "viewStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 20, 430, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 690, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 500, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 480, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 550, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 610, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 710, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 960, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 790, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 860, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 890, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 870, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 900, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 420, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 760, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 450, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 10, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 410, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 930, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 80, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 150, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 140, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 170, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 150, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "viewStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 7, 130, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 170, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 150, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 230, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 240, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 210, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 240, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 300, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 330, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 430, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 950, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
