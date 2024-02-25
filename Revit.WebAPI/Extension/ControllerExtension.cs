using Microsoft.Extensions.DependencyInjection;
using Revit.Service.UnitOfWork;

namespace Revit.WebAPI.Extension
{
    public static class ControllerExtension
    {
        internal static void AddRevitController(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers(config =>
            {
                config.Filters.Add<UnitOfWorkFilterAttribute>();
            }).AddNewtonsoftJson(option =>
            {
                option.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
            });
        }

    }
}
