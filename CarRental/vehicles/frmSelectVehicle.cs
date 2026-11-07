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
    public partial class frmSelectVehicle : Form
    {
        public delegate void DelGetVehicleID(int ID);
        public event DelGetVehicleID IDBack;
        public frmSelectVehicle()
        {
            InitializeComponent();
        }
        private int _VehicleID = -1;

      
        private void _LoadDataGridView()
        {
            dgvAvailableVehicles.DataSource = Vehicle.GetAllAvailableVehicles();
            if (dgvAvailableVehicles.Rows.Count > 0)
            {
                dgvAvailableVehicles.Columns[9].HeaderText="Is Available";
                dgvAvailableVehicles.Columns[9].Width = 137;


            }
            else
            {
                MessageBox.Show("No Available Vehicles Right Now", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        private void _Select()
        {
            if (_VehicleID > 0)
            {
                IDBack?.Invoke(_VehicleID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Select Vehicle First", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        

        private void buttonbtnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelectVehicle_Load(object sender, EventArgs e)
        {
            _LoadDataGridView();
            if (dgvAvailableVehicles.Rows.Count > 0)
            {
                _VehicleID = (int)dgvAvailableVehicles.SelectedRows[0].Cells[0].Value;
                dgvAvailableVehicles.SelectedRows[0].Selected = true;
                ctrlVehicleInfo1.LoadVehicle(_VehicleID);
            }
        }

        private void dgvAvailableVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _VehicleID = (int)dgvAvailableVehicles.SelectedRows[0].Cells[0].Value;
            if (_VehicleID > 0)
                ctrlVehicleInfo1.LoadVehicle(_VehicleID);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _Select();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Select();
        }
    }
}
