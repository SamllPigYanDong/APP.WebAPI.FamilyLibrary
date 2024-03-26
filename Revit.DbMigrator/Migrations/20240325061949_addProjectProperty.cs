using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class addProjectProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BasePath",
                table: "R_Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "项目支持文件路径");

            migrationBuilder.AddColumn<string>(
                name: "IconPath",
                table: "R_Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "图标路径");

            migrationBuilder.AddColumn<string>(
                name: "ProjectFilesPath",
                table: "R_Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "项目相关路径");

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7105), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7114), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7119), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BasePath", "CreationTime", "IconPath", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2237), "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2231), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BasePath", "CreationTime", "IconPath", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2275), "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2248), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BasePath", "CreationTime", "IconPath", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2284), "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2281), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BasePath", "CreationTime", "IconPath", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2289), "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2286), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BasePath", "CreationTime", "IconPath", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2295), "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2294), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BasePath", "CreationTime", "IconPath", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2302), "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2299), "" });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(1509), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2437), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7316), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 3, 25, 14, 19, 48, 430, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "d0816ca5-7f60-48fe-914a-8adb41262c9b", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2654), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2578), "AQAAAAIAAYagAAAAEE5+qTQkRHhxM2zC7mDN8sZaQIFJyNGpcHt7gzIVmrDEXr7cO9pAlIpeDrzieIGbsA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePath",
                table: "R_Project");

            migrationBuilder.DropColumn(
                name: "IconPath",
                table: "R_Project");

            migrationBuilder.DropColumn(
                name: "ProjectFilesPath",
                table: "R_Project");

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6699), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6728), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6732), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5550), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5553), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5555), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5557), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5560), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5257), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6808), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6810), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6813), new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "8203aacc-f95e-449d-835f-85b339fbcabd", new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5731), new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5683), "AQAAAAIAAYagAAAAEA2sbjtZZ4JDoDM3egC28BaY804INcoBrhfYe/YE1cu9N1YIitoFi7niy6BZAFpYrQ==" });
        }
    }
}
