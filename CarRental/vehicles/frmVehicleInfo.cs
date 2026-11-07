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
    public partial class frmVehicleInfo : Form
    {
        private int _VehicleID=-1;
        public frmVehicleInfo(int VehicleID)
        {
            InitializeComponent();
            _VehicleID = VehicleID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVehicleInfo_Load(object sender, EventArgs e)
        {
            ctrlVehicleInfo1.LoadVehicle(_VehicleID);
        }
    }
}
