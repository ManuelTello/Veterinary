using Microsoft.EntityFrameworkCore;
using Veterinary.Backend.Domain.AggregateRoots.Owner;

namespace Veterinary.Backend.Infrastructure.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ApplicationContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }

        public DbSet<Owner> Owners { get; set; }
    }
}

