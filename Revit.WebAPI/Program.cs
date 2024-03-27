using Autofac;
using Autofac.Extensions.DependencyInjection;
using Revit.WebAPI.Extension;

var builder = WebApplication.CreateBuilder(args);

//����host������
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacModuleRegister());
});

//builder.Services.AddRateLimiter(config => config.AddFixedWindowLimiter("fixed", option =>
//{
//    option.PermitLimit = 100;
//    option.Window = TimeSpan.FromSeconds(10);
//    option.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
//    option.QueueLimit = 10;

//}));

//builder.Logging.AddConsole().AddEventLog();


builder.AddRevitController();

builder.AddRevitSwaggerGen();

builder.AddRevitDbContext();


//Identityע�룬������ݿ�������
builder.AddRevitServices();


builder.AddRevitAutoMapper();
//swagger

builder.AddRevitUnitOfWork();

builder.ConfigFile();

builder.AddRevitJWT();


var origins = builder.AddRevitCorsOrigins();

var app = builder.Build();

app.UseCors(origins);
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
