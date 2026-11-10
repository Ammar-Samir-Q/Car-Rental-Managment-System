using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data = CarRental.DAL.Entities;
namespace CarRental.BLL
{
    public class Maintenance
    {

        enum enMode { AddNew = 1, Update = 2 }

        public int MaintenanceID { get; set; }
        public int VehicleID { get; set; }

        public Vehicle VehicleInfo { get; set; }

        public string? Description { get; set; }

        public DateOnly MaintenanceDate { get; set; }

        public decimal Cost { get; set; }

        private enMode _Mode = enMode.AddNew;


        //-----------------------------------

        public Maintenance()
        {
            this.MaintenanceID = -1;
            this.VehicleID = -1;
            this.Description = "";
            this.MaintenanceDate = DateOnly.FromDateTime(DateTime.Now);
            this.Cost = 0;
            this._Mode = enMode.AddNew;
        }

        public Maintenance(int MainteanceID, int VehicleID, string? Description, DateOnly MaintenanceDate, decimal Cost,Vehicle vehicle)
        {
            this.MaintenanceID = MainteanceID;
            this.VehicleID = VehicleID;
            this.VehicleInfo = vehicle;
            this.Description = Description;
            this.MaintenanceDate = MaintenanceDate;
            this.Cost = Cost;
            this._Mode = enMode.Update;
        }

        //----------------------------------

        private async Task<bool> _AddMaintenance()
        {
            Data.Maintenance maintenance = new Data.Maintenance()
            {
                VehicleID = this.VehicleID,
                Description = this.Description,
                MaintenanceDate = this.MaintenanceDate,
                Cost = this.Cost

            };
            this.MaintenanceID = await DAL.MaintenanceRepository.AddMaintenance(maintenance); ;
            return this.MaintenanceID > 0;
        }

        private async Task<bool> _UpdateMaintenance()
        {
            return await DAL.MaintenanceRepository.UpdateMainteance(MaintenanceID, VehicleID, Description, MaintenanceDate, Cost);
        }

        public async Task<bool> Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    this._Mode = enMode.Update;
                    return await _AddMaintenance();
                case enMode.Update:
                    return await _UpdateMaintenance();
            }
            return false;

        }

        public static async Task<Maintenance?> GetMainteanceByID(int MaintenanceID)
        {

            var maintenace = await DAL.MaintenanceRepository.GetMaintenanceByID(MaintenanceID);
            if (maintenace!=null)
            {
                var Vehicle=await BLL.Vehicle.GetVehicleByID(maintenace.VehicleID);
                return new Maintenance(MaintenanceID, maintenace.VehicleID, maintenace.Description, maintenace.MaintenanceDate, maintenace.Cost,Vehicle);
            }
            else
                return null;

        }

        public static async Task<DataTable> GetAllMaintenances()
        {
            return await DAL.MaintenanceRepository.GetAllMaintenances();
        }

        public static async Task<DataTable> GetAllMaintenancesForVehicle(int VehicleID)
        {
            return await DAL.MaintenanceRepository.GetAllMaintenancesForVehicle(VehicleID);
        }


        public static async Task<bool> DeleteMaintenance(int MaintenanceID)
        {
            return await DAL.MaintenanceRepository.DeleteMaintenance(MaintenanceID);
        }

        public async Task<bool> Delete()
        {
            return await DAL.MaintenanceRepository.DeleteMaintenance(this.MaintenanceID);
        }

        public static async Task<bool> IsMaintenanceExists(int MaintenanceID)
        {
            return await DAL.MaintenanceRepository.IsMaintenanceExists(MaintenanceID);
        }

        public async Task<bool> IsExists()
        {
            return await DAL.MaintenanceRepository.IsMaintenanceExists(this.MaintenanceID);
        }

    }
}
