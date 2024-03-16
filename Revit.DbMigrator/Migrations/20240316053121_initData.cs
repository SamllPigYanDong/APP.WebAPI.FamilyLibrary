using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class initData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "R_UserToken");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "R_User");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "R_UserRole");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "R_UserLogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "R_UserClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "R_Role");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "R_RoleClaim");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "R_UserRole",
                newName: "IX_R_UserRole_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "R_UserLogin",
                newName: "IX_R_UserLogin_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "R_UserClaim",
                newName: "IX_R_UserClaim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "R_RoleClaim",
                newName: "IX_R_RoleClaim_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "R_User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "R_User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "R_Role",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "R_Role",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_UserToken",
                table: "R_UserToken",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_User",
                table: "R_User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_UserRole",
                table: "R_UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_UserLogin",
                table: "R_UserLogin",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_UserClaim",
                table: "R_UserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_Role",
                table: "R_Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_R_RoleClaim",
                table: "R_RoleClaim",
                column: "Id");

            migrationBuilder.InsertData(
                table: "R_Permission",
                columns: new[] { "Id", "ApiMethod", "Code", "Component", "CreationTime", "CreatorId", "Icon", "LastModificationTime", "Name", "ParentId", "PermissionType", "Remark", "Sort", "Status", "Url" },
                values: new object[,]
                {
                    { 1L, "", "system", "", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5239), 0L, "el-icon-s-tools", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5260), "系统管理", 0L, 0, null, 0, 1, "system" },
                    { 2L, "", "system.user", "views/documentation/index", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5290), 0L, "el-icon-user-solid", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5291), "用户管理", 1L, 0, null, 0, 1, "system.user" },
                    { 3L, "", "system.role", "views/documentation/index", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5296), 0L, "peoples", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5297), "角色管理", 1L, 0, null, 0, 1, "role" },
                    { 4L, "", "system.permission", "views/documentation/index", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5300), 0L, "list", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5301), "菜单管理", 1L, 0, null, 0, 1, "permission" },
                    { 5L, "", "system.rolepermission", "views/documentation/index", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5306), 0L, "example", new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5307), "角色权限", 1L, 0, null, 0, 1, "rolepermission" }
                });

            migrationBuilder.InsertData(
                table: "R_Project",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "ProjectName" },
                values: new object[] { 1L, new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2653), 1L, new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2648), "测试" });

            migrationBuilder.InsertData(
                table: "R_Role",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "LastModificationTime", "Name", "NormalizedName", "Remark", "Status" },
                values: new object[] { 1L, null, new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2751), 0L, new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2728), "管理员", "管理员", null, 1 });

            migrationBuilder.InsertData(
                table: "R_User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationTime", "CreatorId", "Email", "EmailConfirmed", "FullName", "LastModificationTime", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Remark", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1L, 0, "cce81f75-220a-4013-a955-e8487f007e3c", new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2908), 0L, "admin@R_tric.com", true, "管理员", new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2852), false, null, "ADMIN@R_TRIC.COM", "ADMIN", "AQAAAAIAAYagAAAAEJN86Zo+74PsRxzyKR1m6y2anPRzEuvXZJDEF5yCR9FyAa6PT02yQKxj14kLvjhyyg==", "123456789", false, null, "abc", 1, false, "admin" });

            migrationBuilder.InsertData(
                table: "R_ProjectUser",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "ProjectId", "UserId" },
                values: new object[] { 1L, new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2193), 0L, new DateTime(2024, 3, 16, 13, 31, 20, 540, DateTimeKind.Local).AddTicks(2211), 1L, 1L });

            migrationBuilder.InsertData(
                table: "R_RolePermission",
                columns: new[] { "Id", "CreationTime", "CreatorId", "LastModificationTime", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5526), 0L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5527), 1L, 1L },
                    { 2L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5541), 0L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5542), 2L, 1L },
                    { 3L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5543), 0L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5544), 3L, 1L },
                    { 4L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5545), 0L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5546), 4L, 1L },
                    { 5L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5547), 0L, new DateTime(2024, 3, 16, 13, 31, 20, 691, DateTimeKind.Local).AddTicks(5547), 5L, 1L }
                });

            migrationBuilder.InsertData(
                table: "R_UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_R_RolePermission_PermissionId",
                table: "R_RolePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_R_RolePermission_RoleId",
                table: "R_RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_R_ProjectUser_ProjectId",
                table: "R_ProjectUser",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_R_ProjectUser_UserId",
                table: "R_ProjectUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_R_ProjectUser_R_Project_ProjectId",
                table: "R_ProjectUser",
                column: "ProjectId",
                principalTable: "R_Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_ProjectUser_R_User_UserId",
                table: "R_ProjectUser",
                column: "UserId",
                principalTable: "R_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_RoleClaim_R_Role_RoleId",
                table: "R_RoleClaim",
                column: "RoleId",
                principalTable: "R_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_RolePermission_R_Permission_PermissionId",
                table: "R_RolePermission",
                column: "PermissionId",
                principalTable: "R_Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_RolePermission_R_Role_RoleId",
                table: "R_RolePermission",
                column: "RoleId",
                principalTable: "R_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_UserClaim_R_User_UserId",
                table: "R_UserClaim",
                column: "UserId",
                principalTable: "R_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_UserLogin_R_User_UserId",
                table: "R_UserLogin",
                column: "UserId",
                principalTable: "R_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_UserRole_R_Role_RoleId",
                table: "R_UserRole",
                column: "RoleId",
                principalTable: "R_Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_UserRole_R_User_UserId",
                table: "R_UserRole",
                column: "UserId",
                principalTable: "R_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_R_UserToken_R_User_UserId",
                table: "R_UserToken",
                column: "UserId",
                principalTable: "R_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_R_ProjectUser_R_Project_ProjectId",
                table: "R_ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_R_ProjectUser_R_User_UserId",
                table: "R_ProjectUser");

            migrationBuilder.DropForeignKey(
                name: "FK_R_RoleClaim_R_Role_RoleId",
                table: "R_RoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_R_RolePermission_R_Permission_PermissionId",
                table: "R_RolePermission");

            migrationBuilder.DropForeignKey(
                name: "FK_R_RolePermission_R_Role_RoleId",
                table: "R_RolePermission");

            migrationBuilder.DropForeignKey(
                name: "FK_R_UserClaim_R_User_UserId",
                table: "R_UserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_R_UserLogin_R_User_UserId",
                table: "R_UserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_R_UserRole_R_Role_RoleId",
                table: "R_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_R_UserRole_R_User_UserId",
                table: "R_UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_R_UserToken_R_User_UserId",
                table: "R_UserToken");

            migrationBuilder.DropIndex(
                name: "IX_R_RolePermission_PermissionId",
                table: "R_RolePermission");

            migrationBuilder.DropIndex(
                name: "IX_R_RolePermission_RoleId",
                table: "R_RolePermission");

            migrationBuilder.DropIndex(
                name: "IX_R_ProjectUser_ProjectId",
                table: "R_ProjectUser");

            migrationBuilder.DropIndex(
                name: "IX_R_ProjectUser_UserId",
                table: "R_ProjectUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_R_UserToken",
                table: "R_UserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_R_UserRole",
                table: "R_UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_R_UserLogin",
                table: "R_UserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_R_UserClaim",
                table: "R_UserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_R_User",
                table: "R_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_R_RoleClaim",
                table: "R_RoleClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_R_Role",
                table: "R_Role");

            migrationBuilder.DeleteData(
                table: "R_ProjectUser",
                keyColumn: "Id",
                keyValue: 1L);

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
                table: "R_Project",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "R_Role",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "R_User",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.RenameTable(
                name: "R_UserToken",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "R_UserRole",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "R_UserLogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "R_UserClaim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "R_User",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "R_RoleClaim",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "R_Role",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_R_UserRole_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_R_UserLogin_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_R_UserClaim_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_R_RoleClaim_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
