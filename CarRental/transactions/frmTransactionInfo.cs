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
    public partial class frmTransactionInfo : Form
    {
        int _TransactionID = -1;
        public frmTransactionInfo(int TransactionID)
        {
            _TransactionID = TransactionID;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransactionInfo_Load(object sender, EventArgs e)
        {
            ctrlTransactionInfo1.LoadTransaction(_TransactionID);
        }

        private void ctrlTransactionInfo1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
