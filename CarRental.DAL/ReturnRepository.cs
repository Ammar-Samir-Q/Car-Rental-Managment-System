using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class ReturnRepository
    {
        public static int Create(DateTime ActualReturnDate, float Milage, string FinalCheckNotes, float AdditonalCharges, float ActualTotalDueAmount, byte ReturnCondition, byte FuleLevel)

        {
            int ReturnID = -1;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"
INSERT INTO [dbo].[VehicleReturns]
           ([ActualReturnDate]
           ,[Mileage]
           ,[FinalCheckNotes]
           ,[AdditionalCharges]
           ,[ActualTotalDueAmount]
           ,[ReturnCondition]
           ,[FuleLevel])
     VALUES
           (@ActualReturnDate
           ,@Mileage
           ,@FinalCheckNotes
           ,@AdditonalCharges
           ,@ActualTotalDueAmount
           ,@ReturnCondition
           ,@FuleLevel)
        SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            command.Parameters.AddWithValue("@Mileage", Milage);
            if (string.IsNullOrEmpty(FinalCheckNotes))
                command.Parameters.AddWithValue("@FinalCheckNotes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);

            if (AdditonalCharges > 0)
                command.Parameters.AddWithValue("@AdditonalCharges", AdditonalCharges);
            else
                command.Parameters.AddWithValue("@AdditonalCharges", DBNull.Value);

            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
            command.Parameters.AddWithValue("@ReturnCondition", ReturnCondition);
            command.Parameters.AddWithValue("@FuleLevel", FuleLevel);



            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    ReturnID = ID;



            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }

            return ReturnID;
        }

        public static bool Update(int ReturnID, DateTime ActualReturnDate, float Milage, string FinalCheckNotes, float AdditonalCharges, float ActualTotalDueAmount, byte ReturnCondition, byte FuleLevel)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"UPDATE VehicleReturns
   SET ActualReturnDate = @ActualReturnDate
      ,Mileage = @Mileage
      ,FinalCheckNotes = @FinalCheckNotes
      ,AdditionalCharges = @AdditionalCharges
      ,ActualTotalDueAmount = @ActualTotalDueAmount
      ,ReturnCondition= @ReturnCondition
      ,FuleLevel = @FuleLevel
 WHERE ReturnID=@ReturnID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("ReturnID", ReturnID);
            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            command.Parameters.AddWithValue("@Milage", Milage);
            if (string.IsNullOrEmpty(FinalCheckNotes))
                command.Parameters.AddWithValue("@FinalCheckNotes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);

            if (AdditonalCharges > 0)
                command.Parameters.AddWithValue("@AdditonalCharges", AdditonalCharges);
            else
                command.Parameters.AddWithValue("@AdditonalCharges", DBNull.Value);

            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
            command.Parameters.AddWithValue("@ReturnCondition", ReturnCondition);
            command.Parameters.AddWithValue("@FuleLevel", FuleLevel);

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

        public static bool GetByID(int ReturnID, ref DateTime ActualReturnDate, ref float Milage, ref string FinalCheckNotes, ref float AdditonalCharges, ref float ActualTotalDueAmount, ref byte ReturnCondition, ref byte FuleLevel)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM VehicleReturns WHERE ReturnID=@ReturnID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ReturnID", ReturnID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                    Milage = (float)Convert.ToSingle((reader["Mileage"]));
                    if (reader["FinalCheckNotes"] != DBNull.Value)
                        FinalCheckNotes = (string)reader["FinalCheckNotes"];
                    else
                        FinalCheckNotes = "";

                    if (reader["AdditionalCharges"] != DBNull.Value)
                        AdditonalCharges = (float)Convert.ToSingle(reader["AdditionalCharges"]);
                    else
                        AdditonalCharges = -1;

                    ActualTotalDueAmount = (float)Convert.ToSingle(reader["ActualTotalDueAmount"]);
                    ReturnCondition = (byte)reader["ReturnCondition"];
                    FuleLevel = (byte)reader["FuleLevel"];

                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool Delete(int ReturnID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"DELETE FROM VehicleReturns WHERE ReturnID=@ReturnID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ReturnID", ReturnID);
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
            string Query = @"SELECT * FROM VehicleReturns";
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

        public static bool IsExists(int ReturnID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM VehicleReturns WHERE ReturnID=@ReturnID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ReturnID", ReturnID);
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

        public static bool GetByBookingID(int BookingID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 FROM VehicleReturns Join
                RentalTransactions On VehicleReturns.ReturnID=RentalTransactions.ReturnID
                WHERE RentalTransactions.BookingID=@BookingID;";
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
    }
}
