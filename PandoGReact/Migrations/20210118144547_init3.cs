using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PandoGReact.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quidem itaque cupiditate." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odit accusantium et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolorum quis sed." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel eligendi officiis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nam molestiae assumenda." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unde et eum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alias nulla delectus." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debitis sint sit." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Modi incidunt dolores." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eius enim ea." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores a animi." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui est esse." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut delectus molestiae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beatae et voluptatibus." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iste magnam veniam." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inventore voluptatibus amet." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "A quaerat sed." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iste nisi tenetur." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Similique ratione aut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illo labore magni." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et et officia." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunt placeat dolor." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolore ratione reiciendis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloremque aut error." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est quos amet." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id enim neque." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut architecto aut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Et qui recusandae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia consequatur dolorem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit ad sit." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deleniti cupiditate eveniet." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commodi doloribus voluptatem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui praesentium illum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illo dolore tempore." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitae qui ut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Id pariatur earum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Numquam nam nulla." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ad placeat quia." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatum reiciendis ea." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis facere rerum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facere ut ut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culpa quis quaerat." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit nam minus." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autem alias rem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui ipsa adipisci." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui ullam adipisci." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laboriosam voluptatem vitae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptas mollitia temporibus." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earum debitis quaerat." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quas placeat ad." });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 17,
                column: "JobId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 18,
                column: "JobId",
                value: 50);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 19,
                column: "JobId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 20,
                column: "JobId",
                value: 48);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 31,
                column: "JobId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 48,
                column: "JobId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 49,
                column: "JobId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 50,
                column: "JobId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 51,
                column: "JobId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 52,
                column: "JobId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 57,
                column: "JobId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 58,
                column: "JobId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 63,
                column: "JobId",
                value: 38);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 64,
                column: "JobId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 65,
                column: "JobId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 66,
                column: "JobId",
                value: 50);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 67,
                column: "JobId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 68,
                column: "JobId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 69,
                column: "JobId",
                value: 48);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 70,
                column: "JobId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 71,
                column: "JobId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 201, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 269, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 263, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 262, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 261, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 260, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 259, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 258, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 257, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 256, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 255, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 254, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 253, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 252, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 251, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 250, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 249, new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 248, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 247, new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 264, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 246, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 265, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 267, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 284, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 283, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 282, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 281, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 280, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 279, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 278, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 277, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 276, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 275, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 274, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 273, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 272, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 271, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 270, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 202, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 268, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 266, new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 285, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 245, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 243, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 221, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 220, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 219, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 218, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 217, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 216, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 215, new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 214, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 213, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 212, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 211, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 210, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 209, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 208, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 207, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 206, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 205, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 222, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 244, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 223, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 225, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 242, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 241, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 240, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 239, new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 238, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 237, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 236, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 235, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 234, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 233, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 232, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 231, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 230, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 229, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 228, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 227, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 226, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 224, new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 286, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 287, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 288, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 }
                });

            migrationBuilder.InsertData(
                table: "ViewLines",
                columns: new[] { "Id", "Date", "JobId" },
                values: new object[,]
                {
                    { 204, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 300, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 299, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 298, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 297, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 296, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 203, new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 294, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 289, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 290, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 295, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 292, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 293, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 291, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 }
                });

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
                value: 2);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 6);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 10);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 13);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 17);

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
                value: 19);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 19);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 27);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 26);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 28);

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
                value: 26);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 27);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 29);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 32);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 29,
                column: "Count",
                value: 33);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 36);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 40);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 40);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 42);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 45);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 45);

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
                value: 55);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 143);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 143);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 209);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 231);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 231);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 231);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 231);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 286);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 374);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 462);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 429);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 473);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 462);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 429);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 429);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 473);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 550);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 605);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 583);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 616);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 594);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 572);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 605);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 649);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 627);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 715);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 29,
                column: "Count",
                value: 737);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 803);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 880);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 880);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 935);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 1001);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 1001);

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
                value: 50);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Count",
                value: 130);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 130);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 190);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Count",
                value: 210);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Count",
                value: 210);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 210);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 210);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 260);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 340);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 420);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 390);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 430);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 420);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 390);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 390);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 18,
                column: "Count",
                value: 430);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 19,
                column: "Count",
                value: 500);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 550);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 530);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 560);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 540);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 520);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 550);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 590);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 570);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 650);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 29,
                column: "Count",
                value: 670);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 730);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 800);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 800);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 850);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 910);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 910);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateClose", "Title" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quod est animi." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolor sed id." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est et fuga." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vero debitis quidem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut reprehenderit et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non qui eos." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maiores nobis corrupti." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quidem necessitatibus soluta." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non amet vero." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quo commodi facilis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint aliquam dignissimos." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iure ea eius." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ducimus cumque eligendi." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel libero eos." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Repellendus architecto et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quo voluptatem ut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia sed sapiente." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sit dolorum eius." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placeat omnis perspiciatis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aut accusamus eos." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laudantium magni doloremque." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Velit esse magni." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ab sunt tempora." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non perspiciatis ea." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quis natus officiis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "In omnis laboriosam." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atque temporibus occaecati." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quia praesentium ad." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Itaque aut harum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incidunt aperiam nobis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doloribus aspernatur et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reprehenderit blanditiis aut." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consectetur quis iure." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asperiores et incidunt." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temporibus quia qui." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eveniet corporis id." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exercitationem enim eum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptates omnis accusantium." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debitis dolorem veniam." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recusandae saepe et." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vel ipsam quidem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Architecto eum molestiae." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "In quisquam quibusdam." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui ad consequatur." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commodi accusantium voluptatem." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuga pariatur nostrum." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem dolores sunt." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui non reiciendis." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Est nihil mollitia." });

            migrationBuilder.UpdateData(
                table: "JobLines",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateClose", "DateOpen", "Title" },
                values: new object[] { new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Libero ut sint." });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 17,
                column: "JobId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 18,
                column: "JobId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 19,
                column: "JobId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 20,
                column: "JobId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 31,
                column: "JobId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 48,
                column: "JobId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 49,
                column: "JobId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 50,
                column: "JobId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 51,
                column: "JobId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 52,
                column: "JobId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 57,
                column: "JobId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 58,
                column: "JobId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 63,
                column: "JobId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 64,
                column: "JobId",
                value: 40);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 65,
                column: "JobId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 66,
                column: "JobId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 67,
                column: "JobId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 68,
                column: "JobId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 69,
                column: "JobId",
                value: 38);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 70,
                column: "JobId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 71,
                column: "JobId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2020, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 });

            migrationBuilder.UpdateData(
                table: "ViewLines",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Date", "JobId" },
                values: new object[] { new DateTime(2020, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 });

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 1);

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
                value: 3);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 4);

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
                value: 9);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 8);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 9);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 11);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 14);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 12);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 16);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 18);

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
                value: 23);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 27);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 30);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 31);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 33);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 36);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 36);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 40);

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
                keyValue: 29,
                column: "Count",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 46);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 49);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 50);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 51);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 55);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "jobStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 58);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 22);

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
                value: 77);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 44);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 99);

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
                value: 132);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 209);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 198);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 187);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 209);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 253);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 341);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 308);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 275);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 363);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 407);

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
                value: 517);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 550);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 594);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 671);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 693);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 726);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 803);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 792);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 880);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 946);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 29,
                column: "Count",
                value: 1023);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 1023);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 1089);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 1111);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 1133);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 1221);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "predictionStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 1276);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Count",
                value: 20);

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
                value: 70);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Count",
                value: 40);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Count",
                value: 90);

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
                value: 120);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 8,
                column: "Count",
                value: 190);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 9,
                column: "Count",
                value: 180);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 10,
                column: "Count",
                value: 170);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 11,
                column: "Count",
                value: 190);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 12,
                column: "Count",
                value: 230);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 13,
                column: "Count",
                value: 310);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 14,
                column: "Count",
                value: 280);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 15,
                column: "Count",
                value: 250);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 16,
                column: "Count",
                value: 330);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 17,
                column: "Count",
                value: 370);

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
                value: 470);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 20,
                column: "Count",
                value: 500);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 21,
                column: "Count",
                value: 540);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 22,
                column: "Count",
                value: 610);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 23,
                column: "Count",
                value: 630);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 24,
                column: "Count",
                value: 660);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 25,
                column: "Count",
                value: 730);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 26,
                column: "Count",
                value: 720);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 27,
                column: "Count",
                value: 800);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 28,
                column: "Count",
                value: 860);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 29,
                column: "Count",
                value: 930);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 30,
                column: "Count",
                value: 930);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 31,
                column: "Count",
                value: 990);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 32,
                column: "Count",
                value: 1010);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 33,
                column: "Count",
                value: 1030);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 34,
                column: "Count",
                value: 1110);

            migrationBuilder.UpdateData(
                schema: "stats",
                table: "viewStats",
                keyColumn: "Id",
                keyValue: 35,
                column: "Count",
                value: 1160);
        }
    }
}
