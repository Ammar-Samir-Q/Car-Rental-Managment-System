using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data = CarRental.DAL.Entities;

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

        public decimal RentalPricePerDay { get; set; }

        public string InitialCheckNotes { get; set; }

        public int CreatedByUserID { get; set; }

        public int TotalDays { get { return (RentalEndDate.Date - RentalStartDate.Date).Days; } }

        public decimal InitialTotalDueAmount { get { return RentalPricePerDay * TotalDays; } }

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

        public Booking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropOffLocation, decimal RentalPricePerDay, string InitialCheckNotes, int CreatedByUserID,Customer customerInfo,Vehicle vehicleInfo)
        {
            this.BookingID = BookingID;
            this.CustomerID = CustomerID;
            this.CustomerInfo = customerInfo;
            this.VehicleID = VehicleID;
            this.VehicleInfo = vehicleInfo;
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

        private async Task<bool> _AddRent()
        {
            var rent = new Data.Booking()
            {
                CustomerID = this.CustomerID,
                VehicleID = this.VehicleID,
                RentalStartDate = this.RentalStartDate,
                RentalEndDate = this.RentalEndDate,
                PickupLocation = this.PickupLocation,
                DropOffLocation = this.DropOffLocation,
                RentalPricePerDay = this.RentalPricePerDay,
                InitialCheckNotes = this.InitialCheckNotes,
                CreatedByUserID = this.CreatedByUserID


            };


            this.BookingID = await DAL.BookingRepository.AddRent(rent);
            return this.BookingID > 0;
        }

        private async Task<bool> _UpdateRent()
        {
            return await DAL.BookingRepository.Update(BookingID, CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropOffLocation, RentalPricePerDay, InitialCheckNotes, CreatedByUserID);
        }

        public  async Task<bool> Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return await _AddRent();
                case enMode.Update:
                    return await _UpdateRent();

            }
            return false;

        }

        public static async Task<Booking?> GetRentalByID(int BookingID)
        {
            var Booking = await DAL.BookingRepository.GetByID(BookingID);

            if (Booking!=null)
            {
                var vehicle = await BLL.Vehicle.GetVehicleByID(Booking.VehicleID);
                var customer = await BLL.Customer.GetCustomerByID(Booking.CustomerID);


                return new Booking(BookingID, Booking.CustomerID, Booking.VehicleID, Booking.RentalStartDate, Booking.RentalEndDate, Booking.PickupLocation, Booking.DropOffLocation, Booking.RentalPricePerDay, Booking.InitialCheckNotes, Booking.CreatedByUserID,customer,vehicle);
            }
            else
                return null;




        }

        public static async Task<bool> DeleteRent(int BookingID)
        {
            return await DAL.BookingRepository.Delete(BookingID);
        }
        public async Task<bool> Delete()
        {
            return await DAL.BookingRepository.Delete(this.BookingID);
        }

        public static async Task<DataTable> GetAllRents()
        {
            return await DAL.BookingRepository.GetAll();
        }

        public static async Task<bool> IsRentExists(int BookingID)
        {
            return await DAL.BookingRepository.IsExists(BookingID);
        }

        public async Task<bool> IsExists()
        {
            return await DAL.BookingRepository.IsExists(this.BookingID);
        }

        public async Task<bool> IsReturned()
        {
            return await DAL.ReturnRepository.GetByBookingID(this.BookingID);
        }

        public static async Task<bool> IsBookingReturned(int BookingID)
        {
            return await DAL.ReturnRepository.GetByBookingID(BookingID);
        }

        public static async Task<int> GetTotalBookings()
        {
            return await DAL.BookingRepository.GetTotalBookings();
        }

        public static async Task<int> GetTotalCompletedRents()
        {
            return await DAL.BookingRepository.GetTotalCompletedRents();
        }

        public static async Task<DataTable> GetTotalRentTimesVehicleReport()
        {
            return await DAL.BookingRepository.GetVehiclesRentTimesReport();
        }
        public static async Task<DataTable> GetVehiclesCountReport()
        {
            return await DAL.BookingRepository.GetVehiclesCountReport();
        }
    }
}
