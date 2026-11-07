using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        private int _UserID=-1;
        public int UserID { get { return _UserID; } }

        public void LoadUser(int UserID)
        {
            _UserID = UserID;
            if (UserID <= 0)
                return;

                User User = User.GetUserByID(UserID);
                if( User == null )
            {
                MessageBox.Show("Error : Faild To Load User Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                ctrlPersonInfo1.LoadPerson(User.PersonID);
                lblUserID.Text = UserID.ToString();
            lblUsername.Text = User.Username;
            lblCreationDate.Text = User.CreationDate.ToShortDateString();
            lblIsActive.Text = User.IsActive ? "Yes" : "No";
            lblRole.Text = User.GetRoleTitle;
            linklblEditUser.Enabled = true;


        }

        private void linklblEditUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(clsGlobalSettings.CurrentUser.Role== User.enRole.Admin)
            {
                Form frm = new frmAddUpdateUser(_UserID);
                frm.ShowDialog();
                this.LoadUser(_UserID);
            }
            else
            {
                MessageBox.Show("User Cant Edit Users", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
 
        }
    }
}
