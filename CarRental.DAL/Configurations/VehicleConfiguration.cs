using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Configurations
{
    public class VehicleConfiguration:IEntityTypeConfiguration<Vehicle>
    {

        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");

            builder.HasKey(v => v.VehicleID);

            builder.Property(v => v.VehicleID)
                   .ValueGeneratedOnAdd();

            builder.Property(v => v.Make)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(v => v.Model)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(v => v.Year)
                   .IsRequired();

            builder.Property(v => v.CurrentMilage)
                   .IsRequired();

            builder.Property(v => v.FuleTypeID)
                   .IsRequired();

            builder.Property(v => v.VehicleCategoryID)
                   .IsRequired();

            builder.Property(v => v.PlateNumber)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(v => v.RentalPricePerDay)
                   .HasColumnType("smallmoney")
                   .IsRequired();

            builder.Property(v => v.IsAvailableForRent)
                   .IsRequired();

            builder.Property(v => v.ImagePath)
                   .HasColumnType("nchar(300)")
                   .IsRequired(false);

            // RentalBookings Relationship (One-to-Many)
            builder.HasMany(v => v.RentalBookings)
                   .WithOne(b => b.Vehicle)
                   .HasForeignKey(b => b.VehicleID);

            // Maintenances Relationship (One-to-Many)
            builder.HasMany(v => v.Maintenances)
                   .WithOne(m => m.Vehicle)
                   .HasForeignKey(m => m.VehicleID);


        }


    }
}
