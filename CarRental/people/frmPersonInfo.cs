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
    public partial class frmPersonInfo : Form
    {
        private int _PersonID=-1;
        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID=PersonID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.LoadPerson(_PersonID);
        }
    }
}
