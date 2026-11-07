//namespace CarRental
//{
//    partial class frmReports
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
//            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
//            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
//            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
//            this.label1 = new System.Windows.Forms.Label();
//            this.btnClose = new System.Windows.Forms.Button();
//            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
//            this.chartVehicles = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            this.chartTotalBookings = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            this.chartDailyEarnings = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            this.chartAvailableVehicles = new System.Windows.Forms.DataVisualization.Charting.Chart();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.flowLayoutPanel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.chartVehicles)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chartTotalBookings)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chartDailyEarnings)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chartAvailableVehicles)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            resources.ApplyResources(this.label1, "label1");
//            this.label1.Name = "label1";
//            // 
//            // btnClose
//            // 
//            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            resources.ApplyResources(this.btnClose, "btnClose");
//            this.btnClose.Name = "btnClose";
//            this.btnClose.UseVisualStyleBackColor = true;
//            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
//            // 
//            // flowLayoutPanel1
//            // 
//            this.flowLayoutPanel1.Controls.Add(this.chartVehicles);
//            this.flowLayoutPanel1.Controls.Add(this.chartTotalBookings);
//            this.flowLayoutPanel1.Controls.Add(this.chartDailyEarnings);
//            this.flowLayoutPanel1.Controls.Add(this.chartAvailableVehicles);
//            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
//            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
//            // 
//            // chartVehicles
//            // 
//            this.chartVehicles.BackColor = System.Drawing.Color.Transparent;
//            this.chartVehicles.BorderlineColor = System.Drawing.Color.Transparent;
//            chartArea1.Name = "ChartArea1";
//            this.chartVehicles.ChartAreas.Add(chartArea1);
//            legend1.Name = "Legend1";
//            this.chartVehicles.Legends.Add(legend1);
//            resources.ApplyResources(this.chartVehicles, "chartVehicles");
//            this.chartVehicles.Name = "chartVehicles";
//            this.chartVehicles.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
//            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            title1.Name = "Title1";
//            title1.Text = "Most Rented Vehicles";
//            this.chartVehicles.Titles.Add(title1);
//            // 
//            // chartTotalBookings
//            // 
//            this.chartTotalBookings.BackColor = System.Drawing.Color.Transparent;
//            this.chartTotalBookings.BorderlineColor = System.Drawing.Color.Transparent;
//            chartArea2.Name = "ChartArea1";
//            this.chartTotalBookings.ChartAreas.Add(chartArea2);
//            legend2.Name = "Legend1";
//            this.chartTotalBookings.Legends.Add(legend2);
//            resources.ApplyResources(this.chartTotalBookings, "chartTotalBookings");
//            this.chartTotalBookings.Name = "chartTotalBookings";
//            this.chartTotalBookings.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
//            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            title2.Name = "Title1";
//            title2.Text = "Total Daily Bookings";
//            this.chartTotalBookings.Titles.Add(title2);
//            // 
//            // chartDailyEarnings
//            // 
//            this.chartDailyEarnings.BackColor = System.Drawing.Color.Transparent;
//            this.chartDailyEarnings.BorderlineColor = System.Drawing.Color.Transparent;
//            chartArea3.Name = "ChartArea1";
//            this.chartDailyEarnings.ChartAreas.Add(chartArea3);
//            legend3.Name = "Legend1";
//            this.chartDailyEarnings.Legends.Add(legend3);
//            resources.ApplyResources(this.chartDailyEarnings, "chartDailyEarnings");
//            this.chartDailyEarnings.Name = "chartDailyEarnings";
//            this.chartDailyEarnings.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
//            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            title3.Name = "Title1";
//            title3.Text = "Total Daily Earnings";
//            this.chartDailyEarnings.Titles.Add(title3);
//            // 
//            // chartAvailableVehicles
//            // 
//            this.chartAvailableVehicles.BackColor = System.Drawing.Color.Transparent;
//            this.chartAvailableVehicles.BorderlineColor = System.Drawing.Color.Transparent;
//            chartArea4.Name = "ChartArea1";
//            this.chartAvailableVehicles.ChartAreas.Add(chartArea4);
//            legend4.Name = "Legend1";
//            this.chartAvailableVehicles.Legends.Add(legend4);
//            resources.ApplyResources(this.chartAvailableVehicles, "chartAvailableVehicles");
//            this.chartAvailableVehicles.Name = "chartAvailableVehicles";
//            this.chartAvailableVehicles.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
//            this.chartAvailableVehicles.PaletteCustomColors = new System.Drawing.Color[] {
//        System.Drawing.Color.LightCoral,
//        System.Drawing.Color.PaleGreen};
//            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            title4.Name = "Title1";
//            title4.Text = "Total Avaliable/Unavailable Vehicles";
//            this.chartAvailableVehicles.Titles.Add(title4);
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.Image = global::CarRental.Properties.Resources.icon_FuelLevel;
//            resources.ApplyResources(this.pictureBox1, "pictureBox1");
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.TabStop = false;
//            // 
//            // frmReports
//            // 
//            resources.ApplyResources(this, "$this");
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.White;
//            this.CancelButton = this.btnClose;
//            this.Controls.Add(this.pictureBox1);
//            this.Controls.Add(this.flowLayoutPanel1);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.btnClose);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;
//            this.Name = "frmReports";
//            this.Load += new System.EventHandler(this.frmReports_Load);
//            this.flowLayoutPanel1.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.chartVehicles)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chartTotalBookings)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chartDailyEarnings)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.chartAvailableVehicles)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Button btnClose;
//        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
//        private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyEarnings;
//        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalBookings;
//        private System.Windows.Forms.DataVisualization.Charting.Chart chartVehicles;
//        private System.Windows.Forms.DataVisualization.Charting.Chart chartAvailableVehicles;
//        private System.Windows.Forms.PictureBox pictureBox1;
//    }
//}