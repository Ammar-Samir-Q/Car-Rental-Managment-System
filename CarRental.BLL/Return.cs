using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.BLL
{
    public class Return
    {
        enum enMode { Addnew = 1, Update = 2 }
        public enum enReturnCondition { Good = 1, Normal = 2, Damaged = 3, NeedsMaintenance = 4, VeryDirty = 5, LateReturn = 6 }
        public enum enFuelLevel { Full = 1, ThreeQuarters = 2, Half = 3, Quarter = 4, Empty = 5 }

        public int ReturnID { get; set; }


        public DateTime ActualReturnDate { get; set; }

        public int Milage { get; set; }

        public string FinalCheckNotes { get; set; }

        public float AddtionalCharges { get; set; }

        public float ActualTotalDueAmount { get; set; }

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
            this.ActualReturnDate = DateTime.Now;
            this.Milage = 0;
            this.FinalCheckNotes = "";
            this.AddtionalCharges = 0;
            this.ActualTotalDueAmount = 0;
            this.ReturnCondition = enReturnCondition.Good;
            this.FuelLevel = enFuelLevel.Full;
            this._Mode = enMode.Addnew;

        }

        public Return(int ReturnID, DateTime ActualReturnDate, int Milage, string FinalCheckNotes, float AddtionalCharges, float ActualTotalDueAmount, byte ReturnCondition, byte FuelLevel)
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

        private bool _AddReturn()
        {
            this.ReturnID = DAL.ReturnRepository.Create(ActualReturnDate, Milage, FinalCheckNotes, AddtionalCharges, ActualTotalDueAmount, (byte)ReturnCondition, (byte)FuelLevel);
            return this.ReturnID > 0;
        }

        private bool _UpdateReturn()
        {
            return DAL.ReturnRepository.Update(ReturnID, ActualReturnDate, Milage, FinalCheckNotes, AddtionalCharges, ActualTotalDueAmount, (byte)ReturnCondition, (byte)FuelLevel);
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.Addnew:
                    this._Mode = enMode.Update;
                    return _AddReturn();
                case enMode.Update:
                    return _UpdateReturn();
            }
            return false;
        }


        public static Return GetReturnByID(int ReturnID)
        {
            DateTime ActualReturnDate = DateTime.Now;
            float Mileage = 0;
            byte ReturnCondition = 1, FuelLevel = 1;
            string FinalCheckNotes = "";
            float AdditionalCharges = 0, ActualTotalDueAmount = 0;
            if (DAL.ReturnRepository.GetByID(ReturnID, ref ActualReturnDate, ref Mileage, ref FinalCheckNotes, ref AdditionalCharges, ref ActualTotalDueAmount, ref ReturnCondition, ref FuelLevel))
            {
                return new Return(ReturnID, ActualReturnDate, (int)Mileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount, ReturnCondition, FuelLevel);
            }
            else
                return null;



        }

        public static DataTable GetAllReturns()
        {
            return DAL.ReturnRepository.GetAll();
        }

        public static bool DeleteReturn(int ReturnID)
        {
            return DAL.ReturnRepository.Delete(ReturnID);
        }
        public bool DeleteReturn()
        {
            return DAL.ReturnRepository.Delete(this.ReturnID);
        }

        public static bool IsReturnExists(int ReturnID)
        {
            return DAL.ReturnRepository.IsExists(ReturnID);
        }


        public bool IsExists()
        {
            return DAL.ReturnRepository.IsExists(this.ReturnID);
        }
    }
}
