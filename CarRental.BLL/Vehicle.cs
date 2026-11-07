using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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

        public float RentalPricePerDay { get; set; }

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
            int Year, int CuurentMilage, int FuelType, int VehicleCategory, string PlateNumber, float RentalPricePerDay, bool IsAvailableForRent, string ImagePath)
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

        private bool _AddVehicle()
        {
            this.VehicleID = DAL.VehicleRepository.AddVehicle(Make, Model, Year, CurrentMilage, (int)FuelType, (int)VehicleCategory, PlateNumber, RentalPricePerDay, IsAvailableForRent, ImagePath);
            return this.VehicleID > 0;
        }

        private bool _UpdateVehicle()
        {
            return DAL.VehicleRepository.UpdateVehicle(VehicleID, Make, Model, Year, CurrentMilage, (int)FuelType, (int)VehicleCategory, PlateNumber, RentalPricePerDay, IsAvailableForRent, ImagePath);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    _Mode = enMode.Update;
                    return _AddVehicle();
                case enMode.Update:
                    return _UpdateVehicle();
            }
            return false;
        }

        public static Vehicle GetVehicleByID(int VehicleID)
        {
            string Make = "", Model = "", PlateNumber = "", ImagePath = "";
            int FuelType = 1, VehicleCategory = 1, CurrentMilage = 0, Year = 0;
            float RentalPricePerDay = 0;
            bool IsAvailableForRent = false;
            if (DAL.VehicleRepository.GetVehicleByID(VehicleID, ref Make, ref Model, ref Year, ref CurrentMilage, ref FuelType, ref VehicleCategory, ref PlateNumber, ref RentalPricePerDay, ref IsAvailableForRent, ref ImagePath))
            {
                return new Vehicle(VehicleID, Make, Model, Year, CurrentMilage, FuelType, VehicleCategory, PlateNumber, RentalPricePerDay, IsAvailableForRent, ImagePath);
            }
            else
                return null;
        }

        public static bool DeleteVehicle(int VehicleID)
        {
            return DAL.VehicleRepository.DeleteVehicle(VehicleID);
        }

        public bool Delete()
        {
            return DAL.VehicleRepository.DeleteVehicle(this.VehicleID);
        }

        public static DataTable GetAllVehicles()
        {
            return DAL.VehicleRepository.GetAllVehicles();
        }

        public static DataTable GetAllAvailableVehicles()
        {
            return DAL.VehicleRepository.GetAllAvailableVehicles();
        }

        public static bool IsVehicleExists(int VehicleID)
        {
            return DAL.VehicleRepository.IsVehicleExists(VehicleID);
        }

        public static bool IsVehicleExists(string PlateNumber)
        {
            return DAL.VehicleRepository.IsVehicleExists(PlateNumber);
        }


        public bool IsExists()
        {
            return DAL.VehicleRepository.IsVehicleExists(this.VehicleID);
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

        public bool SetVehicleAvilable(bool IsAvailable)
        {
            return DAL.VehicleRepository.SetVehicleAvilable(this.VehicleID, IsAvailable);
        }
        public static bool SetVehicleAvilable(int VehicleID, bool IsAvailable)
        {
            return DAL.VehicleRepository.SetVehicleAvilable(VehicleID, IsAvailable);
        }

        public static bool UpdateMilage(int VehicleID, int Milage)
        {
            return DAL.VehicleRepository.UpdateMilage(VehicleID, Milage);
        }

        public bool UpdateMilage(int Milage)
        {
            return DAL.VehicleRepository.UpdateMilage(this.VehicleID, Milage);
        }

        public static int GetTotalRentTimes(int VehicleID)
        {
            return DAL.VehicleRepository.GetTotalRentTimes(VehicleID);
        }
        public int GetTotalRentTimes()
        {
            return DAL.VehicleRepository.GetTotalRentTimes(this.VehicleID);
        }

        public static DataTable GetRentHistory(int VehicleID)
        {
            return DAL.VehicleRepository.GetVehicleRentHistory(VehicleID);
        }

        public static int GetTotalVehicles()
        {
            return DAL.VehicleRepository.GetTotalVehicles();
        }
    }
}
