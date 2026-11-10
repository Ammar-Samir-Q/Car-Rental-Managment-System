using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class Return
    {
        public int ReturnID { get;  set; }

        public DateOnly ActualReturnDate { get;  set; }

        public double Mileage { get;  set; }

        public string? FinalCheckNotes { get;  set; }

        public decimal? AdditionalCharges { get;  set; }

        public decimal ActualTotalDueAmount { get;  set; }

        public byte ReturnCondition { get;  set; }

        public byte FuleLevel { get;  set; }

        // Navigation Properties
        public Transaction? Transaction { get; set; }
    }
}
