using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL
{
    public class DatabaseService
    {
        public static bool TestConnection()
        {
            return DAL.DataHelper.CheckConnection();
        }


        public static bool BackupDatabase(string Path)
        {
            return DAL.DataHelper.BackupDatabase(Path);
        }
    }
}
