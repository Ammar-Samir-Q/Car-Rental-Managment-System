using CarRental.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddUpdatePerson : Form
    {
        enum enMode { Addnew = 1, Update = 2 }
        private enMode _Mode;


        private int _PersonID;
        private Person _Person;

        public delegate void delPersonID(int PersonID);
        public event delPersonID DataBackPersonID;

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
        }
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.Addnew;
        }

        //--------------------------------------Load---------------------------------------------

        void _SetDefaults()
        {
            _Person = new Person();

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            //We Make The Max Date To Enter 18 years old
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);



            rbMale.Checked = true;
            pbImage.Image = Properties.Resources.png_Male;
        }

        void _LoadData()
        {
            if (Properties.Settings.Default.Language == "en")
            {
                lblTitle.Text = "Update Person";
                this.Text = lblTitle.Text;
            }
            else
            {
                lblTitle.Text = "تحديث شخص";
                this.Text = lblTitle.Text;
            }

            _Person = Person.GetPerson(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Error : Perosn Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtAddress.Text = _Person.Address;
            txtNationalNo.Text = _Person.NationalNo;
            rbMale.Checked = _Person.Gender == 0;
            rbFemale.Checked = _Person.Gender == 1;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            _LoadImage();

        }

        void _LoadImage()
        {
            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                pbImage.ImageLocation = _Person.ImagePath;
                btnRemoveImage.Visible = true;
                return;
            }

            btnRemoveImage.Visible = false;

            if (rbMale.Checked)
                pbImage.Image = Properties.Resources.png_Male;
            else
                pbImage.Image = Properties.Resources.png_Female;

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _SetDefaults();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        //--------------------------------------Load---------------------------------------------



        //--------------------------------------Save---------------------------------------------


        private bool _HandelImage()
        {
            if (pbImage.ImageLocation == _Person.ImagePath)
                return true;
            if (string.IsNullOrEmpty(pbImage.ImageLocation) && string.IsNullOrEmpty(_Person.ImagePath))
                return true;

            //Case 1 If Picture Is Removed And The Path On The Database Exists = Delete Image And Change ImagePath In DB To Null
            if (string.IsNullOrEmpty(pbImage.ImageLocation)&&!string.IsNullOrEmpty(_Person.ImagePath))
            {
                if (!Util.ImageHelper.DeleteImage(_Person.ImagePath, Application.StartupPath))
                {
                    MessageBox.Show("Failed To Delete Image", "Image Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _Person.ImagePath = null;
                return true;
            }
            
            //Case 2 : If Picture Is Exists And Not Yet Saved To Database= SaveImage And Return Relative Path To Imagepath  
            if(string.IsNullOrEmpty(_Person.ImagePath)&&!string.IsNullOrEmpty(pbImage.ImageLocation))
            {
                string ReleativePath = Util.ImageHelper.SaveImage(pbImage.ImageLocation,Application.StartupPath,"People");
                if(string.IsNullOrEmpty(ReleativePath))
                {
                    MessageBox.Show("Error While Saving Image To Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _Person.ImagePath = ReleativePath;
                pbImage.ImageLocation = _Person.ImagePath;
                return true;
            }

            //Case 3 : if picture on the imagelocation is diffrent from the picture on the imagepath = update picture on database (delete old and save new

            if(pbImage.ImageLocation!=_Person.ImagePath)
            {
                if(Util.ImageHelper.DeleteImage(_Person.ImagePath,Application.StartupPath))
                {
                    string ReleativePath = Util.ImageHelper.SaveImage(pbImage.ImageLocation, Application.StartupPath, "People");
                    if (string.IsNullOrEmpty(ReleativePath))
                    {
                        MessageBox.Show("Error While Saving Image To Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    _Person.ImagePath = ReleativePath;
                    pbImage.ImageLocation = _Person.ImagePath;
                    return true;

                }

            }


            return false;   

        }
        private async void _SaveData()
        {
            
            _Person.FirstName=txtFirstName.Text.Trim();
            _Person.SecondName=txtSecondName.Text.Trim();
            _Person.ThirdName=txtThirdName.Text.Trim();
            _Person.LastName=txtLastName.Text.Trim();   
            _Person.NationalNo=txtNationalNo.Text.Trim();
            _Person.Email=txtEmail.Text.Trim();
            _Person.Phone=txtPhone.Text.Trim();
            _Person.Address=txtAddress.Text.Trim();
            _Person.DateOfBirth=dtpDateOfBirth.Value;
            _Person.Gender = rbMale.Checked ? (byte)0 : (byte)1;

            

            if (!_HandelImage())
                return;

            if(await _Person.Save())
            {
                lblPersonID.Text=_Person.PersonID.ToString();
                if (Properties.Settings.Default.Language == "en")
                {
                    lblTitle.Text = "Update Person";
                    this.Text = lblTitle.Text;
                }
                else
                {
                    lblTitle.Text = "تحديث شخص";
                    this.Text = lblTitle.Text;
                }
                _Mode = enMode.Update;
                MessageBox.Show("Person Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBackPersonID?.Invoke(_Person.PersonID);
            }
            else
            {
                MessageBox.Show("Error : Error While Saving The Data", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(this.ValidateChildren())
                    _SaveData();
        }



        //--------------------------------------Save---------------------------------------------



        //--------------------------------------Misc---------------------------------------------


        private void _ChooseImage()
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Title = "Choose Person Image";
            ofd.Filter = "Image Files | *.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if(!string.IsNullOrEmpty(ofd.FileName))
                {
                    pbImage.ImageLocation = ofd.FileName;
                    btnRemoveImage.Visible = true;
                    return;
                }
                else
                    _LoadImage();

            }



        }

        private void _RemoveImage()
        {
            pbImage.ImageLocation = "";
            if (rbMale.Checked)
                pbImage.Image = Properties.Resources.png_Male;
            else
                pbImage.Image = Properties.Resources.png_Female;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            _ChooseImage();
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            _RemoveImage();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            _LoadImage();
        }

        private void brnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //--------------------------------------Misc---------------------------------------------




        //--------------------------------------Validation---------------------------------------------


        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                ep.SetError(txtFirstName,"Enter First Name");
            }
            else
            {
                e.Cancel= false;
                ep.SetError(txtFirstName, "");

            }

        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondName.Text))
            {
                e.Cancel = true;
                ep.SetError(txtSecondName, "Enter Second Name");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtSecondName, "");

            }
        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThirdName.Text))
            {
                e.Cancel = true;
                ep.SetError(txtThirdName, "Enter Third Name");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtThirdName, "");

            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                ep.SetError(txtLastName, "Enter Last Name");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtLastName, "");

            }
        }

        private async void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text))
            {
                e.Cancel = true;
                ep.SetError(txtNationalNo, "Enter National Number");
                return;
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtNationalNo, "");
            }

            if (_Person.NationalNo == txtNationalNo.Text)
                return;

            if (await Person.IsPersonExists(txtNationalNo.Text))
            {
                e.Cancel = true;
                ep.SetError(txtNationalNo, "National Number is Already Exists");
                return;
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtNationalNo, "");
            }
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                ep.SetError(txtPhone, "Enter Phone Number");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtPhone, "");

            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                ep.SetError(txtAddress, "Enter Address");
            }
            else
            {
                e.Cancel = false;
                ep.SetError(txtAddress, "");

            }
        }


        //--------------------------------------Validation---------------------------------------------









    }
}
