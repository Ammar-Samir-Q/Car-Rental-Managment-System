namespace CarRental
{
    partial class frmSelectVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectVehicle));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonbtnClose1 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvAvailableVehicles = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlVehicleInfo1 = new CarRental.ctrlVehicleInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableVehicles)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonbtnClose1
            // 
            resources.ApplyResources(this.buttonbtnClose1, "buttonbtnClose1");
            this.buttonbtnClose1.Name = "buttonbtnClose1";
            this.buttonbtnClose1.UseVisualStyleBackColor = true;
            this.buttonbtnClose1.Click += new System.EventHandler(this.buttonbtnClose1_Click);
            // 
            // btnSelect
            // 
            resources.ApplyResources(this.btnSelect, "btnSelect");
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvAvailableVehicles
            // 
            resources.ApplyResources(this.dgvAvailableVehicles, "dgvAvailableVehicles");
            this.dgvAvailableVehicles.AllowUserToAddRows = false;
            this.dgvAvailableVehicles.AllowUserToDeleteRows = false;
            this.dgvAvailableVehicles.AllowUserToOrderColumns = true;
            this.dgvAvailableVehicles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAvailableVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableVehicles.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAvailableVehicles.MultiSelect = false;
            this.dgvAvailableVehicles.Name = "dgvAvailableVehicles";
            this.dgvAvailableVehicles.ReadOnly = true;
            this.dgvAvailableVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableVehicles_CellClick);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            resources.ApplyResources(this.selectToolStripMenuItem, "selectToolStripMenuItem");
            this.selectToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Arrow;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // ctrlVehicleInfo1
            // 
            resources.ApplyResources(this.ctrlVehicleInfo1, "ctrlVehicleInfo1");
            this.ctrlVehicleInfo1.Name = "ctrlVehicleInfo1";
            // 
            // frmSelectVehicle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.ctrlVehicleInfo1);
            this.Controls.Add(this.dgvAvailableVehicles);
            this.Controls.Add(this.buttonbtnClose1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmSelectVehicle";
            this.Load += new System.EventHandler(this.frmSelectVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableVehicles)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonbtnClose1;
        private System.Windows.Forms.Button btnSelect;
        private ctrlVehicleInfo ctrlVehicleInfo1;
        private System.Windows.Forms.DataGridView dgvAvailableVehicles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
    }
}