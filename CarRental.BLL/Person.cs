using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.BLL
{
    public class Person
    {
        private enum enMode { AddNew = 1, Update = 2 }
        public enum enGender { Male = 0, Female = 1 }

        public int PersonID { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }

        public byte Gender { get; set; }

        public string NationalNo { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ImagePath { get; set; }

        private enMode _Mode = enMode.AddNew;

        //----------------------------------------------

        public Person()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Gender = 0;
            this.NationalNo = "";
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.ImagePath = "";
            this.DateOfBirth = DateTime.Now;
            this._Mode = enMode.AddNew;
        }
        public Person(int PersonID, string FirstName, string SecondName, string ThirdName,
            string LastName, byte Gender, string NationalNo, string Phone, string Email, string Address, DateTime DateOfBirth, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.ImagePath = ImagePath;
            this._Mode = enMode.Update;

        }

        //----------------------------------------------------------------

        private async Task<bool> _AddPerson()
        {
            this.PersonID = await DAL.PersonRepository.AddPerson(FirstName, SecondName, ThirdName, LastName, Gender, NationalNo, Phone, Email, Address, DateOfBirth, ImagePath);
            return this.PersonID > 0;
        }
        private async Task<bool> _UpdatePerosn()
        {
            return await DAL.PersonRepository.UpdatePerson(PersonID, FirstName, SecondName, ThirdName, LastName, Gender, NationalNo, Phone, Email, Address, DateOfBirth, ImagePath);
        }

        public async Task<bool> Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return await _AddPerson();
                case enMode.Update:
                    return await _UpdatePerosn();

            }

            return false;
        }

        public static Person GetPerson(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", Lastname = "";
            byte Gender = 0;
            string NationalNo = "", Phone = "", Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;

            if (DAL.PersonRepository.GetPersonByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref Lastname, ref Gender, ref NationalNo, ref Phone, ref Email, ref Address, ref DateOfBirth, ref ImagePath))
            {
                return new Person(PersonID, FirstName, SecondName, ThirdName, Lastname, Gender, NationalNo, Phone, Email, Address, DateOfBirth, ImagePath);
            }
            else
                return null;
        }

        public static Person GetPerson(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", Lastname = "";
            byte Gender = 0;
            string Phone = "", Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;

            if (DAL.PersonRepository.GetPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref Lastname, ref Gender, ref Phone, ref Email, ref Address, ref DateOfBirth, ref ImagePath))
            {
                return new Person(PersonID, FirstName, SecondName, ThirdName, Lastname, Gender, NationalNo, Phone, Email, Address, DateOfBirth, ImagePath);
            }
            else
                return null;
        }

        public static async Task<bool> DeletePerson(int PersonID)
        {
            return await DAL.PersonRepository.DeletePerson(PersonID);
        }

        public async Task<bool> Delete()
        {
            return await DAL.PersonRepository.DeletePerson(this.PersonID);
        }

        public static async Task<bool> IsPersonExists(int PersonID)
        {
            return await DAL.PersonRepository.IsPersonExists(PersonID);
        }

        public static async Task<bool> IsPersonExists(string NationaNo)
        {
            return await DAL.PersonRepository.IsPersonExists(NationaNo);
        }

        public async Task<bool> IsExists()
        {
            return await DAL.PersonRepository.IsPersonExists(this.PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return DAL.PersonRepository.GetAllPeople();
        }
    }
}
