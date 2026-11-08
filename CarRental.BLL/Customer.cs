using CarRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data = CarRental.DAL.Entities;
namespace CarRental.BLL
{
    public class Customer
    {
        enum enMode { AddNew = 1, Update = 2 }
        public int CustomerID { get; set; }

        public int PersonID { get; set; }

        public Person PersonInfo { get; }

        public DateOnly CreationDate { get; set; }

        public int CreatedByUserID { get; set; }

        public string DriverLicnsesNumber { get; set; }

        private enMode _Mode = enMode.AddNew;

        //----------------------------------
        public Customer()
        {
            this.CustomerID = -1;
            this.PersonID = -1;
            this.CreationDate=DateOnly.FromDateTime(DateTime.Now);
            this.DriverLicnsesNumber = "";
            this.CreatedByUserID = -1;
            this._Mode = enMode.AddNew;
        }

        public Customer(int CustomerID, int PersonID, DateOnly CreationDate, string DriverLicenseNumber, int CreatedByUserID,Person personInfo)
        {
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;
            this.PersonInfo = personInfo;
            this.CreationDate = CreationDate;
            this.DriverLicnsesNumber = DriverLicenseNumber;
            this.CreatedByUserID = CreatedByUserID;
            this._Mode = enMode.Update;
        }

        //-----------------------------------

        private async Task<bool> _AddCustomer()
        {
            Data.Customer customer = new Data.Customer()
            {
                PersonID = this.PersonID,
                CreationDate=this.CreationDate,
                DriverLicenseNumber=this.DriverLicnsesNumber,
                CreatedByUserID=this.CreatedByUserID
            };


            this.CustomerID =await DAL.CustomerRepository.Create(customer);
            return this.CustomerID > 0;
        }

        private async Task<bool> _UpdateCustomer()
        {
            Data.Customer customer = new Data.Customer()
            {
                CustomerID = this.CustomerID,
                PersonID = this.PersonID,
                CreationDate = this.CreationDate,
                DriverLicenseNumber = this.DriverLicnsesNumber,
                CreatedByUserID = this.CreatedByUserID
            };
            return await DAL.CustomerRepository.Update(customer);
        }

        public async  Task<bool> Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return await _AddCustomer();
                case enMode.Update:
                    return await _UpdateCustomer();
            }
            return false;
        }

        public static async Task<Customer?> GetCustomerByID(int CustomerID)
        {
            Data.Customer? customer = await DAL.CustomerRepository.GetByID(CustomerID);
            if (customer!=null)
            {
                    Person? personInfo = await BLL.Person.GetPerson(customer.PersonID);
                return new Customer(customer.CustomerID, customer.PersonID, customer.CreationDate, customer.DriverLicenseNumber, customer.CreatedByUserID, personInfo);
            }
            else
                return null;

        }

        public async static Task<Customer?> GetCustomerByPersonID(int PersonID)
        {
            Data.Customer? customer = await DAL.CustomerRepository.GetByPersonID(PersonID);
            if (customer != null)
            {
                Person? personInfo = await BLL.Person.GetPerson(customer.PersonID);
                return new Customer(customer.CustomerID, customer.PersonID, customer.CreationDate, customer.DriverLicenseNumber, customer.CreatedByUserID, personInfo);
            }
            else
                return null;

        }

        public static async Task<bool> DeleteCustomer(int CustomerID)
        {
            return await DAL.CustomerRepository.Delete(CustomerID);
        }

        public async Task<bool> Delete()
        {
            return await DAL.CustomerRepository.Delete(this.CustomerID);
        }

        public static async Task<DataTable> GetAllCustomers()
        {
            return await DAL.CustomerRepository.GetAll();
        }

        public static DataTable GetCustomerHistory(int CustomerID)
        {
            return DAL.CustomerRepository.GetAllBookings(CustomerID);
        }

        public static async Task<bool> IsCustomerExists(int CustomerID)
        {
            return await DAL.CustomerRepository.IsExists(CustomerID);
        }

        public static async Task<bool> IsCustomerExists(string DriverLicneseNumber)
        {
            return await DAL.CustomerRepository.IsExists(DriverLicneseNumber);
        }


        public static async Task<bool> IsCustomerExistsByPersonID(int PersonID)
        {
            return await DAL.CustomerRepository.IsExistsByPersonID(PersonID);
        }


        public async Task<bool> IsExists()
        {
            return await DAL.CustomerRepository.IsExists(this.CustomerID);
        }

        public static async Task<int> GetTotalRentTimes(int CustomerID)
        {
            return await DAL.CustomerRepository.GetTotalRentTimes(CustomerID);
        }

        public async Task<int> GetTotalRentTimes()
        {
            return await DAL.CustomerRepository.GetTotalRentTimes(this.CustomerID);
        }

        public static async Task<DateTime> GetLastRentDate(int CustomerID)
        {
            return await DAL.CustomerRepository.GetLastRentDate(CustomerID);
        }

        public async Task<DateTime> GetLastRentDate()
        {
            return await DAL.CustomerRepository.GetLastRentDate(CustomerID);
        }

        public static async Task<int> GetTotalCustomers()
        {
            return await DAL.CustomerRepository.GetTotalCustomers();
        }
    }
}
