using CarRental.DTO.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entity=CarRental.DAL.Entities;
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

        public string? Email { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? ImagePath { get; set; }

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
            string LastName, byte Gender, string NationalNo, string Phone, string? Email, string Address, DateTime DateOfBirth, string? ImagePath)
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
            Entity.Person Newperson = new Entity.Person()
            {
                FirstName = this.FirstName,
                SecondName=this.SecondName,
                ThirdName=this.ThirdName,
                LastName=this.LastName,
                Gender=this.Gender,
                NationalNo=this.NationalNo,
                Phone=this.Phone,
                Email=this.Email,
                Address=this.Address,
                DateOfBirth=this.DateOfBirth,
                ImagePath=this.ImagePath
            };

            this.PersonID = await DAL.PersonRepository.AddPerson(Newperson);
            return this.PersonID > 0;
        }
        private async Task<bool> _UpdatePerosn()
        {
            Entity.Person person = new Entity.Person()
            {
                PersonID = this.PersonID,
                FirstName = this.FirstName,
                SecondName = this.SecondName,
                ThirdName = this.ThirdName,
                LastName = this.LastName,
                Gender = this.Gender,
                NationalNo = this.NationalNo,
                Phone = this.Phone,
                Email = this.Email,
                Address = this.Address,
                DateOfBirth = this.DateOfBirth,
                ImagePath = this.ImagePath
            };
            return await DAL.PersonRepository.UpdatePerson(person);
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

        public static async Task<Person?> GetPerson(int PersonID)
        {

            Entity.Person? person = await DAL.PersonRepository.GetPersonByID(PersonID);
            if (person!=null)
            {
                return new Person(PersonID, person.FirstName, person.SecondName, person.ThirdName, person.LastName, person.Gender, person.NationalNo, person.Phone, person.Email, person.Address, person.DateOfBirth, person.ImagePath);
            }
            else
                return null;
        }

        public static async Task<Person?> GetPerson(string NationalNo)
        {
            Entity.Person? person = await DAL.PersonRepository.GetPersonByNationalNo(NationalNo);
            if (person != null)
            {
                return new Person(person.PersonID, person.FirstName, person.SecondName, person.ThirdName, person.LastName, person.Gender, person.NationalNo, person.Phone, person.Email, person.Address, person.DateOfBirth, person.ImagePath);
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

        public static async Task<DataTable> GetAllPeople()
        {
            return await DAL.PersonRepository.GetAllPeople();
        }
    }
}
