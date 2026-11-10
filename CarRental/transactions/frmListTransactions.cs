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
    public partial class frmListTransactions : Form
    {
        public frmListTransactions()
        {
            InitializeComponent();
        }
        DataTable _dtTransactions;
       
        async Task _LoadDataGridView()
        {
            _dtTransactions =await Transaction.GetAllTransactions();
            dgvTransactions.DataSource= _dtTransactions;
            if(dgvTransactions.Rows.Count > 0 )
            {
                dgvTransactions.Columns[0].HeaderText = "Transaction ID";
                dgvTransactions.Columns[0].Width =130;

                dgvTransactions.Columns[1].HeaderText = "Booking ID";
                dgvTransactions.Columns[1].Width =100;

                dgvTransactions.Columns[2].HeaderText = "Return ID";
                dgvTransactions.Columns[2].Width =100;

                dgvTransactions.Columns[3].HeaderText = "Payment Details";
                dgvTransactions.Columns[3].Width =200;

                dgvTransactions.Columns[4].HeaderText = "Paid Initial Total Due Amount";
                dgvTransactions.Columns[4].Width =157;

                dgvTransactions.Columns[5].HeaderText = "Actual Total Due Amount";
                dgvTransactions.Columns[5].Width =150;

                dgvTransactions.Columns[6].HeaderText = "Total Refunded Amount";
                dgvTransactions.Columns[6].Width =150;

                dgvTransactions.Columns[7].HeaderText = "Transaction Date";
                dgvTransactions.Columns[7].Width =100;

                dgvTransactions.Columns[8].HeaderText = "Updated Transaction Date";
                dgvTransactions.Columns[8].Width =150;

                dgvTransactions.Columns[9].HeaderText = "User ID";
                dgvTransactions.Columns[9].Width =100;
                dgvTransactions.Columns[9].Visible = false;

                dgvTransactions.Columns[10].HeaderText = "Created By";
                dgvTransactions.Columns[10].Width =100;

            }



        }
        
        void _CountRecords()
        {
            lblRecordsNumber.Text=dgvTransactions.Rows.Count.ToString();
        }

        private async void frmListTransactions_Load(object sender, EventArgs e)
        {
           await _LoadDataGridView();
            _CountRecords();
            cbFilter.SelectedIndex = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookingInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBookingInfo((int)dgvTransactions.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTransactionInfo((int)dgvTransactions.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            if(cbFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                _dtTransactions.DefaultView.RowFilter = "";
            }
            else
            {
                txtFilter.Visible=true;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void _ApplyFilters()
        {
            string Filter = cbFilter.Text.Replace(" ", "");
            if(txtFilter.Text=="")
            {
                _dtTransactions.DefaultView.RowFilter = "";
                return;
            }
            if(cbFilter.SelectedIndex==4)
            {
                _dtTransactions.DefaultView.RowFilter = string.Format("{0} Like '{1}%'", Filter, txtFilter.Text);
                return;
            }
            else
            {
                _dtTransactions.DefaultView.RowFilter=string.Format("{0} = {1}",Filter, txtFilter.Text);
                return;
            }

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 4)
                return;

            e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }
    }
}
