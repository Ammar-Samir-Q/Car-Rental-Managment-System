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
    public class MaintenanceRepository
    {
        public static async Task<int> AddMaintenance(Maintenance maintenance)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            await context.AddAsync(maintenance);

            await context.SaveChangesAsync();
            return maintenance.MaintenanceID;

        }

        public static async Task<bool> UpdateMainteance(int MaintenanceID, int VehicleID, string Description, DateOnly MaintenanceDate, decimal Cost)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            
            var maintenance=await context.Maintenances.FindAsync(MaintenanceID);
            if(maintenance==null) return false; 

            maintenance.VehicleID = VehicleID;
            maintenance.Description = Description;
            maintenance.MaintenanceDate = MaintenanceDate;
            maintenance.Cost = Cost;
            await context.SaveChangesAsync();
            return true;

        }

        public static async Task<Maintenance?> GetMaintenanceByID(int MaintenanceID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Maintenances.FindAsync(MaintenanceID);

        }

        public static async Task<bool> DeleteMaintenance(int MaintenanceID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var maintenances=await context.Maintenances.FindAsync(MaintenanceID);
            if(maintenances==null) return false;
            context.Maintenances.Remove(maintenances);
           await context.SaveChangesAsync();
            return true;


        }

        //ADO.NET
        public static async Task<DataTable> GetAllMaintenances()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Maintenances_View";
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
            {

                throw ex;
            }
            finally { connection.Close(); }
            return dataTable;
            {
            }
        }

        //ADO.NET
        public static async Task<DataTable> GetAllMaintenancesForVehicle(int VehicleID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Maintenances_View WHERE VehicleID=@VehicleID";

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
            {
                throw ex;
            }
            finally { connection.Close(); }
            return dataTable;
            {
            }
        }


        public static async Task<bool> IsMaintenanceExists(int MaintenanceID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            
            return await context.Maintenances.AnyAsync(m=>m.MaintenanceID== MaintenanceID);
        }
    }
}
