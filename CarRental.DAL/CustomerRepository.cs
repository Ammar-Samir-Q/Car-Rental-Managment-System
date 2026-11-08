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
    public class CustomerRepository
    {
        public async static Task<int> Create(Customer NewCustomer)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            context.Customers.Add(NewCustomer);

            await context.SaveChangesAsync();

            return NewCustomer.CustomerID;

        }

        public static async Task<bool> Update(Customer UpdatedCustomer)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var customer = await context.Customers.FindAsync(UpdatedCustomer.CustomerID);

            if (customer == null) return false;

            customer.PersonID = UpdatedCustomer.PersonID;
            customer.DriverLicenseNumber = UpdatedCustomer.DriverLicenseNumber;
            customer.CreatedByUserID = UpdatedCustomer.CreatedByUserID;

            await context.SaveChangesAsync();

            return true;
        }

        public static async Task<Customer?> GetByID(int CustomerID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            var customer = await context.Customers.FindAsync(CustomerID);

            return customer;


        }

        public static async Task<Customer?> GetByPersonID(int personID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            var customer = await context.Customers.FirstOrDefaultAsync(c => c.PersonID == personID);

            return customer;
        }

        public static async Task<bool> Delete(int CustomerID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            var Customer = await context.Customers.FindAsync(CustomerID);
            if (Customer == null) return false;
            context.Customers.Remove(Customer);
            await context.SaveChangesAsync();
            return true;
        }

        //ADO.NET
        public static async Task<DataTable> GetAll()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DataHelper.ConnectionString))
            {
                string Query = @"SELECT * FROM Customer_View";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return dataTable;

        }

        public static DataTable GetAllBookings(int CustomerID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT BookingID,RentalBooking_View.Model,RentalStartDate,RentalEndDate,
                    RentalPricePerDay,CreatedBy FROM RentalBooking_View WHERE CustomerID=@CustomerID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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


        public static async Task<bool> IsExists(int CustomerID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Customers.AnyAsync(C => C.CustomerID == CustomerID);
        }

        public static async Task<bool> IsExists(string DriverLicneseNumber)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Customers.AnyAsync(C => C.DriverLicenseNumber ==DriverLicneseNumber);
        }

        public static async Task<bool> IsExistsByPersonID(int PersonID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Customers.AnyAsync(C => C.PersonID == PersonID);

        }

        public static async Task<int> GetTotalRentTimes(int CustomerID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.RentalBookings.Where(b => b.CustomerID == CustomerID).CountAsync();
        }

        public static async Task<DateTime> GetLastRentDate(int CustomerID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.RentalBookings.Where(b => b.CustomerID == CustomerID).Select(b => b.RentalStartDate).OrderDescending().FirstOrDefaultAsync();
        }

        public static async Task<int> GetTotalCustomers()
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Customers.CountAsync();
        }
    }
}
