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
    public partial class frmBookingInfo : Form
    {
        private int _BookingID = -1;
        public frmBookingInfo(int BookingID)
        {
            _BookingID = BookingID;
            InitializeComponent();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookingInfo_Load(object sender, EventArgs e)
        {
            if (_BookingID == -1)
                return;
            ctrlRentInfo1.LoadBooking(_BookingID);

        }
    }
}
