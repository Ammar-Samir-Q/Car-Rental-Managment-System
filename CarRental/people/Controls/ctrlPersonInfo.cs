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
    public partial class ctrlPersonInfo : UserControl
    {
        private string _NationalNo="";
        private int _PersonID=-1;
        private Person? _Person;
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        public int PersonID { get { return _PersonID; }}
        
        public Person Person { get { return _Person; }}

        public async void LoadPerson(int PersonID)
        {
            _PersonID= PersonID;
            if (PersonID < 0)
                return;

            _Person =await Person.GetPerson(PersonID);
            _LoadData();


        }

        public async void LoadPerson(string NationalNo)
        {
            _NationalNo = NationalNo;
            if (string.IsNullOrEmpty(_NationalNo))
                return;

            _Person =await Person.GetPerson(_NationalNo);
            if (_Person == null)
                return;
            _PersonID=_Person.PersonID;
            _LoadData();


        }

        public void ResetControl()
        {
            lblID.Text = "[???]";
            lblFullname.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblEmail.Text = "[???]";
            lblNationalNo.Text = "[???]";
            lblAddress.Text="[???]";
            lblAge.Text = "[???]";
            lblGender.Text = "[???]";
            lblPhone.Text = "[???]";
            pbPersonImage.Image = Properties.Resources.png_Male;
            linklblEditPerson.Enabled= false;
        }
        private void _LoadData()
        {
            if (_Person == null)
                return;

            lblID.Text=_Person.PersonID.ToString();
            lblFullname.Text = _Person.FullName;
            lblNationalNo.Text= _Person.NationalNo.ToString();
            lblDateOfBirth.Text= _Person.DateOfBirth.ToShortDateString();
            lblAge.Text = ((int)(DateTime.Now.Date - _Person.DateOfBirth.Date).TotalDays/365).ToString();
            lblEmail.Text = _Person.Email==""?"No Email": _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblAddress.Text = _Person.Address;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";

            if(!string.IsNullOrEmpty(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation=_Person.ImagePath;
            }
            else
            {
                pbPersonImage.Image = _Person.Gender == 0 ? Properties.Resources.png_Male : Properties.Resources.png_Female;
            }

            linklblEditPerson.Enabled = true;

        }

        private void linklblEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GlobalClass.CurrentUser.Role == User.enRole.Admin)
            {
                Form frm = new frmAddUpdatePerson(_PersonID);
                frm.ShowDialog();
                this.LoadPerson(_PersonID);
            }
            else
            {
                MessageBox.Show("User Cant Edit People", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        
        }

    }
}
