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
    public partial class frmAddUpdateMaintenance : Form
    {
        private int _VehicleID = -1;

        public frmAddUpdateMaintenance()
        {
            InitializeComponent();
        }

        public frmAddUpdateMaintenance(int VehicleID)
        {
            _VehicleID=VehicleID;
            InitializeComponent();
        }

        public async void _SaveMaintenance()
        {
            Maintenance Maintenance=new Maintenance();
            Maintenance.VehicleID = ctrlVehicleInfo1.VehicleID;
            Maintenance.Description = txtDescription.Text;
            Maintenance.MaintenanceDate = DateOnly.FromDateTime(DateTime.Now);
            Maintenance.Cost=Convert.ToDecimal(txtCost.Text);
            
            if(await Maintenance.Save())
            {
                lblMaintenanceID.Text = Maintenance.MaintenanceID.ToString();
                lblDate.Text = Maintenance.MaintenanceDate.ToShortDateString();
                btnSave.Enabled = false;
                MessageBox.Show("Maintenance Saved Successufully", "Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error : Error While Saving Maintenance Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           





        }

       

        public void GetVehicleID(int VehicleID)
        {
            if (VehicleID > 0)
            {                
                _VehicleID = VehicleID;
                ctrlVehicleInfo1.LoadVehicle(VehicleID);
            }
            else
            {
                MessageBox.Show("Please Select Vehicle First", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtDescription.Text))
            {
                e.Cancel= true;
                ep.SetError(txtDescription, "Enter Description");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtDescription, "");

            }
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCost.Text))
            {
                e.Cancel = true;
                ep.SetError(txtCost, "Enter Cost");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtCost, "");

            }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }


     
        private void frmAddUpdateMaintenance_Load(object sender, EventArgs e)
        {
            if(_VehicleID>0)
            {
                btnSelect.Visible= false;
                ctrlVehicleInfo1.LoadVehicle(_VehicleID);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ctrlVehicleInfo1.VehicleID <= 0)
            {
                MessageBox.Show("Select Vehicle First", "Select Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.ValidateChildren())
                _SaveMaintenance();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmSelectVehicle frm = new frmSelectVehicle();
            frm.IDBack += GetVehicleID;
            frm.ShowDialog();
        }
    }
}
