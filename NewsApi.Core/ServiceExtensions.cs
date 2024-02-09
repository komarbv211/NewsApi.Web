using Microsoft.Extensions.DependencyInjection;
using NewsApi.Core.AutoMapper;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using NewsApi.Core.Services;

namespace NewsApi.Core
{
    public static class ServiceExtensions
    {
        public static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperNewsProfile));
        }
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseService<News>), typeof(BaseService<News>));
            services.AddScoped(typeof(IBaseService<Authors>), typeof(BaseService<Authors>));
            //services.AddScoped(typeof(IBaseService<Roles>), typeof(BaseService<Roles>));
            //services.AddScoped(typeof(IBaseService<Users>), typeof(BaseService<Users>));
            services.AddScoped(typeof(IBaseService<Statistics>), typeof(BaseService<Statistics>));
        }
    }
}
