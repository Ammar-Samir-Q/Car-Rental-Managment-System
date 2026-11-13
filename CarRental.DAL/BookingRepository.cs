using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.DAL.Factories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class BookingRepository
    {
        public static async Task<int> AddRent(Booking booking,Transaction transaction)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            using var TransactionScope = await context.Database.BeginTransactionAsync();


            try
            {

                await context.RentalBookings.AddAsync(booking);
                await context.SaveChangesAsync();

                if (transaction.ReturnID <= 0)
                    transaction.ReturnID = null;


                transaction.BookingID = booking.BookingID;

                await context.RentalTransactions.AddAsync(transaction);

                await context.SaveChangesAsync();

                if (transaction.TransactionID > 0 && booking.BookingID > 0)
                    await TransactionScope.CommitAsync();
                else
                    await TransactionScope.RollbackAsync();


            }
            catch
            {
                await TransactionScope.RollbackAsync();
            }

            return booking.BookingID;
        }

        public static async Task<bool> Update(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate,
            DateTime RentalEndDate, string PickupLocation, string DropOffLocation, decimal RentalPricePerDay, string InitialCheckNotes, int CreatedByUserID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var booking = await context.RentalBookings.FindAsync(BookingID);

            if (booking == null) return false;

            booking.CustomerID = CustomerID;
            booking.VehicleID = VehicleID;
            booking.RentalStartDate = RentalStartDate;
            booking.RentalEndDate = RentalEndDate;
            booking.PickupLocation = PickupLocation;
            booking.DropOffLocation = DropOffLocation;
            booking.RentalPricePerDay = RentalPricePerDay;
            booking.InitialCheckNotes = InitialCheckNotes;
            booking.CreatedByUserID = CreatedByUserID;

            await context.SaveChangesAsync();

            return true;


        }

        public static async Task<Booking?> GetByID(int BookingID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.RentalBookings.FindAsync(BookingID);

        }

        public static async Task<bool> Delete(int BookingID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var booking = await context.RentalBookings.FindAsync(BookingID);
            if (booking == null) return false;
            context.RentalBookings.Remove(booking);
            await context.SaveChangesAsync();
            return true;
        }

        //ADO.NET
        public async static Task<DataTable> GetAll()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM RentalBooking_View";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return dataTable;
            {
            }
        }

        public static async Task<bool> IsExists(int BookingID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.RentalBookings.AnyAsync(b => b.BookingID == BookingID);
        }

        public static async Task<int> GetTotalBookings()
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return await context.RentalBookings.CountAsync();
        }

        public static async Task<int> GetTotalCompletedRents()
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return await context.RentalTransactions.Where(t => t.ReturnID != null).CountAsync();
        }

    }
}
