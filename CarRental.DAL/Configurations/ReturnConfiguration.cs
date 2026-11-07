using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Configurations
{
    public class ReturnConfiguration: IEntityTypeConfiguration<Return>
    {
        public void Configure(EntityTypeBuilder<Return> builder)
        {
            builder.ToTable("VehicleReturns");

            builder.HasKey(r => r.ReturnID);

            builder.Property(r => r.ReturnID)
                   .ValueGeneratedOnAdd();

            builder.Property(r => r.ActualReturnDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(r => r.Mileage)
                   .HasColumnType("float")
                   .IsRequired();

            builder.Property(r => r.FinalCheckNotes)
                   .HasMaxLength(300)
                   .IsRequired(false);

            builder.Property(r => r.AdditionalCharges)
                   .HasColumnType("smallmoney")
                   .IsRequired(false);

            builder.Property(r => r.ActualTotalDueAmount)
                   .HasColumnType("smallmoney")
                   .IsRequired();

            builder.Property(r => r.ReturnCondition)
                   .HasColumnType("tinyint")
                   .IsRequired();

            builder.Property(r => r.FuleLevel)
                   .HasColumnType("tinyint")
                   .IsRequired();
        }
    }
}
