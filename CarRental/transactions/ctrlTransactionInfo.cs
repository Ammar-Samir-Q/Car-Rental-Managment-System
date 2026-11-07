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
    public partial class ctrlTransactionInfo : UserControl
    {

        Transaction _Transaction;
        public ctrlTransactionInfo()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TransactionID {  get; set; }


        private void _LoadData()
        {
            _Transaction =Transaction.GetTransactionByID(TransactionID);
            if (_Transaction == null)
                return;
            
            lblTransactionID.Text=_Transaction.TransactionID.ToString();
            lblBookingID.Text=_Transaction.BookingID.ToString();
            lblReturnID.Text = _Transaction.ReturnID == -1 ? "Not Returned Yet" : _Transaction.ReturnID.ToString();
            lblPaymentDetails.Text=_Transaction.PaymentsDetails==""?"No Details":_Transaction.PaymentsDetails.ToString();
            lblInitialPaid.Text=_Transaction.PaidInitialTotalDueAmount.ToString();
            lblActualPaid.Text = _Transaction.ActualTotalDueAmount <= 0 ? "Not Paid Yet" : _Transaction.ActualTotalDueAmount.ToString();
            lblTotalRefunded.Text=_Transaction.TotalRefundedAmount<=0?"No Refund":_Transaction.TotalRefundedAmount.ToString();
            lblDate.Text=_Transaction.TransactionDate.ToShortDateString();
            lblUpdatedDate.Text= _Transaction.UpdatedTransactionDate.ToShortDateString();
            lblAdditionalCharges.Text=_Transaction.ReturnID==-1?"No Additional Charges":_Transaction.ReturnInfo.AddtionalCharges>0?_Transaction.ReturnInfo.AddtionalCharges.ToString(): "No Additional Charges";

            lblLinkBookingInfo.Enabled = true;
            if(_Transaction.ReturnID>0)
                linklblReturnInfo.Enabled=true;


        }
        public void LoadTransaction(int transactionID)
        {
            TransactionID = transactionID;
            if(TransactionID> 0)
            {
                _LoadData();
            }

        }

        private void lblLinkBookingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmBookingInfo(_Transaction.BookingID);
            frm.ShowDialog();
        }

        private void linklblReturnInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmReturnInfo(_Transaction.ReturnID);
            frm.ShowDialog();
        }


    }
}
