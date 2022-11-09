using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookCover",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");


            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                columns: new[] { "BookCover", "YearPrint" },
                values: new object[] { "c:\\Data\\Image\\three.png", new DateTime(2022, 11, 8, 15, 31, 55, 737, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                columns: new[] { "BookCover", "YearPrint" },
                values: new object[] { "c:\\Data\\Image\\one.png", new DateTime(2022, 11, 8, 15, 31, 55, 737, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                columns: new[] { "BookCover", "YearPrint" },
                values: new object[] { "c:\\Data\\Image\\two.png", new DateTime(2022, 11, 8, 15, 31, 55, 737, DateTimeKind.Utc).AddTicks(9737) });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookCover",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 15, 27, 19, 538, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 15, 27, 19, 538, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 15, 27, 19, 538, DateTimeKind.Utc).AddTicks(2748));

        }
    }
}
