using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class adjustproject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "R_Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "项目名称",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "项目名称");

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3076), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3129), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3134), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3140), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3150), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4568), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4563), "测试1" });

            migrationBuilder.InsertData(
                table: "R_Project",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "ProjectName" },
                values: new object[,]
                {
                    { 2L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4604), 1L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4579), "测试2" },
                    { 3L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4615), 1L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4610), "测试3" },
                    { 4L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4622), 1L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4620), "测试4" },
                    { 5L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4626), 1L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4624), "测试5" },
                    { 6L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4632), 1L, new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4628), "测试6" }
                });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4818), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3572), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3598), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 3, 16, 18, 17, 23, 193, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "2b7a8ca2-e4f3-4e7a-a066-455cc85c84d1", new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(5029), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4958), "AQAAAAIAAYagAAAAEEdMGa754sLYgqVFqttB1ivPmE3ZCAlx4+EetNwwR0dAeB/V0E/goe3hm5lq/ho0Nw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectName",
                table: "R_Project",
                type: "nvarchar(max)",
                nullable: true,
                comment: "项目名称",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "项目名称");

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5239), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5297) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5306), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime", "ProjectName" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2648), "测试" });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2751), new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5526), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5541), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5543), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "cce81f75-220a-4013-a955-e8487f007e3c", new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2908), new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2852), "AQAAAAIAAYagAAAAEJN86Zo+74PsRxzyKR1m6y2anPRzEuvXZJDEF5yCR9FyAa6PT02yQKxj14kLvjhyyg==" });
        }
    }
}
