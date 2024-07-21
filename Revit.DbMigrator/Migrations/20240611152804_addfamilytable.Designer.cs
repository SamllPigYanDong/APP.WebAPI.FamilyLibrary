﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Revit.EntityFrameworkCore;

#nullable disable

namespace Revit.DbMigrator.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240611152804_addfamilytable")]
    partial class addfamilytable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.20");

            modelBuilder.Entity("GalaFamilyLibraryServer.Application.Entities.R_Family", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("文件路径");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("R_Family", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2437),
                            CreatorId = 1L,
                            FilePath = "NULL",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2436),
                            Name = "TESTFAMILY"
                        });
                });

            modelBuilder.Entity("GalaFamilyLibraryServer.Application.Entities.R_FamilyUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<long>("FamilyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("R_FamilyUser");
                });

            modelBuilder.Entity("Revit.Entity.Permissions.R_Permission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApiMethod")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasComment("API方法：GET、PUT、POST、DELETE");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasComment("权限编码");

                    b.Property<string>("Component")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT")
                        .HasComment("Vue页面组件");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<string>("Icon")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasComment("图标");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT")
                        .HasComment("权限名称");

                    b.Property<long>("ParentId")
                        .HasColumnType("INTEGER")
                        .HasComment("父菜单Id");

                    b.Property<int>("PermissionType")
                        .HasColumnType("INTEGER")
                        .HasComment("菜单类型,0：菜单权限、元素权限、Api权限、数据权限");

                    b.Property<string>("Remark")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT")
                        .HasComment("备注");

                    b.Property<int>("Sort")
                        .HasColumnType("INTEGER")
                        .HasComment("排序");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER")
                        .HasComment("状态，0：禁用，1：正常");

                    b.Property<string>("Url")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT")
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
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4811),
                            CreatorId = 0L,
                            Icon = "el-icon-s-tools",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4826),
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
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4836),
                            CreatorId = 0L,
                            Icon = "el-icon-user-solid",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4838),
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
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4840),
                            CreatorId = 0L,
                            Icon = "peoples",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4841),
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
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4843),
                            CreatorId = 0L,
                            Icon = "list",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4843),
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
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4847),
                            CreatorId = 0L,
                            Icon = "example",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4847),
                            Name = "角色权限",
                            ParentId = 1L,
                            PermissionType = 0,
                            Sort = 0,
                            Status = 1,
                            Url = "rolepermission"
                        });
                });

            modelBuilder.Entity("Revit.Entity.Problem.R_Problem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("TEXT")
                        .HasComment("截止日期");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT")
                        .HasComment("问题描述");

                    b.Property<int>("EmergencyDegree")
                        .HasColumnType("INTEGER")
                        .HasComment("紧急程度");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<int>("ProblemStatus")
                        .HasColumnType("INTEGER")
                        .HasComment("问题状态");

                    b.Property<long>("RelativeFileId")
                        .HasColumnType("INTEGER")
                        .HasComment("相关文件Id");

                    b.Property<long>("ResponsibleId")
                        .HasColumnType("INTEGER")
                        .HasComment("责任人Id");

                    b.Property<long>("VerifierId")
                        .HasColumnType("INTEGER")
                        .HasComment("审核人Id");

                    b.HasKey("Id");

                    b.ToTable("R_Problem", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Project.R_Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("图标路径");

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("项目介绍");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<string>("ProjectAddress")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("项目地址");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("项目名称");

                    b.HasKey("Id");

                    b.ToTable("R_Project", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2564),
                            CreatorId = 1L,
                            IconPath = "",
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2563),
                            ProjectAddress = "",
                            ProjectName = "测试1"
                        },
                        new
                        {
                            Id = 2L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2566),
                            CreatorId = 1L,
                            IconPath = "",
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2565),
                            ProjectAddress = "",
                            ProjectName = "测试2"
                        },
                        new
                        {
                            Id = 3L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2567),
                            CreatorId = 1L,
                            IconPath = "",
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2566),
                            ProjectAddress = "",
                            ProjectName = "测试3"
                        },
                        new
                        {
                            Id = 4L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2568),
                            CreatorId = 1L,
                            IconPath = "",
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2568),
                            ProjectAddress = "",
                            ProjectName = "测试4"
                        },
                        new
                        {
                            Id = 5L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2570),
                            CreatorId = 1L,
                            IconPath = "",
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2569),
                            ProjectAddress = "",
                            ProjectName = "测试5"
                        },
                        new
                        {
                            Id = 6L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2571),
                            CreatorId = 1L,
                            IconPath = "",
                            Introduction = "",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2571),
                            ProjectAddress = "",
                            ProjectName = "测试6"
                        });
                });

            modelBuilder.Entity("Revit.Entity.Project.R_ProjectFolder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("后缀名称");

                    b.Property<string>("FileSize")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("文件大小");

                    b.Property<bool>("IsRoot")
                        .HasColumnType("INTEGER")
                        .HasComment("是否为根路径");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("文件名称无后缀");

                    b.Property<long>("ProjectId")
                        .HasColumnType("INTEGER")
                        .HasComment("项目Id");

                    b.Property<string>("RelativePath")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasComment("相对路径");

                    b.HasKey("Id");

                    b.ToTable("R_ProjectFolder", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Project.R_ProjectUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<long>("ProjectId")
                        .HasColumnType("INTEGER")
                        .HasComment("项目Id");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER")
                        .HasComment("用户Id");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("R_ProjectUser", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2549),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2550),
                            ProjectId = 1L,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("Revit.Entity.Roles.R_Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Remark")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT")
                        .HasComment("备注");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER")
                        .HasComment("状态，0：禁用，1：正常");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("R_Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ConcurrencyStamp = "94f492ce-0bf5-4f00-8977-e7b588af8cc7",
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2632),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2587),
                            Name = "admin",
                            NormalizedName = "ADMIN",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Revit.Entity.Roles.R_RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("R_RoleClaim", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Roles.R_RolePermission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<long>("PermissionId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("R_RolePermission");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4910),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4911),
                            PermissionId = 1L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4915),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4916),
                            PermissionId = 2L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4917),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4918),
                            PermissionId = 3L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4918),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4918),
                            PermissionId = 4L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4919),
                            CreatorId = 0L,
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 92, DateTimeKind.Local).AddTicks(4919),
                            PermissionId = 5L,
                            RoleId = 1L
                        });
                });

            modelBuilder.Entity("Revit.Entity.Users.R_User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT")
                        .HasComment("创建时间");

                    b.Property<long>("CreatorId")
                        .HasColumnType("INTEGER")
                        .HasComment("创建者Id");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnType("TEXT")
                        .HasComment("最后编辑时间");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("R_User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f64694bf-63b2-43a7-a6b5-a870ecd2b395",
                            CreationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2663),
                            CreatorId = 0L,
                            Email = "admin@R_tric.com",
                            EmailConfirmed = true,
                            FullName = "管理员",
                            LastModificationTime = new DateTime(2024, 6, 11, 23, 28, 4, 90, DateTimeKind.Local).AddTicks(2659),
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@R_TRIC.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEBPD81huwnddt9ouM3VM/BDGfomuRAccFWKmQqR/VRPEZCl58xmjfTbzI0B/ncGilg==",
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
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("R_UserClaim", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("R_UserLogin", (string)null);
                });

            modelBuilder.Entity("Revit.Entity.Users.R_UserRole", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RoleId")
                        .HasColumnType("INTEGER");

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
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("R_UserToken", (string)null);
                });

            modelBuilder.Entity("GalaFamilyLibraryServer.Application.Entities.R_FamilyUser", b =>
                {
                    b.HasOne("GalaFamilyLibraryServer.Application.Entities.R_Family", null)
                        .WithMany()
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
