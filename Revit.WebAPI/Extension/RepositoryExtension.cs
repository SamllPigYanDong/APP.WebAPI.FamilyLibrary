using Revit.Repository.Commons;

namespace Revit.WebAPI.Extension
{
    public static class RepositoryExtension
    {
        internal static void AddRevitRepository(this WebApplicationBuilder builder)
        {
            var assemblies = AppDomain.CurrentDomain.GetReferanceAssemblies();
            foreach (var assembly in assemblies)
            {
                List<Type> types = assembly.GetTypes()
                    .Where(t => t.BaseType == typeof(BaseRepository))
                    .ToList();
                types.ForEach(type =>
                {
                    //获取该类所继承的所有接口
                    Type[] interfaces = type.GetInterfaces();
                    interfaces.ToList().ForEach(interfaceObject =>
                    {
                        builder.Services.AddTransient(interfaceObject, type);
                    });
                });
            }

        }
    }
}
