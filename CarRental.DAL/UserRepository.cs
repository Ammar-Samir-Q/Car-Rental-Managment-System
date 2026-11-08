using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.DAL.Factories;
using CarRental.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.DAL
{
    public class UserRepository
    {

        public static async Task<int> AddUser(User NewUser)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

           await context.Users.AddAsync(NewUser);

            await context.SaveChangesAsync();

            return NewUser.UserID;

        }

        public static async Task<bool> UpdateUser(User User)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            var user =await context.Users.FindAsync(User.UserID);

            if (user == null) return false;

            user.PersonID = User.PersonID;
            user.Username = User.Username;
            user.Password = User.Password;
            user.Role = User.Role;
            user.IsActive = User.IsActive;

            await context.SaveChangesAsync();
            return true;


        }
        public static async Task<User?> GetUserByID(int UserID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Users.FindAsync(UserID);

        }
        public async static Task<User?> GetUserByIDAsync(int UserID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Users.FindAsync(UserID);
        }

        public async static Task<User?> GetUserByUsernameAndPasswordAsync(string Username, string Password)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Users.Where(u=>u.Username==Username&&u.Password==Password).FirstOrDefaultAsync();
        }

        public static async Task<bool> DeleteUser(int UserID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();
            var User=await context.Users.FindAsync(UserID);
            if (User == null) return false;

            context.Users.Remove(User);
            await context.SaveChangesAsync();
            return true;
        }

        public async static Task<DataTable> GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataHelper.ConnectionString);
            string Query = @"SELECT * FROM Users_View";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                await connection.OpenAsync();
                SqlDataReader reader =await command.ExecuteReaderAsync();
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
        }

        public static async Task<bool> IsUserExists(int UserID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Users.AnyAsync(u=>u.UserID==UserID);

        }

        public static async Task<bool> IsUserExistsByPersonID(int PersonID)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Users.AnyAsync(u => u.PersonID == PersonID);
        }

        
        public static async Task<bool> IsUserExists(string Username, string password)
        {
            using AppDbContext context = DbContextFactory.CreateDbContext();

            return await context.Users.AnyAsync(u => u.Username == Username&&u.Password==password);

        }

    }
}
