using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class Transaction
    {
        public int TransactionID { get; set; }

        public int BookingID { get; set; }

        public int? ReturnID { get; set; }

        public string? PaymentDetails { get; set; }

        public decimal PaidInitialTotalDueAmount { get; set; }

        public decimal? ActualTotalDueAmount { get; set; }

        public decimal? TotalRefundedAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateOnly? UpdatedTransactionDate { get; set; }


        // Navigation Properties
        public Booking Booking { get; set; } = null!;

        public Return? Return { get; set; }

    }
}
