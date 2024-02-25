﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "R_Permission",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "权限名称"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "权限编码"),
                    Url = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "Url地址"),
                    Component = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "Vue页面组件"),
                    Icon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "图标"),
                    PermissionType = table.Column<int>(type: "int", nullable: false, comment: "菜单类型,0：菜单权限、元素权限、Api权限、数据权限"),
                    ApiMethod = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, comment: "API方法：GET、PUT、POST、DELETE"),
                    Sort = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    ParentId = table.Column<long>(type: "bigint", nullable: false, comment: "父菜单Id"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态，0：禁用，1：正常"),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "备注"),
                    CreatorId = table.Column<long>(type: "bigint", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_Role",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorId = table.Column<long>(type: "bigint", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "最后编辑时间"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态，0：禁用，1：正常"),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "备注"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorId = table.Column<long>(type: "bigint", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "最后编辑时间"),
                    FullName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "R_RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_RoleClaim_R_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "R_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_RolePermission",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    PermissionId = table.Column<long>(type: "bigint", nullable: false),
                    CreatorId = table.Column<long>(type: "bigint", nullable: false, comment: "创建者Id"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "创建时间"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "最后编辑时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_RolePermission_R_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "R_Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_R_RolePermission_R_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "R_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_R_UserClaim_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_UserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_R_UserLogin_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_UserRole",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_R_UserRole_R_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "R_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_R_UserRole_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "R_UserToken",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_R_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_R_UserToken_R_User_UserId",
                        column: x => x.UserId,
                        principalTable: "R_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_R_Permission_Code",
                table: "R_Permission",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_R_Permission_ParentId",
                table: "R_Permission",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_R_Permission_Sort",
                table: "R_Permission",
                column: "Sort");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "R_Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_R_RoleClaim_RoleId",
                table: "R_RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_R_RolePermission_PermissionId",
                table: "R_RolePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_R_RolePermission_RoleId",
                table: "R_RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "R_User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "R_User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_R_UserClaim_UserId",
                table: "R_UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_R_UserLogin_UserId",
                table: "R_UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_R_UserRole_RoleId",
                table: "R_UserRole",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "R_RoleClaim");

            migrationBuilder.DropTable(
                name: "R_RolePermission");

            migrationBuilder.DropTable(
                name: "R_UserClaim");

            migrationBuilder.DropTable(
                name: "R_UserLogin");

            migrationBuilder.DropTable(
                name: "R_UserRole");

            migrationBuilder.DropTable(
                name: "R_UserToken");

            migrationBuilder.DropTable(
                name: "R_Permission");

            migrationBuilder.DropTable(
                name: "R_Role");

            migrationBuilder.DropTable(
                name: "R_User");
        }
    }
}