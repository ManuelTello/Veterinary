using Microsoft.EntityFrameworkCore;

namespace Veterinary.Backend.Infrastructure.Persistence.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ApplicationContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }
    }
}

