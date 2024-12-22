﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veterinary.Backend.Infrastructure.Persistence.Context;

#nullable disable

namespace Veterinary.Backend.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20241220222137_OwnerAdded")]
    partial class OwnerAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Veterinary.Backend.Domain.AggregateRoots.Owner.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("id")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("DateAddedToTheSystem")
                        .HasColumnType("DATETIME")
                        .HasColumnName("date_added_to_system")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("owners", (string)null);
                });

            modelBuilder.Entity("Veterinary.Backend.Domain.AggregateRoots.Owner.Owner", b =>
                {
                    b.OwnsOne("Veterinary.Backend.Domain.ObjectValues.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("OwnerId")
                                .HasColumnType("VARCHAR");

                            b1.Property<string>("EmailValue")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("VARCHAR")
                                .HasColumnName("email_address")
                                .HasColumnOrder(3);

                            b1.HasKey("OwnerId");

                            b1.ToTable("owners");

                            b1.WithOwner()
                                .HasForeignKey("OwnerId");
                        });

                    b.OwnsOne("Veterinary.Backend.Domain.ObjectValues.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("OwnerId")
                                .HasColumnType("VARCHAR");

                            b1.Property<string>("NameValue")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("VARCHAR")
                                .HasColumnName("name")
                                .HasColumnOrder(4);

                            b1.HasKey("OwnerId");

                            b1.ToTable("owners");

                            b1.WithOwner()
                                .HasForeignKey("OwnerId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
