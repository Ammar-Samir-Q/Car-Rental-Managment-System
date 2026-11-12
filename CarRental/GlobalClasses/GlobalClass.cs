using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;
namespace CarRental
{
    public class GlobalClass
    {
        //UserID Saved Here After Login
        static string Keyname = "HKEY_CURRENT_USER\\Software\\CarRentalSystem";

        public static User? CurrentUser;

        public GlobalClass()
        {
            CurrentUser = new User();
        }

        public static bool SaveUserInfoToReg(string Username,string Password)
        {
            
            try
            {
                Registry.SetValue(Keyname, "Username", Username);
                Registry.SetValue(Keyname, "Password", Password);
                return true;
            }
            catch(Exception ex)
            {
                string Source = "CarRentalApp";
                //if(!EventLog.SourceExists(Source))
                //{
                //    EventLog.CreateEventSource(Source,"Appliaction");
                //}
                //EventLog.WriteEntry(Source, ex.ToString(),EventLogEntryType.Error);
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false; 
            }

        }

        public static bool ReadUserInfoFromReg(ref string Username, ref string Password)
        {

            try
            {
                Username=Registry.GetValue(Keyname, "Username", null) as string;
                Password=Registry.GetValue(Keyname, "Password", null) as string;
                return true;
            }
            catch (Exception ex)
            {
                string Source = "CarRentalApp";
                if (!EventLog.SourceExists(Source))
                {
                    EventLog.CreateEventSource(Source, "Appliaction");
                }
                EventLog.WriteEntry(Source, ex.ToString(), EventLogEntryType.Error);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }

}

