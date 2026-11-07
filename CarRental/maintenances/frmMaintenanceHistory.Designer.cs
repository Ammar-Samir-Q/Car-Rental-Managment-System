namespace CarRental
{
    partial class frmMaintenanceHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceHistory));
            this.dgvMaintenanceHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlVehicleInfo1 = new CarRental.ctrlVehicleInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceHistory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaintenanceHistory
            // 
            resources.ApplyResources(this.dgvMaintenanceHistory, "dgvMaintenanceHistory");
            this.dgvMaintenanceHistory.AllowUserToAddRows = false;
            this.dgvMaintenanceHistory.AllowUserToDeleteRows = false;
            this.dgvMaintenanceHistory.AllowUserToOrderColumns = true;
            this.dgvMaintenanceHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMaintenanceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMaintenanceHistory.MultiSelect = false;
            this.dgvMaintenanceHistory.Name = "dgvMaintenanceHistory";
            this.dgvMaintenanceHistory.ReadOnly = true;
            this.dgvMaintenanceHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ctrlVehicleInfo1
            // 
            resources.ApplyResources(this.ctrlVehicleInfo1, "ctrlVehicleInfo1");
            this.ctrlVehicleInfo1.Name = "ctrlVehicleInfo1";
            // 
            // frmMaintenanceHistory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMaintenanceHistory);
            this.Controls.Add(this.ctrlVehicleInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMaintenanceHistory";
            this.Load += new System.EventHandler(this.frmMaintenanceHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceHistory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlVehicleInfo ctrlVehicleInfo1;
        private System.Windows.Forms.DataGridView dgvMaintenanceHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}