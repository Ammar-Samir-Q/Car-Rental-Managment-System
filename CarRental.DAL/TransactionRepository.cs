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
    public class TransactionRepository
    {
        public static async Task<int> AddTransaction(Transaction transaction)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            if (transaction.ReturnID <= 0)
                transaction.ReturnID = null;

            await context.RentalTransactions.AddAsync(transaction);

            await context.SaveChangesAsync();

            return transaction.TransactionID;
        }

        public static async Task<bool> UpdateTransaction(int TransactionID, int BookingID, int? ReturnID, string PaymentDetails,
            decimal PaidInitialTotalDueAmount, decimal? ActualTotalDueAmount, decimal? TotalRefundedAmount, DateTime TransactionDate, DateOnly? UpdatedTransactionDate)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var transaction = await context.RentalTransactions.FindAsync(TransactionID);

            if (transaction == null) return false;

            transaction.BookingID= BookingID;
            transaction.ReturnID= ReturnID;
            transaction.PaymentDetails= PaymentDetails;
            transaction.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
            transaction.ActualTotalDueAmount = ActualTotalDueAmount;
            transaction.TotalRefundedAmount = TotalRefundedAmount;
            transaction.TransactionDate= TransactionDate;
            transaction.UpdatedTransactionDate= UpdatedTransactionDate;

            await context.SaveChangesAsync();

            return true;

        }

        public static async Task<Transaction?> GetTransactionByID(int TransactionID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.RentalTransactions.FindAsync(TransactionID);
        }

        public static async Task<Transaction?> GetTransactionByBookingID(int BookingID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.RentalTransactions.FirstOrDefaultAsync(t=>t.BookingID==BookingID);
        }

        public static async Task<Transaction?> GetTransactionByReturnID(int ReturnID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.RentalTransactions.FirstOrDefaultAsync(t => t.BookingID == ReturnID);
        }


        public static async Task<bool> DeleteTransaction(int TransactionID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            var transaction = await context.RentalTransactions.FindAsync(TransactionID);
             
            if (transaction == null) return false;

            context.RentalTransactions.Remove(transaction);
            await context.SaveChangesAsync();
            return true;
        }

        //ADO.NET
        public static async Task<DataTable> GetAllTransactions()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM RentalTransactions_View";
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

        public static async Task<bool> IsTransactionExists(int TransactionID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.RentalTransactions.AnyAsync(t=>t.TransactionID==TransactionID);

        }
        //ADO.NET

        public static async Task<DataTable> GetDailyReport()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataHelper.ConnectionString))
                {
                    string Query = @"SELECT Total=ISNULL(SUM(ActualTotalDueAmount),Sum(PaidInitialTotalDueAmount)),TransactionDate As Date FROM RentalTransactions
                                    Group by TransactionDate;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                       await connection.OpenAsync();
                        using (SqlDataReader reader =await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }


                    }


                }
            }
            catch (Exception ex)
            { }
            return dataTable;
        }
        //ADO.NET
        public static async Task<DataTable> GetRentReport()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataHelper.ConnectionString))
                {
                    string Query = @"SELECT TotalRents=ISNULL(Count(RentalTransactions.BookingID),0),TransactionDate As Date FROM RentalTransactions
                                        Group by TransactionDate;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                      await  connection.OpenAsync();
                        using (SqlDataReader reader =await command.ExecuteReaderAsync())
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
