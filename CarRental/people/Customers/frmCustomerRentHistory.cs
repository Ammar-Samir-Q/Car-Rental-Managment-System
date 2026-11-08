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
    public partial class frmCustomerRentHistory : Form
    {
        private int _CustomerID = -1;
        public frmCustomerRentHistory(int CustomerID)
        {
            _CustomerID=CustomerID;
            InitializeComponent();
        }

        private async void frmCustomerRentHistory_Load(object sender, EventArgs e)
        {
            if (_CustomerID == -1)
                return;
            var customer = await Customer.GetCustomerByID(_CustomerID);
            if (customer == null) return;
            ctrlPersonInfo1.LoadPerson(customer.PersonID);
            dgvRentHistory.DataSource = Customer.GetCustomerHistory(_CustomerID);
            if( dgvRentHistory.Rows.Count > 0  )
            {
                dgvRentHistory.Columns[0].HeaderText = "Booking ID";
                dgvRentHistory.Columns[0].Width = 100;

                dgvRentHistory.Columns[1].HeaderText = "Model Name";
                dgvRentHistory.Columns[1].Width = 150;

                dgvRentHistory.Columns[2].HeaderText = "Rental Start Date";
                dgvRentHistory.Columns[2].Width = 200;

                dgvRentHistory.Columns[3].HeaderText = "Rental End Date";
                dgvRentHistory.Columns[3].Width = 200;

                dgvRentHistory.Columns[4].HeaderText = "Price Per Day";
                dgvRentHistory.Columns[4].Width = 120;

                dgvRentHistory.Columns[5].HeaderText = "Created by";
                dgvRentHistory.Columns[5].Width = 150;

               
            }
            lblRecords.Text=dgvRentHistory.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm =new frmBookingInfo((int)dgvRentHistory.Rows[0].Cells[0].Value);
            frm.ShowDialog();
            
        }

 
    }
}
