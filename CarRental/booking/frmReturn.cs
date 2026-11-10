using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmReturn : Form
    {
        private int _BookingID = -1;
        public frmReturn()
        {
            InitializeComponent();
        }

        public frmReturn(int BookingID)
        {
            _BookingID=BookingID;
            InitializeComponent();
        }

      //---------------------------------Load-------------------------------------
        private void _SetDefaults()
        {
            btnSave.Enabled = false;
            gbReturn.Enabled= false;
            ctrlRentInfoWithFilter1.FilterEnabled = true;
            dtpReturnDate.MinDate=DateTime.Now;
            dtpReturnDate.Value=DateTime.Now;

            cbReturnCondation.SelectedIndex = 0;
            cbFuelLevel.SelectedIndex = 0;

        }

        private void _LoadData()
        {

            ctrlRentInfoWithFilter1.LoadBooking(_BookingID);
            dtpReturnDate.MinDate=ctrlRentInfoWithFilter1.Booking.RentalStartDate.AddDays(1);
            gbReturn.Enabled = true;
            btnSave.Enabled = true;
            btnNext.Visible = false;
            tc.SelectedTab=tpReturnDetails;
        }

        private void frmAddRent_Load(object sender, EventArgs e)
        {
            _SetDefaults();
            if(_BookingID>0)
                _LoadData();

        }

        //---------------------------------Load-------------------------------------

        //---------------------------------Next-------------------------------------

        private async void _Next()
        {
            if (ctrlRentInfoWithFilter1.BookingID <= 0)
            {
                MessageBox.Show("Select Booking First", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ctrlRentInfoWithFilter1.Booking == null)
                return;

            if(await ctrlRentInfoWithFilter1.Booking.IsReturned())
            {
                MessageBox.Show("This Booking Is Already Returnd", "Returnd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblRentalDays.Text = ((dtpReturnDate.Value.Date - ctrlRentInfoWithFilter1.Booking.RentalStartDate.Date).Days).ToString();
            lblTotalDueAmount.Text = (int.Parse(lblRentalDays.Text) * ctrlRentInfoWithFilter1.Booking.RentalPricePerDay).ToString();

            _BookingID = ctrlRentInfoWithFilter1.Booking.BookingID;

            tc.SelectedTab = tpReturnDetails;
            ctrlRentInfoWithFilter1.FilterEnabled= false;
            gbReturn.Enabled= true;
            btnNext.Visible = false;
            btnSave.Enabled= true;


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _Next();
        }



        //---------------------------------Next-------------------------------------

        //---------------------------------Save-------------------------------------

        private async Task _SaveReturn()
        {
            if(dtpReturnDate.Value.Date==ctrlRentInfoWithFilter1.Booking.RentalStartDate)
            {
                MessageBox.Show("Return Date Must Be After Start Date","Date Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            Transaction? transaction = await Transaction.GetTransactionByBookingID(_BookingID);
            if (transaction == null)
                return;

            btnSave.Enabled = false;
            Return _Return = new Return();
            
            float TotalDueAmount = float.Parse(lblTotalDueAmount.Text);
            if(!string.IsNullOrEmpty(txtAddtionalCharges.Text))
            {
               TotalDueAmount+=float.Parse(txtAddtionalCharges.Text);
            }


            _Return.ActualReturnDate=DateOnly.FromDateTime(dtpReturnDate.Value);
            _Return.Milage = int.Parse(txtMilage.Text);
            if(!await Vehicle.UpdateMilage(ctrlRentInfoWithFilter1.Booking.VehicleID,_Return.Milage))
            {
                MessageBox.Show("Error : Error While Updating Vehicle Milage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (! await Vehicle.SetVehicleAvilable(ctrlRentInfoWithFilter1.Booking.VehicleID, true))
            {
                MessageBox.Show("Error : Error While Updating Vehicle Availablity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Return.FinalCheckNotes = txtNotes.Text;
            _Return.AddtionalCharges = Convert.ToDecimal(txtAddtionalCharges.Text==""?0:float.Parse(txtAddtionalCharges.Text));
            _Return.ActualTotalDueAmount = Convert.ToDecimal(TotalDueAmount);
            _Return.ReturnCondition = (Return.enReturnCondition)(cbReturnCondation.SelectedIndex + 1);
            _Return.FuelLevel = (Return.enFuelLevel)(cbFuelLevel.SelectedIndex + 1);

            if(!await _Return.Save())
            {
                MessageBox.Show("Error : Error While Saving Return Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            transaction.ReturnID = _Return.ReturnID;
            transaction.ActualTotalDueAmount=_Return.ActualTotalDueAmount;
            transaction.TotalRefundedAmount = (transaction.PaidInitialTotalDueAmount - transaction.ActualTotalDueAmount) < 0 ? 0 : transaction.PaidInitialTotalDueAmount - transaction.ActualTotalDueAmount;

            transaction.UpdatedTransactionDate = DateOnly.FromDateTime(DateTime.Now);

            if(!await transaction.Save())
            {
                MessageBox.Show("Error : Error While Updating Trasaction Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Return.DeleteReturn();
                return;
            }

            MessageBox.Show("Booking Returnd Successfully", "Returnd",MessageBoxButtons.OK,MessageBoxIcon.Information);
            lblReturnID.Text = _Return.ReturnID.ToString();


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                _SaveReturn();
        }



        //---------------------------------Misc-------------------------------------


        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (ctrlRentInfoWithFilter1.Booking == null)
                return;

            lblRentalDays.Text = ((dtpReturnDate.Value.Date - ctrlRentInfoWithFilter1.Booking.RentalStartDate.Date).Days).ToString();
            lblTotalDueAmount.Text = (int.Parse(lblRentalDays.Text) * ctrlRentInfoWithFilter1.Booking.RentalPricePerDay).ToString();
        }



        //---------------------------------Misc-------------------------------------

        private void txtMilage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMilage.Text))
            {
                e.Cancel = true;
                ep.SetError(txtMilage, "Enter Milage");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtMilage, "");
            }


        }

        private void txtAddtionalCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMilage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
