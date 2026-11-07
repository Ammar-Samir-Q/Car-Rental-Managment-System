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
    //Reset Defaults After Not Found
    public partial class ctrlPersonInfoWithFilter : UserControl
    {
        private int _PersonID = -1;
        private string _NationalNo = "";
        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool FilterEnabled { set { gbFilter.Enabled = value; }  get { return gbFilter.Enabled; } }
        public  int SelectedPersonID { get { return _PersonID; } }

        public Person SelectedPersonInfo { get { return Person.GetPerson(_PersonID); } }

        public void ResetControl()
        {
            this.ctrlPersonInfo1.ResetControl();
        }

        public async void LoadPerson(int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            _PersonID = PersonID;
            if (await Person.IsPersonExists(PersonID))
            {
                txtFilter.Text =_PersonID.ToString();
                FilterEnabled = false;
                ctrlPersonInfo1.LoadPerson(PersonID);
            }
            else
                MessageBox.Show("Person With PersonID : " + _PersonID + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public async void LoadPerson(string NationalNo)
        {
            cbFilter.SelectedIndex = 1;
            _NationalNo = NationalNo;
            if (await Person.IsPersonExists(NationalNo))
            {
                _PersonID = Person.GetPerson(NationalNo).PersonID;
                txtFilter.Text = NationalNo;
                FilterEnabled = false;
                ctrlPersonInfo1.LoadPerson(NationalNo);
            }
            else
                MessageBox.Show("Person With NationalNo : " + NationalNo + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void _ResetDefaults()
        {
            ctrlPersonInfo1.ResetControl();
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilter.Text))
            {
                _ResetDefaults();
                return;
            }

            if(cbFilter.SelectedIndex==0)
            {
                _PersonID = int.Parse(txtFilter.Text);
                if(! await Person.IsPersonExists(_PersonID))
                {
                    _ResetDefaults();
                    MessageBox.Show("Person With PersonID : " + _PersonID + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ctrlPersonInfo1.LoadPerson(_PersonID);
                return;
            }
            if(cbFilter.SelectedIndex == 1)
            {

                _NationalNo= txtFilter.Text;

                if(! await Person.IsPersonExists(_NationalNo))
                {
                    _ResetDefaults();
                    MessageBox.Show("Person With NationalNo : " + _NationalNo + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ctrlPersonInfo1.LoadPerson(_NationalNo);
                _PersonID = ctrlPersonInfo1.PersonID;
            }


        }

        private async void LoadAddedPerson(int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            _PersonID = PersonID;
            if (await Person.IsPersonExists(PersonID))
            {
                txtFilter.Text = _PersonID.ToString();
                ctrlPersonInfo1.LoadPerson(PersonID);
            }
            else
                MessageBox.Show("Added Person With PersonID : " + _PersonID + " Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm=new frmAddUpdatePerson();
            frm.DataBackPersonID += LoadAddedPerson;
            frm.ShowDialog();
        }

        private void ctrlPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar)==13)
            {
                btnFind.PerformClick();
            }

            if (cbFilter.SelectedIndex == 0)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
            }
    }
}
