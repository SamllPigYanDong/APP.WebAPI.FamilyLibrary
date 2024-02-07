using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "bef6ea55-9d1d-4721-a7a1-3141b609a1c1", new DateTime(2024, 2, 7, 13, 16, 36, 152, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationTime",
                value: new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "PasswordHash" },
                values: new object[] { "87c810d0-7c5d-4475-9b76-3a8531c07dee", new DateTime(2024, 2, 7, 13, 16, 36, 152, DateTimeKind.Local).AddTicks(1932), "AQAAAAEAACcQAAAAENL+nQ4Wyexazej1dp8uLxq9o07Zyp/ZPChJkXHYHyy2x70ZNMhz4khMjMl5Nm4t6w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime" },
                values: new object[] { "abab3444-3848-40b1-9574-31dae6fa7698", new DateTime(2024, 1, 26, 23, 24, 37, 330, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationTime",
                value: new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "PasswordHash" },
                values: new object[] { "753eec86-8f19-41f2-932d-ea77f40b7979", new DateTime(2024, 1, 26, 23, 24, 37, 330, DateTimeKind.Local).AddTicks(7370), "AQAAAAEAACcQAAAAEEgXLi3ybliDjJrE4H8Di8NPUV4h21icV5vEnuJIzRJ/lU7eotNSt+B0AamljoedrA==" });
        }
    }
}
