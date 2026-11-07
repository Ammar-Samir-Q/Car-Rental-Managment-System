using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            
            builder.ToTable("RentalTransactions");

            builder.HasKey(t => t.TransactionID);

            builder.Property(t => t.TransactionID)
                   .ValueGeneratedOnAdd();

            builder.Property(t => t.BookingID)
                   .IsRequired();

            builder.Property(t => t.ReturnID)
                   .IsRequired(false);

            builder.Property(t => t.PaymentDetails)
                   .HasMaxLength(300)
                   .IsRequired(false);

            builder.Property(t => t.PaidInitialTotalDueAmount)
                   .HasColumnType("smallmoney")
                   .IsRequired();

            builder.Property(t => t.ActualTotalDueAmount)
                   .HasColumnType("smallmoney")
                   .IsRequired(false);

            builder.Property(t => t.TotalRefundedAmount)
                   .HasColumnType("smallmoney")
                   .IsRequired(false);

            builder.Property(t => t.TransactionDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(t => t.UpdatedTransactionDate)
                   .HasColumnType("date")
                   .IsRequired(false);

            // Booking Relationship
            builder.HasOne(t => t.Booking)
                   .WithOne(b => b.Transaction)
                   .HasForeignKey<Transaction>(t => t.BookingID);

            // Return Relationship
                builder.HasOne(t => t.Return)
              .WithOne(r => r.Transaction)
              .HasForeignKey<Transaction>(t => t.ReturnID);
        }
    }
}
