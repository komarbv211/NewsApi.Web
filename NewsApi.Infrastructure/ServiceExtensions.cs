

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewsApi.Infrastructure.Context;

namespace NewsApi.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        }
    }
}
