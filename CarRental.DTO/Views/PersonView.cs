using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.Views
{
    public class PersonView
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; } = null!;

        public string FullName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;

    }
}
