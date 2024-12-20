using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Veterinary.Backend.Infrastructure.Persistence.Context;

namespace Veterinary.Backend.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddPersistence(services, configuration);
            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ApplicationConnection") ?? throw new NullReferenceException();

            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            return services;
        }
    }
}