using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data = CarRental.DAL.Entities;

namespace CarRental.BLL
{
    public class Vehicle
    {
        enum enMode { AddNew = 1, Update = 2 }
        public enum enFuelType { Petrol = 1, Diesel = 2, Gas = 3, Electric = 4, Hybird = 5 }
        public enum enVehicleCategory { Micro = 1, Sedan = 2, HatchBack = 3, Universal = 4, LiftBack = 5, MuscleCar = 6, SportCar = 7, SUV = 8, Crossover = 9, Pickup = 10, Van = 11 }

        public int VehicleID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public int CurrentMilage { get; set; }

        public enFuelType FuelType { get; set; }

        public enVehicleCategory VehicleCategory { get; set; }

        public string PlateNumber { get; set; }

        public decimal RentalPricePerDay { get; set; }

        public bool IsAvailableForRent { get; set; }

        public string ImagePath { get; set; }

        private enMode _Mode;

        //--------------------------------------------------

        public Vehicle()
        {
            this.VehicleID = -1;
            this.Make = "";
            this.Model = "";
            this.Year = -1;
            this.CurrentMilage = -1;
            this.FuelType = enFuelType.Petrol;
            this.VehicleCategory = enVehicleCategory.Sedan;
            this.PlateNumber = "";
            this.RentalPricePerDay = 0;
            this.IsAvailableForRent = false;
            this.ImagePath = "";
            this._Mode = enMode.AddNew;

        }

        public Vehicle(int VehicleID, string Make, string Model,
            int Year, int CuurentMilage, int FuelType, int VehicleCategory, string PlateNumber, decimal RentalPricePerDay, bool IsAvailableForRent, string ImagePath)
        {
            this.VehicleID = VehicleID;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.CurrentMilage = CuurentMilage;
            this.FuelType = (enFuelType)FuelType;
            this.VehicleCategory = (enVehicleCategory)VehicleCategory;
            this.PlateNumber = PlateNumber;
            this.RentalPricePerDay = RentalPricePerDay;
            this.IsAvailableForRent = IsAvailableForRent;
            this.ImagePath = ImagePath;
            this._Mode = enMode.Update;
        }

        //----------------------------------------------------

        private async Task<bool> _AddVehicle()
        {
            var vehicle = new Data.Vehicle()
            {
                Make = this.Make,
                Model = this.Model,
                CurrentMileage = this.CurrentMilage,
                FuelTypeID =(byte)this.FuelType,
                VehicleCategoryID = (byte)this.VehicleCategory,
                PlateNumber = this.PlateNumber,
                RentalPricePerDay = this.RentalPricePerDay,
                IsAvailableForRent = this.IsAvailableForRent,
                ImagePath = this.ImagePath
            };
                


            this.VehicleID = await DAL.VehicleRepository.AddVehicle(vehicle);
            return this.VehicleID > 0;
        }

        private async Task<bool> _UpdateVehicle()
        {
            return await DAL.VehicleRepository.UpdateVehicle(VehicleID, Make, Model, Year, CurrentMilage, (int)FuelType, (int)VehicleCategory, PlateNumber, RentalPricePerDay, IsAvailableForRent, ImagePath);
        }

        public async Task<bool> Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return await _AddVehicle();
                case enMode.Update:
                    return await _UpdateVehicle();
            }
            return false;
        }

        public static async Task<Vehicle?> GetVehicleByID(int VehicleID)
        {
            var vehicle = await DAL.VehicleRepository.GetVehicleByID(VehicleID);
            if (vehicle!=null)
                return new Vehicle(VehicleID, vehicle.Make, vehicle.Model, vehicle.Year, vehicle.CurrentMileage, vehicle.FuelTypeID, vehicle.VehicleCategoryID, vehicle.PlateNumber, vehicle.RentalPricePerDay, vehicle.IsAvailableForRent, vehicle.ImagePath);
            else
                return null;
        }

        public static async Task<bool> DeleteVehicle(int VehicleID)
        {
            return await DAL.VehicleRepository.DeleteVehicle(VehicleID);
        }

        public async Task<bool> Delete()
        {
            return await DAL.VehicleRepository.DeleteVehicle(this.VehicleID);
        }

        public static async Task<DataTable> GetAllVehicles()
        {
            return await DAL.VehicleRepository.GetAllVehicles();
        }

        public static async Task<DataTable> GetAllAvailableVehicles()
        {
            return await DAL.VehicleRepository.GetAllAvailableVehicles();
        }

        public static async Task<bool> IsVehicleExists(int VehicleID)
        {
            return await DAL.VehicleRepository.IsVehicleExists(VehicleID);
        }

        public static async Task<bool> IsVehicleExists(string PlateNumber)
        {
            return await DAL.VehicleRepository.IsVehicleExists(PlateNumber);
        }


        public async Task<bool> IsExists()
        {
            return await DAL.VehicleRepository.IsVehicleExists(this.VehicleID);
        }

        public string GetFuelTypeTitle()
        {
            switch (FuelType)
            {
                case enFuelType.Petrol:
                    return "Petrol";
                case enFuelType.Diesel:
                    return "Diesel";
                case enFuelType.Gas:
                    return "Gas";
                case enFuelType.Electric:
                    return "Electric";
                case enFuelType.Hybird:
                    return "Hybird";
            }
            return "";

        }

        public string GetVehicleCategoryTitle()
        {
            switch (VehicleCategory)
            {
                case enVehicleCategory.Micro:
                    return "Micro";
                case enVehicleCategory.Sedan:
                    return "Sedan";
                case enVehicleCategory.HatchBack:
                    return "Hatch Back";
                case enVehicleCategory.Universal:
                    return "Universal";
                case enVehicleCategory.LiftBack:
                    return "LiftBack";
                case enVehicleCategory.MuscleCar:
                    return "Muscle Car";
                case enVehicleCategory.SportCar:
                    return "Sport Car";
                case enVehicleCategory.SUV:
                    return "SUV";
                case enVehicleCategory.Crossover:
                    return "Crossover";
                case enVehicleCategory.Pickup:
                    return "Pickup";
                case enVehicleCategory.Van:
                    return "Van";

            }
            return "";


        }

        public async Task<bool> SetVehicleAvilable(bool IsAvailable)
        {
            return await DAL.VehicleRepository.SetVehicleAvilable(this.VehicleID, IsAvailable);
        }
        public static async Task<bool> SetVehicleAvilable(int VehicleID, bool IsAvailable)
        {
            return await DAL.VehicleRepository.SetVehicleAvilable(VehicleID, IsAvailable);
        }

        public static async Task<bool> UpdateMilage(int VehicleID, int Milage)
        {
            return await DAL.VehicleRepository.UpdateMilage(VehicleID, Milage);
        }

        public async Task<bool> UpdateMilage(int Milage)
        {
            return await DAL.VehicleRepository.UpdateMilage(this.VehicleID, Milage);
        }

        public static async Task<int> GetTotalRentTimes(int VehicleID)
        {
            return await DAL.VehicleRepository.GetTotalRentTimes(VehicleID);
        } 
        public async Task<int> GetTotalRentTimes()
        {
            return await DAL.VehicleRepository.GetTotalRentTimes(this.VehicleID);
        }

        public static async Task<DataTable> GetRentHistory(int VehicleID)
        {
            return await DAL.VehicleRepository.GetVehicleRentHistory(VehicleID);
        }

        public static async Task<int> GetTotalVehicles()
        {
            return await DAL.VehicleRepository.GetTotalVehicles();
        }
    }
}
