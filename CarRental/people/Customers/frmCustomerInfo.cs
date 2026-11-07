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
    public partial class frmCustomerInfo : Form
    {
        private int _CustomerID = -1;
        public frmCustomerInfo(int CustomerID)
        {
            _CustomerID=CustomerID;
            InitializeComponent();
        }

        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            ctrlCustomerInfo1.LoadCustomer(_CustomerID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
