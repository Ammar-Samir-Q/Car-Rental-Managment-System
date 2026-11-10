using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data = CarRental.DAL.Entities;

namespace CarRental.BLL
{
    public class Return
    {
        enum enMode { Addnew = 1, Update = 2 }
        public enum enReturnCondition { Good = 1, Normal = 2, Damaged = 3, NeedsMaintenance = 4, VeryDirty = 5, LateReturn = 6 }
        public enum enFuelLevel { Full = 1, ThreeQuarters = 2, Half = 3, Quarter = 4, Empty = 5 }

        public int ReturnID { get; set; }


        public DateOnly ActualReturnDate { get; set; }

        public int Milage { get; set; }

        public string FinalCheckNotes { get; set; }

        public decimal? AddtionalCharges { get; set; }

        public decimal ActualTotalDueAmount { get; set; }

        public enReturnCondition ReturnCondition { get; set; }

        public enFuelLevel FuelLevel { get; set; }

        public string FuelLevelTitle
        {
            get
            {
                switch (this.FuelLevel)
                {
                    case enFuelLevel.Full:
                        return "Full";
                    case enFuelLevel.ThreeQuarters:
                        return "Three Quarters";
                    case enFuelLevel.Half:
                        return "Half";
                    case enFuelLevel.Quarter:
                        return "Quarter";
                    case enFuelLevel.Empty:
                        return "Empty";
                }
                return "Unknown";


            }
        }

        public string ReturnConditionTitle
        {
            get
            {
                switch (this.ReturnCondition)
                {
                    case enReturnCondition.Good:
                        return "Good";
                    case enReturnCondition.Normal:
                        return "Normal";
                    case enReturnCondition.Damaged:
                        return "Damaged";
                    case enReturnCondition.NeedsMaintenance:
                        return "Needs Maintenance";
                    case enReturnCondition.VeryDirty:
                        return "Very Dirty";
                    case enReturnCondition.LateReturn:
                        return "Late Return";
                }
                return "Unknown";
            }


        }

        private enMode _Mode = enMode.Addnew;

        //--------------------------------------------
        public Return()
        {
            this.ReturnID = -1;
            this.ActualReturnDate = DateOnly.FromDateTime(DateTime.Now);
            this.Milage = 0;
            this.FinalCheckNotes = "";
            this.AddtionalCharges = 0;
            this.ActualTotalDueAmount = 0;
            this.ReturnCondition = enReturnCondition.Good;
            this.FuelLevel = enFuelLevel.Full;
            this._Mode = enMode.Addnew;

        }

        public Return(int ReturnID, DateOnly ActualReturnDate, int Milage, string FinalCheckNotes, decimal? AddtionalCharges, decimal ActualTotalDueAmount, byte ReturnCondition, byte FuelLevel)
        {
            this.ReturnID = ReturnID;
            this.ActualReturnDate = ActualReturnDate;
            this.Milage = Milage;
            this.AddtionalCharges = AddtionalCharges;
            this.FinalCheckNotes = FinalCheckNotes;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.ReturnCondition = (enReturnCondition)ReturnCondition;
            this.FuelLevel = (enFuelLevel)FuelLevel;
            this._Mode = enMode.Update;
        }

        //--------------------------------------------

        private async Task<bool> _AddReturn()
        {

            Data.Return Return = new Data.Return()
            {
                ActualReturnDate=this.ActualReturnDate,
                Mileage=this.Milage,
                FinalCheckNotes=this.FinalCheckNotes,
                AdditionalCharges=this.AddtionalCharges,
                ActualTotalDueAmount=this.ActualTotalDueAmount,
                ReturnCondition=(byte)this.ReturnCondition,
                FuleLevel=(byte)this.FuelLevel

            };

            this.ReturnID = await DAL.ReturnRepository.Create(Return);
            return this.ReturnID > 0;
        }

        private async Task<bool> _UpdateReturn()
        {
          return await DAL.ReturnRepository.Update(ReturnID, ActualReturnDate, Milage, FinalCheckNotes, AddtionalCharges, ActualTotalDueAmount, (byte)ReturnCondition, (byte)FuelLevel);
        }

        public async Task<bool> Save()
        {
            switch (this._Mode)
            {
                case enMode.Addnew:
                    this._Mode = enMode.Update;
                    return await _AddReturn();
                case enMode.Update:
                    return await _UpdateReturn();
            }
            return false;
        }


        public static async Task<Return?> GetReturnByID(int ReturnID)
        {
            var Return = await DAL.ReturnRepository.GetByID(ReturnID);
            if (Return!=null)
            {
                return new Return(ReturnID, Return.ActualReturnDate, (int)Return.Mileage, Return.FinalCheckNotes, Return.AdditionalCharges, Return.ActualTotalDueAmount, Return.ReturnCondition, Return.FuleLevel);
            }
            else
                return null;



        }

        public static async Task<DataTable> GetAllReturns()
        {
            return await DAL.ReturnRepository.GetAll();
        }

        public static async Task<bool> DeleteReturn(int ReturnID)
        {
            return await DAL.ReturnRepository.Delete(ReturnID);
        }
        public async Task<bool> DeleteReturn()
        {
            return await DAL.ReturnRepository.Delete(this.ReturnID);
        }

        public static async Task<bool> IsReturnExists(int ReturnID)
        {
            return await DAL.ReturnRepository.IsExists(ReturnID);
        }


        public async Task<bool> IsExists()
        {
            return await DAL.ReturnRepository.IsExists(this.ReturnID);
        }
    }
}
