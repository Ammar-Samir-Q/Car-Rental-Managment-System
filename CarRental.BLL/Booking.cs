using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.BLL
{
    public class Booking
    {
        enum enMode { AddNew = 1, Update = 2 }

        public int BookingID { get; set; }

        public int CustomerID { get; set; }

        public Customer CustomerInfo { get; set; }

        public int VehicleID { get; set; }

        public Vehicle VehicleInfo { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public string PickupLocation { get; set; }

        public string DropOffLocation { get; set; }

        public float RentalPricePerDay { get; set; }

        public string InitialCheckNotes { get; set; }

        public int CreatedByUserID { get; set; }

        public int TotalDays { get { return (RentalEndDate.Date - RentalStartDate.Date).Days; } }

        public float InitialTotalDueAmount { get { return RentalPricePerDay * TotalDays; } }

        private enMode _Mode = enMode.AddNew;

        //------------------------------------------------
        public Booking()
        {
            this.BookingID = -1;
            this.CustomerID = -1;
            this.VehicleID = -1;
            this.RentalStartDate = DateTime.Now;
            this.RentalEndDate = DateTime.Now;
            this.PickupLocation = "";
            this.DropOffLocation = "";
            this.RentalPricePerDay = 0;
            this.InitialCheckNotes = "";
            this.CreatedByUserID = -1;
            this._Mode = enMode.AddNew;
        }

        public Booking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropOffLocation, float RentalPricePerDay, string InitialCheckNotes, int CreatedByUserID)
        {
            this.BookingID = BookingID;
            this.CustomerID = CustomerID;
           // this.CustomerInfo = Customer.GetCustomerByID(CustomerID);
            this.VehicleID = VehicleID;
            this.VehicleInfo = Vehicle.GetVehicleByID(VehicleID);
            this.RentalStartDate = RentalStartDate;
            this.RentalEndDate = RentalEndDate;
            this.PickupLocation = PickupLocation;
            this.DropOffLocation = DropOffLocation;
            this.RentalPricePerDay = RentalPricePerDay;
            this.InitialCheckNotes = InitialCheckNotes;
            this.CreatedByUserID = CreatedByUserID;

            this._Mode = enMode.Update;

        }

        //------------------------------------------------

        private bool _AddRent()
        {
            this.BookingID = DAL.BookingRepository.AddRent(CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropOffLocation, RentalPricePerDay, InitialCheckNotes, CreatedByUserID);
            return this.BookingID > 0;
        }

        private bool _UpdateRent()
        {
            return DAL.BookingRepository.Update(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropOffLocation, RentalPricePerDay, InitialCheckNotes, CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return _AddRent();
                case enMode.Update:
                    return _UpdateRent();

            }
            return false;

        }

        public static Booking GetRentalByID(int BookingID)
        {
            int CustomerID = -1, VehicleID = -1, CreatedByUserID = -1;
            string PickupLocation = "", DropOffLocation = "", InitialCheckNotes = "";
            DateTime RentalStartDate = DateTime.Now, RentalEndDate = DateTime.Now;
            float RentalPricePerDay = 0;

            if (DAL.BookingRepository.GetByID(BookingID, ref CustomerID, ref VehicleID, ref RentalStartDate, ref RentalEndDate, ref PickupLocation, ref DropOffLocation, ref RentalPricePerDay, ref InitialCheckNotes, ref CreatedByUserID))
            {
                return new Booking(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropOffLocation, RentalPricePerDay, InitialCheckNotes, CreatedByUserID);
            }
            else
                return null;




        }

        public static bool DeleteRent(int BookingID)
        {
            return DAL.BookingRepository.Delete(BookingID);
        }
        public bool Delete()
        {
            return DAL.BookingRepository.Delete(this.BookingID);
        }

        public static DataTable GetAllRents()
        {
            return DAL.BookingRepository.GetAll();
        }

        public static bool IsRentExists(int BookingID)
        {
            return DAL.BookingRepository.IsExists(BookingID);
        }

        public bool IsExists()
        {
            return DAL.BookingRepository.IsExists(this.BookingID);
        }

        public bool IsReturned()
        {
            return DAL.ReturnRepository.GetByBookingID(this.BookingID);
        }

        public static bool IsBookingReturned(int BookingID)
        {
            return DAL.ReturnRepository.GetByBookingID(BookingID);
        }

        public static int GetTotalBookings()
        {
            return DAL.BookingRepository.GetTotalBookings();
        }

        public static int GetTotalCompletedRents()
        {
            return DAL.BookingRepository.GetTotalCompletedRents();
        }

        public static DataTable GetTotalRentTimesVehicleReport()
        {
            return DAL.BookingRepository.GetVehiclesRentTimesReport();
        }
        public static DataTable GetVehiclesCountReport()
        {
            return DAL.BookingRepository.GetVehiclesCountReport();
        }
    }
}
