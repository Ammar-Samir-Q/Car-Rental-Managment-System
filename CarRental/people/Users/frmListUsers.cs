using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.BLL;

namespace CarRental
{
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        public DataTable _dtUsers;

        private async Task _LoadDataGridView()
        {
            _dtUsers=await User.GetAllUsers();
            dgvUsers.DataSource= _dtUsers;
            if(dgvUsers.Rows.Count >0 )
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 130;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 130;

                dgvUsers.Columns[2].HeaderText = "Fullname";
                dgvUsers.Columns[2].Width = 300;

                dgvUsers.Columns[3].HeaderText = "Username";
                dgvUsers.Columns[3].Width = 200;

                dgvUsers.Columns[4].HeaderText = "Role";
                dgvUsers.Columns[4].Width = 150;

                dgvUsers.Columns[5].HeaderText = "Is Active";
                dgvUsers.Columns[5].Width = 105;


                dgvUsers.Columns[6].HeaderText = "Creation Date";
                dgvUsers.Columns[6].Width = 200;


            }
        }

        private async void _RefreashDataGridView()
        {
            _dtUsers =await User.GetAllUsers();
            dgvUsers.DataSource = _dtUsers;
            _CountRecords();
        }

        private void _CountRecords()
        {
            lblRecordsNumber.Text=dgvUsers.Rows.Count.ToString();
        }

        private void _ApplyFilters()
        {
            string Filter =cbFilter.Text.Replace(" ","");
            if(cbFilter.SelectedIndex==0||string.IsNullOrEmpty(txtFilter.Text))
            {
                _dtUsers.DefaultView.RowFilter = "";
                return;
            }

            if(cbFilter.SelectedIndex==3)
            {
                _dtUsers.DefaultView.RowFilter = string.Format("{0} Like '{1}%'",Filter,txtFilter.Text);
                return;
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = string.Format("{0} = {1}", Filter, txtFilter.Text);
            }



        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            if (cbFilter.SelectedIndex==0)
            {
                txtFilter.Visible=false;
                cbActive.Visible=false;
                cbRole.Visible=false;
                return;
            }
            if(cbFilter.SelectedIndex==4)
            {
                txtFilter.Visible = false;
                cbActive.Visible = true;
                cbRole.Visible = false;
                return;
            }
            if( cbFilter.SelectedIndex==5)
            {
                txtFilter.Visible = false;
                cbActive.Visible = false;
                cbRole.Visible = true;
                return;


            }
            else
            {
                txtFilter.Visible = true;


            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRole.SelectedIndex==0)
            {
                _dtUsers.DefaultView.RowFilter = "";
                return;
            }
            if (cbRole.SelectedIndex == 1)
            {
                _dtUsers.DefaultView.RowFilter = string.Format("{0} Like 'Admin'", cbFilter.Text);
                return;
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = string.Format("{0} Like 'User'", cbFilter.Text);
                return;
            }
        }

        private void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbActive.SelectedIndex == 0)
            {
                _dtUsers.DefaultView.RowFilter = "";
                return;
            }
            if (cbActive.SelectedIndex == 1)
            {
                _dtUsers.DefaultView.RowFilter = string.Format("{0} = 1", "IsActive");
                return;
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = string.Format("{0} = 0", "IsActive");
                return;
            }
        }

        private async void frmListUsers_Load(object sender, EventArgs e)
        {
             await _LoadDataGridView();
            _CountRecords();
            cbFilter.SelectedIndex= 0;
            cbActive.SelectedIndex= 0;
            cbRole.SelectedIndex= 0;
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 3)
                return;

            e.Handled=!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm=new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(GlobalClass.CurrentUser.Role==User.enRole.Admin)
            {
                Form frm = new frmAddUpdateUser((int)dgvUsers.SelectedRows[0].Cells[0].Value);
                frm.ShowDialog();
                _RefreashDataGridView();
            }
            else
            {
                MessageBox.Show("User Cant Edit Users ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalClass.CurrentUser.Role == User.enRole.Admin)
            {
                if (MessageBox.Show("Are You Sure To Delete This User ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }

                if (await User.DeleteUser((int)dgvUsers.SelectedRows[0].Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreashDataGridView();
                }
                else
                    MessageBox.Show("Faild To Delete This User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("User Cant Delete Users ", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo((int)dgvUsers.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            _RefreashDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm=new frmAddUpdateUser();
            frm.ShowDialog();
            _RefreashDataGridView();
        }
    }
}
