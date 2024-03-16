using Microsoft.Extensions.DependencyInjection;
using Revit.Service.UnitOfWork;
using Revit.WebAPI.Auth;

namespace Revit.WebAPI.Extension
{
    public static class ControllerExtension
    {
        internal static void AddRevitController(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers(config =>
            {
                config.Filters.Add<UnitOfWorkFilterAttribute>();
                config.Filters.Add<R_AuthorizeAttribute>();
            }).AddNewtonsoftJson(option =>
            {
                option.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm";
            });
        }

    }
}
