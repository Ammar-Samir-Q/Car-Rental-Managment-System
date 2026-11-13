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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListVehicles));
            cbFuelType = new ComboBox();
            label1 = new Label();
            txtFilter = new TextBox();
            cbFilter = new ComboBox();
            lblRecordsNumber = new Label();
            lblRecords = new Label();
            lblTitle = new Label();
            btnClose = new Button();
            dgvVehicles = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            infoToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            maintencaneHistoryToolStripMenuItem = new ToolStripMenuItem();
            vehicleRentHistoryToolStripMenuItem = new ToolStripMenuItem();
            cbVehicleCategory = new ComboBox();
            cbIsAvailable = new ComboBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbFuelType
            // 
            resources.ApplyResources(cbFuelType, "cbFuelType");
            cbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuelType.FormattingEnabled = true;
            cbFuelType.Items.AddRange(new object[] { resources.GetString("cbFuelType.Items"), resources.GetString("cbFuelType.Items1"), resources.GetString("cbFuelType.Items2"), resources.GetString("cbFuelType.Items3"), resources.GetString("cbFuelType.Items4"), resources.GetString("cbFuelType.Items5") });
            cbFuelType.Name = "cbFuelType";
            cbFuelType.SelectedIndexChanged += cbFuelType_SelectedIndexChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // txtFilter
            // 
            resources.ApplyResources(txtFilter, "txtFilter");
            txtFilter.Name = "txtFilter";
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // cbFilter
            // 
            resources.ApplyResources(cbFilter, "cbFilter");
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { resources.GetString("cbFilter.Items"), resources.GetString("cbFilter.Items1"), resources.GetString("cbFilter.Items2"), resources.GetString("cbFilter.Items3"), resources.GetString("cbFilter.Items4"), resources.GetString("cbFilter.Items5"), resources.GetString("cbFilter.Items6"), resources.GetString("cbFilter.Items7"), resources.GetString("cbFilter.Items8") });
            cbFilter.Name = "cbFilter";
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lblRecordsNumber
            // 
            resources.ApplyResources(lblRecordsNumber, "lblRecordsNumber");
            lblRecordsNumber.Name = "lblRecordsNumber";
            // 
            // lblRecords
            // 
            resources.ApplyResources(lblRecords, "lblRecords");
            lblRecords.Name = "lblRecords";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.Name = "lblTitle";
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvVehicles
            // 
            resources.ApplyResources(dgvVehicles, "dgvVehicles");
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.AllowUserToDeleteRows = false;
            dgvVehicles.AllowUserToOrderColumns = true;
            dgvVehicles.BackgroundColor = Color.White;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.ContextMenuStrip = contextMenuStrip1;
            dgvVehicles.MultiSelect = false;
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, maintenanceToolStripMenuItem, maintencaneHistoryToolStripMenuItem, vehicleRentHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            resources.ApplyResources(infoToolStripMenuItem, "infoToolStripMenuItem");
            infoToolStripMenuItem.Image = Properties.Resources.icon_info;
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
            editToolStripMenuItem.Image = Properties.Resources.icon_Edit;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(deleteToolStripMenuItem, "deleteToolStripMenuItem");
            deleteToolStripMenuItem.Image = Properties.Resources.icon_Delete32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // maintenanceToolStripMenuItem
            // 
            resources.ApplyResources(maintenanceToolStripMenuItem, "maintenanceToolStripMenuItem");
            maintenanceToolStripMenuItem.Image = Properties.Resources.icon_Maintenance;
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Click += maintenanceToolStripMenuItem_Click;
            // 
            // maintencaneHistoryToolStripMenuItem
            // 
            resources.ApplyResources(maintencaneHistoryToolStripMenuItem, "maintencaneHistoryToolStripMenuItem");
            maintencaneHistoryToolStripMenuItem.Image = Properties.Resources.icon_History;
            maintencaneHistoryToolStripMenuItem.Name = "maintencaneHistoryToolStripMenuItem";
            maintencaneHistoryToolStripMenuItem.Click += maintencaneHistoryToolStripMenuItem_Click;
            // 
            // vehicleRentHistoryToolStripMenuItem
            // 
            resources.ApplyResources(vehicleRentHistoryToolStripMenuItem, "vehicleRentHistoryToolStripMenuItem");
            vehicleRentHistoryToolStripMenuItem.Image = Properties.Resources.icon_History;
            vehicleRentHistoryToolStripMenuItem.Name = "vehicleRentHistoryToolStripMenuItem";
            vehicleRentHistoryToolStripMenuItem.Click += vehicleRentHistoryToolStripMenuItem_Click;
            // 
            // cbVehicleCategory
            // 
            resources.ApplyResources(cbVehicleCategory, "cbVehicleCategory");
            cbVehicleCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVehicleCategory.FormattingEnabled = true;
            cbVehicleCategory.Items.AddRange(new object[] { resources.GetString("cbVehicleCategory.Items"), resources.GetString("cbVehicleCategory.Items1"), resources.GetString("cbVehicleCategory.Items2"), resources.GetString("cbVehicleCategory.Items3"), resources.GetString("cbVehicleCategory.Items4"), resources.GetString("cbVehicleCategory.Items5"), resources.GetString("cbVehicleCategory.Items6"), resources.GetString("cbVehicleCategory.Items7"), resources.GetString("cbVehicleCategory.Items8"), resources.GetString("cbVehicleCategory.Items9"), resources.GetString("cbVehicleCategory.Items10"), resources.GetString("cbVehicleCategory.Items11") });
            cbVehicleCategory.Name = "cbVehicleCategory";
            cbVehicleCategory.SelectedIndexChanged += cbVehicleCategory_SelectedIndexChanged;
            // 
            // cbIsAvailable
            // 
            resources.ApplyResources(cbIsAvailable, "cbIsAvailable");
            cbIsAvailable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsAvailable.FormattingEnabled = true;
            cbIsAvailable.Items.AddRange(new object[] { resources.GetString("cbIsAvailable.Items"), resources.GetString("cbIsAvailable.Items1"), resources.GetString("cbIsAvailable.Items2") });
            cbIsAvailable.Name = "cbIsAvailable";
            cbIsAvailable.SelectedIndexChanged += cbIsAvailable_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.Icon_Filter;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.pngwing_com__3_;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Image = Properties.Resources.icon_Add;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmListVehicles
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            Controls.Add(button1);
            Controls.Add(cbIsAvailable);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cbVehicleCategory);
            Controls.Add(cbFuelType);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(lblRecordsNumber);
            Controls.Add(lblRecords);
            Controls.Add(btnClose);
            Controls.Add(dgvVehicles);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmListVehicles";
            Load += frmListVehicles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

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