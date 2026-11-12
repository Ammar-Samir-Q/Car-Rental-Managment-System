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
    public partial class ctrlRentInfoWithFilter : UserControl
    {
        public ctrlRentInfoWithFilter()
        {
            InitializeComponent();
        }

        public int BookingID { get { return ctrlRentInfo1.BookingID; } }
        public Booking? Booking { get { return ctrlRentInfo1.Booking; } }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool FilterEnabled { get { return gbFilter.Enabled; } set { gbFilter.Enabled = value; } }
        
        public async void LoadBooking(int BookingID)
        {
            this.FilterEnabled = false;
            if (BookingID <= 0)
                return;

            if(!await Booking.IsRentExists(BookingID))
            {
                MessageBox.Show("Booking With BookingID : " + BookingID + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            ctrlRentInfo1.LoadBooking(BookingID);


        }

        public async void LoadBookingByTransactionID(int TransactionID)
        {
            this.FilterEnabled = false;
            if (TransactionID <= 0)
                return;

            if ( !await Transaction.IsTransactionExists(TransactionID))
            {
                MessageBox.Show("Booking With TransactionID : " + TransactionID + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            ctrlRentInfo1.LoadBookingByTransactionID(TransactionID);


        }


        private void ctrlRentInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private async void Find()
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                ctrlRentInfo1.ResetControl();
                return;
            }
            //Booking ID
            if(cbFilter.SelectedIndex==0)
            {
                int BookingID = int.Parse(txtFilter.Text);
                if (!await Booking.IsRentExists(int.Parse(txtFilter.Text)))
                {
                    txtFilter.Clear();
                    ctrlRentInfo1.ResetControl();
                    MessageBox.Show("Booking With BookingID : " + BookingID + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ctrlRentInfo1.LoadBooking(BookingID);
                return;
            }

            //TransactionID
            if(cbFilter.SelectedIndex==1)
            {
                int TransactionID=int.Parse(txtFilter.Text);
                if(!await Transaction.IsTransactionExists(TransactionID))
                {
                    txtFilter.Clear();
                    ctrlRentInfo1.ResetControl();
                    MessageBox.Show("Booking With TransactionID: " + TransactionID + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ctrlRentInfo1.LoadBookingByTransactionID(TransactionID);
                return;
            }



        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
        }

    }
}
