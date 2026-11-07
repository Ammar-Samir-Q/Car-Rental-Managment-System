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
    public partial class frmMaintenanceInfo : Form
    {
        private int _MaintenanceID = -1;
        public frmMaintenanceInfo(int MaintenanceID)
        {
            _MaintenanceID = MaintenanceID;
            InitializeComponent();
        }

        private void frmMaintenanceInfo_Load(object sender, EventArgs e)
        {
            ctrlMaintenanceInfo1.LoadMaintenance(_MaintenanceID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
