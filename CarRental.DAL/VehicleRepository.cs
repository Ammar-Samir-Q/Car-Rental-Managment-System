using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.DAL.Factories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarRental.DAL
{
    public class VehicleRepository
    {
        public static async Task<int> AddVehicle(Vehicle vehicle)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            await context.AddAsync(vehicle);

            await context.SaveChangesAsync();

            return vehicle.VehicleID;

        }

        public static async Task<bool> UpdateVehicle(int VehicleID, string Make, string Model, int Year, int CurrentMilage, int FuleTypeID, int VehicleCategoryID, string PlateNumber, decimal RentalPricePerDay, bool IsAvailableForRent, string ImagePath)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var vehicle = await context.Vehicles.FindAsync(VehicleID);

            if(vehicle==null) return false;

            vehicle.Make= Make;
            vehicle.Model= Model;
            vehicle.Year= Year;
            vehicle.CurrentMileage= CurrentMilage;
            vehicle.FuelTypeID  = FuleTypeID;
            vehicle.VehicleCategoryID= VehicleCategoryID;
            vehicle.PlateNumber= PlateNumber;
            vehicle.RentalPricePerDay = RentalPricePerDay;
            vehicle.IsAvailableForRent = IsAvailableForRent;
            vehicle.ImagePath= ImagePath;

            await context.SaveChangesAsync();

            return true;
        }

        public static async Task<Vehicle?> GetVehicleByID(int VehicleID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Vehicles.FindAsync(VehicleID);
        }
      

        

        public static async Task<bool> DeleteVehicle(int VehicleID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            var vehicle = await context.Vehicles.FindAsync(VehicleID);

            if (vehicle == null) return false;

            context.Vehicles.Remove(vehicle);
           await context.SaveChangesAsync();
            return true;

        }

        public async static Task<DataTable> GetAllVehicles()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Vehicles_View";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
               await connection.OpenAsync();
                SqlDataReader reader =await command.ExecuteReaderAsync();
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

        public static async Task<DataTable> GetVehicleRentHistory(int VehicleID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT BookingID,Fullname,RentalStartDate,RentalEndDate,CreatedBy FROM RentalBooking_View
                                WHERE VehicleID=@VehicleID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            try
            {
               await connection.OpenAsync();
                SqlDataReader reader =await command.ExecuteReaderAsync();
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

        public static async  Task<DataTable> GetAllAvailableVehicles()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Vehicles_View  Where IsAvailableForRent=1;";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
               await connection.OpenAsync();
                SqlDataReader reader =await command.ExecuteReaderAsync();
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


        public static async Task<bool> IsVehicleExists(int VehicleID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Vehicles.AnyAsync(v=>v.VehicleID==VehicleID);

        }

        public static async Task<bool> IsVehicleExists(string PlateNumber)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Vehicles.AnyAsync(v => v.PlateNumber == PlateNumber);


        }

        public static async Task<bool> SetVehicleAvilable(int VehicleID, bool IsAvailable)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var vehicle = await context.Vehicles.FindAsync(VehicleID);

            if (vehicle == null) return false;

            vehicle.IsAvailableForRent = IsAvailable;

            await context.SaveChangesAsync();

            return true;


        }

        public static async Task<bool> UpdateMilage(int VehicleID, int Milage)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var vehicle = await context.Vehicles.FindAsync(VehicleID);

            if (vehicle == null) return false;

            vehicle.CurrentMileage = Milage;

            await context.SaveChangesAsync();

            return true;



        }
        public static async Task<int> GetTotalRentTimes(int VehicleID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return await context.RentalBookings.Where(b=>b.VehicleID == VehicleID).CountAsync();
        }

        public static async Task<int> GetTotalVehicles()
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return await context.Vehicles.CountAsync();
        }

        //ADO.NET
        public static async Task<int> GetTopRentedVehicle()
        {
            int TopVehicleID = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 VehicleID,Count(BookingID) as TotalRents From RentalBooking
                        Group By VehicleID 
                        Order by TotalRents DESC ;";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
               await connection.OpenAsync();
                object? result =await command.ExecuteScalarAsync();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    TopVehicleID = Count;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return TopVehicleID;
        }

        public static async Task<int> GetTotalAvailableVehicles()
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return await context.Vehicles.Where(v => v.IsAvailableForRent).CountAsync();
        }

        public static async Task<int> GetTotalUnavilableVehicles()
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return await context.Vehicles.Where(v => !v.IsAvailableForRent).CountAsync();
        }
    }
}
