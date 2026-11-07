using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Configurations
{
    public class UserConfiguration:IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.UserID);

            builder.Property(u => u.UserID)
                   .ValueGeneratedOnAdd();

            builder.Property(u => u.PersonID)
                   .IsRequired();

            builder.Property(u => u.Username)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(u => u.Password)
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(u => u.Role)
                   .HasColumnType("tinyint")
                   .IsRequired();

            builder.Property(u => u.IsActive)
                   .IsRequired();

            builder.Property(u => u.CreationDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasOne(u => u.Person)
                   .WithOne(p => p.User)
                   .HasForeignKey<User>(u => u.PersonID);

            builder.HasMany(u => u.CreatedCustomers)
                   .WithOne(c => c.CreatedByUser)
                   .HasForeignKey(c => c.CreatedByUserID);

            builder.HasMany(u => u.CreatedBookings)
                   .WithOne(b => b.CreatedByUser)
                   .HasForeignKey(b => b.CreatedByUserID);
        }

    }
}
