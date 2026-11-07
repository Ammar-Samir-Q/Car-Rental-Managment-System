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
    public partial class frmVehicleRentHistory : Form
    {
        private int _VehicleID = -1;
        public frmVehicleRentHistory(int VehicleID)
        {
            _VehicleID = VehicleID;
            InitializeComponent();
        }

        private void frmVehicleRentHistory_Load(object sender, EventArgs e)
        {
            if (_VehicleID == -1)
                return;

            ctrlVehicleInfo1.LoadVehicle(_VehicleID);
            dgvRentHistory.DataSource = Vehicle.GetRentHistory(_VehicleID);
            if(dgvRentHistory.Rows.Count > 0 )
            {
                dgvRentHistory.Columns[0].HeaderText = "Booking ID";
                dgvRentHistory.Columns[0].Width = 100;

                dgvRentHistory.Columns[1].HeaderText = "Fullname";
                dgvRentHistory.Columns[1].Width = 325;

                dgvRentHistory.Columns[2].HeaderText = "Rental Start Date";
                dgvRentHistory.Columns[2].Width = 200;

                dgvRentHistory.Columns[3].HeaderText = "Rental End Date";
                dgvRentHistory.Columns[3].Width = 200;

                dgvRentHistory.Columns[4].HeaderText = "Created By";
                dgvRentHistory.Columns[4].Width = 200;

            }
            lblRecordsCount.Text = dgvRentHistory.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBookingInfo((int)dgvRentHistory.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

      
    }
}
