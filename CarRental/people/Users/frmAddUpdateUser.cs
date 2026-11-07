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
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew=1,Update=2,Convert=3}
        private enMode _Mode;
        private int _UserID = -1;
        private int _PersonID = -1;
        private User _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int ID,enMode Mode=enMode.Update)
        {
            InitializeComponent();
            _Mode = Mode;
            if (_Mode==enMode.Convert)
            {
                _PersonID = ID;
                return;
            }
            _UserID= ID;
        }
        //---------------------------------Load------------------------------------
        private void _SetDefaults()
        {
            
            _User=new User();
            btnSave.Enabled = false;
            btnNext.Visible = true;

            
            
            gbUserInfo.Enabled = false;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cbIsActive.Checked = true;
            cbRole.SelectedIndex = 0;
        }

        private void _SetConvertingMode()
        {
            if (_PersonID <= 0)
                return;
            if(User.IsUserExistsByPersonID(_PersonID))
            {
                MessageBox.Show("This Person Is Already User In The System","Already Exists",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
                return;
            }
                
            ctrlPersonInfoWithFilter1.LoadPerson(_PersonID);
            ctrlPersonInfoWithFilter1.FilterEnabled = false;
            _Next();
        }

        private void _LoadData()
        {
            _User= User.GetUserByID(_UserID);
            if( _User==null ) 
            {
                MessageBox.Show("Error : Error While Loading The User Wuth ID : " + _UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (Properties.Settings.Default.Language == "en")
                {
                lblTitle.Text = "Update-User";
                this.Text = lblTitle.Text;
            }
            else
            {
                lblTitle.Text = "تعديل مستخدم";
                this.Text = lblTitle.Text;

            }
        


            ctrlPersonInfoWithFilter1.LoadPerson(_User.PersonID);
            ctrlPersonInfoWithFilter1.FilterEnabled = false;
            btnNext.Visible= false;
            btnSave.Enabled = true;

            txtUsername.Text = _User.Username;
            cbIsActive.Checked = _User.IsActive;
            cbRole.SelectedIndex = ((int)_User.Role)-1;
            lblUserID.Text=_User.UserID.ToString();
            gbUserInfo.Enabled= true;
            tcPersonInfo.SelectedTab = tpUserinfo;

        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _SetDefaults();
            if (_Mode == enMode.Update)
            {
                _LoadData();
                return;
            }
            if(_Mode==enMode.Convert)
            {
                _SetConvertingMode();
            }

        }

        //---------------------------------Load------------------------------------

        //---------------------------------Save------------------------------------

        private void _Save()
        {
            _User.Username=txtUsername.Text;
            _User.Password=txtPassword.Text;   
            _User.IsActive=cbIsActive.Checked;
            _User.Role=(User.enRole)(cbRole.SelectedIndex+1);
            _User.PersonID = ctrlPersonInfoWithFilter1.SelectedPersonID;


            if(_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                if (Properties.Settings.Default.Language == "en")
                {
                    lblTitle.Text = "Update-User";
                    this.Text = lblTitle.Text;
                }
                else
                {
                    lblTitle.Text = "تعديل مستخدم";
                    this.Text = lblTitle.Text;

                }
                MessageBox.Show("User Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this._Mode=enMode.Update;
            }
            else
            {
                MessageBox.Show("Error : Error While Saving User Data", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
                _Save();
        }



        //---------------------------------Save------------------------------------


        //---------------------------------Misc------------------------------------

        private void _Next()
        {
            int PersonID = ctrlPersonInfoWithFilter1.SelectedPersonID;
            if(PersonID<0)
            {
                MessageBox.Show("Error : Select Person First","Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(!Person.IsPersonExists(PersonID))
            {
                MessageBox.Show("Error : Person Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(User.IsUserExistsByPersonID(PersonID))
            {
                MessageBox.Show("Error : Person is Already User In The System Choose Antoher One", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlPersonInfoWithFilter1.FilterEnabled = false;
            btnNext.Visible=false;
            btnSave.Enabled=true;
            gbUserInfo.Enabled = true;
            tcPersonInfo.SelectTab(1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _Next();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //---------------------------------Misc------------------------------------



        //---------------------------------Validation------------------------------------

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel= true;
                ep.SetError(txtUsername, "Enter Username");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtUsername, "");

            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                ep.SetError(txtPassword, "Enter Password");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtPassword, "");

            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text!=txtPassword.Text)
            {
                e.Cancel = true;
                ep.SetError(txtConfirmPassword, "Wrong Password");
                return;
            }


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
        }

        



        //---------------------------------Validation------------------------------------


    }
}
