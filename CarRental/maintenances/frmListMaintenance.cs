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
    public partial class frmListMaintenance : Form
    {
        public frmListMaintenance()
        {
            InitializeComponent();
        }

        private DataTable _dtMaintenances;

        private async Task _LoadDataGridView()
        {
            _dtMaintenances =await  Maintenance.GetAllMaintenances();
            dgvMaintenances.DataSource = _dtMaintenances;
            if(dgvMaintenances.Rows.Count > 0 )
            {
                dgvMaintenances.Columns[0].HeaderText = "Maintenance ID";
                dgvMaintenances.Columns[0].Width = 100;

                dgvMaintenances.Columns[1].HeaderText = "Vehicle ID";
                dgvMaintenances.Columns[1].Width = 100;

                dgvMaintenances.Columns[2].HeaderText = "Vehicle Model";
                dgvMaintenances.Columns[2].Width = 200;

                dgvMaintenances.Columns[3].HeaderText = "Description";
                dgvMaintenances.Columns[3].Width = 517;

                dgvMaintenances.Columns[4].HeaderText = "Maintenance Date";
                dgvMaintenances.Columns[4].Width = 100;

                dgvMaintenances.Columns[5].HeaderText = "Cost";
                dgvMaintenances.Columns[5].Width = 200;


            }
        }

        private async Task _RefreashDataGridView()
        {
            _dtMaintenances =await Maintenance.GetAllMaintenances();
            dgvMaintenances.DataSource = _dtMaintenances;
        }
        private void _CountRecords()
        {
            lblRecordsNumber.Text = dgvMaintenances.Rows.Count.ToString();
        }

        private async void frmListMaintenance_Load(object sender, EventArgs e)
        {
            await _LoadDataGridView();
            _CountRecords();
            cbFilter.SelectedIndex = 0;
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaintenanceInfo((int)dgvMaintenances.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==DialogResult.OK)
            {
                if (await Maintenance.DeleteMaintenance((int)dgvMaintenances.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successufully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreashDataGridView();
                }
                else
                    MessageBox.Show("Faild To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _ApplyFilters()
        {
            string filter = cbFilter.Text.Replace(" ", "");
            if(txtFilter.Text=="")
            {
                _dtMaintenances.DefaultView.RowFilter = "";
                return;
            }

            if(cbFilter.SelectedIndex==1||cbFilter.SelectedIndex == 2)
            {
                _dtMaintenances.DefaultView.RowFilter = string.Format("{0} = {1}",filter,txtFilter.Text);
                return;
            }
            else
            {
                _dtMaintenances.DefaultView.RowFilter=string.Format("{0} Like '{1}%'",filter,txtFilter.Text);
                return;
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            if(cbFilter.SelectedIndex==0)
            {
                txtFilter.Visible=false;
                _dtMaintenances.DefaultView.RowFilter = "";
                return;
            }
            else
            {
                txtFilter.Visible = true;
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.SelectedIndex==1||cbFilter.SelectedIndex==2)
            {
                e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            Form frm= new frmAddUpdateMaintenance();
            frm.ShowDialog();
            await _RefreashDataGridView();
        }
    }
}
