using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class MaintenanceRepository
    {
        public static int AddMaintenance(int VehicleID, string Description, DateTime MaintenanceDate, float Cost)
        {
            int MaintenanceID = -1;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Insert Into Maintenances
(VehicleID,Description,MaintenanceDate,Cost)
values
(@VehicleID,@Description,@MaintenanceDate,@Cost);
SELECT SCOPE_IDENTITY();
";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            if (string.IsNullOrEmpty(Description))
                command.Parameters.AddWithValue("@Description", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Description", Description);

            command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
            command.Parameters.AddWithValue("@Cost", Cost);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    MaintenanceID = ID;



            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }

            return MaintenanceID;
        }

        public static bool UpdateMainteance(int MaintenanceID, int VehicleID, string Description, DateTime MaintenanceDate, float Cost)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"UPDATE Maintenances
Set VehicleID=@VehicleID,
Description=@Description,
MaintenanceDate=@MaintenanceDate,
Cost=@Cost
WHERE MaintenanceID=@MainrenanceID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);
            command.Parameters.AddWithValue("@Vehicle", VehicleID);
            if (string.IsNullOrEmpty(Description))
                command.Parameters.AddWithValue("@Description", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Description", Description);

            command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
            command.Parameters.AddWithValue("@Cost", Cost); try
            {
                connection.Open();
                IsUpdated = command.ExecuteNonQuery() > 0;
            }
            catch (System.Exception ex)
            { }
            finally { connection.Close(); }
            return IsUpdated;

        }

        public static bool GetMaintenanceByID(int MaintenanceID, ref int VehicleID, ref string Description, ref DateTime MaintenanceDate, ref float Cost)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 Maintenances.* FROM Maintenances WHERE MaintenanceID=@MaintenanceID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    VehicleID = (int)reader["VehicleID"];
                    if (reader["Description"] == DBNull.Value)
                        Description = "";
                    else
                        Description = (string)reader["Description"];

                    MaintenanceDate = (DateTime)reader["MaintenanceDate"];
                    Cost = (float)((decimal)reader["Cost"]);

                    IsFound = true;

                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool DeleteMaintenance(int MaintenanceID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"DELETE FROM Maintenances WHERE MaintenanceID=@MaintenanceID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);
            try
            {
                connection.Open();
                IsDeleted = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return IsDeleted;
        }

        public static DataTable GetAllMaintenances()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Maintenances_View";
            SqlCommand command = new SqlCommand(Query, connection);
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

        public static DataTable GetAllMaintenancesForVehicle(int VehicleID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Maintenances_View WHERE VehicleID=@VehicleID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
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


        public static bool IsMaintenanceExists(int MaintenanceID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Maintenances WHERE MaintenanceID=@MaintenanceID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("", 1);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsExists = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return IsExists;



        }
    }
}
