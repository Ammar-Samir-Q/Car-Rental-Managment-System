using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Configurations
{
    public class MaintenanceConfiguration:IEntityTypeConfiguration<Maintenance>
    {
        public void Configure(EntityTypeBuilder<Maintenance> builder)
        {
            builder.ToTable("Maintenances");

            builder.HasKey(m => m.MaintenanceID);

            builder.Property(m => m.MaintenanceID)
                   .ValueGeneratedOnAdd();

            builder.Property(m => m.VehicleID)
                   .IsRequired();

            builder.Property(m => m.Description)
                   .HasMaxLength(300)
                   .IsRequired(false);

            builder.Property(m => m.MaintenanceDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(m => m.Cost)
                   .HasColumnType("smallmoney")
                   .IsRequired();

            builder.HasOne(m => m.Vehicle)
                   .WithMany(v => v.Maintenances)
                   .HasForeignKey(m => m.VehicleID);
        }
    }
}
