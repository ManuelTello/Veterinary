using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Veterinary.Backend.Infrastructure.Persistence.Context;

namespace Veterinary.Backend.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            AddPersistence(services);
            return services;
        }
        
        private static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlite("Data Source=Veterinary.db;Cache=Shared;Mode=ReadWriteCreate;");
            });
            return services;
        }
    }
}

