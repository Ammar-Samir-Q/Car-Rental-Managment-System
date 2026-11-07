using CarRental.DAL.Context;
using CarRental.DAL.Factories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.DAL
{
    public class DataHelper
    {

        static public string ConnectionString = "Server=.;Database=CarRental;User=sa;Password=sa123456";
        static public string MasterConnection = "Server=.;Database=master;Trusted_Connection=true";


        static public bool CheckConnection()
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            return context.Database.CanConnect();
        }


        static public bool BackupDatabase(string Path)
        {
            //Path += $"\\[{DateTime.Now:yyyy-MM-dd-hh-mm}]--CarRentalBackup--.bak";
            //SqlConnection connection = new SqlConnection(ConnectionString);
            //string Query = @"Backup DataBase CarRental To DISK =@Path";
            //SqlCommand command = new SqlCommand(Query, connection);
            //command.Parameters.AddWithValue("@Path", Path);
            //try
            //{
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    Util.Logger.LogHelper.Log("CarRental", ex.Message, System.Diagnostics.EventLogEntryType.Error);
            //    connection.Close();
            //    return false;
            //}

            return false;

        }


    }
}
