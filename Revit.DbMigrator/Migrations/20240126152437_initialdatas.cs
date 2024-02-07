using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class initialdatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "R_Permission",
                columns: new[] { "Id", "ApiMethod", "Code", "Component", "CreationTime", "CreatorId", "Icon", "LastModificationTime", "Name", "ParentId", "PermissionType", "Remark", "Sort", "Status", "Url" },
                values: new object[,]
                {
                    { 1L, "", "system", "", new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8260), 0L, "el-icon-s-tools", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "系统管理", 0L, 0, null, 0, 1, "system" },
                    { 2L, "", "system.user", "views/documentation/index", new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8278), 0L, "el-icon-user-solid", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "用户管理", 1L, 0, null, 0, 1, "system.user" },
                    { 3L, "", "system.role", "views/documentation/index", new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8280), 0L, "peoples", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "角色管理", 1L, 0, null, 0, 1, "role" },
                    { 4L, "", "system.permission", "views/documentation/index", new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8282), 0L, "list", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "菜单管理", 1L, 0, null, 0, 1, "permission" },
                    { 5L, "", "system.rolepermission", "views/documentation/index", new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8284), 0L, "example", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "角色权限", 1L, 0, null, 0, 1, "rolepermission" }
                });

            migrationBuilder.InsertData(
                table: "R_Role",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "LastModificationTime", "Name", "NormalizedName", "Remark", "Status" },
                values: new object[] { 1L, "abab3444-3848-40b1-9574-31dae6fa7698", new DateTime(2024, 1, 26, 23, 24, 37, 330, DateTimeKind.Local).AddTicks(7033), 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "管理员", "管理员", null, 1 });

            migrationBuilder.InsertData(
                table: "R_User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationTime", "CreatorId", "Email", "EmailConfirmed", "FullName", "LastModificationTime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Remark", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1L, 0, "753eec86-8f19-41f2-932d-ea77f40b7979", new DateTime(2024, 1, 26, 23, 24, 37, 330, DateTimeKind.Local).AddTicks(7370), 0L, "admin@R_tric.com", true, "管理员", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "ADMIN@R_TRIC.COM", "ADMIN", "AQAAAAEAACcQAAAAEEgXLi3ybliDjJrE4H8Di8NPUV4h21icV5vEnuJIzRJ/lU7eotNSt+B0AamljoedrA==", "123456789", false, null, "abc", 1, false, "admin" });

            migrationBuilder.InsertData(
                table: "R_RolePermission",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8349), 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1L, 1L },
                    { 2L, new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8353), 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2L, 1L },
                    { 3L, new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8355), 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3L, 1L },
                    { 4L, new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8356), 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4L, 1L },
                    { 5L, new DateTime(2024, 1, 26, 23, 24, 37, 342, DateTimeKind.Local).AddTicks(8357), 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5L, 1L }
                });

            migrationBuilder.InsertData(
                table: "R_UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1L, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "R_UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
