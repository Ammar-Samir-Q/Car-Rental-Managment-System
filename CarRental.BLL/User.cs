using System.Data;
using CarRental.DTO;
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

        public DateTime CreationDate { get; set; }

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
            this.CreationDate = DateTime.Now;
            this._Mode = enMode.AddNew;
        }

        public User(int UserID, int PersonID, string Username, string Password, byte Role, bool IsActive, DateTime CreationDate)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = Person.GetPerson(PersonID);
            this.Username = Username;
            this.Password = Password;
            this.Role = (enRole)Role;
            this.IsActive = IsActive;
            this.CreationDate = CreationDate;
            this._Mode = enMode.Update;
        }

        private bool _AddUser()
        {

            this.UserID = DAL.UserRepository.AddUser(PersonID, Username, Util.Security.SecurityHelper.HashData(Password), (byte)Role, IsActive);
            return this.UserID > 0;
        }

        private bool _UpdateUser()
        {
            return DAL.UserRepository.UpdateUser(UserID, PersonID, Username, Util.Security.SecurityHelper.HashData(Password), (byte)Role, IsActive, CreationDate);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return _AddUser();
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static User GetUserByID(int UserID)
        {
            int PersonID = -1;
            string Username = "", Password = "";
            byte Role = 0;
            bool IsActive = false;
            DateTime CreationDate = DateTime.Now;
            if (DAL.UserRepository.GetUserByID(UserID, ref PersonID, ref Username, ref Password, ref Role, ref IsActive, ref CreationDate))
            {
                return new User(UserID, PersonID, Username, Password, Role, IsActive, CreationDate);
            }
            else
                return null;
        }
        public async static Task<User> GetUserByIDAsync(int UserID)
        {
            UserDTO usersDTO;
            usersDTO = await DAL.UserRepository.GetUserByIDAsync(UserID);
            if (!string.IsNullOrEmpty(usersDTO.Username))
            {
                return new User(usersDTO.UserID, usersDTO.PersonID, usersDTO.Username, usersDTO.Password, usersDTO.Role, usersDTO.IsActive, usersDTO.CreationDate);
            }
            else
                return null;
        }

        public async static Task<User> GetUserByUsernameAndPasswordAsync(string Username, string Password)
        {
            UserDTO usersDTO;
            usersDTO = await DAL.UserRepository.GetUserByUsernameAndPasswordAsync(Username, Util.Security.SecurityHelper.HashData(Password));
            if (!string.IsNullOrEmpty(usersDTO.Username))
            {
                return new User(usersDTO.UserID, usersDTO.PersonID, usersDTO.Username, usersDTO.Password, usersDTO.Role, usersDTO.IsActive, usersDTO.CreationDate);
            }
            else
                return null;
        }
        public static bool DeleteUser(int UserID)
        {
            return DAL.UserRepository.DeleteUser(UserID);
        }
        public bool Delete()
        {
            return DAL.UserRepository.DeleteUser(this.UserID);
        }

        public static DataTable GetAllUsers()
        {
            return DAL.UserRepository.GetAllUsers();
        }

        public static bool IsUserExists(int UserID)
        {
            return DAL.UserRepository.IsUserExists(UserID);
        }

        public static bool IsUserExists(string UserName, string Password)
        {
            return DAL.UserRepository.IsUserExists(UserName, Util.Security.SecurityHelper.HashData(Password));
        }

        public bool IsExists()
        {
            return DAL.UserRepository.IsUserExists(this.UserID);
        }


        public static bool IsUserExistsByPersonID(int PersonID)
        {
            return DAL.UserRepository.IsUserExistsByPersonID(PersonID);
        }
    }
}
