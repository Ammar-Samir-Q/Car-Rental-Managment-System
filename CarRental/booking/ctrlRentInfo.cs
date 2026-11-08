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
    public partial class ctrlRentInfo : UserControl
    {
        public ctrlRentInfo()
        {
            InitializeComponent();
        }
        private int _BookingID = -1;
        private Booking _Booking;

        public int BookingID {  get { return _BookingID; }} 

        public Booking Booking { get { return _Booking; }}

        public void LoadBooking(int BookingID)
        {
            if (BookingID < 0)
                return;

            _BookingID = BookingID;
            _LoadData();
           
        }
        public void LoadBookingByTransactionID(int TransactionID)
        {
            if (TransactionID < 0)
                return;
            
            _BookingID = Transaction.GetTransactionByID(TransactionID).BookingID;
            _LoadData();

        }


        public void ResetControl()
        {
            _SetDefaults();
        }
        private async void _LoadData()
        {
             _Booking= Booking.GetRentalByID(BookingID);

            if (_Booking == null)
                return;

            lblBookingID.Text = _Booking.BookingID.ToString();
            lblStartDate.Text=_Booking.RentalStartDate.ToShortDateString();
            lblEndDate.Text=_Booking.RentalEndDate.ToShortDateString();
            lblPickupLocation.Text= _Booking.PickupLocation==""?"N/A":_Booking.PickupLocation;
            lblDropOffLocation.Text=_Booking.DropOffLocation==""?"N/A":_Booking.DropOffLocation;
            lblCheackNotes.Text=_Booking.InitialCheckNotes==""?"N/A":_Booking.InitialCheckNotes;
            lblRentalPrice.Text = _Booking.RentalPricePerDay.ToString();
            var user= await User.GetUserByID(_Booking.CreatedByUserID);
            lblCreatedBy.Text = user==null?"N/A":user.Username;
            lblTotalDays.Text = _Booking.TotalDays.ToString();
            lblTotalPaidAmount.Text = _Booking.InitialTotalDueAmount.ToString();


            lblVehicleID.Text = _Booking.VehicleID.ToString();
            lblModel.Text = _Booking.VehicleInfo.Model;
            lblYear.Text = _Booking.VehicleInfo.Year.ToString();
            lblMilage.Text=_Booking.VehicleInfo.CurrentMilage.ToString();
            if(!string.IsNullOrEmpty(_Booking.VehicleInfo.ImagePath))
                pbVehicle.ImageLocation= _Booking.VehicleInfo.ImagePath;

            lblCustomerID.Text = _Booking.CustomerID.ToString();
            lblName.Text = _Booking.CustomerInfo.PersonInfo.FullName;
            lblPhone.Text = _Booking.CustomerInfo.PersonInfo.Phone;
            lblDriverLicense.Text=_Booking.CustomerInfo.DriverLicnsesNumber.ToString();

            if (string.IsNullOrEmpty(_Booking.CustomerInfo.PersonInfo.ImagePath))
            {
                if (_Booking.CustomerInfo.PersonInfo.Gender == 0)
                    pbCustomer.Image = Properties.Resources.png_Male;
                else
                    pbCustomer.Image = Properties.Resources.png_Female;

            }
            else
                pbCustomer.ImageLocation = _Booking.CustomerInfo.PersonInfo.ImagePath;


            linklblVehicleInfo.Enabled = true;
            linklblCustomerInfo.Enabled = true;









        }

        private void _SetDefaults()
        {

            lblBookingID.Text = "[???]";
            lblStartDate.Text = "[???]";
            lblEndDate.Text = "[???]";
            lblPickupLocation.Text = "[???]";
            lblDropOffLocation.Text = "[???]";
            lblCheackNotes.Text = "[???]";
            lblRentalPrice.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            lblTotalDays.Text = "[???]";
            lblTotalPaidAmount.Text ="[???]";


            lblVehicleID.Text = "[???]";
            lblModel.Text = "[???]";
            lblYear.Text = "[???]";
            lblMilage.Text = "[???]";
            

            lblCustomerID.Text = "[???]";
            lblName.Text = "[???]";
            lblPhone.Text = "[???]";
            lblDriverLicense.Text = "[???]";

     
            pbCustomer.Image = Properties.Resources.png_Male;
            pbVehicle.Image= Properties.Resources.png_DefaultCar;

           


            linklblVehicleInfo.Enabled = false;
            linklblCustomerInfo.Enabled = false;







        }

        private void linklblVehicleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmVehicleInfo(_Booking.VehicleID);
            frm.ShowDialog();
        }

        private void linklblCustomerInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm=new frmCustomerInfo(_Booking.CustomerID);
            frm.ShowDialog();
        }
    }
}
