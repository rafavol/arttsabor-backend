using ArttSabor.Persistence.Repositories;
using ArttSabor.Persistence.Repositories.Interfaces;

namespace ArttSabor.API.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        }
    }
}
