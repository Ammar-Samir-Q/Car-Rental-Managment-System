using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class Vehicle
    {
        public int VehicleID { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public decimal CurrentMileage { get; set; }

        public int FuelTypeID { get; set; }

        public int VehicleCategoryID { get; set; }

        public string PlateNumber { get; set; }

        public decimal RentalPricePerDay { get; set; }

        public bool IsAvailableForRent { get; set; }

        public string ImagePath { get; set; }

        // Navigation Properties
        public ICollection<Booking> RentalBookings { get; set; }   = new List<Booking>();

        public ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();
    }
}
