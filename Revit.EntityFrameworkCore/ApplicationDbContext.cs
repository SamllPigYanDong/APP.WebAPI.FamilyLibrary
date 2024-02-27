
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Revit.Entity.Permissions;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using System.Reflection.Emit;

namespace Revit.EntityFrameworkCore
{
    public class ApplicationDbContext : IdentityDbContext<R_User, R_Role, long
        , R_UserClaim, R_UserRole, R_UserLogin, R_RoleClaim, R_UserToken>
    {

        public DbSet<R_RolePermission> R_RolePermission { get; set; }
        public DbSet<R_Permission> R_Permission { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            CreateTable(modelBuilder);
            SetProperties(modelBuilder);
            InitialData(modelBuilder);
        }

        private void CreateTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<R_User>().ToTable("R_User");

            modelBuilder.Entity<R_UserLogin>().ToTable("R_UserLogin");
            modelBuilder.Entity<R_UserClaim>().ToTable("R_UserClaim");
            modelBuilder.Entity<R_UserToken>().ToTable("R_UserToken");

            modelBuilder.Entity<R_Role>().ToTable("R_Role");

            modelBuilder.Entity<R_RoleClaim>().ToTable("R_RoleClaim");

            modelBuilder.Entity<R_UserRole>().ToTable("R_UserRole");
        }

        private void SetProperties(ModelBuilder modelBuilder)
        {
            //设定字段长度
            modelBuilder.Entity<R_Role>(entity =>
            {
                entity.Property(r => r.Name).HasMaxLength(100);
                entity.Property(r => r.NormalizedName).HasMaxLength(100);
            });
            modelBuilder.Entity<R_User>(entity =>
            {
                entity.Property(r => r.UserName).HasMaxLength(100);
                entity.Property(r => r.NormalizedUserName).HasMaxLength(100);
            });
            //1. 指定外键关系
            modelBuilder.Entity<R_Role>(entity =>
            {
                //指定角色与角色权限表，一对多
                entity.HasMany<R_RolePermission>().WithOne().HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<R_Permission>(entity =>
            {
                //指定权限与角色权限表，一对多
                entity.HasMany<R_RolePermission>().WithOne().HasForeignKey(x => x.PermissionId).OnDelete(DeleteBehavior.Cascade);
            });
        }

        private void InitialData(ModelBuilder modelBuilder)
        {
            var adminRoleId = 1;
            // 2. 添加角色
            modelBuilder.Entity<R_Role>().HasData(
                new R_Role
                {
                    Id = adminRoleId,
                    CreationTime = DateTime.Now,
                    Name = "管理员",
                    NormalizedName = "管理员".ToUpper(),
                    Status = RoleStatus.Normal
                }
            );

            // 3. 添加用户
            var adminUserId = 1;
            R_User adminUser = new R_User
            {
                Id = adminUserId,
                CreationTime = DateTime.Now,
                UserName = "admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "admin@R_tric.com",
                NormalizedEmail = "admin@R_tric.com".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false,
                SecurityStamp = "abc",
                FullName = "管理员",
                Status = UserStatus.Normal
            };

            PasswordHasher<R_User> ph = new PasswordHasher<R_User>();
            adminUser.PasswordHash = ph.HashPassword(adminUser, "Abc123@");
            modelBuilder.Entity<R_User>().HasData(adminUser);

            // 4. 给用户加入管理员权限
            modelBuilder.Entity<R_UserRole>()
                .HasData(new R_UserRole()
                {
                    RoleId = adminRoleId,
                    UserId = adminUserId
                });

            //5. 初始化权限
            var permissionList = new List<R_Permission>
{
    new R_Permission()
    {
        Id = 1,
        Name = "系统管理",
        Code = "system",
        Url = "system",
        Component = "",
        Icon = "el-icon-s-tools",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 0,
        Status = PermissionStatus.Normal
    },
    new R_Permission()
    {
        Id = 2,
        Name = "用户管理",
        Code = "system.user",
        Url = "system.user",
        Component = "views/documentation/index",
        Icon = "el-icon-user-solid",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 1,
        Status = PermissionStatus.Normal
    },
    new R_Permission()
    {
        Id = 3,
        Name = "角色管理",
        Code = "system.role",
        Url = "role",
        Component = "views/documentation/index",
        Icon = "peoples",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 1,
        Status = PermissionStatus.Normal
    },
    new R_Permission()
    {
        Id = 4,
        Name = "菜单管理",
        Code = "system.permission",
        Url = "permission",
        Component = "views/documentation/index",
        Icon = "list",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 1,
        Status = PermissionStatus.Normal
    }
    ,
    new R_Permission()
    {
        Id = 5,
        Name = "角色权限",
        Code = "system.rolepermission",
        Url = "rolepermission",
        Component = "views/documentation/index",
        Icon = "example",
        PermissionType = PermissionType.Menu,
        ApiMethod = "",
        Sort = 0,
        ParentId = 1,
        Status = PermissionStatus.Normal
    }
};
            modelBuilder.Entity<R_Permission>().HasData(permissionList);

            // 6. 给角色分配权限
            var rolePermissionList = new List<R_RolePermission>();
            foreach (var permission in permissionList)
            {
                rolePermissionList.Add(new R_RolePermission()
                {
                    Id = permission.Id,
                    RoleId = adminRoleId,
                    PermissionId = permission.Id
                });
            }
            modelBuilder.Entity<R_RolePermission>()
                .HasData(rolePermissionList);
        }

    }
}
