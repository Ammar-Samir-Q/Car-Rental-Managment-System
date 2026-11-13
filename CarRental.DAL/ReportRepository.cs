using CarRental.DAL.Context;
using CarRental.DAL.Factories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class ReportRepository
    {
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
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
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


        //ADO.NET
        public static async Task<int> GetTopRentedVehicleReport()
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
                object? result = await command.ExecuteScalarAsync();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    TopVehicleID = Count;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return TopVehicleID;
        }

        //public static async Task<int> GetTopRentedVehicleReport()
        //{
        //    using AppDbContext context = DbContextFactory.CreateDbContext();

        //    int VehicleID=await context.RentalBookings


        //}




    }
}
