using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "R_Permission",
                columns: new[] { "Id", "ApiMethod", "Code", "Component", "CreationTime", "CreatorId", "Icon", "LastModificationTime", "Name", "ParentId", "PermissionType", "Remark", "Sort", "Status", "Url" },
                values: new object[,]
                {
                    { 1L, "", "system", "", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6387), 0L, "el-icon-s-tools", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6405), "系统管理", 0L, 0, null, 0, 1, "system" },
                    { 2L, "", "system.user", "views/documentation/index", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6417), 0L, "el-icon-user-solid", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6418), "用户管理", 1L, 0, null, 0, 1, "system.user" },
                    { 3L, "", "system.role", "views/documentation/index", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6423), 0L, "peoples", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6424), "角色管理", 1L, 0, null, 0, 1, "role" },
                    { 4L, "", "system.permission", "views/documentation/index", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6554), 0L, "list", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6555), "菜单管理", 1L, 0, null, 0, 1, "permission" },
                    { 5L, "", "system.rolepermission", "views/documentation/index", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6560), 0L, "example", new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6561), "角色权限", 1L, 0, null, 0, 1, "rolepermission" }
                });

            migrationBuilder.InsertData(
                table: "R_Role",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "LastModificationTime", "Name", "NormalizedName", "Remark", "Status" },
                values: new object[] { 1L, null, new DateTime(2024, 2, 27, 23, 48, 5, 925, DateTimeKind.Local).AddTicks(1291), 0L, new DateTime(2024, 2, 27, 23, 48, 5, 925, DateTimeKind.Local).AddTicks(1287), "管理员", "管理员", null, 1 });

            migrationBuilder.InsertData(
                table: "R_User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationTime", "CreatorId", "Email", "EmailConfirmed", "FullName", "LastModificationTime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Remark", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1L, 0, "d42be3dd-9856-40f0-bd3d-750badc6d591", new DateTime(2024, 2, 27, 23, 48, 5, 925, DateTimeKind.Local).AddTicks(1847), 0L, "admin@R_tric.com", true, "管理员", new DateTime(2024, 2, 27, 23, 48, 5, 925, DateTimeKind.Local).AddTicks(1787), false, null, "ADMIN@R_TRIC.COM", "ADMIN", "AQAAAAIAAYagAAAAEAKTt709ApyCWQSTP7yirZfEgYNdTOBmb4RS1MW/e14KmnHMoptAOTcbeLlmiq+Siw==", "123456789", false, null, "abc", 1, false, "admin" });

            migrationBuilder.InsertData(
                table: "R_RolePermission",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6657), 0L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6658), 1L, 1L },
                    { 2L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6667), 0L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6668), 2L, 1L },
                    { 3L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6669), 0L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6670), 3L, 1L },
                    { 4L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6672), 0L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6673), 4L, 1L },
                    { 5L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6674), 0L, new DateTime(2024, 2, 27, 23, 48, 6, 52, DateTimeKind.Local).AddTicks(6675), 5L, 1L }
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
