using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class VehicleRepository
    {
        public static int AddVehicle(string Make, string Model, int Year, int CurrentMilage, int FuleType, int VehicleCategory, string PlateNumber, float RentalPricePerDay, bool IsAvailableForRent, string ImagePath)
        {
            int VehicleID = -1;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Insert Into Vehicles
(Make,Model,Year,CurrentMilage,FuleTypeID,VehicleCategoryID,PlateNumber,RentalPricePerDay,IsAvailableForRent,ImagePath)
VALUES
(@Make,@Model,@Year,@CurrentMilage,@FuleTypeID,@VehicleCategoryID,@PlateNumber,@RentalPricePerDay,@IsAvailableForRent,@ImagePath);
SELECT SCOPE_IDENTITY();
";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Make", Make);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@CurrentMilage", CurrentMilage);
            command.Parameters.AddWithValue("@FuleTypeID", FuleType);
            command.Parameters.AddWithValue("@VehicleCategoryID", VehicleCategory);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);
            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    VehicleID = ID;



            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }

            return VehicleID;
        }

        public static bool UpdateVehicle(int VehicleID, string Make, string Model, int Year, int CurrentMilage, int FuleTypeID, int VehicleCategoryID, string PlateNumber, float RentalPricePerDay, bool IsAvailableForRent, string ImagePath)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"UPDATE Vehicles
Set Make=@Make,
Model=@Model,
Year=@Year,
CurrentMilage=@CurrentMilage,
FuleTypeID=@FuleTypeID,
VehicleCategoryID=@VehicleCategoryID,
PlateNumber=@PlateNumber,
RentalPricePerDay=@RentalPricePerDay,
IsAvailableForRent=@IsAvailableForRent,
ImagePath=@ImagePath
WHERE VehicleID=@VehicleID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@Make", Make);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@CurrentMilage", CurrentMilage);
            command.Parameters.AddWithValue("@FuleTypeID", FuleTypeID);
            command.Parameters.AddWithValue("@VehicleCategoryID", VehicleCategoryID);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);
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

        public static bool GetVehicleByID(int VehicleID, ref string Make, ref string Model, ref int Year, ref int CurrentMilage, ref int FuleTypeID, ref int VehicleCategoryID, ref string PlateNumber, ref float RentalPricePerDay, ref bool IsAvailableForRent, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 Vehicles.* FROM Vehicles WHERE VehicleID=@VehicleID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Make = (string)reader["Make"];
                    Model = (string)reader["Model"];
                    Year = (int)reader["Year"];
                    CurrentMilage = (int)reader["CurrentMilage"];
                    FuleTypeID = (int)reader["FuleTypeID"];
                    VehicleCategoryID = (int)reader["VehicleCategoryID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    RentalPricePerDay = (float)((decimal)reader["RentalPricePerDay"]);
                    IsAvailableForRent = (bool)reader["IsAvailableForRent"];
                    if (reader["ImagePath"] == DBNull.Value)
                        ImagePath = "";
                    else
                        ImagePath = (string)reader["ImagePath"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { return IsFound; }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool DeleteVehicle(int VehicleID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"DELETE FROM Vehicles WHERE VehicleID=@VehicleID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
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

        public static DataTable GetAllVehicles()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Vehicles_View";
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

        public static DataTable GetVehicleRentHistory(int VehicleID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT BookingID,Fullname,RentalStartDate,RentalEndDate,CreatedBy FROM RentalBooking_View
                                WHERE VehicleID=@VehicleID";
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

        public static DataTable GetAllAvailableVehicles()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Vehicles_View  Where IsAvailableForRent=1;";
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


        public static bool IsVehicleExists(int VehicleID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Vehicles WHERE VehicleID=@VehicleID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@VehcileID", VehicleID);
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

        public static bool IsVehicleExists(string PlateNumber)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM Vehicles WHERE PlateNumber=@PlateNumber";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
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

        public static bool SetVehicleAvilable(int VehicleID, bool IsAvailable)
        {
            bool IsSaved = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Update Vehicles
            Set IsAvailableForRent=@IsAvailableForRent
            WHERE VehicleID=@VehicleID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailable);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                connection.Open();
                IsSaved = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return IsSaved;



        }

        public static bool UpdateMilage(int VehicleID, int Milage)
        {
            bool IsSaved = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Update Vehicles
            Set CurrentMilage=@CurrentMilage
            WHERE VehicleID=@VehicleID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrentMilage", Milage);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                connection.Open();
                IsSaved = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return IsSaved;



        }
        public static int GetTotalRentTimes(int VehicleID)
        {
            int TotalRentTimes = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT Count(RentalBooking.BookingID) As TotalRentTimes FROM RentalBooking
WHERE VehicleID=@VehicleID;
";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
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

        public static int GetTotalVehicles()
        {
            int Total = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT Count(VehicleID) As TotalVehicles FROM Vehicles;";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    Total = Count;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return Total;
        }

        public static int GetTopRentedVehicle()
        {
            int TopVehicleID = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT TOP 1 VehicleID,Count(BookingID) as TotalRents From RentalBooking
Group By VehicleID 
Order by TotalRents DESC ;";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    TopVehicleID = Count;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return TopVehicleID;
        }

        public static int GetTotalAvailableVehicles()
        {
            int Total = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT COUNT(VehicleID) As AvailableVehicles FROM Vehicles WHERE IsAvailableForRent=1;";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    Total = Count;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return Total;
        }

        public static int GetTotalUnavilableVehicles()
        {
            int Total = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT COUNT(VehicleID) As AvailableVehicles FROM Vehicles WHERE IsAvailableForRent=0;";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int Count))
                    Total = Count;

            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }
            return Total;
        }
    }
}
