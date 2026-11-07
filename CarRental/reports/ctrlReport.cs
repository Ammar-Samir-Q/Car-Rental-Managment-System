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
    public partial class ctrlReport : UserControl
    {
        public ctrlReport()
        {
            InitializeComponent();
        }
        public void ChangeColor(Color Backcolor,Color ForeColor)
        {
            this.BackColor = Backcolor; 
            this.ForeColor = ForeColor;
        }
        public void LoadReport(string ReportName,int Value)
        {
            if(!string.IsNullOrEmpty(ReportName))
            {
                lblTitle.Text = ReportName;
                lblValue.Text=Value.ToString();
            }
        }
        public void LoadReport(string ReportName, string Value)
        {
            if (!string.IsNullOrEmpty(ReportName))
            {
                lblTitle.Text = ReportName;
                lblValue.Text = Value;
            }
        }
        public void LoadReport(string ReportName, DateTime Value)
        {
            if (!string.IsNullOrEmpty(ReportName))
            {
                lblTitle.Text = ReportName;
                lblValue.Text = Value.ToShortDateString();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
