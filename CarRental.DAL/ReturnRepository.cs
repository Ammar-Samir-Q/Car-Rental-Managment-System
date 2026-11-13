using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.DAL.Factories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class ReturnRepository
    {
        public static async Task<int> Create(Return VehicleReturn)
        {
           using AppDbContext context=DbContextFactory.CreateDbContext();
            await  context.VehicleReturns.AddAsync(VehicleReturn);
            await context.SaveChangesAsync();
            return VehicleReturn.ReturnID;
        }

        public static async Task<bool> Update(int ReturnID, DateOnly ActualReturnDate, float Milage, string FinalCheckNotes, decimal? AdditonalCharges, decimal ActualTotalDueAmount, byte ReturnCondition, byte FuleLevel)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            var Return = await context.VehicleReturns.FindAsync(ReturnID);
            if (Return == null) return false;

            Return.ActualReturnDate= ActualReturnDate;
            Return.Mileage= Milage;
            Return.FinalCheckNotes= FinalCheckNotes;
            Return.AdditionalCharges= AdditonalCharges;
            Return.ActualTotalDueAmount = ActualTotalDueAmount;
            Return.FuleLevel=FuleLevel;
            Return.ReturnCondition=ReturnCondition;

            await context.SaveChangesAsync();

            return true;


        }

        public static async Task<Return?> GetByID(int ReturnID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.VehicleReturns.FindAsync(ReturnID);

        }

        public static async Task<bool> Delete(int ReturnID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            var Return = await context.VehicleReturns.FindAsync(ReturnID);
            if (Return == null) return false;

            context.VehicleReturns.Remove(Return);
            await context.SaveChangesAsync();
            return true;

        }

        public static async Task<DataTable> GetAll()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM VehicleReturns";
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

        public static async Task<bool> IsExists(int ReturnID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
           return await context.VehicleReturns.AnyAsync(r=>r.ReturnID== ReturnID);
                

        }

        //Replace With EF
        public async static Task<bool> IsExistsByBookingID(int BookingID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return await context.RentalTransactions.Where(t=>t.BookingID==BookingID).AnyAsync(t => t.ReturnID!=null);
        }
    }
}
