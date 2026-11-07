using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.BLL
{
    public class Customer
    {
        enum enMode { AddNew = 1, Update = 2 }
        public int CustomerID { get; set; }

        public int PersonID { get; set; }

        public Person PersonInfo { get; }

        public DateTime CreationDate { get; set; }

        public int CreatedByUserID { get; set; }

        public string DriverLicnsesNumber { get; set; }

        private enMode _Mode = enMode.AddNew;

        //----------------------------------
        public Customer()
        {
            this.CustomerID = -1;
            this.PersonID = -1;
            this.CreationDate = DateTime.Now;
            this.DriverLicnsesNumber = "";
            this.CreatedByUserID = -1;
            this._Mode = enMode.AddNew;
        }

        public Customer(int CustomerID, int PersonID, DateTime CreationDate, string DriverLicenseNumber, int CreatedByUserID)
        {
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;
            this.PersonInfo = Person.GetPerson(PersonID);
            this.CreationDate = CreationDate;
            this.DriverLicnsesNumber = DriverLicenseNumber;
            this.CreatedByUserID = CreatedByUserID;
            this._Mode = enMode.Update;
        }

        //-----------------------------------

        private bool _AddCustomer()
        {
            this.CustomerID = DAL.CustomerRepository.Create(PersonID, CreationDate, CreatedByUserID, DriverLicnsesNumber);
            return this.CustomerID > 0;
        }

        private bool _UpdateCustomer()
        {
            return DAL.CustomerRepository.Update(CustomerID, PersonID, CreationDate, CreatedByUserID, DriverLicnsesNumber);
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return _AddCustomer();
                case enMode.Update:
                    return _UpdateCustomer();
            }
            return false;
        }

        public static Customer GetCustomerByID(int CustomerID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            string DriverLicenseNumber = "";
            DateTime CreationDate = DateTime.Now;
            if (DAL.CustomerRepository.GetByID(CustomerID, ref PersonID, ref CreationDate, ref CreatedByUserID, ref DriverLicenseNumber))
            {
                return new Customer(CustomerID, PersonID, CreationDate, DriverLicenseNumber, CreatedByUserID);
            }
            else
                return null;

        }

        public static Customer GetCustomerByPersonID(int PersonID)
        {
            int CustomerID = -1, CreatedByUserID = -1;
            string DriverLicenseNumber = "";
            DateTime CreationDate = DateTime.Now;
            if (DAL.CustomerRepository.GetByPersonID(PersonID, ref CustomerID, ref CreationDate, ref CreatedByUserID, ref DriverLicenseNumber))
            {
                return new Customer(CustomerID, PersonID, CreationDate, DriverLicenseNumber, CreatedByUserID);
            }
            else
                return null;

        }

        public static bool DeleteCustomer(int CustomerID)
        {
            return DAL.CustomerRepository.Delete(CustomerID);
        }

        public bool Delete()
        {
            return DAL.CustomerRepository.Delete(this.CustomerID);
        }

        public static DataTable GetAllCustomers()
        {
            return DAL.CustomerRepository.GetAll();
        }

        public static DataTable GetCustomerHistory(int CustomerID)
        {
            return DAL.CustomerRepository.GetAllBookings(CustomerID);
        }

        public static bool IsCustomerExists(int CustomerID)
        {
            return DAL.CustomerRepository.IsExists(CustomerID);
        }

        public static bool IsCustomerExists(string DriverLicneseNumber)
        {
            return DAL.CustomerRepository.IsExists(DriverLicneseNumber);
        }


        public static bool IsCustomerExistsByPersonID(int PersonID)
        {
            return DAL.CustomerRepository.IsExistsByPersonID(PersonID);
        }


        public bool IsExists()
        {
            return DAL.CustomerRepository.IsExists(this.CustomerID);
        }

        public static int GetTotalRentTimes(int CustomerID)
        {
            return DAL.CustomerRepository.GetTotalRentTimes(CustomerID);
        }

        public int GetTotalRentTimes()
        {
            return DAL.CustomerRepository.GetTotalRentTimes(this.CustomerID);
        }

        public static DateTime GetLastRentDate(int CustomerID)
        {
            return DAL.CustomerRepository.GetLastRentDate(CustomerID);
        }

        public DateTime GetLastRentDate()
        {
            return DAL.CustomerRepository.GetLastRentDate(CustomerID);
        }

        public static int GetTotalCustomers()
        {
            return DAL.CustomerRepository.GetTotalCustomers();
        }
    }
}
