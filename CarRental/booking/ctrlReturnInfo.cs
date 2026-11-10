using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRental
{
    public partial class ctrlReturnInfo : UserControl
    {
        public ctrlReturnInfo()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ReturnID { get; set; }

        private Transaction _transaction;
        public void LoadReturn(int ReturnID)
        {
            if (ReturnID <= 0)
                return;

            this.ReturnID = ReturnID;
            _LoadData();

        }

        public async void _LoadData()
        {
            if (ReturnID <= 0)
                return;

            Return? Return = await Return.GetReturnByID(ReturnID);
            if(Return == null) 
                return;

            _transaction = await Transaction.GetTransactionByReturnID(ReturnID);
            lblReturnID.Text    = Return.ReturnID.ToString();
            lblReturnDate.Text = Return.ActualReturnDate.ToShortDateString();
            lblMilage.Text = Return.Milage.ToString();
            lblCheckNotes.Text = Return.FinalCheckNotes == "" ? "No Notes" : Return.FinalCheckNotes;
            lblFuelLevel.Text = Return.FuelLevelTitle;
            lblReturnCondition.Text=Return.ReturnConditionTitle;
            lblRentalDays.Text = ((Convert.ToDateTime(Return.ActualReturnDate)) - (_transaction.BookingInfo.RentalStartDate)).ToString();
        }

        private void lblLinkBookingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmBookingInfo(_transaction.BookingID);
            frm.ShowDialog();
        }


    }
}
