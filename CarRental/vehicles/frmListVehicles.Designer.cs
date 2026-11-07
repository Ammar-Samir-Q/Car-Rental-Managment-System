namespace CarRental
{
    partial class frmListVehicles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListVehicles));
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintencaneHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleRentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbVehicleCategory = new System.Windows.Forms.ComboBox();
            this.cbIsAvailable = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFuelType
            // 
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbFuelType, "cbFuelType");
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Items.AddRange(new object[] {
            resources.GetString("cbFuelType.Items"),
            resources.GetString("cbFuelType.Items1"),
            resources.GetString("cbFuelType.Items2"),
            resources.GetString("cbFuelType.Items3"),
            resources.GetString("cbFuelType.Items4"),
            resources.GetString("cbFuelType.Items5")});
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.SelectedIndexChanged += new System.EventHandler(this.cbFuelType_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtFilter
            // 
            resources.ApplyResources(this.txtFilter, "txtFilter");
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbFilter, "cbFilter");
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            resources.GetString("cbFilter.Items"),
            resources.GetString("cbFilter.Items1"),
            resources.GetString("cbFilter.Items2"),
            resources.GetString("cbFilter.Items3"),
            resources.GetString("cbFilter.Items4"),
            resources.GetString("cbFilter.Items5"),
            resources.GetString("cbFilter.Items6"),
            resources.GetString("cbFilter.Items7"),
            resources.GetString("cbFilter.Items8")});
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblRecordsNumber
            // 
            resources.ApplyResources(this.lblRecordsNumber, "lblRecordsNumber");
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            // 
            // lblRecords
            // 
            resources.ApplyResources(this.lblRecords, "lblRecords");
            this.lblRecords.Name = "lblRecords";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToOrderColumns = true;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dgvVehicles, "dgvVehicles");
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.maintencaneHistoryToolStripMenuItem,
            this.vehicleRentHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_info;
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Edit;
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Delete32;
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Maintenance;
            resources.ApplyResources(this.maintenanceToolStripMenuItem, "maintenanceToolStripMenuItem");
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // maintencaneHistoryToolStripMenuItem
            // 
            this.maintencaneHistoryToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_History;
            resources.ApplyResources(this.maintencaneHistoryToolStripMenuItem, "maintencaneHistoryToolStripMenuItem");
            this.maintencaneHistoryToolStripMenuItem.Name = "maintencaneHistoryToolStripMenuItem";
            this.maintencaneHistoryToolStripMenuItem.Click += new System.EventHandler(this.maintencaneHistoryToolStripMenuItem_Click);
            // 
            // vehicleRentHistoryToolStripMenuItem
            // 
            this.vehicleRentHistoryToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_History;
            resources.ApplyResources(this.vehicleRentHistoryToolStripMenuItem, "vehicleRentHistoryToolStripMenuItem");
            this.vehicleRentHistoryToolStripMenuItem.Name = "vehicleRentHistoryToolStripMenuItem";
            this.vehicleRentHistoryToolStripMenuItem.Click += new System.EventHandler(this.vehicleRentHistoryToolStripMenuItem_Click);
            // 
            // cbVehicleCategory
            // 
            this.cbVehicleCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbVehicleCategory, "cbVehicleCategory");
            this.cbVehicleCategory.FormattingEnabled = true;
            this.cbVehicleCategory.Items.AddRange(new object[] {
            resources.GetString("cbVehicleCategory.Items"),
            resources.GetString("cbVehicleCategory.Items1"),
            resources.GetString("cbVehicleCategory.Items2"),
            resources.GetString("cbVehicleCategory.Items3"),
            resources.GetString("cbVehicleCategory.Items4"),
            resources.GetString("cbVehicleCategory.Items5"),
            resources.GetString("cbVehicleCategory.Items6"),
            resources.GetString("cbVehicleCategory.Items7"),
            resources.GetString("cbVehicleCategory.Items8"),
            resources.GetString("cbVehicleCategory.Items9"),
            resources.GetString("cbVehicleCategory.Items10"),
            resources.GetString("cbVehicleCategory.Items11")});
            this.cbVehicleCategory.Name = "cbVehicleCategory";
            this.cbVehicleCategory.SelectedIndexChanged += new System.EventHandler(this.cbVehicleCategory_SelectedIndexChanged);
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbIsAvailable, "cbIsAvailable");
            this.cbIsAvailable.FormattingEnabled = true;
            this.cbIsAvailable.Items.AddRange(new object[] {
            resources.GetString("cbIsAvailable.Items"),
            resources.GetString("cbIsAvailable.Items1"),
            resources.GetString("cbIsAvailable.Items2")});
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.SelectedIndexChanged += new System.EventHandler(this.cbIsAvailable_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRental.Properties.Resources.Icon_Filter;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.pngwing_com__3_;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::CarRental.Properties.Resources.icon_Add;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListVehicles
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbIsAvailable);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbVehicleCategory);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmListVehicles";
            this.Load += new System.EventHandler(this.frmListVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFuelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.ComboBox cbVehicleCategory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbIsAvailable;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintencaneHistoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem vehicleRentHistoryToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}