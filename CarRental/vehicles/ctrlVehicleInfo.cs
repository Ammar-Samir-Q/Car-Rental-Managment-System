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
    public partial class ctrlVehicleInfo : UserControl
    {
        public ctrlVehicleInfo()
        {
            InitializeComponent();
        }
        private int _VehicleID = -1;
        private Vehicle _Vehicle;
        public int VehicleID { get { return _VehicleID; } }
        public Vehicle Vehicle { get { return _Vehicle; } }
        public void LoadVehicle(int VehicleID)
        {
            _VehicleID = VehicleID;
            _Vehicle=Vehicle.GetVehicleByID(VehicleID);
            if( _Vehicle != null )
            {
                _LoadData();
            }


        }


        private void _LoadData()
        {
            lblVehicleID.Text=_Vehicle.VehicleID.ToString();
            lblMake.Text = _Vehicle.Make;
            lblModel.Text = _Vehicle.Model;
            lblYear.Text = _Vehicle.Year.ToString();
            lblMilage.Text=_Vehicle.CurrentMilage.ToString();
            lblFuelType.Text= _Vehicle.GetFuelTypeTitle();
            lblVehicleCategory.Text = _Vehicle.GetVehicleCategoryTitle();
            lblIsAvailable.Text = _Vehicle.IsAvailableForRent ? "Yes" : "No";
            lblTotalRentTimes.Text=_Vehicle.GetTotalRentTimes().ToString();
            lblPricePerDay.Text=_Vehicle.RentalPricePerDay.ToString();
            if(!string.IsNullOrEmpty(_Vehicle.ImagePath))
                pbImage.ImageLocation = _Vehicle.ImagePath;

            linklblEditVehicle.Enabled = true;




        }

        private void linklblEditVehicle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GlobalClass.CurrentUser.Role == User.enRole.Admin)
            {
                Form frm = new frmAddUpdateVehicle(_VehicleID);
                frm.ShowDialog();
                this.LoadVehicle(_VehicleID);
            }
            else
            {
                MessageBox.Show("User Cant Edit Vehicles", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
