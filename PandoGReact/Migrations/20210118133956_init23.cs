using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PandoGReact.Migrations
{
    public partial class init23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nobis cupiditate porro." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem minus qui." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicabo maxime molestias." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corporis sapiente consequatur." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed veniam debitis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut ipsa rerum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accusantium molestiae fuga." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem iure velit." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisci ipsum quis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Voluptatem necessitatibus omnis.");

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel dolores vitae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui neque amet." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iste animi aut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum ullam accusamus." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa aut aliquam." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odit id nobis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perspiciatis quas ut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt aut sapiente." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minus nam culpa." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A fugit animi." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labore enim aut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minima qui vel." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullam est consequuntur." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 24,
                column: "Title",
                value: "Harum dolorem aut.");

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus autem quis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum illo voluptas." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quidem aut sit." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quisquam id nobis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem qui atque." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harum quia molestiae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia est fugiat." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reiciendis et mollitia." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omnis quas nobis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum sapiente labore." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quas et molestiae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et nihil ipsum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ipsa nam ut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laboriosam enim dignissimos." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rerum consectetur excepturi." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eius ut voluptatum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis aut ea." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illo aut harum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sequi ullam sit." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisci aperiam distinctio." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deleniti enim dolorem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est ea error." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veritatis ex rerum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui ut delectus." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia et odit." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit tenetur molestias." });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 6,
                column: "JobId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 151, new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 193, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 180, new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 181, new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 182, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 183, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 184, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 185, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 186, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 187, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 188, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 179, new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 189, new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 191, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 192, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 152, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 194, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 195, new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 196, new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 197, new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 198, new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 199, new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 190, new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 178, new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 177, new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 176, new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 155, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 156, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 157, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 158, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 159, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 160, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 161, new DateTime(2020, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 162, new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 163, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 164, new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 165, new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 166, new DateTime(2020, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 167, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 168, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 169, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 170, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 171, new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 172, new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 173, new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 174, new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 175, new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 200, new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 154, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 153, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 }
                });

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: -1);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 24);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 27);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 31);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 32);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 34);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 39);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 41);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 39);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 41);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 47);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 48);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: -22);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 66);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 99);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 176);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 264);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 308);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 363);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 440);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 462);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 484);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 473);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 473);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 539);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 561);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 550);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 561);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 627);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 594);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 627);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 693);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 715);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 748);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 770);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 858);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 836);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 902);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 869);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 957);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 913);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 968);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 1034);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 1012);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 1056);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 1078);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: -20);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 60);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 90);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 160);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 240);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 280);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 330);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 400);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 420);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 440);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 430);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 430);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 490);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 510);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 500);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 510);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 570);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 540);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 570);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 630);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 650);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 680);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 700);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 780);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 760);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 820);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 790);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 870);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 830);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 880);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 940);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 920);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 960);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 980);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est vero iusto." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Itaque nihil est." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et beatae tenetur." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorem quis molestiae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porro libero non." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aperiam provident dolores." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ad sequi debitis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earum dicta dolore." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et incidunt nulla." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Laudantium odit fuga.");

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullam atque non." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "In reiciendis dolores." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut mollitia unde." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Itaque rerum et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commodi consequatur saepe." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum dolore asperiores." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eum incidunt dolor." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos quia molestiae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quae neque vel." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id praesentium at." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem inventore dolores." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed fuga repellendus." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maiores assumenda vero." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 24,
                column: "Title",
                value: "Non voluptas sed.");

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corrupti aspernatur quia." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adipisci velit autem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ipsum itaque culpa." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Error eligendi rem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sequi mollitia voluptas." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facere et ullam." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dignissimos exercitationem hic." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut delectus in." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et sit et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam quas aut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soluta et ipsum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ipsa aut et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem tenetur nemo." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Architecto voluptas ullam." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et alias ut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magnam cumque ut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut quis voluptatem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et ut et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quos earum sunt." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atque cumque neque." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem et vel." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Distinctio repellendus magni." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloremque incidunt nihil." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id sed similique." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blanditiis delectus inventore." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eos est nam." });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 5,
                column: "JobId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 6,
                column: "JobId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 4);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 7);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 20);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 24);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 27);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 30);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 34);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 35);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 38);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 39);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 45);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 48);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 47);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 88);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 165);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 154);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 187);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 165);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 143);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 187);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 165);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 253);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 264);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 231);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 264);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 330);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 363);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 451);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 473);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 495);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 462);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 473);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 550);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 528);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 605);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 671);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 759);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 781);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 836);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 869);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 979);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 957);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 990);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 1056);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 1023);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 1045);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Count",
                value: 80);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 150);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 140);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 170);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 150);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 130);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 170);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 150);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 230);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 240);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 210);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 240);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 300);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 330);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 410);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 430);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 450);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 420);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 430);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 500);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 480);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 550);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 610);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 690);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 710);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 760);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 790);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 890);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 870);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 900);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 960);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 930);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 950);
        }
    }
}
