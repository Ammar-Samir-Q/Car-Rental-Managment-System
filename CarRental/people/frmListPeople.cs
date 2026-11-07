using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.BLL;

namespace CarRental
{
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }
        private DataTable _dtPeople;

        private void _CountRecords()
        {
            lblRecordsNumber.Text=dgvPeople.Rows.Count.ToString();
        }
       
        private void _FillComboBox()
        {
            cbFilter.Items.Add("None");
            cbFilter.Items.Add("Person ID");
            cbFilter.Items.Add("National No");
            cbFilter.Items.Add("Full Name");
            cbFilter.Items.Add("Gender");
            cbFilter.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
        }
        
        private void _ApplyFilters()
        {
            string Filter = cbFilter.Text.Replace(" ", "");

            if(Filter == ""||txtFilter.Text=="")
            {
                _dtPeople.DefaultView.RowFilter = "";
                return;
            }

            if(cbFilter.SelectedIndex==1)
            {
                _dtPeople.DefaultView.RowFilter=string.Format("{0}={1}",Filter,txtFilter.Text);
                return;
            }
            if(cbFilter.SelectedIndex==2|| cbFilter.SelectedIndex==3)
            {
                _dtPeople.DefaultView.RowFilter = string.Format("{0} Like '{1}%'", Filter, txtFilter.Text);
                return;
            }
        }

        private void _LoadDataGridView()
        {
            _dtPeople =  Person.GetAllPeople();
            dgvPeople.DataSource= _dtPeople;
            if(dgvPeople.Rows.Count > 0 )
            {
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 100;

                dgvPeople.Columns[1].HeaderText = "National Number";
                dgvPeople.Columns[1].Width = 116;

                dgvPeople.Columns[2].HeaderText = "Fullname";
                dgvPeople.Columns[2].Width = 200;

                dgvPeople.Columns[3].HeaderText = "DateOfBirth";
                dgvPeople.Columns[3].Width = 200;

                dgvPeople.Columns[4].HeaderText = "Gender";
                dgvPeople.Columns[4].Width = 100;

                dgvPeople.Columns[5].HeaderText = "Phone";
                dgvPeople.Columns[5].Width = 100;

                dgvPeople.Columns[6].HeaderText = "Email";
                dgvPeople.Columns[6].Width = 200;

                dgvPeople.Columns[7].HeaderText = "Address";
                dgvPeople.Columns[7].Width = 200;




            }
        }
        private async Task _RefreashDataGridView()
        {
            _dtPeople =  Person.GetAllPeople();
            dgvPeople.DataSource= _dtPeople;
            _CountRecords();
        }

        private async void frmListPeople_Load(object sender, EventArgs e)
        {
             _LoadDataGridView();
            _FillComboBox();
            _CountRecords();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm=new frmAddUpdatePerson();
            frm.ShowDialog();
            await _RefreashDataGridView();
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm=new frmAddUpdatePerson((int)dgvPeople.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            await _RefreashDataGridView();
        }

        private  void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            if(cbFilter.SelectedIndex == 0)
            {
                txtFilter.Visible = false;
                cbGender.Visible = false;
                _dtPeople.DefaultView.RowFilter = "";
                return;
            }
            else
            {
                txtFilter.Visible = true;
            }
        
            if(cbFilter.SelectedIndex==4)
            {
                txtFilter.Visible = false;
                cbGender.Visible = true;
            }
            else
            {
                cbGender.Visible = false;
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGender.SelectedIndex == 0)
            {
                _dtPeople.DefaultView.RowFilter = "";
                return;
            }

            if (cbFilter.SelectedIndex == 4)
            {
                _dtPeople.DefaultView.RowFilter = string.Format("{0} Like '{1}'", "Gender", (cbGender.SelectedIndex == 1 ? "Male": "Female").ToString());
            }
            _CountRecords();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
            _CountRecords();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.SelectedIndex==1)
            {
                e.Handled = !char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);

            }
        }

        private async void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersonInfo((int)dgvPeople.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            await _RefreashDataGridView();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Person With Person ID : " + dgvPeople.SelectedRows[0].Cells[0].Value +
                " Will Be Deleted Are You Sure ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Person.DeletePerson((int)dgvPeople.SelectedRows[0].Cells[0].Value)) 
                {
                    MessageBox.Show("Person Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Faild To Delete This Person (Cheack If There is Data Connected To it..)", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            await _RefreashDataGridView();
        }

        private async void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddCustomer((int)dgvPeople.SelectedRows[0].Cells[0].Value,frmAddCustomer.enMode.Convert);
            frm.ShowDialog();
            await _RefreashDataGridView();
        }

        private async void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser((int)dgvPeople.SelectedRows[0].Cells[0].Value, frmAddUpdateUser.enMode.Convert);
            frm.ShowDialog();
            await _RefreashDataGridView();
        }

     
    }
}
