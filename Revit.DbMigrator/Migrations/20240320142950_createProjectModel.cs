using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class createProjectModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "R_Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "项目介绍");

            migrationBuilder.AddColumn<string>(
                name: "ProjectAddress",
                table: "R_Project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "项目地址");

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
                columns: new[] { "CreationTime", "Introduction", "LastModificationTime", "ProjectAddress" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5547), "", new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5543), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "Introduction", "LastModificationTime", "ProjectAddress" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5550), "", new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5549), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "Introduction", "LastModificationTime", "ProjectAddress" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5553), "", new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5551), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "Introduction", "LastModificationTime", "ProjectAddress" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5555), "", new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5554), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "Introduction", "LastModificationTime", "ProjectAddress" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5557), "", new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5556), "" });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "Introduction", "LastModificationTime", "ProjectAddress" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5560), "", new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5559), "" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "R_Project");

            migrationBuilder.DropColumn(
                name: "ProjectAddress",
                table: "R_Project");

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
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4568), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4615), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4626), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4632), new DateTime(2024, 3, 16, 18, 17, 22, 926, DateTimeKind.Local).AddTicks(4628) });

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
    }
}
