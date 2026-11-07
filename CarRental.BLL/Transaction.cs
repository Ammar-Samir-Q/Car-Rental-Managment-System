using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.BLL
{
    public class Transaction
    {
       
            enum enMode { Addnew = 1, Update = 2 }

            public int TransactionID { get; set; }

            public int BookingID { get; set; }

            public Booking BookingInfo { get; set; }

            public int ReturnID { get; set; }

            public Return ReturnInfo { get; }

            public string PaymentsDetails { get; set; }

            public float PaidInitialTotalDueAmount { get; set; }

            public float ActualTotalDueAmount { get; set; }

            public float TotalRefundedAmount { get; set; }

            public DateTime TransactionDate { get; set; }

            public DateTime UpdatedTransactionDate { get; set; }

            private enMode _Mode = enMode.Addnew;


            //------------------------------------

            public Transaction()
            {
                this.TransactionID = -1;
                this.BookingID = -1;
                this.ReturnID = -1;
                this.PaymentsDetails = "";
                this.PaidInitialTotalDueAmount = 0;
                this.ActualTotalDueAmount = 0;
                this.TotalRefundedAmount = 0;
                this.TransactionDate = DateTime.Now;
                this.UpdatedTransactionDate = TransactionDate;
                this._Mode = enMode.Addnew;
            }

            public Transaction(int TransactionID, int BookingID, int ReturnID, string PaymentDetails, float PaidInitialTotalDueAmount, float ActualTotalDueAmount, float TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
            {
                this.TransactionID = TransactionID;
                this.BookingID = BookingID;
                this.BookingInfo = Booking.GetRentalByID(BookingID);
                this.ReturnID = ReturnID;
                if (ReturnID > 0)
                    this.ReturnInfo = Return.GetReturnByID(ReturnID);
                this.PaymentsDetails = PaymentDetails;
                this.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
                this.ActualTotalDueAmount = ActualTotalDueAmount;
                this.TotalRefundedAmount = TotalRefundedAmount;
                this.TransactionDate = TransactionDate;
                this.UpdatedTransactionDate = UpdatedTransactionDate;
                this._Mode = enMode.Update;

            }

            //-----------------------------------

            private bool _AddTransaction()
            {
                this.TransactionID = DAL.TransactionRepository.AddTransaction(BookingID, ReturnID, PaymentsDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
                return this.TransactionID > 0;
            }

            private bool _UpdateTransaction()
            {
                return DAL.TransactionRepository.UpdateTransaction(TransactionID, BookingID, ReturnID, PaymentsDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
            }

            public bool Save()
            {
                switch (this._Mode)
                {
                    case enMode.Addnew:
                        _Mode = enMode.Update;
                        return _AddTransaction();
                    case enMode.Update:
                        return _UpdateTransaction();

                }
                return false;

            }

            public static Transaction GetTransactionByID(int TransactionID)
            {
                int BookingID = -1, ReturnID = -1;
                string PaymentDetails = "";
                float PaidInitialTotalDueAmount = 0, ActualTotalDueAmount = 0, TotalRefundedAmount = 0;
                DateTime TransactionDate = DateTime.Now;
                DateTime UpdatedTransactionDate = DateTime.Now;
                if (DAL.TransactionRepository.GetTransactionByID(TransactionID, ref BookingID, ref ReturnID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
                {
                    return new Transaction(TransactionID, BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
                }
                else
                    return null;
            }

            public static Transaction GetTransactionByBookingID(int BookingID)
            {
                int TransactionID = -1, ReturnID = -1;
                string PaymentDetails = "";
                float PaidInitialTotalDueAmount = 0, ActualTotalDueAmount = 0, TotalRefundedAmount = 0;
                DateTime TransactionDate = DateTime.Now;
                DateTime UpdatedTransactionDate = DateTime.Now;
                if (DAL.TransactionRepository.GetTransactionByBookingID(BookingID, ref TransactionID, ref ReturnID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
                {
                    return new Transaction(TransactionID, BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
                }
                else
                    return null;
            }

            public static Transaction GetTransactionByReturnID(int ReturnID)
            {
                int TransactionID = -1, BookingID = -1;
                string PaymentDetails = "";
                float PaidInitialTotalDueAmount = 0, ActualTotalDueAmount = 0, TotalRefundedAmount = 0;
                DateTime TransactionDate = DateTime.Now;
                DateTime UpdatedTransactionDate = DateTime.Now;
                if (DAL.TransactionRepository.GetTransactionByReturnID(ReturnID, ref TransactionID, ref BookingID, ref PaymentDetails, ref PaidInitialTotalDueAmount, ref ActualTotalDueAmount, ref TotalRefundedAmount, ref TransactionDate, ref UpdatedTransactionDate))
                {
                    return new Transaction(TransactionID, BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
                }
                else
                    return null;
            }

            public static DataTable GetAllTransactions()
            {
                return DAL.TransactionRepository.GetAllTransactions();
            }

            public static bool DeleteTransaction(int TransactionID)
            {
                return DAL.TransactionRepository.DeleteTransaction(TransactionID);
            }

            public bool Delete()
            {
                return DAL.TransactionRepository.DeleteTransaction(this.TransactionID);
            }

            public static bool IsTransactionExists(int TransactionID)
            {
                return DAL.TransactionRepository.IsTransactionExists(TransactionID);
            }

            public bool IsExists()
            {
                return DAL.TransactionRepository.IsTransactionExists(this.TransactionID);
            }

            public static DataTable GetDailyReportData()
            {
                return DAL.TransactionRepository.GetDailyReport();
            }

            public static DataTable GetRentReportData()
            {
                return DAL.TransactionRepository.GetRentReport();
            }
        }
}
