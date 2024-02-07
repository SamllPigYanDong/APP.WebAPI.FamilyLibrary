﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Revit.EntityFrameworkCore;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Revit.Entity.Permissions.R_Permission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ApiMethod")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("API方法：GET、PUT、POST、DELETE");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("权限编码");

                    b.Property<string>("Component")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Vue页面组件");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("bigint")
                        .HasComment("创建者Id");

                    b.Property<string>("Icon")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("图标");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasComment("最后编辑时间");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("权限名称");

                    b.Property<long>("ParentId")
                        .HasColumnType("bigint")
                        .HasComment("父菜单Id");

                    b.Property<int>("PermissionType")
                        .HasColumnType("int")
                        .HasComment("菜单类型,0：菜单权限、元素权限、Api权限、数据权限");

                    b.Property<string>("Remark")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("备注");

                    b.Property<int>("Sort")
                        .HasColumnType("int")
                        .HasComment("排序");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("状态，0：禁用，1：正常");

                    b.Property<string>("Url")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Url地址");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("ParentId");

                    b.HasIndex("Sort");

                    b.ToTable("R_Permission");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ApiMethod = "",
                            Code = "system",
                            Component = "",
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5709),
                            CreatorId = 0L,
                            Icon = "el-icon-s-tools",
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "系统管理",
                            ParentId = 0L,
                            PermissionType = 0,
                            Sort = 0,
                            Status = 1,
                            Url = "system"
                        },
                        new
                        {
                            Id = 2L,
                            ApiMethod = "",
                            Code = "system.user",
                            Component = "views/documentation/index",
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5724),
                            CreatorId = 0L,
                            Icon = "el-icon-user-solid",
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "用户管理",
                            ParentId = 1L,
                            PermissionType = 0,
                            Sort = 0,
                            Status = 1,
                            Url = "system.user"
                        },
                        new
                        {
                            Id = 3L,
                            ApiMethod = "",
                            Code = "system.role",
                            Component = "views/documentation/index",
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5729),
                            CreatorId = 0L,
                            Icon = "peoples",
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "角色管理",
                            ParentId = 1L,
                            PermissionType = 0,
                            Sort = 0,
                            Status = 1,
                            Url = "role"
                        },
                        new
                        {
                            Id = 4L,
                            ApiMethod = "",
                            Code = "system.permission",
                            Component = "views/documentation/index",
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5730),
                            CreatorId = 0L,
                            Icon = "list",
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "菜单管理",
                            ParentId = 1L,
                            PermissionType = 0,
                            Sort = 0,
                            Status = 1,
                            Url = "permission"
                        },
                        new
                        {
                            Id = 5L,
                            ApiMethod = "",
                            Code = "system.rolepermission",
                            Component = "views/documentation/index",
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5734),
                            CreatorId = 0L,
                            Icon = "example",
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "角色权限",
                            ParentId = 1L,
                            PermissionType = 0,
                            Sort = 0,
                            Status = 1,
                            Url = "rolepermission"
                        });
                });

            modelBuilder.Entity("Revit.Entity.Roles.R_Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("bigint")
                        .HasComment("创建者Id");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasComment("最后编辑时间");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Remark")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("备注");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("状态，0：禁用，1：正常");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("R_Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ConcurrencyStamp = "bef6ea55-9d1d-4721-a7a1-3141b609a1c1",
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 152, DateTimeKind.Local).AddTicks(1710),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "管理员",
                            NormalizedName = "管理员",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Revit.Entity.Roles.R_RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("R_RoleClaim", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Roles.R_RolePermission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("bigint")
                        .HasComment("创建者Id");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasComment("最后编辑时间");

                    b.Property<long>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("R_RolePermission");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5788),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PermissionId = 1L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5792),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PermissionId = 2L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5793),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PermissionId = 3L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5794),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PermissionId = 4L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 160, DateTimeKind.Local).AddTicks(5794),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PermissionId = 5L,
                            RoleId = 1L
                        });
                });

            modelBuilder.Entity("Revit.Entity.Users.R_User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("bigint")
                        .HasComment("创建者Id");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasComment("最后编辑时间");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Remark")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("R_User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "87c810d0-7c5d-4475-9b76-3a8531c07dee",
                            CreationTime = new DateTime(2024, 2, 7, 13, 16, 36, 152, DateTimeKind.Local).AddTicks(1932),
                            CreatorId = 0L,
                            Email = "admin@R_tric.com",
                            EmailConfirmed = true,
                            FullName = "管理员",
                            LastModificationTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@R_TRIC.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAENL+nQ4Wyexazej1dp8uLxq9o07Zyp/ZPChJkXHYHyy2x70ZNMhz4khMjMl5Nm4t6w==",
                            PhoneNumber = "123456789",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "abc",
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("R_UserClaim", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("R_UserLogin", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserRole", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("R_UserRole", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            RoleId = 1L
                        });
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserToken", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("R_UserToken", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Roles.R_RoleClaim", b =>
                {
                    b.HasOne("Revit.Entity.Roles.R_Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Revit.Entity.Roles.R_RolePermission", b =>
                {
                    b.HasOne("Revit.Entity.Permissions.R_Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Revit.Entity.Roles.R_Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserClaim", b =>
                {
                    b.HasOne("Revit.Entity.Users.R_User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserLogin", b =>
                {
                    b.HasOne("Revit.Entity.Users.R_User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserRole", b =>
                {
                    b.HasOne("Revit.Entity.Roles.R_Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Revit.Entity.Users.R_User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserToken", b =>
                {
                    b.HasOne("Revit.Entity.Users.R_User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
