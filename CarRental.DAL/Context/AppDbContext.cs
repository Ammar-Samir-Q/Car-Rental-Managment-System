using CarRental.DAL.Entities;
using CarRental.DTO.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Person> People { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Maintenance> Maintenances { get; set; }

        public DbSet<Booking> RentalBookings { get; set; }

        public DbSet<Transaction> RentalTransactions { get; set; }

        public DbSet<Return> VehicleReturns { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        }
    }
}
