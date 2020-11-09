using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Dal.Migrations
{
    public partial class DataSeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blogs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Blogs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 22, "ohran.faruk@hotmail.com", "Faruk" },
                    { 2, 22, "jasir.buric@hotmail.com", "Jasir" },
                    { 3, 22, "muhamed.halkic@hotmail.com", "Muhamed" },
                    { 4, 22, "mirzad.varupa@hotmail.com", "Mirzad" },
                    { 5, 22, "haris.mlaco@hotmail.com", "Haris" },
                    { 6, 22, "ahmed.terzic@hotmail.com", "Ahmed" },
                    { 7, 22, "ajdin.tabak@hotmail.com", "Ajdin" }
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "PublishedAt", "Summary", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Prvi blog content", new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(4543), "Summary", "Naslov1", 1 },
                    { 2, "Prvi blog content", new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5200), "Summary", "Naslov2", 1 },
                    { 3, "Prvi blog content", new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5215), "Summary", "Naslov3", 1 },
                    { 4, "Prvi blog content", new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5217), "Summary", "Naslov4", 1 },
                    { 5, "Prvi blog content", new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5219), "Summary", "Naslov1", 3 },
                    { 6, "Prvi blog content", new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5224), "Summary", "Naslov2", 3 },
                    { 7, "Prvi blog content", new DateTime(2020, 11, 9, 10, 5, 16, 165, DateTimeKind.Utc).AddTicks(5225), "Summary", "Naslov3", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
