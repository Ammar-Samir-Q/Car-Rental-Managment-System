using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL
{
    public class DatabaseService
    {
        public static async Task<bool> TestConnection()
        {
            return await DAL.DataHelper.CheckConnection();
        }


        public static async Task<bool> BackupDatabase(string Path)
        {
            return await DAL.DataHelper.BackupDatabase(Path);
        }
    }
}
