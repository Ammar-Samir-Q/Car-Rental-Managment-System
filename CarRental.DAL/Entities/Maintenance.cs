using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Entities
{
    public class Maintenance
    {
        public int MaintenanceID { get; set; }

        public int VehicleID { get; set; }

        public string? Description { get; set; }

        public DateTime MaintenanceDate { get; set; }

        public decimal Cost { get; set; }

        // Navigation Properties
        public Vehicle Vehicle { get; set; } = null!;
    }
}
