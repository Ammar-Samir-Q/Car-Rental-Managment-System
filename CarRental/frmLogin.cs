using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace CarRental
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool ReadUserNameAndPassowrd(ref string userName,ref string password)
        {
            try
            {
                string Path = Directory.GetCurrentDirectory();
                Path += "\\LoginData.txt";
                if (!File.Exists(Path))
                {
                    return false;
                }

                using (StreamReader reader = new StreamReader(Path))
                {
                    string Line = "";
                    while ((Line = reader.ReadLine()) != null)
                    {

                        string[] Result = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                        userName = Result[0];
                        password = Result[1];
                        return true;
                    }


                }
            }
            catch(Exception ex)
            {
            }
            return false;
        }

        private void _LoadUserData()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            cbRememberMe.Checked = false;
            _HandelNullLogin();
            string Username="", Password = "";
            if(clsGlobalSettings.ReadUserInfoFromReg(ref Username,ref Password))
            {
                txtUserName.Text = Username;
                txtPassword.Text=Password;
                cbRememberMe.Checked = true;
                btnLogin.Focus();
            }
            else
            {
                txtUserName.Focus();
            }
        }

        private void _HandelNullLogin()
        {
            if(string.IsNullOrEmpty(txtUserName.Text)&&string.IsNullOrEmpty(txtPassword.Text))
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                btnLogin.Enabled = false;
                cbRememberMe.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
                cbRememberMe.Enabled = true;
            }

        }

        [Obsolete]
        private void _SaveUserData(string Username,string Password)
        {
            try
            {
                string Path = Directory.GetCurrentDirectory();
                Path += "\\LoginData.txt";

           
                using (StreamWriter writer = new StreamWriter(Path))
                {
                    string LineToSave = Username + "#//#" + Password;
                    writer.WriteLine(LineToSave);
                    return;
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString());}

        }

        private void _HandelSavingData()
        {
            if (cbRememberMe.Checked)
            {
                if (!clsGlobalSettings.SaveUserInfoToReg(txtUserName.Text, txtPassword.Text))
                {
                    MessageBox.Show("Faild To Save Login Data", "Reg Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                clsGlobalSettings.SaveUserInfoToReg("", "");
            }

        }

        private async void _Login()
        {
            User User =await User.GetUserByUsernameAndPasswordAsync(txtUserName.Text, txtPassword.Text);
            if (User==null)
            {
                MessageBox.Show("Wrong Username Or Password", " User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _HandelSavingData();
            clsGlobalSettings.CurrentUser = User;
            Form frm = new MainMenu(this);
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            _Login();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _HandelBackColor()
        {
            panel1.BackColor = Properties.Settings.Default.MainColor;
            panel2.BackColor = Properties.Settings.Default.MainColor;
            btnClose.BackColor = panel1.BackColor;
            btnLogin.BackColor = panel2.BackColor;
            btnDatabaseStatus.BackColor = panel1.BackColor;
            btnEnterAsCustomer.BackColor = panel2.BackColor;

            if (panel1.BackColor == Color.White)
            {
                lblTitle.ForeColor = Color.Black;
                lblSubTitle.ForeColor = Color.Black;
                lblVersion.ForeColor = Color.Black;
                btnLogin.ForeColor = Color.Black;
                btnClose.ForeColor = Color.Black;
                btnDatabaseStatus.ForeColor = Color.Black;
                btnEnterAsCustomer.ForeColor = Color.Black;
            }

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            _HandelBackColor();
            if(!DatabaseService.TestConnection())
            {
                btnLogin.Visible = false;
                btnEnterAsCustomer.Visible = false;
                txtPassword.Enabled = false;
                txtUserName.Enabled = false;
                return;
            }
            else
            {
                txtPassword.Enabled = true;
                txtUserName.Enabled = true;
                btnLogin.Visible = true;
                btnEnterAsCustomer.Visible = true;
            }

            _LoadUserData();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            _HandelNullLogin();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            _HandelNullLogin();
        }
        


        private async void btnEnterAsCustomer_Click(object sender, EventArgs e)
        {
            clsGlobalSettings.CurrentUser =await User.GetUserByIDAsync(13);
            Form frm = new MainMenu();
            this.Hide();
            frm.ShowDialog();
            Application.Exit();
        }
    }
}
