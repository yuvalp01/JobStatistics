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
                    { 1, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enim aliquid repellendus." },
                    { 30, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut voluptas autem." },
                    { 29, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut dolore sit." },
                    { 28, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptate saepe id." },
                    { 27, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non necessitatibus nisi." },
                    { 26, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ab ut explicabo." },
                    { 24, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellendus omnis mollitia." },
                    { 23, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inventore ipsam vel." },
                    { 22, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitae voluptas laborum." },
                    { 21, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tenetur dolorem harum." },
                    { 20, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porro odit perspiciatis." },
                    { 19, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et dolores repellat." },
                    { 18, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut consequatur qui." },
                    { 17, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illo neque quam." },
                    { 16, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eaque voluptatibus amet." },
                    { 25, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optio tempora aliquid." },
                    { 14, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemo voluptate eligendi." },
                    { 15, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas expedita et." },
                    { 2, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sequi non quis." },
                    { 3, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum ea vitae." },
                    { 4, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Totam maxime doloremque." },
                    { 6, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cum illum excepturi." },
                    { 7, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nostrum sit necessitatibus." },
                    { 5, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit sequi magni." },
                    { 9, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem placeat assumenda." },
                    { 10, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ea at repudiandae." },
                    { 11, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum aut aut." },
                    { 12, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui rem et." },
                    { 13, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis aliquam molestiae." },
                    { 8, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animi molestias aliquid." }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 374, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 380, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 375, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 376, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 377, new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 378, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 379, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 381, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 388, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 383, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 384, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 385, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 386, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 387, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 389, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 390, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 373, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 382, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 372, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 357, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 370, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 353, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 354, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 355, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 356, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 391, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 358, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 359, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 360, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 361, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 362, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 363, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 364, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 365, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 366, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 367, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 368, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 369, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 371, new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 392, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 407, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 394, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 416, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 417, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 418, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 419, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 420, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 421, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 422, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 423, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 424, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 425, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 426, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 427, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 428, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 429, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 430, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 431, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 432, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 415, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 393, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 414, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 412, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 395, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 396, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 397, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 398, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 399, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 400, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 401, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 402, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 403, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 404, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 405, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 406, new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 352, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 408, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 409, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 410, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 411, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 413, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 351, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 336, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 349, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 290, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 291, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 292, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 293, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 294, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 295, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 296, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 297, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 298, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 299, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 300, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 301, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 302, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 303, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 304, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 305, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 306, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 289, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 307, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 288, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 286, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 269, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 270, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 271, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 272, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 273, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 274, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 275, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 276, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 277, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 278, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 279, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 280, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 281, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 282, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 283, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 284, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 285, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 287, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 350, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 308, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 310, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 332, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 333, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 334, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 335, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 433, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 337, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 338, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 339, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 340, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 341, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 342, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 343, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 344, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 345, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 346, new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 347, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 348, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 331, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 309, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 330, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 328, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 311, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 312, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 313, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 314, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 315, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 316, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 317, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 318, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 319, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 320, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 321, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 322, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 323, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 324, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 325, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 326, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 327, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 329, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 434, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 449, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 436, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 542, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 543, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 544, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 545, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 546, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 547, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 548, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 549, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 550, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 551, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 552, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 553, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 554, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 555, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 556, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 557, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 558, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 541, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 559, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 540, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 538, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 521, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 522, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 523, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 524, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 525, new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 526, new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 527, new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 528, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 529, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 530, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 531, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 532, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 533, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 534, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 535, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 536, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 537, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 539, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 520, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 560, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 562, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 584, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 585, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 586, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 587, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 588, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 589, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 590, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 591, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 592, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 593, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 594, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 595, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 596, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 597, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 598, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 599, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 600, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 583, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 561, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 582, new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 580, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 563, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 564, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 565, new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 566, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 567, new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 568, new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 569, new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 570, new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 571, new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 572, new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 573, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 574, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 575, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 576, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 577, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 578, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 579, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 581, new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 435, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 519, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 517, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 458, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 459, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 460, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 461, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 462, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 463, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 464, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 465, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 466, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 467, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 468, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 469, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 470, new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 471, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 472, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 473, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 474, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 457, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 475, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 456, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 454, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 437, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 438, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 439, new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 440, new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 441, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 442, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 443, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 444, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 445, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 446, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 447, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 448, new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 267, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 450, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 451, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 452, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 453, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 455, new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 518, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 476, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 478, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 500, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 501, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 502, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 503, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 504, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 505, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 506, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 507, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 508, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 509, new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 510, new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 511, new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 512, new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 513, new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 514, new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 515, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 516, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 499, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 477, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 498, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 496, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 479, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 480, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 481, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 482, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 483, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 484, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 485, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 486, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 487, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 488, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 489, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 490, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 491, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 492, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 493, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 494, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 495, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 497, new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 266, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 268, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 264, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 96, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 95, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 94, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 93, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 92, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 91, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 90, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 89, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 88, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 87, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 86, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 85, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 84, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 83, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 82, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 265, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 80, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 79, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 78, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 77, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 76, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 75, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 74, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 73, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 72, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 71, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 70, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 69, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 68, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 97, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 98, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 99, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 100, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 130, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 129, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 128, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 127, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 126, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 125, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 124, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 123, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 122, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 121, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 120, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 119, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 118, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 117, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 67, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 116, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 114, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 113, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 112, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 111, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 110, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 109, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 108, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 107, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 106, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 105, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 104, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 103, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 102, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 101, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 115, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 131, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 66, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 64, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 29, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 28, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 27, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 26, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 25, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 24, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 23, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 21, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 20, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 19, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 18, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 17, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 16, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 15, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 14, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 13, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 12, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 9, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 8, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 7, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 6, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 5, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 4, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 3, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 2, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 30, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 31, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 32, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 33, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 63, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 62, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 61, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 60, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 59, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 58, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 57, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 56, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 55, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 54, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 53, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 52, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 51, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 50, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 65, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 49, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 47, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 46, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 45, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 44, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 42, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 41, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 40, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 39, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 37, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 36, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 35, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 34, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 48, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 132, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 81, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 134, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 230, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 229, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 228, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 227, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 226, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 225, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 224, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 223, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 222, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 221, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 220, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 219, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 218, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 217, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 216, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 215, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 214, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 213, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 212, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 211, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 210, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 209, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 208, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 207, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 206, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 205, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 204, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 203, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 202, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 231, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 201, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 232, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 234, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 263, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 262, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 261, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 260, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 259, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 258, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 257, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 256, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 255, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 254, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 253, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 252, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 133, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 250, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 249, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 248, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 247, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 246, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 245, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 244, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 243, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 242, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 241, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 240, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 239, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 238, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 237, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 236, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 235, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 233, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 200, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 251, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 198, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 163, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 162, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 161, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 160, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 159, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 158, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 157, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 156, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 155, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 154, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 153, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 152, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 151, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 150, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 148, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 147, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 146, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 145, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 144, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 143, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 142, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 141, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 140, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 139, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 138, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 137, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 136, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 135, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 199, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 164, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 165, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 149, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 167, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 197, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 166, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 196, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 195, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 194, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 193, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 192, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 191, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 190, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 188, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 187, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 186, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 185, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 184, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 183, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 189, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 182, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 169, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 170, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 168, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 171, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 172, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 174, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 175, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 173, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 177, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 178, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 179, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 180, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 181, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 176, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "jobStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 20, 23, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 23, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 22, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 22, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 25, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 22, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 39, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 29, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 31, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 34, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 38, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 42, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 41, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 19, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 25, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 20, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 7, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 18, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 43, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 4, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 8, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 9, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 12, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 15, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 14, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 18, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 21, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 20, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 19, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 18, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 18, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 18, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 19, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 19, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 43, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "predictionStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 16, 396, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 176, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 484, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 550, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 517, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 495, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 550, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "predictionStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 28, 682, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 484, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 748, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 869, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 902, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 924, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 946, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 957, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 88, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 836, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 517, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 638, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 440, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 154, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 429, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 209, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 264, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 330, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 396, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 462, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 308, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 418, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 407, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 407, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 407, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 418, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 429, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 440, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "viewStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 20, 470, new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 450, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 440, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 440, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 500, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 470, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 500, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 840, new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 620, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 680, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 760, new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 790, new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 820, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 390, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "stats",
                table: "viewStats",
                columns: new[] { "Id", "Count", "Date" },
                values: new object[,]
                {
                    { 27, 580, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 400, new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 80, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 360, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 860, new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 160, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 140, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 190, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 240, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 300, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 280, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 360, new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 420, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 400, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 380, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 370, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 370, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 370, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 380, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 390, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 870, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
