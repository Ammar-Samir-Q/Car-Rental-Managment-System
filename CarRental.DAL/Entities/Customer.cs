using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public int PersonID { get; set; }

        public DateTime CreationDate { get; set; }

        public int CreatedByUserID { get; set; }

        public string? DriverLicenseNumber { get; set; }

        // Navigation Properties
        public Person Person { get; set; }

        public User CreatedByUser { get; set; }

        public ICollection<Booking> RentalBookings { get; set; } = new List<Booking>();
    }
}
