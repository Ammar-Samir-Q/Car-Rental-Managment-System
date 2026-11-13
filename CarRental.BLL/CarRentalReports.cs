using CarRental.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarRental.BLL
{
    public class CarRentalReports
    {

        public async static Task<DataTable> GetVehiclesRentTimesReport()
        {
                return await DAL.ReportRepository.GetVehiclesRentTimesReport();
        }

        public async static Task<DataTable> GetDailyReport()
        {
            return await DAL.ReportRepository.GetDailyReport();
        }

        public async static Task<DataTable> GetRentReport()
        {
            return await DAL.ReportRepository.GetRentReport();
        }

        public async static Task<DataTable> GetVehiclesCountReport()
        {
            return await DAL.ReportRepository.GetVehiclesCountReport();
        }

        public async static Task<int> GetTopRentedVehicle()
        {
            return await DAL.ReportRepository.GetTopRentedVehicleReport();
        }

    }
}
