using CarRental.DAL.Context;
using CarRental.DAL.Factories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.DAL
{
    public class DataHelper
    {

        static public string ConnectionString = "Server=.;Database=CarRental;Trusted_Connection=true;TrustServerCertificate=true;";
        static public string MasterConnection = "Server=.;Database=master;Trusted_Connection=true";


        static public async Task <bool> CheckConnection()
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return await context.Database.CanConnectAsync();
        }


        static public async Task<bool> BackupDatabase(string Path)
        {
            Path += $"\\[{DateTime.Now:yyyy-MM-dd-hh-mm}]--CarRentalBackup--.bak";
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Query = @"Backup DataBase CarRental To DISK =@Path";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Path", Path);
            try
            {
              await  connection.OpenAsync();
               await command.ExecuteNonQueryAsync();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                return false;
            }
        }


    }
}
