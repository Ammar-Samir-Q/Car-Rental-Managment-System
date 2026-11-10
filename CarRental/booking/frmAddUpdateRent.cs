using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddUpdateRent : Form
    {
        enum enMode { AddNew=1,Update=2}
        private enMode _Mode;
        private int _BookingID = -1;
        private Booking? _Booking = new Booking();


        private int _CustomerID;

        private int _VehicleID;
        private Customer? _Customer;
        private Vehicle? _Vehicle;

        public frmAddUpdateRent()
        {
            InitializeComponent();
            _Mode= enMode.AddNew;
        }

        public frmAddUpdateRent(int BookingID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _BookingID = BookingID;
        }

        public  frmAddUpdateRent(int VehicleID, int CustomerID = -1)
        {
            InitializeComponent();
                _VehicleID= VehicleID;
            _CustomerID = CustomerID;
            _Mode = enMode.AddNew;
        }
        //-------------------------Load---------------------------

        private async void _LoadData()
        {

            if (_BookingID == -1)
                return;
            
             _Booking=await Booking.GetRentalByID(_BookingID);
            
            if (_Booking == null) 
                return;

            
            if(await _Booking.IsReturned())
            {
                MessageBox.Show("This Book is Already Returned", "Returnd Rental", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            _Customer= await Customer.GetCustomerByID(_Booking.CustomerID);
            _Vehicle=await Vehicle.GetVehicleByID(_Booking.VehicleID);

            _LoadUpdateForm();
            _LoadSummaryInfo();

         
        }

        private async void _SetDefaults()
        {
            if(_CustomerID>0)
      _Customer = await Customer.GetCustomerByID(_CustomerID);



            btnSave.Enabled = false;
            btnNextVehicle.Enabled = false;
            btnNextRent.Enabled = false;
            

            gbSelectVehicle.Enabled = false;
            gbRentInfo.Enabled = false;
            gbSummary.Enabled = false;
            ctrlPersonInfoWithFilter1.ResetControl();
            //=============Date==================
            dtpStartDate.MinDate = DateTime.Now;
            dtpEndDate.MinDate = DateTime.Now.AddDays(1);

            dtpStartDate.MaxDate = DateTime.Now.AddMonths(5);
            dtpEndDate.MaxDate= DateTime.Now.AddMonths(5);
            //=============Date==================

            if(_Customer!=null)
            {
                ctrlPersonInfoWithFilter1.LoadPerson(_Customer.PersonID);
                _NextPerosn();
            }

            if (_Vehicle != null)
            {
                
                ctrlVehicleInfo1.LoadVehicle(_Vehicle.VehicleID);
                if( _Customer==null)
                {
                    tcRent.SelectedTab = tpPerson;
                }
            }

        }

        private async void frmAddRent_Load(object sender, EventArgs e)
        {
            if(_VehicleID>0)
       _Vehicle = await BLL.Vehicle.GetVehicleByID(_VehicleID);


            _SetDefaults();
            if(_Mode==enMode.Update)
                 _LoadData();
        }

        async void _LoadUpdateForm()
        {
            lblTitle.Text = "Update-Title";
            this.Text = lblTitle.Text;

            btnNext.Visible = false;
            btnNextRent.Visible = false;
            btnNextVehicle.Visible = false;
            btnSave.Enabled = true;

            gbSelectVehicle.Enabled = true;
            gbSelectPerosn.Enabled = true;
            gbRentInfo.Enabled = true;
            gbSummary.Enabled = true;

            lblRentID.Text =_Booking.BookingID.ToString();
            var transaction = await Transaction.GetTransactionByBookingID(_Booking.BookingID);
            lblTransactionID.Text = transaction.TransactionID.ToString();
            ctrlPersonInfoWithFilter1.LoadPerson(_Booking.CustomerInfo.PersonID);
            ctrlVehicleInfo1.LoadVehicle(_Booking.VehicleID);

            dtpStartDate.MinDate = _Booking.RentalStartDate;
            dtpEndDate.MinDate = _Booking.RentalStartDate;

            dtpStartDate.Value = _Booking.RentalStartDate;
            dtpEndDate.Value = _Booking.RentalEndDate;

            txtPickupLocation.Text = _Booking.PickupLocation;
            txtDropOffLocation.Text = _Booking.DropOffLocation;
            txtInitialNotes.Text = _Booking.InitialCheckNotes;
            txtPaymentDetails.Text = transaction.PaymentsDetails;
        }


        //-------------------------Load---------------------------

        //-------------------------Next---------------------------

         private async void _NextPerosn()
        {
            if(ctrlPersonInfoWithFilter1.SelectedPersonID<1?false:!await Person.IsPersonExists(ctrlPersonInfoWithFilter1.SelectedPersonID))
            {
                MessageBox.Show("Select Person First", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Handel Person To Customer Problem
            if (!await Customer.IsCustomerExistsByPersonID(ctrlPersonInfoWithFilter1.SelectedPersonID))
            {
                if (MessageBox.Show("This Person Is Not a Customer Make it Customer First ?", "Not A Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                
                Form frm=new frmAddCustomer(ctrlPersonInfoWithFilter1.SelectedPersonID,frmAddCustomer.enMode.Convert);
                frm.ShowDialog();

                if (! await Customer.IsCustomerExistsByPersonID(ctrlPersonInfoWithFilter1.SelectedPersonID))
                {
                    return;
                }
            }

            _Customer= await Customer.GetCustomerByPersonID(ctrlPersonInfoWithFilter1.SelectedPersonID);
            tcRent.SelectedTab = tpVehicle;
            btnNext.Visible=false;
             gbSelectPerosn.Enabled = false;
             gbSelectVehicle.Enabled = true;
             btnNextVehicle.Enabled = true;


    }

        async void _NextVehicle()
        {
            if (ctrlVehicleInfo1.Vehicle == null)
            {
                MessageBox.Show("Select Vehicle First", "Select Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!ctrlVehicleInfo1.Vehicle.IsAvailableForRent)
            {
                MessageBox.Show("This Vehicle Is Not Available Select Available Vehicle","Not Available",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _Vehicle= await Vehicle.GetVehicleByID(ctrlVehicleInfo1.VehicleID);
            tcRent.SelectedTab = tpRentInfo;
            btnNextVehicle.Visible=false;
            gbSelectVehicle.Enabled=false;
            gbRentInfo.Enabled = true;
            btnNextRent.Enabled=true;

        }

        void _NextRentInfo()
        {
            if (!ValidateChildren())
                return;
            
            if(dtpEndDate.Value.Date<=dtpStartDate.Value.Date)
            {
                MessageBox.Show("End-Date Can't Be Before Start Date Or On The Same Day", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tcRent.SelectedTab = tpSummary;
            _LoadSummaryInfo();
            btnNextRent.Visible=false;
            gbRentInfo.Enabled = false;
            gbSummary.Enabled=true;
            btnSave.Enabled=true;


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _NextPerosn();
        }

        private void btnNextVehicle_Click(object sender, EventArgs e)
        {
            _NextVehicle();
        }

        private void btnNextRent_Click(object sender, EventArgs e)
        {
            _NextRentInfo();
        }



        //-------------------------Next---------------------------


        //-------------------------Misc---------------------------
         
        async void GetVehicleID(int VehicleID)
        {
            if (VehicleID > 0)
            {
                ctrlVehicleInfo1.LoadVehicle(VehicleID);
                _Vehicle=await Vehicle.GetVehicleByID(VehicleID);
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSelectVehicle frm=new frmSelectVehicle();
            frm.IDBack += GetVehicleID;
            frm.ShowDialog();
        }

       private void _LoadSummaryInfo()
        {
            lblCustomerName.Text = _Customer.PersonInfo.FullName;
            lblDriverLicenseNumber.Text = _Customer.DriverLicnsesNumber;
            lblVehicleModel.Text = _Vehicle.Model;
            lblRentalPricePerDay.Text=_Vehicle.RentalPricePerDay.ToString();
            lblCurrentMilage.Text=_Vehicle.CurrentMilage.ToString();

            lblStartDate.Text = dtpStartDate.Value.ToShortDateString();
            lblEndDate.Text=dtpEndDate.Value.ToShortDateString();

            int TotalDays=(dtpEndDate.Value.Date-dtpStartDate.Value.Date).Days;

            lblTotalDays.Text   = TotalDays.ToString();
            lblTotalInitialAmount.Text = (_Vehicle.RentalPricePerDay * TotalDays).ToString();




        }

        private void linklblCustomerInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmCustomerInfo(_Customer.CustomerID);
            frm.ShowDialog();
        }

        private void linklblVehicleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmVehicleInfo(_Vehicle.VehicleID);
            frm.ShowDialog();
        }




        //-------------------------Misc---------------------------

        //-------------------------Save---------------------------

        async Task _SaveData()
        {

            _Booking.CustomerID = _Customer.CustomerID;
            _Booking.VehicleID = _Vehicle.VehicleID;
            _Booking.RentalStartDate = dtpStartDate.Value;
            _Booking.RentalEndDate = dtpEndDate.Value;
            _Booking.PickupLocation = txtPickupLocation.Text;
            _Booking.DropOffLocation = txtDropOffLocation.Text;
            _Booking.RentalPricePerDay = _Vehicle.RentalPricePerDay;
            _Booking.CreatedByUserID = GlobalClass.CurrentUser.UserID;
            _Booking.InitialCheckNotes = txtInitialNotes.Text;


            if ( !await _Booking.Save())
            {
                MessageBox.Show("Error : Faild While Saving The Rent Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Transaction? Transaction = new Transaction();

            if (_Mode == enMode.Update)
                Transaction =await Transaction.GetTransactionByBookingID(_Booking.BookingID);

         

            Transaction.BookingID = _Booking.BookingID;
            Transaction.PaidInitialTotalDueAmount=_Booking.InitialTotalDueAmount;
            Transaction.PaymentsDetails = txtPaymentDetails.Text;
            
            if(_Mode==enMode.AddNew)
            Transaction.TransactionDate = DateTime.Now;
            
            Transaction.UpdatedTransactionDate = DateOnly.FromDateTime(DateTime.Now);
            if(!await Transaction.Save())
            {
                MessageBox.Show("Faild While Saving Transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Booking.Delete();
                return;
            }

            lblRentID.Text = _Booking.BookingID.ToString();
            lblTransactionID.Text=Transaction.TransactionID.ToString();



            Vehicle.SetVehicleAvilable(_Booking.VehicleID, false);
            MessageBox.Show("Saved Susseccfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
     
        }

      
        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveData();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Value.ToShortDateString();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Value.ToShortDateString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Data Will Not Be Saved ? ","Close",MessageBoxButtons.OKCancel)==DialogResult.OK)
            this.Close();
        }

        //-------------------------Save---------------------------

    }
}
