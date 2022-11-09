using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 15, 25, 30, 430, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 15, 25, 30, 430, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 15, 25, 30, 430, DateTimeKind.Utc).AddTicks(1192));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 14, 57, 47, 718, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 14, 57, 47, 718, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                column: "YearPrint",
                value: new DateTime(2022, 11, 8, 14, 57, 47, 718, DateTimeKind.Utc).AddTicks(7302));
        }
    }
}
