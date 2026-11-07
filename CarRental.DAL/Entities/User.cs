using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class User
    {

        public int UserID { get; set; }

        public int PersonID { get; set; }

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public byte Role { get; set; }

        public bool IsActive { get; set; }

        public DateOnly CreationDate { get; set; }

        // Navigation Properties
        public Person Person { get; set; } = null!;

        public ICollection<Customer> CreatedCustomers { get; set; }= new List<Customer>();

        public ICollection<Booking> CreatedBookings { get; set; } = new List<Booking>();
    }
}
