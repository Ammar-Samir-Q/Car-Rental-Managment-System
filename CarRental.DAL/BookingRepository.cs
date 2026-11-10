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
        public static async Task<int> AddRent(Booking booking)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            await context.RentalBookings.AddAsync(booking);

            await context.SaveChangesAsync();

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

        public async static Task<DataTable> GetVehiclesRentTimesReport()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataHelper.ConnectionString))
                {
                                        string Query = @"SELECT TotalRentTimes=ISNULL(Count(BookingID),0),Vehicles.Model As ModelName FROM RentalBooking
                    JOIN Vehicles On RentalBooking.VehicleID=Vehicles.VehicleID
                    Group by Vehicles.Model;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                            else
                                dataTable = null;
                        }


                    }

                }
            }
            catch (Exception ex)
            { }
            return dataTable;
        }


        public static async Task<DataTable> GetVehiclesCountReport()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataHelper.ConnectionString))
                {
                    string Query = @"SELECT NotAvailable=COUNT(Vehicles.VehicleID),(SELECT AvailableVehicles=Count(Vehicles.VehicleID) FROM Vehicles WHERE Vehicles.IsAvailableForRent=1) As Available
                                    FROM Vehicles
                                    WHERE Vehicles.IsAvailableForRent=0;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                            else
                                dataTable = null;
                        }


                    }


                }
            }
            catch (Exception ex)
            { }
            return dataTable;
        }


    }
}
