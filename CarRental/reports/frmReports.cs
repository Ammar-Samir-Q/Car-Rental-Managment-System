//using CarRental.BLL;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

//namespace CarRental
//{
//    public partial class frmReports : Form
//    {
//        public frmReports()
//        {
//            InitializeComponent();
//        }

//        private void btnClose_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void _SetReportsFlow()
//        {
//            flowLayoutPanel1.AutoScroll = true;
//            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
//            flowLayoutPanel1.WrapContents = true;
//            ctrlReport report1 = new ctrlReport();
//            report1.LoadReport("Total Customers", Customer.GetTotalCustomers());
//            ctrlReport report2 = new ctrlReport();
//            report2.LoadReport("Total Vehicles", Vehicle.GetTotalVehicles());
//            ctrlReport report3 = new ctrlReport();
//            report3.LoadReport("Total Bookings",Booking.GetTotalBookings());
//            ctrlReport report4 = new ctrlReport();
//            report4.LoadReport("Total Rents", Booking.GetTotalCompletedRents());


//            flowLayoutPanel1.Controls.Add(report1);
//            flowLayoutPanel1.Controls.Add(report2);
//            flowLayoutPanel1.Controls.Add(report3);
//            flowLayoutPanel1.Controls.Add(report4);
//        }
        
//        private void _SetCharts()
//        {
         
        
//            chartTotalBookings.DataSource=Transaction.GetRentReportData();
//            chartDailyEarnings.DataSource = Transaction.GetDailyReportData();            
//            chartVehicles.DataSource = Booking.GetTotalRentTimesVehicleReport();

//            DataTable dtVehiclesCount=Booking.GetVehiclesCountReport();

//            var SeriesEarnings=new Series();
//            SeriesEarnings.Name = "Earnings";
//            SeriesEarnings.ChartType=SeriesChartType.Column;
//            SeriesEarnings.XValueMember = "Date";
//            SeriesEarnings.YValueMembers = "Total";
//            SeriesEarnings.IsValueShownAsLabel = true;
            
//            var SeriesRents = new Series();
//            SeriesRents.Name = "Bookings";
//            SeriesRents.ChartType=SeriesChartType.Column;
//            SeriesRents.XValueMember = "Date";
//            SeriesRents.YValueMembers = "TotalRents";
//            SeriesRents.IsValueShownAsLabel= true;


//            var SeriesVehicles = new Series();
//            SeriesVehicles.Name = "Vehicles";
//            SeriesVehicles.ChartType = SeriesChartType.Bar;
//            SeriesVehicles.XValueMember = "ModelName";
//            SeriesVehicles.YValueMembers = "TotalRentTimes";
//            SeriesVehicles.IsValueShownAsLabel=true;
            


//            var SeriesVehiclesCount = new Series();
//            SeriesVehiclesCount.Name = "Number";
//            SeriesVehiclesCount.ChartType = SeriesChartType.Pie;
//            SeriesVehiclesCount.XValueMember = "Available";
//            SeriesVehiclesCount.YValueMembers = "NotAvailable";
//            SeriesVehiclesCount.IsValueShownAsLabel= true;

//            chartDailyEarnings.Series.Add(SeriesEarnings);
//            chartDailyEarnings.DataBind();

//            chartTotalBookings.Series.Add(SeriesRents);
//            chartTotalBookings.DataBind();

//            chartVehicles.Series.Add(SeriesVehicles);
//            chartVehicles.DataBind();

//            int Available = (int)dtVehiclesCount.Rows[0]["Available"];
//            int UnAvailable = (int)dtVehiclesCount.Rows[0]["NotAvailable"];
//            SeriesVehiclesCount.Points.AddXY("UnAvailable", UnAvailable);
//            SeriesVehiclesCount.Points.AddXY("Available", Available);

//            chartAvailableVehicles.Series.Add(SeriesVehiclesCount);
//            chartAvailableVehicles.DataBind();


//        }
//        private void frmReports_Load(object sender, EventArgs e)
//        {
//            _SetReportsFlow();
//            _SetCharts();
//        }
//    }
//}
