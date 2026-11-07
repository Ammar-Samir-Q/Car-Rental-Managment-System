using CarRental.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class UserRepository
    {

        public static int AddUser(int PersonID, string UserName, string Password, byte Role, bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Insert Into Users
 (PersonID,UserName,Password,Role,IsActive,CreationDate)
 values
(@PersonID,@UserName,@Password,@Role,@IsActive,@CreationDate)
    SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Role", Role);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreationDate", DateTime.Now);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    UserID = ID;



            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, byte Role, bool IsActive, DateTime CreationDate)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Update Users
Set PersonID=@PersonID,
UserName=@UserName,
Password=@Password,
Role=@Role,
IsActive=@IsActive,
CreationDate=@CreationDate
WHERE UserID=@UserID;
";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Role", Role);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreationDate", CreationDate);



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
        public static bool GetUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref byte Role, ref bool IsActive, ref DateTime CreationDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 Users.* FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    Role = (byte)reader["Role"];
                    IsActive = (bool)reader["IsActive"];
                    CreationDate = (DateTime)reader["CreationDate"];
                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally { connection.Close(); }
            return IsFound;


        }
        public async static Task<UserDTO> GetUserByIDAsync(int UserID)
        {
            return new UserDTO(1, 1, "Test", "P", 1, true, DateTime.Now);
        }

        public async static Task<UserDTO> GetUserByUsernameAndPasswordAsync(string Username, string Password)
        {
            return new UserDTO(1, 1, "Test", "P", 1, true, DateTime.Now);
        }

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"DELETE FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Users_View";
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

        public static bool IsUserExists(int UserID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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

        public static bool IsUserExistsByPersonID(int PersonID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Users WHERE PersonID=@PersonID";
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


        public static bool IsUserExists(string Username, string password)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Users WHERE Username=@Username AND Password=@Password";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Username", Username);
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
