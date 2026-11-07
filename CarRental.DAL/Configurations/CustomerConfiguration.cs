using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            
            builder.ToTable("Customers");

            builder.HasKey(c => c.CustomerID);

            builder.Property(c => c.CustomerID)
                   .ValueGeneratedOnAdd();

            builder.Property(c => c.PersonID)
                   .IsRequired();

            builder.Property(c => c.CreationDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(c => c.CreatedByUserID)
                   .IsRequired();

            builder.Property(c => c.DriverLicenseNumber)
                   .HasColumnName("DriverLicenseNumber")
                   .HasMaxLength(20)
                   .IsRequired(false);

            // Person Relationship (One-to-One)
            builder.HasOne(c => c.Person)
                   .WithOne(p => p.Customer)
                   .HasForeignKey<Customer>(c => c.PersonID);

            // RentalBookings Relationship (One-to-Many)
            builder.HasMany(c => c.RentalBookings)
                   .WithOne(b => b.Customer)
                   .HasForeignKey(b => b.CustomerID);
        }
    }
}
