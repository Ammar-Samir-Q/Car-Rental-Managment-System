using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class CustomerRepository
    {
        public static int Create(int PersonID, DateTime CreationDate, int CreatedByUserID, string DriverLicenseNumber)
        {
            int CustomerID = -1;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Insert Into Customers
(PersonID,CreationDate,CreatedByUserID,DriverLicenseNumber)
VALUES
(@PersonID,@CreationDate,@CreatedByUserID,@DriverLicenseNumber)
SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreationDate", CreationDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    CustomerID = ID;



            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }

            return CustomerID;
        }

        public static bool Update(int CustomerID, int PersonID, DateTime CreationDate, int CreatedByUserID, string DriverLicenseNumber)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"UPDATE Customers 
Set PersonID=@PersonID,
CreationDate=@CreationDate,
CreatedByUserID=@CreatedByUserID,
DriverLicenseNumber=@DriverLicenseNumber
WHERE CustomerID=@CustomerID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreationDate", CreationDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);
            try
            {
                connection.Open();
                IsUpdated = command.ExecuteNonQuery() > 0;
            }
            catch (System.Exception ex)
            { }
            finally { connection.Close(); }
            return IsUpdated;

        }

        public static bool GetByID(int CustomerID, ref int PersonID, ref DateTime CreationDate, ref int CreatedByUserID, ref string DriverLicenseNumber)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 Customers.* FROM Customers WHERE CustomerID=@CustomerID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    CreationDate = (DateTime)reader["CreationDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    DriverLicenseNumber = (string)reader["DriverLicenseNumber"];
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool GetByPersonID(int PersonID, ref int CustomerID, ref DateTime CreationDate, ref int CreatedByUserID, ref string DriverLicenseNumber)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 Customers.* FROM Customers WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CustomerID = (int)reader["CustomerID"];
                    CreationDate = (DateTime)reader["CreationDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    DriverLicenseNumber = (string)reader["DriverLicenseNumber"];
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool Delete(int CustomerID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"DELETE FROM Customers WHERE CustomerID=@CustomerID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Customer_View";
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


        public static bool IsExists(int CustomerID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Customers WHERE CustomerID=@CustomerID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        public static bool IsExists(string DriverLicneseNumber)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Customers WHERE DriverLicneseNumber=@DriverLicneseNumber";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicneseNumber);
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

        public static bool IsExistsByPersonID(int PersonID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Customers WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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

        public static int GetTotalRentTimes(int CustomerID)
        {
            int TotalRentTimes = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT Count(RentalBooking.BookingID) As TotalRentTimes FROM RentalBooking
WHERE CustomerID=@CustomerID;
";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    TotalRentTimes = Count;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return TotalRentTimes;
        }

        public static DateTime GetLastRentDate(int CustomerID)
        {
            DateTime LastRentDate = DateTime.MinValue;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 RentalBooking.RentalStartDate FROM RentalBooking
WHERE CustomerID=3
ORDER BY RentalStartDate DESC
";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && DateTime.TryParse(result.ToString(), out DateTime LastDate))
                    LastRentDate = LastDate;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return LastRentDate;
        }

        public static int GetTotalCustomers()
        {
            int TotalCustomers = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT COUNT(CustomerID) FROM Customers";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    TotalCustomers = Count;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return TotalCustomers;
        }
    }
}
