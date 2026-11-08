using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.DTO.Views;
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
        public async static Task<int> AddPerson(Person person)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            await context.People.AddAsync(person);

            await context.SaveChangesAsync();

            return person.PersonID;


        }

        public static async Task<bool> UpdatePerson(Person person)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var Person = await context.People.FindAsync(person.PersonID);

            if (Person == null)
                return false;

            Person.FirstName = person.FirstName;
            Person.SecondName = person.SecondName;
            Person.ThirdName = person.ThirdName;
            Person.LastName = person.LastName;
            Person.Gender = person.Gender;
            Person.NationalNo = person.NationalNo;
            Person.Phone = person.Phone;
            Person.Email = person.Email;
            Person.Address = person.Address;
            Person.DateOfBirth = person.DateOfBirth;
            Person.ImagePath = person.ImagePath;


            await context.SaveChangesAsync();

            return true;

        }

        public async static Task<Person?> GetPersonByID(int PersonID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.People.FindAsync(PersonID);

        }

        public static async Task<Person?> GetPersonByNationalNo(string nationalNo)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.People.FirstOrDefaultAsync(p=>p.NationalNo==nationalNo);

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

        //ADO.NET
        
        public static async Task<DataTable> GetAllPeople()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataHelper.ConnectionString))
                {
                    await connection.OpenAsync();
                    string Query = @"SELECT * FROM People_View";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            if (reader.HasRows)
                                dataTable.Load(reader);
                            
   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTable;

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
