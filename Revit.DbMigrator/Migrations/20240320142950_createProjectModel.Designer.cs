﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Revit.EntityFrameworkCore;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240320142950_createProjectModel")]
    partial class createProjectModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6699),
                            CreatorId = 0L,
                            Icon = "el-icon-s-tools",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6720),
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
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6728),
                            CreatorId = 0L,
                            Icon = "el-icon-user-solid",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6728),
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
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6732),
                            CreatorId = 0L,
                            Icon = "peoples",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6732),
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
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6735),
                            CreatorId = 0L,
                            Icon = "list",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6736),
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
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6738),
                            CreatorId = 0L,
                            Icon = "example",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6739),
                            Name = "角色权限",
                            ParentId = 1L,
                            PermissionType = 0,
                            Sort = 0,
                            Status = 1,
                            Url = "rolepermission"
                        });
                });

            modelBuilder.Entity("Revit.Entity.Project.R_Project", b =>
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

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("项目介绍");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("datetime2")
                        .HasComment("最后编辑时间");

                    b.Property<string>("ProjectAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("项目地址");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("项目名称");

                    b.HasKey("Id");

                    b.ToTable("R_Project", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5547),
                            CreatorId = 1L,
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5543),
                            ProjectAddress = "",
                            ProjectName = "测试1"
                        },
                        new
                        {
                            Id = 2L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5550),
                            CreatorId = 1L,
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5549),
                            ProjectAddress = "",
                            ProjectName = "测试2"
                        },
                        new
                        {
                            Id = 3L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5553),
                            CreatorId = 1L,
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5551),
                            ProjectAddress = "",
                            ProjectName = "测试3"
                        },
                        new
                        {
                            Id = 4L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5555),
                            CreatorId = 1L,
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5554),
                            ProjectAddress = "",
                            ProjectName = "测试4"
                        },
                        new
                        {
                            Id = 5L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5557),
                            CreatorId = 1L,
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5556),
                            ProjectAddress = "",
                            ProjectName = "测试5"
                        },
                        new
                        {
                            Id = 6L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5560),
                            CreatorId = 1L,
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5559),
                            ProjectAddress = "",
                            ProjectName = "测试6"
                        });
                });

            modelBuilder.Entity("Revit.Entity.Project.R_ProjectUser", b =>
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

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint")
                        .HasComment("项目Id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasComment("用户Id");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("R_ProjectUser", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5257),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5273),
                            ProjectId = 1L,
                            UserId = 1L
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
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5599),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5597),
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
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6805),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6805),
                            PermissionId = 1L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6808),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6809),
                            PermissionId = 2L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6810),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6811),
                            PermissionId = 3L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6811),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6812),
                            PermissionId = 4L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6813),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 722, DateTimeKind.Local).AddTicks(6813),
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
                            ConcurrencyStamp = "8203aacc-f95e-449d-835f-85b339fbcabd",
                            CreationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5731),
                            CreatorId = 0L,
                            Email = "admin@R_tric.com",
                            EmailConfirmed = true,
                            FullName = "管理员",
                            LastModificationTime = new DateTime(2024, 3, 20, 22, 29, 49, 616, DateTimeKind.Local).AddTicks(5683),
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@R_TRIC.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEA2sbjtZZ4JDoDM3egC28BaY804INcoBrhfYe/YE1cu9N1YIitoFi7niy6BZAFpYrQ==",
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

            modelBuilder.Entity("Revit.Entity.Project.R_ProjectUser", b =>
                {
                    b.HasOne("Revit.Entity.Project.R_Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Revit.Entity.Users.R_User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
