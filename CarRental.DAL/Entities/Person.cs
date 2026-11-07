using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class Person
    {
        public int PersonID { get; set; }

        public string NationalNo { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string SecondName { get; set; } = null!;

        public string ThirdName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public byte Gender { get; set; }

        public string Phone { get; set; } = null!;

        public string? Email { get; set; }

        public string Address { get; set; } = null!;

        public string? ImagePath { get; set; }

        // Navigation Properties
        public User? User { get; set; }

        public Customer? Customer { get; set; }


    }
}
