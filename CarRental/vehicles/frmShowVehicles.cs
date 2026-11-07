using CarRental.BLL;
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
    public partial class frmShowVehicles : Form
    {
        public frmShowVehicles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowVehicles_Load(object sender, EventArgs e)
        {
            DataTable dtVehicles=Vehicle.GetAllVehicles();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.WrapContents = true;

            foreach(DataRow Row in dtVehicles.Rows)
            {
                ctrlVehicleCard ctrl=new ctrlVehicleCard();
                ctrl.LoadVehicle((int)Row[0]);
                flowLayoutPanel1.Controls.Add(ctrl);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int scrollStep = 1; // كل ما صغرت الرقم يصير أبطأ

            int maxScroll = flowLayoutPanel1.VerticalScroll.Maximum;

            int current = flowLayoutPanel1.VerticalScroll.Value;

            if (current + scrollStep < maxScroll)
            {
                flowLayoutPanel1.AutoScrollPosition = new Point(0, current + scrollStep);
            }
            else
            {
                // يرجع للبداية (اختياري)
                flowLayoutPanel1.AutoScrollPosition = new Point(0, 0);
            }
        }

        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
