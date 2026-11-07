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
    public partial class frmListCustomers : Form
    {
        public frmListCustomers()
        {
            InitializeComponent();
        }

        private DataTable _dtCustomers;


        private void _LoadDataGridView()
        {
            _dtCustomers=Customer.GetAllCustomers();
            dgvCustomers.DataSource=_dtCustomers;
            if(dgvCustomers.Rows.Count>0 )
            {
                dgvCustomers.Columns[0].HeaderText = "Customer ID";
                dgvCustomers.Columns[0].Width = 100;

                dgvCustomers.Columns[1].HeaderText = "Person ID";
                dgvCustomers.Columns[1].Width = 100;

                dgvCustomers.Columns[2].HeaderText = "Fullname";
                dgvCustomers.Columns[2].Width = 300;

                dgvCustomers.Columns[3].HeaderText = "Gender";
                dgvCustomers.Columns[3].Width = 160;

                dgvCustomers.Columns[4].HeaderText = "Driver License";
                dgvCustomers.Columns[4].Width = 156;

                dgvCustomers.Columns[5].HeaderText = "Creation Date";
                dgvCustomers.Columns[5].Width = 200;

                dgvCustomers.Columns[6].HeaderText = "Created By";
                dgvCustomers.Columns[6].Width = 200;

            }
            else
            {
                cbFilter.Enabled=false;
            }
        }
       

        private void _RefreashDataGridView()
        {
            _dtCustomers = Customer.GetAllCustomers();
            dgvCustomers.DataSource = _dtCustomers;
        }
        private void _CountRecnords()
        {
            lblRecordsNumber.Text=dgvCustomers.Rows.Count.ToString();
        }
        
        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            _LoadDataGridView();
            _CountRecnords();
            cbFilter.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddCustomer((int)dgvCustomers.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddCustomer();
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCustomerInfo((int)dgvCustomers.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }

        private void _ApplyFilters()
        {
            string Filter = cbFilter.Text.Replace(" ","");
            if(txtFilter.Text=="")
            {
                _dtCustomers.DefaultView.RowFilter = "";
                return;
            }

            if(cbFilter.SelectedIndex==1||cbFilter.SelectedIndex == 2)
            {
                _dtCustomers.DefaultView.RowFilter = string.Format("{0} = {1}", Filter, txtFilter.Text);
                return;
            }
            else
            {
                _dtCustomers.DefaultView.RowFilter = string.Format("{0} Like '{1}%'", Filter, txtFilter.Text);
                return;
            }




        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            if(cbFilter.SelectedIndex==0)
            {
                _dtCustomers.DefaultView.RowFilter = "";
                txtFilter.Visible= false;
                cbGender.Visible= false;
                return;
            }
            else
            {
                txtFilter.Visible=true;
                cbGender.Visible = false;

            }
            if(cbFilter.SelectedIndex==4)
            {
                _dtCustomers.DefaultView.RowFilter = "";
                txtFilter.Visible = false;
                cbGender.Visible = true;
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGender.SelectedIndex==0)
            {
                _dtCustomers.DefaultView.RowFilter = "";
                return;
            }
            else
            _dtCustomers.DefaultView.RowFilter = string.Format("Gender Like '{0}%'",cbGender.Text);

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.SelectedIndex==1||cbFilter.SelectedIndex==2)
            {
                e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
            }
        }

        private void showRentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm =new frmCustomerRentHistory((int)dgvCustomers.Rows[0].Cells[0].Value);
            frm.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddCustomer();
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure To Delete This Customer ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (Customer.DeleteCustomer((int)dgvCustomers.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("Customer Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    _RefreashDataGridView();
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Customer (Check If There Is Data Conncted To It)", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
    }
}
