using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("RentalBooking");

            builder.HasKey(b => b.BookingID);

            builder.Property(b => b.BookingID)
                   .ValueGeneratedOnAdd();

            builder.Property(b => b.CustomerID)
                   .IsRequired();

            builder.Property(b => b.VehicleID)
                   .IsRequired();

            builder.Property(b => b.RentalStartDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(b => b.RentalEndDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(b => b.PickupLocation)
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.Property(b => b.DropOffLocation)
                   .HasMaxLength(200)
                   .IsRequired(false);

            builder.Property(b => b.RentalPricePerDay)
                   .HasColumnType("smallmoney")
                   .IsRequired();

            builder.Property(b => b.InitialCheckNotes)
                   .HasMaxLength(300)
                   .IsRequired(false);

            builder.Property(b => b.CreatedByUserID)
                   .IsRequired();
            ////Relationships
            //builder.HasOne(b => b.Customer)
            //       .WithMany(c => c.RentalBookings)
            //       .HasForeignKey(b => b.CustomerID);

            //builder.HasOne(b => b.Vehicle)
            //       .WithMany(v => v.RentalBookings)
            //       .HasForeignKey(b => b.VehicleID);

            //builder.HasOne(b => b.CreatedByUser)
            //       .WithMany(u => u.CreatedBookings)
            //       .HasForeignKey(b => b.CreatedByUserID);
        }
    }
}
