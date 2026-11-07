using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class Return
    {
        public int ReturnID { get; private set; }

        public DateOnly ActualReturnDate { get; private set; }

        public double Mileage { get; private set; }

        public string? FinalCheckNotes { get; private set; }

        public decimal? AdditionalCharges { get; private set; }

        public decimal ActualTotalDueAmount { get; private set; }

        public byte ReturnCondition { get; private set; }

        public byte FuleLevel { get; private set; }

        // Navigation Properties
        public Transaction? Transaction { get; set; }
    }
}
