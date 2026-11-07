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
    public partial class frmReturnInfo : Form
    {
        public frmReturnInfo(int ReturnID)
        {
            InitializeComponent();
            ctrlReturnInfo1.LoadReturn(ReturnID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReturnInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
