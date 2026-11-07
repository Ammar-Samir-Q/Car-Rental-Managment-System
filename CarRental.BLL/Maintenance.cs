using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.BLL
{
    public class Maintenance
    {

        enum enMode { AddNew = 1, Update = 2 }

        public int MaintenanceID { get; set; }
        public int VehicleID { get; set; }

        public Vehicle VehicleInfo { get; set; }

        public string Description { get; set; }

        public DateTime MaintenanceDate { get; set; }

        public float Cost { get; set; }

        private enMode _Mode = enMode.AddNew;


        //-----------------------------------

        public Maintenance()
        {
            this.MaintenanceID = -1;
            this.VehicleID = -1;
            this.Description = "";
            this.MaintenanceDate = DateTime.Now;
            this.Cost = 0;
            this._Mode = enMode.AddNew;
        }

        public Maintenance(int MainteanceID, int VehicleID, string Description, DateTime MaintenanceDate, float Cost)
        {
            this.MaintenanceID = MainteanceID;
            this.VehicleID = VehicleID;
            this.VehicleInfo = Vehicle.GetVehicleByID(VehicleID);
            this.Description = Description;
            this.MaintenanceDate = MaintenanceDate;
            this.Cost = Cost;
            this._Mode = enMode.Update;
        }

        //----------------------------------

        private bool _AddMaintenance()
        {
            this.MaintenanceID = DAL.MaintenanceRepository.AddMaintenance(VehicleID, Description, MaintenanceDate, Cost); ;
            return this.MaintenanceID > 0;
        }

        private bool _UpdateMaintenance()
        {
            return DAL.MaintenanceRepository.UpdateMainteance(MaintenanceID, VehicleID, Description, MaintenanceDate, Cost);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    this._Mode = enMode.Update;
                    return _AddMaintenance();
                case enMode.Update:
                    return _UpdateMaintenance();
            }
            return false;

        }

        public static Maintenance GetMainteanceByID(int MaintenanceID)
        {
            int VehicleID = -1;
            string Description = "";
            DateTime MaintenanceDate = DateTime.Now;
            float Cost = 0;
            if (DAL.MaintenanceRepository.GetMaintenanceByID(MaintenanceID, ref VehicleID, ref Description, ref MaintenanceDate, ref Cost))
            {
                return new Maintenance(MaintenanceID, VehicleID, Description, MaintenanceDate, Cost);
            }
            else
                return null;

        }

        public static DataTable GetAllMaintenances()
        {
            return DAL.MaintenanceRepository.GetAllMaintenances();
        }

        public static DataTable GetAllMaintenancesForVehicle(int VehicleID)
        {
            return DAL.MaintenanceRepository.GetAllMaintenancesForVehicle(VehicleID);
        }


        public static bool DeleteMaintenance(int MaintenanceID)
        {
            return DAL.MaintenanceRepository.DeleteMaintenance(MaintenanceID);
        }

        public bool Delete()
        {
            return DAL.MaintenanceRepository.DeleteMaintenance(this.MaintenanceID);
        }

        public static bool IsMaintenanceExists(int MaintenanceID)
        {
            return DAL.MaintenanceRepository.IsMaintenanceExists(MaintenanceID);
        }

        public bool IsExists()
        {
            return DAL.MaintenanceRepository.IsMaintenanceExists(this.MaintenanceID);
        }

    }
}
