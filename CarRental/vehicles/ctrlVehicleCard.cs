using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ctrlVehicleCard : UserControl
    {
        public ctrlVehicleCard()
        {
            InitializeComponent();
        }
        int _VehicleID = -1;
        public void LoadVehicle(int VehicleID)
        {
            _VehicleID=VehicleID;
            if (VehicleID <= 0)
                return;
            Vehicle vehicle = Vehicle.GetVehicleByID(VehicleID);
            if (vehicle == null)
                return;

            linklblMoreInfo.Enabled = true;
            lblModelName.Text = vehicle.Model;
            lblMake.Text = vehicle.Make;
            lblYear.Text=vehicle.Year.ToString();
            lblCategory.Text=vehicle.GetVehicleCategoryTitle();
            lblFuelType.Text=vehicle.GetFuelTypeTitle();
            lblRentalPrice.Text=vehicle.RentalPricePerDay.ToString();
            pbAvailable.Image=vehicle.IsAvailableForRent?Properties.Resources.icon_Available:Properties.Resources.icon_NotAvailable;

            if(!string.IsNullOrEmpty(vehicle.ImagePath))
            {
                if(File.Exists(vehicle.ImagePath))
                {
                    pbVehicle.ImageLocation = vehicle.ImagePath;
                }

            }
            btnBooking.Enabled = vehicle.IsAvailableForRent;

        }

        private void linklblMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm =new frmVehicleInfo(_VehicleID);
                frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if(_VehicleID>0)
            {
                Form frm = new frmAddUpdateRent(_VehicleID,-1);
                frm.ShowDialog();
                this.LoadVehicle(_VehicleID);
            }
        }
    }
}
