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
    public partial class frmUserInfo : Form
    {
        private int _UserID = -1;
        public frmUserInfo(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserInfo1.LoadUser(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
