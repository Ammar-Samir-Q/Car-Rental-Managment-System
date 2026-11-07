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
    public partial class frmMaintenanceHistory : Form
    {
        int _VehicleID = -1;
        public frmMaintenanceHistory(int VehicleID)
        {
            InitializeComponent();
            _VehicleID = VehicleID;
        }


        private void _LoadDataGridView()
        {
            dgvMaintenanceHistory.DataSource=Maintenance.GetAllMaintenancesForVehicle(_VehicleID);
            if(dgvMaintenanceHistory.Rows.Count > 0)
            {
                dgvMaintenanceHistory.Columns[0].HeaderText = "Maintenance ID";
                dgvMaintenanceHistory.Columns[0].Width = 100;

                dgvMaintenanceHistory.Columns[1].HeaderText = "Vehicle ID";
                dgvMaintenanceHistory.Columns[1].Width = 100;

                dgvMaintenanceHistory.Columns[2].HeaderText = "Description";
                dgvMaintenanceHistory.Columns[2].Width = 450;

                dgvMaintenanceHistory.Columns[3].HeaderText = "Date";
                dgvMaintenanceHistory.Columns[3].Width = 200;

                dgvMaintenanceHistory.Columns[4].HeaderText = "Cost";
                dgvMaintenanceHistory.Columns[4].Width = 200;

            }
        }
        private void frmMaintenanceHistory_Load(object sender, EventArgs e)
        {
            ctrlVehicleInfo1.LoadVehicle(_VehicleID);
            _LoadDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaintenanceInfo((int)dgvMaintenanceHistory.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
