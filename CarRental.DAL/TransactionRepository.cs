using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class TransactionRepository
    {
        public static int AddTransaction(int BookingID, int ReturnID, string PaymentDetails,
          float PaidInitialTotalDueAmount, float ActualTotalDueAmount, float TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {
            int TransactionID = -1;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"INSERT INTO RentalTransactions
(BookingID,ReturnID,PaymentDetails,PaidInitialTotalDueAmount,ActualTotalDueAmount,TotalRefundedAmount,TransactionDate,UpdatedTransactionDate)
VALUES
(@BookingID,@ReturnID,@PaymentDetails,@PaidInitialTotalDueAmount,@ActualTotalDueAmount,@TotalRefundedAmount,@TransactionDate,@UpdatedTransactionDate)
SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            if (ReturnID > 0)
                command.Parameters.AddWithValue("@ReturnID", ReturnID);
            else
                command.Parameters.AddWithValue("@ReturnID", DBNull.Value);

            if (string.IsNullOrEmpty(PaymentDetails))
                command.Parameters.AddWithValue("@PaymentDetails", DBNull.Value);
            else
                command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);

            command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);

            if (ActualTotalDueAmount > 0)
                command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
            else
                command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);

            if (TotalRefundedAmount > 0)
                command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
            else
                command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);

            if (UpdatedTransactionDate != null)
                command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);
            else
                command.Parameters.AddWithValue("@UpdatedTransactionDate", DBNull.Value);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    TransactionID = ID;



            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }

            return TransactionID;
        }

        public static bool UpdateTransaction(int TransactionID, int BookingID, int ReturnID, string PaymentDetails,
            float PaidInitialTotalDueAmount, float ActualTotalDueAmount, float TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"Update RentalTransactions
SET BookingID=@BookingID,
ReturnID=@ReturnID,
PaymentDetails=@PaymentDetails,
PaidInitialTotalDueAmount=@PaidInitialTotalDueAmount,
ActualTotalDueAmount=@ActualTotalDueAmount,
TotalRefundedAmount=@TotalRefundedAmount,
TransactionDate=@TransactionDate,
UpdatedTransactionDate=@UpdatedTransactionDate
WHERE TransactionID=@TransactionID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            command.Parameters.AddWithValue("@BookingID", BookingID);
            if (ReturnID > 0)
                command.Parameters.AddWithValue("@ReturnID", ReturnID);
            else
                command.Parameters.AddWithValue("@ReturnID", DBNull.Value);

            if (string.IsNullOrEmpty(PaymentDetails))
                command.Parameters.AddWithValue("@PaymentDetails", DBNull.Value);
            else
                command.Parameters.AddWithValue("@PaymentDetails", PaymentDetails);

            command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);

            if (ActualTotalDueAmount > 0)
                command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
            else
                command.Parameters.AddWithValue("@ActualTotalDueAmount", DBNull.Value);

            if (TotalRefundedAmount > 0)
                command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
            else
                command.Parameters.AddWithValue("@TotalRefundedAmount", DBNull.Value);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);

            if (UpdatedTransactionDate != null)
                command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);
            else
                command.Parameters.AddWithValue("@UpdatedTransactionDate", DBNull.Value);

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

        public static bool GetTransactionByID(int TransactionID, ref int BookingID, ref int ReturnID, ref string PaymentDetails,
            ref float PaidInitialTotalDueAmount, ref float ActualTotalDueAmount, ref float TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM RentalTransactions Where TransactionID=@TransactionID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    BookingID = (int)reader["BookingID"];
                    if (reader["ReturnID"] != DBNull.Value)
                        ReturnID = (int)reader["ReturnID"];
                    else
                        ReturnID = -1;

                    if (reader["PaymentDetails"] != DBNull.Value)
                        PaymentDetails = (string)reader["PaymentDetails"];
                    else
                        PaymentDetails = "";


                    PaidInitialTotalDueAmount = (float)((decimal)reader["PaidInitialTotalDueAmount"]);

                    if (reader["ActualTotalDueAmount"] != DBNull.Value)
                        ActualTotalDueAmount = (float)((decimal)reader["ActualTotalDueAmount"]);
                    else
                        ActualTotalDueAmount = -1;

                    if (reader["TotalRefundedAmount"] != DBNull.Value)
                        TotalRefundedAmount = (float)((decimal)reader["TotalRefundedAmount"]);
                    else
                        TotalRefundedAmount = -1;

                    TransactionDate = (DateTime)reader["TransactionDate"];

                    if (reader["UpdatedTransactionDate"] != DBNull.Value)
                        UpdatedTransactionDate = (DateTime)reader["UpdatedTransactionDate"];
                    else
                        UpdatedTransactionDate = TransactionDate;


                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool GetTransactionByBookingID(int BookingID, ref int TransactionID, ref int ReturnID, ref string PaymentDetails,
         ref float PaidInitialTotalDueAmount, ref float ActualTotalDueAmount, ref float TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT top 1 RentalTransactions.* FROM RentalTransactions Where BookingID=@BookingID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TransactionID = (int)reader["TransactionID"];
                    if (reader["ReturnID"] != DBNull.Value)
                        ReturnID = (int)reader["ReturnID"];
                    else
                        ReturnID = -1;

                    if (reader["PaymentDetails"] != DBNull.Value)
                        PaymentDetails = (string)reader["PaymentDetails"];
                    else
                        PaymentDetails = "";


                    PaidInitialTotalDueAmount = (float)((decimal)reader["PaidInitialTotalDueAmount"]);

                    if (reader["ActualTotalDueAmount"] != DBNull.Value)
                        ActualTotalDueAmount = (float)((decimal)reader["ActualTotalDueAmount"]);
                    else
                        ActualTotalDueAmount = -1;

                    if (reader["TotalRefundedAmount"] != DBNull.Value)
                        TotalRefundedAmount = (float)((decimal)reader["TotalRefundedAmount"]);
                    else
                        TotalRefundedAmount = -1;

                    TransactionDate = (DateTime)reader["TransactionDate"];

                    if (reader["UpdatedTransactionDate"] != DBNull.Value)
                        UpdatedTransactionDate = (DateTime)reader["UpdatedTransactionDate"];
                    else
                        UpdatedTransactionDate = TransactionDate;


                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }

        public static bool GetTransactionByReturnID(int ReturnID, ref int TransactionID, ref int BookingID, ref string PaymentDetails,
 ref float PaidInitialTotalDueAmount, ref float ActualTotalDueAmount, ref float TotalRefundedAmount, ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT top 1 RentalTransactions.* FROM RentalTransactions Where ReturnID=@ReturnID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ReturnID", ReturnID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TransactionID = (int)reader["TransactionID"];

                    BookingID = (int)reader["BookingID"];


                    if (reader["PaymentDetails"] != DBNull.Value)
                        PaymentDetails = (string)reader["PaymentDetails"];
                    else
                        PaymentDetails = "";


                    PaidInitialTotalDueAmount = (float)((decimal)reader["PaidInitialTotalDueAmount"]);

                    if (reader["ActualTotalDueAmount"] != DBNull.Value)
                        ActualTotalDueAmount = (float)((decimal)reader["ActualTotalDueAmount"]);
                    else
                        ActualTotalDueAmount = -1;

                    if (reader["TotalRefundedAmount"] != DBNull.Value)
                        TotalRefundedAmount = (float)((decimal)reader["TotalRefundedAmount"]);
                    else
                        TotalRefundedAmount = -1;

                    TransactionDate = (DateTime)reader["TransactionDate"];

                    if (reader["UpdatedTransactionDate"] != DBNull.Value)
                        UpdatedTransactionDate = (DateTime)reader["UpdatedTransactionDate"];
                    else
                        UpdatedTransactionDate = TransactionDate;


                    IsFound = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return IsFound;


        }


        public static bool DeleteTransaction(int TransactionID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"DELETE FROM RentalTransaction WHERE TransactionID=@TransactionID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
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

        public static DataTable GetAllTransactions()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM RentalTransactions_View";
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

        public static bool IsTransactionExists(int TransactionID)
        {
            bool IsExists = false;
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT 1 From RentalTransaction WHERE TransactionID=@TransactionID";
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

        public static DataTable GetDailyReport()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataHelper.ConnectionString))
                {
                    string Query = @"SELECT Total=ISNULL(SUM(ActualTotalDueAmount),Sum(PaidInitialTotalDueAmount)),TransactionDate As Date FROM RentalTransactions
Group by TransactionDate;";

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

        public static DataTable GetRentReport()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataHelper.ConnectionString))
                {
                    string Query = @"SELECT TotalRents=ISNULL(Count(RentalTransactions.BookingID),0),TransactionDate As Date FROM RentalTransactions
Group by TransactionDate;";

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
