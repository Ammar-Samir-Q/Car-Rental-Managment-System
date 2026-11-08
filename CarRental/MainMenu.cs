using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CarRental
{
    public partial class MainMenu : Form
    {
        private Form _frmLogin;
        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(object Form)
        {
            _frmLogin = (frmLogin)Form;
            InitializeComponent();
        }


        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void mainteanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListMaintenance();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalClass.CurrentUser.UserID > 0)
            {
                Form frm = new frmUserInfo(GlobalClass.CurrentUser.UserID);
                frm.ShowDialog();
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListCustomers();
            frm.ShowDialog();
        }

        private void allPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void addRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateRent();
            frm.ShowDialog();
        }

        private void manageRentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListRents();
            frm.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturn();
            frm.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListTransactions();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //_frmLogin.ShowDialog();
            //this.Close();
            Application.Restart();

        }



        private void _HandelBackColor()
        {
            this.BackColor = Properties.Settings.Default.MainColor;
            if (this.BackColor == Color.White)
            {
                lblUsername.ForeColor = Color.Black;
                lblUsernameTitle.ForeColor = Color.Black;
                lblTitle.ForeColor = Color.Black;
                lblTitleTotalBookings.ForeColor = Color.Black;
                lblTotalBookings.ForeColor = Color.Black;
                lblTotalCustomers.ForeColor = Color.Black;
                lblTitleTotalCustomers.ForeColor = Color.Black;
                lblTitleTotalRents.ForeColor = Color.Black;
                lblTotalRents.ForeColor = Color.Black;
                lblTotalVehicles.ForeColor = Color.Black;
                lblTitleTotalVehicles.ForeColor = Color.Black;

            }
        }
        private void _LoadDashBoard()
        {
            lblTotalVehicles.Text = Vehicle.GetTotalVehicles().ToString();
            lblTotalCustomers.Text = Customer.GetTotalCustomers().ToString();
            lblTotalRents.Text = Booking.GetTotalCompletedRents().ToString();
            lblTotalBookings.Text = Booking.GetTotalBookings().ToString();
        }
        private void _HandelRoleMenu()
        {
            if (GlobalClass.CurrentUser == null)
            {
                MessageBox.Show("Error While Loading UserData", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
             if(GlobalClass.CurrentUser.Role != User.enRole.Customer)
            {
                lblUsername.Text = GlobalClass.CurrentUser.Username;
                if (GlobalClass.CurrentUser.PersonInfo.ImagePath != "")
                {
                    pbUserImage.ImageLocation = GlobalClass.CurrentUser.PersonInfo.ImagePath;
                }

            }
            switch (GlobalClass.CurrentUser.Role)
            {
                case User.enRole.User:
                    staticsToolStripMenuItem.Enabled = false;
                    systemToolStripMenuItem.Enabled = false;
                    manageRentsToolStripMenuItem.Enabled = false;
                    allPeopleToolStripMenuItem.Enabled = false;
                    lblRole.Text = "User";
                    break;
                case User.enRole.Customer:
                    ايجارToolStripMenuItem.Visible = false;
                    transactionsToolStripMenuItem.Visible = false;
                    VehiclesToolMenuStrip.Enabled = true;
                    manageVehiclesToolStripMenuItem.Visible = false;
                    showVehiclesToolStripMenuItem.Enabled = true;
                    PeopleToolStripMenuItem.Visible = false;
                    mainteanceToolStripMenuItem.Visible = false;
                    staticsToolStripMenuItem.Visible = false;
                    settingsToolStripMenuItem.Visible = false;


                    if (Properties.Settings.Default.Language == "en")
                        lblUsernameTitle.Text = "Welcome Customer";
                    else
                        lblUsernameTitle.Text = "مرحبا";

                    lblUsername.Visible = false;
                    lblRole.Visible = false;
                    break;

            }


        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            _HandelBackColor();
            _LoadDashBoard();
            _HandelRoleMenu();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(GlobalClass.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSettings();
            frm.ShowDialog();
        }

        private void manageVehiiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListVehicles();
            frm.ShowDialog();
        }

        private void showVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowVehicles();
            frm.ShowDialog();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frm = new frmReports();
            //frm.ShowDialog();
        }
    }
}
