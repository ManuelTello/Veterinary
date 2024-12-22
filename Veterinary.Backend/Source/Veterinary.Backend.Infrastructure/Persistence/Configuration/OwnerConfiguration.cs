using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Veterinary.Backend.Domain.AggregateRoots.Owner;

namespace Veterinary.Backend.Infrastructure.Persistence.Configuration
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.ToTable("owners");

            builder.HasKey(owner => owner.Id);
            builder.Property(owner => owner.Id)
                .HasColumnOrder(1)
                .HasColumnName("id")
                .HasColumnType("VARCHAR")
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(owner => owner.DateAddedToTheSystem)
                .HasColumnOrder(2)
                .HasColumnName("date_added_to_system")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.OwnsOne(owner => owner.Email, email =>
            {
                email.Property(p => p.EmailValue)
                    .HasColumnOrder(3)
                    .HasColumnName("email_address")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(250)
                    .IsRequired();
            });

            builder.OwnsOne(owner => owner.Name, name =>
            {
                name.Property(p => p.NameValue)
                    .HasColumnOrder(4)
                    .HasColumnName("name")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(250)
                    .IsRequired();
            });
        }
    }
}