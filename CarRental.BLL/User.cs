using System.Data;
using CarRental.DTO;
using Data=CarRental.DAL.Entities;
using Util;

namespace CarRental.BLL
{
    public class User
    {
        enum enMode { AddNew = 1, Update = 2 }
        public enum enRole { Admin = 1, User = 2, Customer = 3 }

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public Person PersonInfo { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public enRole Role { get; set; }

        public bool IsActive { get; set; }

        public DateOnly CreationDate { get; set; }

        private enMode _Mode = enMode.AddNew;

        public string GetRoleTitle
        {
            get
            {
                switch (this.Role)
                {
                    case enRole.Admin:
                        return "Admin";
                    case enRole.User:
                        return "User";
                    case enRole.Customer:
                        return "Customer";
                }
                return "User";
            }
        }

        //---------------------------------------
        public User()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.Role = enRole.Admin;
            this.IsActive = false;
            this.CreationDate = DateOnly.FromDateTime(DateTime.Now);
            this._Mode = enMode.AddNew;
        }

        public User(int UserID, int PersonID, string Username, string Password, byte Role, bool IsActive, DateOnly CreationDate,Person personInfo)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = personInfo;
            this.Username = Username;
            this.Password = Password;
            this.Role = (enRole)Role;
            this.IsActive = IsActive;
            this.CreationDate = CreationDate;
            this._Mode = enMode.Update;
        }

        private async Task<bool> _AddUser()
        {
            Data.User user = new Data.User()
            {
                PersonID = this.PersonID,
                Username = this.Username,
                Password = Util.Security.SecurityHelper.HashData(this.Password),
                Role =(byte) this.Role,
                IsActive=this.IsActive
            };

            this.UserID = await DAL.UserRepository.AddUser(user);
            return this.UserID > 0;
        }

        private async Task<bool> _UpdateUser()
        {
            Data.User user = new Data.User()
            {
                UserID=this.UserID,
                PersonID = this.PersonID,
                Username = this.Username,
                Password = Util.Security.SecurityHelper.HashData(this.Password),
                Role = (byte)this.Role,
                IsActive = this.IsActive
            };
            return await DAL.UserRepository.UpdateUser(user);
        }

        public async Task<bool> Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return await _AddUser();
                case enMode.Update:
                    return await _UpdateUser();
            }
            return false;
        }

        public static async Task<User?> GetUserByID(int UserID)
        {
            var User = await DAL.UserRepository.GetUserByID(UserID);

            if (User!=null)
            {
                BLL.Person? personInfo = await BLL.Person.GetPerson(User.PersonID);
                return new User(UserID, User.PersonID, User.Username, User.Password, User.Role, User.IsActive, User.CreationDate,personInfo);
            }
            else
                return null;
        }
        public async static Task<User?> GetUserByIDAsync(int UserID)
        {
            var User = await DAL.UserRepository.GetUserByID(UserID);

            if (User != null)
            {
                BLL.Person? personInfo = await BLL.Person.GetPerson(User.PersonID);
                return new User(UserID, User.PersonID, User.Username, User.Password, User.Role, User.IsActive, User.CreationDate, personInfo);
            }
            else
                return null;
        }

        public async static Task<User?> GetUserByUsernameAndPasswordAsync(string Username, string Password,bool IsHash=false)
        {
            Data.User? User;
            if (IsHash)
                User = await DAL.UserRepository.GetUserByUsernameAndPasswordAsync(Username,Password);
            else
                User = await DAL.UserRepository.GetUserByUsernameAndPasswordAsync(Username,Util.Security.SecurityHelper.HashData(Password));

            if (User != null)
            {
                BLL.Person? personInfo = await BLL.Person.GetPerson(User.PersonID);
                return new User(User.UserID, User.PersonID, User.Username, User.Password, User.Role, User.IsActive, User.CreationDate, personInfo);
            }
            else
                return null;
        }
        public static async Task<bool> DeleteUser(int UserID)
        {
            return await DAL.UserRepository.DeleteUser(UserID);
        }
        public async Task<bool> Delete()
        {
            return await DAL.UserRepository.DeleteUser(this.UserID);
        }

        public static async Task<DataTable> GetAllUsers()
        {
            return await DAL.UserRepository.GetAllUsers();
        }

        public static async Task<bool> IsUserExists(int UserID)
        {
            return await DAL.UserRepository.IsUserExists(UserID);
        }

        public static async Task<bool> IsUserExists(string UserName, string Password)
        {
            return await DAL.UserRepository.IsUserExists(UserName, Util.Security.SecurityHelper.HashData(Password));
        }

        public async Task<bool> IsExists()
        {
            return await DAL.UserRepository.IsUserExists(this.UserID);
        }


        public static async Task<bool> IsUserExistsByPersonID(int PersonID)
        {
            return await DAL.UserRepository.IsUserExistsByPersonID(PersonID);
        }
    }
}
