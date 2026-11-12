using CarRental.BLL;
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
    public partial class ctrlCustomerInfo : UserControl
    {
        public ctrlCustomerInfo()
        {
            InitializeComponent();
        }
        private int _CustomerID = -1;
        public int CustomerID { get { return _CustomerID; } }

        public void LoadCustomer(int CustomerID)
        {
            _CustomerID = CustomerID;
            if(_CustomerID>0)
            {
                _LoadData();
            }

        }

        private async void _LoadData()
        {
            Customer? Customer= await Customer.GetCustomerByID(CustomerID);
            if (Customer == null)
                return;
            DateTime LastDate= await Customer.GetLastRentDate();
            linklblEdirCustomers.Enabled = true;
            ctrlPersonInfo1.LoadPerson(Customer.PersonID);
            lblCustomerID.Text=Customer.CustomerID.ToString();
            var user = await User.GetUserByID(Customer.CreatedByUserID);
            lblCreatedBy.Text = user == null ? "N/A" : user.Username; lblCreationDate.Text=Customer.CreationDate.ToShortDateString();
            lblDriverLidnese.Text=Customer.DriverLicnsesNumber.ToString();
            int TotalRentTimes = await Customer.GetTotalRentTimes();
            lblTotalRentTimes.Text =TotalRentTimes.ToString();
            lblLastRent.Text=LastDate==DateTime.MinValue?"No Rents": LastDate.ToShortDateString();


        }

        private void linklblEdirCustomers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm =new frmAddCustomer(_CustomerID);
            frm.ShowDialog();
            this.LoadCustomer(_CustomerID);
        }

       
    }
}
