using Revit.Repository.UnitOfWork;

namespace Revit.WebAPI.Extension
{
    public static class UnitOfWorkExtension
    {
        internal static void AddRevitUnitOfWork(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
