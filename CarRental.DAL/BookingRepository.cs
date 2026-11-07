using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class BookingRepository
    {
        public static int AddRent(int CustomerID, int VehicleID, DateTime RentalStartDate,
    DateTime RentalEndDate, string PickupLocation, string DropOffLocation, float RentalPricePerDay, string InitialCheckNotes, int CreatedByUserID)
        {
            int BookingID = -1;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"INSERT INTO [dbo].[RentalBooking]
           ([CustomerID]
           ,[VehicleID]
           ,[RentalStartDate]
           ,[RentalEndDate]
           ,[PickupLocation]
           ,[DropOffLocation]
           ,[RentalPricePerDay]
           ,[InitialCheckNotes]
           ,[CreatedByUserID])
     VALUES
           (@CustomerID,
           @VehicleID, 
           @RentalStartDate,
           @RentalEndDate,
           @PickupLocation,
           @DropOffLocation, 
           @RentalPricePerDay, 
           @InitialCheckNotes, 
           @CreatedByUserID)
        SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
            command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
            //Handel Null

            if (string.IsNullOrEmpty(PickupLocation))
                command.Parameters.AddWithValue("@PickupLocation", DBNull.Value);
            else
                command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
            //Handel Null
            if (string.IsNullOrEmpty(DropOffLocation))
                command.Parameters.AddWithValue("@DropOffLocation", DBNull.Value);
            else
                command.Parameters.AddWithValue("@DropOffLocation", DropOffLocation);

            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            //Handel Null
            if (string.IsNullOrEmpty(InitialCheckNotes))
                command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);


            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    BookingID = ID;



            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }

            return BookingID;
        }

        public static bool Update(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate,
            DateTime RentalEndDate, string PickupLocation, string DropOffLocation, float RentalPricePerDay, string InitialCheckNotes, int CreatedByUserID)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"UPDATE RentalBooking
SET CustomerID=@CustomerID,
VehicleID=@VehicleID,
RentalStartDate=@RentalStartDate,
RentalEndDate=@RentalEndDate,
PickupLocation=@PickupLocation,
DropOffLocation=@DropOffLocation,
RentalPricePerDay=@rentalPricePerDay,
InitialCheckNotes=@InitialCheckNotes,
CreatedByUserID=@CreatedByUserID
WHERE BookingID=@BookingID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
            command.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
            //Handel Null

            if (string.IsNullOrEmpty(PickupLocation))
                command.Parameters.AddWithValue("@PickupLocation", DBNull.Value);
            else
                command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
            //Handel Null
            if (string.IsNullOrEmpty(DropOffLocation))
                command.Parameters.AddWithValue("@DropOffLocation", DBNull.Value);
            else
                command.Parameters.AddWithValue("@DropOffLocation", DropOffLocation);

            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            //Handel Null
            if (string.IsNullOrEmpty(InitialCheckNotes))
                command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);


            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool GetByID(int BookingID, ref int CustomerID, ref int VehicleID, ref DateTime RentalStartDate,
           ref DateTime RentalEndDate, ref string PickupLocation, ref string DropOffLocation, ref float RentalPricePerDay, ref string InitialCheckNotes, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM RentalBooking WHERE BookingID=@BookingID ";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CustomerID = (int)reader["CustomerID"];
                    VehicleID = (int)reader["VehicleID"];
                    RentalStartDate = (DateTime)reader["RentalStartDate"];
                    RentalEndDate = (DateTime)reader["RentalEndDate"];
                    if (reader["PickupLocation"] == DBNull.Value)
                        PickupLocation = "";
                    else
                        PickupLocation = (string)reader["PickupLocation"];

                    if (reader["DropOffLocation"] == DBNull.Value)
                        DropOffLocation = "";
                    else
                        DropOffLocation = (string)reader["DropOffLocation"];


                    RentalPricePerDay = (float)((decimal)reader["RentalPricePerDay"]);
                    if (reader["InitialCheckNotes"] == DBNull.Value)
                        InitialCheckNotes = "";
                    else
                        InitialCheckNotes = (string)reader["InitialCheckNotes"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];


                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool Delete(int BookingID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"DELETE FROM RentalBooking WHERE BookingID=@BookingID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
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
            string Query = @"SELECT * FROM RentalBooking_View";
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

        public static bool IsExists(int BookingID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM RentalBooking WHERE BookingID=@BookingID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
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

        public static int GetTotalBookings()
        {
            int Total = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT COUNT(BookingID) FROM RentalBooking";
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

        public static int GetTotalCompletedRents()
        {
            int Total = 0;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT COUNT(BookingID) FROM RentalTransactions
WHERE ReturnID is not null;";
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

        public static DataTable GetVehiclesRentTimesReport()
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
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
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


        public static DataTable GetVehiclesCountReport()
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
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
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


    }
}
