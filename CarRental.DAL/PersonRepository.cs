using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class PersonRepository
    {
        public static int AddPerson(string FirstName, string SecondName, string ThirdName, string LastName
         , byte Gendor, string NationalNo, string Phone, string Email, string Address, DateTime DateOfBirth, string ImagePath)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Insert Into People 
                (FirstName,SecondName,ThirdName,LastName,Gender,NationalNo,Phone,Email,Address,DateOfBirth,ImagePath)
                VALUES
                (@FirstName,@SecondName,@ThirdName,@LastName,@Gendor,@NationalNo,@Phone,@Email,@Address,@DateOfBirth,@ImagePath)
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    PersonID = ID;



            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName
            , byte Gendor, string NationalNo, string Phone, string Email, string Address, DateTime DateOfBirth, string ImagePath)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Update People
Set FirstName=@FirstName,
SecondName=@SecondName,
ThirdName=@ThirdName,
LastName=@LastName,
Gender=@Gender,
NationalNo=@NationalNo,
Phone=@Phone,
Email=@Email,
Address=@Address,
DateOfBirth=@DateOfBirth,
ImagePath=@ImagePath
WHERE PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", Gendor);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

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

        public static bool GetPersonByID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
            , ref byte Gendor, ref string NationalNo, ref string Phone, ref string Email, ref string Address, ref DateTime DateOfBirth, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 People.* FROM People WHERE PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Gendor = (byte)reader["Gender"];
                    NationalNo = (string)reader["NationalNo"];
                    Phone = (string)reader["Phone"];
                    //Handle Null
                    if (reader["Email"] == DBNull.Value)
                        Email = "";
                    else
                        Email = (string)reader["Email"];

                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    //Handle Null
                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool GetPersonByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
       , ref byte Gendor, ref string Phone, ref string Email, ref string Address, ref DateTime DateOfBirth, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 People.* FROM People WHERE NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Gendor = (byte)reader["Gender"];
                    Phone = (string)reader["Phone"];
                    //Handle Null
                    if (reader["Email"] == DBNull.Value)
                        Email = "";
                    else
                        Email = (string)reader["Email"];

                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    //Handle Null
                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }


        public static bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"DELETE FROM People WHERE PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PeronID", PersonID);
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

        public static DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM People_View";
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

        public static bool IsPersonExists(int PersonID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM People WHERE PersonID=@PersonID";
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

        public static bool IsPersonExists(string NationalNo)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM People WHERE NationalNo=@NationalNo";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
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
