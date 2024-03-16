using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//���ݿ�������ע��
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    //���õ����ݿ�����
    var provider = builder.Configuration.GetValue<string>("DataProvider");
    switch (provider)
    {
        case "MsSql":
            var msSqlConnection = builder.Configuration.GetConnectionString("MsSqlConnection") 
            ?? throw new InvalidOperationException("MsSqlConnection��appsettings.jsonδ����");
            options.UseSqlServer(msSqlConnection, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
            break;
        case "MySql":
            var mySqlConnection = builder.Configuration.GetConnectionString("MySqlConnection") ?? throw new InvalidOperationException("MySqlConnection��appsettings.jsonδ����");
            //MySql��Ҫ����汾��ServerVersion.AutoDetect���������ַ����Զ���ȡ
            options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection), b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
            break;
    }
});


//Identityע�룬������ݿ�������
builder.Services.AddIdentity<R_User, R_Role>()
            .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

var app = builder.Build();
app.Run();