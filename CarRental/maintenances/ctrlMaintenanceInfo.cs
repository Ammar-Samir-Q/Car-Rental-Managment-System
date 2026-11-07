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
    public partial class ctrlMaintenanceInfo : UserControl
    {
        private int _MaintenanceID=-1;  
        public ctrlMaintenanceInfo()
        {
            InitializeComponent();
        }

        public int MaintenanceID { get { return _MaintenanceID; } }

        public void LoadMaintenance(int MaintenanceID)
        {
            _MaintenanceID= MaintenanceID;
            if(_MaintenanceID>0)
            {
                _LoadData();
            }


        }
        private void _LoadData()
        {
            Maintenance Maintenance=Maintenance.GetMainteanceByID(_MaintenanceID);
            if (Maintenance == null)
                return;

            ctrlVehicleInfo1.LoadVehicle(Maintenance.VehicleID);
            lblMaintenanceID.Text=Maintenance.MaintenanceID.ToString();
            lblDate.Text=Maintenance.MaintenanceDate.ToShortDateString();
            lblDescription.Text = Maintenance.Description;
            lblCost.Text=Maintenance.Cost.ToString();
        }
    }
}
