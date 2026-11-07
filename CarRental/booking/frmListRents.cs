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
    public partial class frmListRents : Form
    {
        public frmListRents()
        {
            InitializeComponent();
        }

        private DataTable _dtBookingRentals;

        private void _LoadDataGridView()
        {
            _dtBookingRentals=Booking.GetAllRents();
            dgvRents.DataSource = _dtBookingRentals;
            if(dgvRents.Rows.Count > 0 )
            {
                dgvRents.Columns[0].HeaderText = "Booking ID";
                dgvRents.Columns[0].Width = 100;

                dgvRents.Columns[1].HeaderText = "Customer ID";
                dgvRents.Columns[1].Width = 100;
                dgvRents.Columns[1].Visible = false;

                dgvRents.Columns[2].HeaderText = "Fullname";
                dgvRents.Columns[2].Width = 247;

                dgvRents.Columns[3].HeaderText = "Vehicle ID";
                dgvRents.Columns[3].Width = 100;
                dgvRents.Columns[3].Visible = false;

                dgvRents.Columns[4].HeaderText = "Model";
                dgvRents.Columns[4].Width = 120;

                dgvRents.Columns[5].HeaderText = "Start Date";
                dgvRents.Columns[5].Width = 100;

                dgvRents.Columns[6].HeaderText = "End Date";
                dgvRents.Columns[6].Width = 100;

                dgvRents.Columns[7].HeaderText = "Pickup Location";
                dgvRents.Columns[7].Width = 150;

                dgvRents.Columns[8].HeaderText = "DropOff Location";
                dgvRents.Columns[8].Width = 150;

                dgvRents.Columns[9].HeaderText = "Price Per Day";
                dgvRents.Columns[9].Width = 100;


                dgvRents.Columns[10].HeaderText = "Initial Check Notes";
                dgvRents.Columns[10].Width = 100;
                dgvRents.Columns[10].Visible = false;

                dgvRents.Columns[11].HeaderText = "Created By User ID";
                dgvRents.Columns[11].Width = 100;
                dgvRents.Columns[11].Visible = false;


                dgvRents.Columns[12].HeaderText = "Created By";
                dgvRents.Columns[12].Width = 150;
                
            }

        }

        private void _RefreashDataGridView()
        {
            _dtBookingRentals = Booking.GetAllRents();
            dgvRents.DataSource = _dtBookingRentals;
            _CountRecords();
        }

        private void _CountRecords()
        {
            lblRecordsNumber.Text = dgvRents.Rows.Count.ToString();
        }

        private void frmListRents_Load(object sender, EventArgs e)
        {
            _LoadDataGridView();
            _CountRecords();
            cbFilter.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateRent();
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateRent((int)dgvRents.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBookingInfo((int)dgvRents.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

        private void setReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturn((int)dgvRents.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            if (cbFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                _dtBookingRentals.DefaultView.RowFilter = "";
                return;
            }
            else
            {
                txtFilter.Visible = true;
                return;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string Filter=cbFilter.Text.Replace(" ","");
            if(txtFilter.Text=="")
            {
                _dtBookingRentals.DefaultView.RowFilter = "";
                return;
            }

            if(cbFilter.SelectedIndex==1)
            {
                _dtBookingRentals.DefaultView.RowFilter = string.Format("{0} = {1}", Filter, txtFilter.Text);
                return;
            }
            else
            {
                _dtBookingRentals.DefaultView.RowFilter = string.Format("{0} Like '{1}%'", Filter, txtFilter.Text);

            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.SelectedIndex==1)
                e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);  
        }

        [Obsolete]
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure To Delete This Booking ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                if (Booking.DeleteRent((int)dgvRents.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("Booking Deleted Successfully", "Deletd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreashDataGridView();
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Booking", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Booking.IsBookingReturned((int)dgvRents.SelectedRows[0].Cells[0].Value))
            {
                returnInfoToolStripMenuItem.Enabled = true;
                setReturnToolStripMenuItem.Enabled=false;
            }
            else
            {
                returnInfoToolStripMenuItem.Enabled = false;
                setReturnToolStripMenuItem.Enabled = true;
            }
        }

        private void returnInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturnInfo(Transaction.GetTransactionByBookingID((int)dgvRents.SelectedRows[0].Cells[0].Value).ReturnID);
            frm.ShowDialog();
        }
    }
}
