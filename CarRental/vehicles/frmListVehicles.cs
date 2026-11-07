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
    public partial class frmListVehicles : Form
    {
        DataTable _dtVehicles;
        public frmListVehicles()
        {
            InitializeComponent();
        }

        private void _LoadDataGridView()
        {
            _dtVehicles = Vehicle.GetAllVehicles();
            dgvVehicles.DataSource = _dtVehicles;
            if (dgvVehicles.Rows.Count > 0 )
            {
                dgvVehicles.Columns[0].HeaderText = "Vehicle ID";
                dgvVehicles.Columns[0].Width = 100;

                dgvVehicles.Columns[1].HeaderText = "Make";
                dgvVehicles.Columns[1].Width = 150;

                dgvVehicles.Columns[2].HeaderText = "Model";
                dgvVehicles.Columns[2].Width = 150;

                dgvVehicles.Columns[3].HeaderText = "Year";
                dgvVehicles.Columns[3].Width = 100;

                dgvVehicles.Columns[4].HeaderText = "Milage";
                dgvVehicles.Columns[4].Width = 100;

                dgvVehicles.Columns[5].HeaderText = "Fuel Type";
                dgvVehicles.Columns[5].Width = 150;

                dgvVehicles.Columns[6].HeaderText = "Category";
                dgvVehicles.Columns[6].Width = 150;

                dgvVehicles.Columns[7].HeaderText = "Plate Number";
                dgvVehicles.Columns[7].Width = 100;

                dgvVehicles.Columns[8].HeaderText = "Price Per Day";
                dgvVehicles.Columns[8].Width = 117;

                dgvVehicles.Columns[9].HeaderText = "Is Available";
                dgvVehicles.Columns[9].Width = 100;



            }
            else
            {
                cbFilter.Enabled= false;
                txtFilter.Enabled= false;
            }
        }
        private void _CountRecords()
        {
            lblRecordsNumber.Text = dgvVehicles.Rows.Count.ToString();
        }

        private void _ApplyFilters()
        {
            string Filter = cbFilter.Text.Replace(" ", "");
            if(Filter ==""||txtFilter.Text=="")
            {
                _dtVehicles.DefaultView.RowFilter = "";
                return;
            }

            if(cbFilter.SelectedIndex==1||cbFilter.SelectedIndex==4)
            {
                _dtVehicles.DefaultView.RowFilter = string.Format("{0} = {1}",Filter,txtFilter.Text);
                return;
            }
            if (cbFilter.SelectedIndex == 2 || cbFilter.SelectedIndex == 3||cbFilter.SelectedIndex==7)
            {
                _dtVehicles.DefaultView.RowFilter = string.Format("{0} Like '{1}%'", Filter, txtFilter.Text);
                return;
            }


        }

        private void _RefreashDataGridView()
        {
            _dtVehicles = Vehicle.GetAllVehicles();
            dgvVehicles.DataSource = _dtVehicles;
        }


        private void frmListVehicles_Load(object sender, EventArgs e)
        {
         
            _LoadDataGridView();
            _CountRecords();
            cbFilter.SelectedIndex = 0;
            cbIsAvailable.SelectedIndex = 0;
            cbFuelType.SelectedIndex = 0;
            cbVehicleCategory.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateVehicle();
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobalSettings.CurrentUser.Role == User.enRole.Admin)
            {
                Form frm = new frmAddUpdateVehicle((int)dgvVehicles.SelectedRows[0].Cells[0].Value);
                frm.ShowDialog();
                _RefreashDataGridView();
            }
            else
            {
                MessageBox.Show("User Cant Edit Vehicles", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
         
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobalSettings.CurrentUser.Role == User.enRole.Admin)
            {

                if (MessageBox.Show("Vehicle Will Be Deleted Are You Sure ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }
                if (Vehicle.GetVehicleByID((int)dgvVehicles.SelectedRows[0].Cells[0].Value).GetTotalRentTimes()>0)
                {
                    MessageBox.Show("Can't Delete This Vehicle Because it have rental history", "Delete Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
          


                    if (Vehicle.DeleteVehicle((int)dgvVehicles.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("Vehicle Deleted Succesfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Vehicle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("User Cant Delete Vehicles", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            _RefreashDataGridView();

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            if(cbFilter.SelectedIndex==5)
            {
                txtFilter.Visible = false;
                cbFuelType.Visible = true;
                cbVehicleCategory.Visible = false;
                cbIsAvailable.Visible = false;
                return;
            }

            if(cbFilter.SelectedIndex==6)
            {
                txtFilter.Visible = false;
                cbFuelType.Visible = false;
                cbVehicleCategory.Visible = true;
                cbIsAvailable.Visible = false;
                return;
            }

            if (cbFilter.SelectedIndex == 8)
            {
                txtFilter.Visible = false;
                cbFuelType.Visible = false;
                cbVehicleCategory.Visible = false;
                cbIsAvailable.Visible = true;
                return;
            }

            if (cbFilter.SelectedIndex==0)
            {
                txtFilter.Visible= false;
                cbFuelType.Visible= false;
                cbVehicleCategory.Visible= false;
                cbIsAvailable.Visible = false;
                _dtVehicles.DefaultView.RowFilter = "";
            }
            else
            {
                txtFilter.Visible = true;
                cbFuelType.Visible = false;
                cbVehicleCategory.Visible = false;
                cbIsAvailable.Visible = false;
            }
        }

        private void cbIsAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbIsAvailable.SelectedIndex==0)
            {
                _dtVehicles.DefaultView.RowFilter = "";
                return;
            }
            else
            {
                _dtVehicles.DefaultView.RowFilter = string.Format("{0} = {1}","IsAvailableForRent",cbIsAvailable.SelectedIndex==1?1:0);

            }

        }

        private void cbVehicleCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cbVehicleCategory.SelectedIndex==0)
            {
                _dtVehicles.DefaultView.RowFilter = "";
                return;
            }
            else
            {
                _dtVehicles.DefaultView.RowFilter = string.Format("VehicleCategory Like '{0}'",cbVehicleCategory.SelectedItem.ToString());

            }

        }

        private void cbFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFuelType.SelectedIndex == 0)
            {
                _dtVehicles.DefaultView.RowFilter = "";
                return;
            }
            else
            {
                _dtVehicles.DefaultView.RowFilter = string.Format($"FuelType like '{cbFuelType.SelectedItem.ToString()}'");

            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.SelectedIndex==1||cbFilter.SelectedIndex==4)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmVehicleInfo((int)dgvVehicles.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateMaintenance((int)dgvVehicles.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            
        }

        private void maintencaneHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaintenanceHistory((int)dgvVehicles.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

        private void vehicleRentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmVehicleRentHistory((int)dgvVehicles.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateVehicle();
            frm.ShowDialog();
            _RefreashDataGridView();
        }
    }
}
