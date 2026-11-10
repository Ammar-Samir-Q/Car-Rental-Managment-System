using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data = CarRental.DAL.Entities;

namespace CarRental.BLL
{
    public class Transaction
    {
       
            enum enMode { Addnew = 1, Update = 2 }

            public int TransactionID { get; set; }

            public int BookingID { get; set; }

            public Booking BookingInfo { get; set; }

            public int? ReturnID { get; set; }

            public Return ReturnInfo { get; }

            public string? PaymentsDetails { get; set; }

            public decimal PaidInitialTotalDueAmount { get; set; }

            public decimal? ActualTotalDueAmount { get; set; }

            public decimal? TotalRefundedAmount { get; set; }

            public DateTime TransactionDate { get; set; }

            public DateOnly? UpdatedTransactionDate { get; set; }

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
                this.UpdatedTransactionDate = DateOnly.FromDateTime(TransactionDate);
                this._Mode = enMode.Addnew;
            }

            public Transaction(int TransactionID, int BookingID, int? ReturnID, string? PaymentDetails, decimal PaidInitialTotalDueAmount, decimal? ActualTotalDueAmount, decimal? TotalRefundedAmount, DateTime TransactionDate, DateOnly? UpdatedTransactionDate,Booking bookingInfo,Return returnInfo)
            {
                this.TransactionID = TransactionID;
                this.BookingID = BookingID;
            this.BookingInfo = bookingInfo;
                this.ReturnID = ReturnID;
            if (ReturnID > 0)
                this.ReturnInfo = returnInfo;
                this.PaymentsDetails = PaymentDetails;
                this.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
                this.ActualTotalDueAmount = ActualTotalDueAmount;
                this.TotalRefundedAmount = TotalRefundedAmount;
                this.TransactionDate = TransactionDate;
                this.UpdatedTransactionDate = UpdatedTransactionDate;
                this._Mode = enMode.Update;

            }

            //-----------------------------------

            private async Task<bool> _AddTransaction()
            {
            Data.Transaction transaction = new Data.Transaction()
            {
                BookingID = this.BookingID,
                ReturnID = this.ReturnID,
                PaymentDetails = this.PaymentsDetails,
                PaidInitialTotalDueAmount=this.PaidInitialTotalDueAmount,
                ActualTotalDueAmount=this.ActualTotalDueAmount,
                TotalRefundedAmount=this.TotalRefundedAmount,
                TransactionDate = this.TransactionDate,
                UpdatedTransactionDate=this.UpdatedTransactionDate

            };



                this.TransactionID = await DAL.TransactionRepository.AddTransaction(transaction);
                return this.TransactionID > 0;
            }

            private async Task<bool> _UpdateTransaction()
            {
                return await DAL.TransactionRepository.UpdateTransaction(TransactionID, BookingID, ReturnID, PaymentsDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
            }

            public async Task<bool> Save()
            {
                switch (this._Mode)
                {
                    case enMode.Addnew:
                        _Mode = enMode.Update;
                        return await _AddTransaction();
                    case enMode.Update:
                        return await _UpdateTransaction();

                }
                return false;

            }

            public static async Task<Transaction?> GetTransactionByID(int TransactionID)
            {
                var transaction = await DAL.TransactionRepository.GetTransactionByID(TransactionID);
                if (transaction!=null)
                {
                var booking = await BLL.Booking.GetRentalByID(transaction.BookingID);
                var returnInfo = await  BLL.Return.GetReturnByID(transaction.ReturnID??-1);

                    return new Transaction(TransactionID, transaction.BookingID, transaction.ReturnID, transaction.PaymentDetails, transaction.PaidInitialTotalDueAmount, transaction.ActualTotalDueAmount, transaction.TotalRefundedAmount, transaction.TransactionDate, transaction.UpdatedTransactionDate,booking,returnInfo);
                }
                else
                    return null;
            }

            public static async Task<Transaction?> GetTransactionByBookingID(int BookingID)
            {
            var transaction = await DAL.TransactionRepository.GetTransactionByBookingID(BookingID);
            if (transaction != null)
            {
                var booking = await BLL.Booking.GetRentalByID(transaction.BookingID);
                var returnInfo = await BLL.Return.GetReturnByID(transaction.ReturnID??-1);

                return new Transaction(transaction.TransactionID, transaction.BookingID, transaction.ReturnID, transaction.PaymentDetails, transaction.PaidInitialTotalDueAmount, transaction.ActualTotalDueAmount, transaction.TotalRefundedAmount, transaction.TransactionDate, transaction.UpdatedTransactionDate, booking, returnInfo);
            }
            else
                return null;
        }

            public static async Task<Transaction> GetTransactionByReturnID(int ReturnID)
            {
            var transaction = await DAL.TransactionRepository.GetTransactionByReturnID(ReturnID);
            if (transaction != null)
            {
                var booking = await BLL.Booking.GetRentalByID(transaction.BookingID);

                var returnInfo = await BLL.Return.GetReturnByID(transaction.ReturnID??-1);

                return new Transaction(transaction.TransactionID, transaction.BookingID, transaction.ReturnID, transaction.PaymentDetails, transaction.PaidInitialTotalDueAmount, transaction.ActualTotalDueAmount, transaction.TotalRefundedAmount, transaction.TransactionDate, transaction.UpdatedTransactionDate, booking, returnInfo);
            }
            else
                return null;
        }

            public static async Task<DataTable> GetAllTransactions()
            {
                return await DAL.TransactionRepository.GetAllTransactions();
            }

            public static async Task<bool> DeleteTransaction(int TransactionID)
            {
                return await DAL.TransactionRepository.DeleteTransaction(TransactionID);
            }

            public async Task<bool> Delete()
            {
                return await DAL.TransactionRepository.DeleteTransaction(this.TransactionID);
            }

            public static async Task<bool> IsTransactionExists(int TransactionID)
            {
                return await DAL.TransactionRepository.IsTransactionExists(TransactionID);
            }

            public async Task<bool> IsExists()
            {
                return await DAL.TransactionRepository.IsTransactionExists(this.TransactionID);
            }

            public static async Task<DataTable> GetDailyReportData()
            {
                return await DAL.TransactionRepository.GetDailyReport();
            }

            public static async Task<DataTable> GetRentReportData()
            {
                return await DAL.TransactionRepository.GetRentReport();
            }
        }
}
