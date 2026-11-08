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
    public partial class frmAddCustomer : Form
    {
        //AddNew = Add New Customer From PersonID
        //Update= Update Existing Customer
        //Convert= Converting PersonID To Customer Directly
        public enum enMode {eAddNew=1,Update=2,Convert=3}
        private int _CustomerID = -1;
        private int _PersonID = -1;
        private Customer? _Customer;
        private enMode _Mode;
        public frmAddCustomer()
        {
            InitializeComponent();
            _Mode = enMode.eAddNew;
        }
        public frmAddCustomer(int ID,enMode Mode=enMode.Update)
        {
            InitializeComponent();
            _Mode = Mode;
            if (Mode==enMode.Convert)
            {
            _PersonID = ID;
                return;
            }

            _CustomerID = ID;
        }



        //--------------------------Load--------------------------
        private async void _SetDefaults()
        {
            _Customer = new Customer();
            lblCreationDate.Text = DateTime.Now.ToShortDateString();
            ctrlPersonInfoWithFilter1.ResetControl();
            //Change This After Login
            var user = await User.GetUserByID(GlobalClass.CurrentUser.UserID);
            lblCreatedBy.Text = user == null?"N/A":user.Username;
            txtDriverLicnese.Text = "";
        }
      
        private async void _LoadData()
        {
            _Customer = await Customer.GetCustomerByID(_CustomerID);
            if (_Customer == null)
                return;

            ctrlPersonInfoWithFilter1.LoadPerson(_Customer.PersonID);
            ctrlPersonInfoWithFilter1.FilterEnabled = false;
            lblTitle.Text=_Customer.CustomerID.ToString();
            lblCreationDate.Text = _Customer.CreationDate.ToShortDateString();
            var user = await User.GetUserByID(_Customer.CreatedByUserID);
            lblCreatedBy.Text = user == null ? "N/A" : user.Username;
            txtDriverLicnese.Text=_Customer.DriverLicnsesNumber.ToString();
            lblCustomerID.Text = _Customer.CustomerID.ToString();
            if (Properties.Settings.Default.Language == "en")
            {
                lblTitle.Text = "Update-Customer";
                this.Text = lblTitle.Text;
            }
            else
            {
                lblTitle.Text = "تعديل عميل";
                this.Text = lblTitle.Text;
            }
        }
        
        private async void _SetConvertingMode()
        {
            if (_PersonID <= 0)
                return;

            if (await Customer.IsCustomerExistsByPersonID(_PersonID))
            {
                MessageBox.Show("This Person Is Already A Customer", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
                
            }

            ctrlPersonInfoWithFilter1.LoadPerson(_PersonID);
            ctrlPersonInfoWithFilter1.FilterEnabled = false;
        }
        private void frmAddCuso_Load(object sender, EventArgs e)
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

        //--------------------------Load--------------------------






        //--------------------------Save--------------------------

        private async void _SaveData()
        {
            _Customer.PersonID = ctrlPersonInfoWithFilter1.SelectedPersonID;
            if(_Mode==enMode.eAddNew||_Mode==enMode.Convert)
            {
                _Customer.CreationDate = DateOnly.FromDateTime(DateTime.Now);
                _Customer.CreatedByUserID = GlobalClass.CurrentUser.UserID;
            }
            _Customer.DriverLicnsesNumber = txtDriverLicnese.Text;
            
            if( await _Customer.Save())
            {
                lblCustomerID.Text = _Customer.CustomerID.ToString();

                if (Properties.Settings.Default.Language == "en")
                {
                    lblTitle.Text = "Update-Customer";
                    this.Text = lblTitle.Text;
                }
                else
                {
                    lblTitle.Text = "تعديل عميل";
                    this.Text = lblTitle.Text;
                }
                _Mode = enMode.Update;
                MessageBox.Show("Customer Data Saved Successufully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error : Faild To Save Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(ctrlPersonInfoWithFilter1.SelectedPersonID<=0)
            {
                MessageBox.Show("Select Person First", "Select Person",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            if(! await Person.IsPersonExists(ctrlPersonInfoWithFilter1.SelectedPersonID))
            {
                MessageBox.Show("This Person is Not Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( await Customer.IsCustomerExistsByPersonID(ctrlPersonInfoWithFilter1.SelectedPersonID)&&_Mode==enMode.eAddNew)
            {
                MessageBox.Show("This Perosn Is Already Customer", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (this.ValidateChildren())
                _SaveData();

        }




        //--------------------------Save--------------------------


        //-----------------------Validation-----------------------


        private async void txtDriverLicnese_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrEmpty(txtDriverLicnese.Text))
            {
                e.Cancel = true;
                ep.SetError(txtDriverLicnese, "Enter Driver Licnese");
                return;
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtDriverLicnese, "");

            }
            if ( await Customer.IsCustomerExists(txtDriverLicnese.Text))
            {
                e.Cancel = true;
                ep.SetError(txtDriverLicnese, "This Driver License Is Already Exists");

            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtDriverLicnese, "");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //-----------------------Validation-----------------------



    }
}
