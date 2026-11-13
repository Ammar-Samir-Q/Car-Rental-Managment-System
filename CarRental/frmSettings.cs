using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            //Set Language checkbox
            if(Properties.Settings.Default.Language=="en")
                cbLanguage.SelectedIndex= 0;
            else
                cbLanguage.SelectedIndex = 1;

          if(Properties.Settings.Default.MainColor==pbblue.BackColor)
            {
                rbBlue.Checked = true;
            }
          if(Properties.Settings.Default.MainColor == pbCyan.BackColor)
            {
                rbCyan.Checked = true;
            }
          if(Properties.Settings.Default.MainColor == pbGray.BackColor)
            {
                rbGray.Checked = true;
            }
          if(Properties.Settings.Default.MainColor == pbBlack.BackColor)
            {
                rbBlack.Checked = true;
            }
          if(Properties.Settings.Default.MainColor == pbWhite.BackColor)
            {
                rbWhite.Checked = true;
            }
          if(Properties.Settings.Default.MainColor == pbDimGray.BackColor)
            {
                rbDarkgray.Checked = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //English
            if(cbLanguage.SelectedIndex == 0)
            {
                Properties.Settings.Default.Language = "en";
            }
            //Arabic
            if(cbLanguage.SelectedIndex==1)
            {
                Properties.Settings.Default.Language = "ar";
            }
            
            if(rbBlue.Checked)
            {
                Properties.Settings.Default.MainColor = pbblue.BackColor;
            }
            if(rbBlack.Checked)
            {
                Properties.Settings.Default.MainColor=pbBlack.BackColor;
            }
            if(rbCyan.Checked)
            {
                Properties.Settings.Default.MainColor=(pbCyan.BackColor);
            }
            if(rbGray.Checked)
            {
                Properties.Settings.Default.MainColor=pbGray.BackColor;
            }
            if(rbWhite.Checked)
            {
                Properties.Settings.Default.MainColor =(pbWhite.BackColor);
            }
            if(rbDarkgray.Checked)
            {
                Properties.Settings.Default.MainColor=pbDimGray.BackColor;
            }

            Properties.Settings.Default.Save();
            Application.Restart();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnBackupDataBase_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                if(!Directory.Exists(fbd.SelectedPath))
                {
                    MessageBox.Show("Folder Not Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(await BLL.DatabaseService.BackupDatabase(fbd.SelectedPath))
                {
                    MessageBox.Show("DataBase Backup Created Successfully", "Backup Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Faild To Backup Database (Cannot Access This Folder)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }
    }
}
