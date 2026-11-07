using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int CustomerID { get; set; }

        public int VehicleID { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public string? PickupLocation { get; set; }

        public string? DropOffLocation { get; set; }

        public decimal RentalPricePerDay { get; set; }

        public string? InitialCheckNotes { get; set; }

        public int CreatedByUserID { get; set; }

        // Navigation Properties
        public Customer Customer { get; set; } = null!;

        public Vehicle Vehicle { get; set; } = null!;

        public User CreatedByUser { get; set; }=null!;

        public Transaction? Transaction { get; set; }

    }
}
