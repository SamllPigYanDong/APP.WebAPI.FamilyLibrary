using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class modifyProjectFolder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePath",
                table: "R_Project");

            migrationBuilder.DropColumn(
                name: "ProjectFilesPath",
                table: "R_Project");

            migrationBuilder.CreateTable(
                name: "R_ProjectFolder",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "文件名称无后缀"),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "后缀名称"),
                    FileSize = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "文件大小"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false, comment: "项目Id"),
                    RelativePath = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "相对路径"),
                    IsRoot = table.Column<bool>(type: "bit", nullable: false, comment: "是否为根路径"),
                    CreatorId = table.Column<long>(type: "bigint", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_ProjectFolder", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5375), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5398), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5402), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5405), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "R_Permission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5408), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6761), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6764), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6767), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6769), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6772), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6534), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5467), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5472), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5474), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5475), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "R_RolePermission",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5477), new DateTime(2024, 3, 26, 22, 32, 34, 916, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "LastModificationTime", "PasswordHash" },
                values: new object[] { "ebd3fbc8-e5c1-44da-b6bd-3a0a6f4087fa", new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 3, 26, 22, 32, 34, 818, DateTimeKind.Local).AddTicks(6874), "AQAAAAIAAYagAAAAEKQQDJhml7E+FsUnNSsKicwrn3xoJo2vU2ce096xCweHm5GYnOIus/nqNhmkoqtw/w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "R_ProjectFolder");

            migrationBuilder.AddColumn<string>(
                name: "BasePath",
                table: "R_Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "项目支持文件路径");

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
                columns: new[] { "BasePath", "CreationTime", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2237), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2231), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "BasePath", "CreationTime", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2275), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2248), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "BasePath", "CreationTime", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2281), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "BasePath", "CreationTime", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2286), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "BasePath", "CreationTime", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2294), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "BasePath", "CreationTime", "LastModificationTime", "ProjectFilesPath" },
                values: new object[] { "", new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2302), new DateTime(2024, 3, 25, 14, 19, 48, 291, DateTimeKind.Local).AddTicks(2299), "" });

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
    }
}
