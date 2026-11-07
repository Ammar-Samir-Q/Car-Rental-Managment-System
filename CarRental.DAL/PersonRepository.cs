using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.DAL.Factories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarRental.DAL
{
    public class PersonRepository
    {
        public async static Task<int> AddPerson(string firstName, string secondName, string thirdName, string lastName
         , byte gendor, string nationalNo, string phone, string email, string address, DateTime dateOfBirth, string imagePath)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var Person = new Person()
            {
                FirstName = firstName,
                SecondName = secondName,
                ThirdName = thirdName,
                LastName = lastName,
                Gender = gendor,
                NationalNo = nationalNo,
                Phone = phone,
                Email = email,
                Address = address,
                DateOfBirth = dateOfBirth,
                ImagePath = imagePath
            };

            await context.People.AddAsync(Person);

            await context.SaveChangesAsync();

            return Person.PersonID;


        }

        public static async Task<bool> UpdatePerson(int PersonID, string firstName, string secondName, string thirdName, string lastName
         , byte gendor, string nationalNo, string phone, string email, string address, DateTime dateOfBirth, string imagePath)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var Person = await context.People.FindAsync(PersonID);

            if (Person == null)
                return false;

            Person.FirstName = firstName;
            Person.SecondName = secondName;
            Person.ThirdName = thirdName;
            Person.LastName = lastName;
            Person.Gender = gendor;
            Person.NationalNo = nationalNo;
            Person.Phone = phone;
            Person.Email = email;
            Person.Address = address;
            Person.DateOfBirth = dateOfBirth;
            Person.ImagePath = imagePath;


            await context.SaveChangesAsync();

            return true;

        }

        public static bool GetPersonByID(int PersonID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName
            , ref byte gendor, ref string nationalNo, ref string phone, ref string? email, ref string address, ref DateTime dateOfBirth, ref string? imagePath)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var Person = context.People.Find(PersonID);

            if (Person == null) return false;

            firstName = Person.FirstName;
            secondName = Person.SecondName;
            thirdName = Person.ThirdName;
            lastName = Person.LastName;
            gendor = Person.Gender;
            nationalNo = Person.NationalNo;
            phone = Person.Phone;
            email = Person.Email;
            address = Person.Address;
            dateOfBirth = Person.DateOfBirth;
            imagePath = Person.ImagePath;


            return true;



        }

        public static bool GetPersonByNationalNo(string nationalNo,ref int personID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName
            , ref byte gendor, ref string phone, ref string? email, ref string address, ref DateTime dateOfBirth, ref string? imagePath)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var Person = context.People.FirstOrDefault(p=>p.NationalNo==nationalNo);

            if (Person == null) return false;

            firstName = Person.FirstName;
            secondName = Person.SecondName;
            thirdName = Person.ThirdName;
            lastName = Person.LastName;
            gendor = Person.Gender;
            personID = Person.PersonID;
            phone = Person.Phone;
            email = Person.Email;
            address = Person.Address;
            dateOfBirth = Person.DateOfBirth;
            imagePath = Person.ImagePath;


            return true;


        }


        public async static Task<bool> DeletePerson(int PersonID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var person = await context.People.FindAsync(PersonID);

            if (person == null) return false;

            context.People.Remove(person);

            await context.SaveChangesAsync();

            return true;

        }

        public static DataTable GetAllPeople()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM People_View";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            { }
            finally { connection.Close(); }
            return dataTable;
            {
            }
        }

        public static async Task<bool> IsPersonExists(int PersonID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

           return await context.People.AnyAsync(p => p.PersonID == PersonID);

        }

        public static async Task<bool> IsPersonExists(string NationalNo)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.People.AnyAsync(p => p.NationalNo == NationalNo);

        }
    }
}
