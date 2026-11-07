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
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;
        private User _User;
        public frmChangePassword(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if(_UserID == -1)
            {
                this.Close();
                return;
            }
            _User=User.GetUserByID(this._UserID);
            if( _User == null )
            {
                this.Close();
                return;
            }
            ctrlUserInfo1.LoadUser(this._UserID);

        }

        private void _Save()
        {
            _User.Password = txtNewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("Password Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                MessageBox.Show("Faild To Update Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
                _Save();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
          
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel= true;
                ep.SetError(txtPassword, "Enter Current Password");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtPassword, "");
            }

            if (!User.IsUserExists(_User.Username,txtPassword.Text))
            {
                e.Cancel = true;
                ep.SetError(txtPassword, "Wrong Password");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
         

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                ep.SetError(txtConfirmPassword, "Confirm Password");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtConfirmPassword, "");
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                ep.SetError(txtConfirmPassword, "Passwords Not Match");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtConfirmPassword, "");
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                e.Cancel = true;
                ep.SetError(txtNewPassword, "Enter New Password");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtNewPassword, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
