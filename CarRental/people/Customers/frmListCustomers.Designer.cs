namespace CarRental
{
    partial class frmListCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListCustomers));
            cbGender = new ComboBox();
            label1 = new Label();
            txtFilter = new TextBox();
            cbFilter = new ComboBox();
            lblRecordsNumber = new Label();
            lblRecords = new Label();
            lblTitle = new Label();
            btnClose = new Button();
            dgvCustomers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            infoToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            showRentHistoryToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cbGender
            // 
            resources.ApplyResources(cbGender, "cbGender");
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { resources.GetString("cbGender.Items"), resources.GetString("cbGender.Items1"), resources.GetString("cbGender.Items2") });
            cbGender.Name = "cbGender";
            cbGender.SelectedIndexChanged += cbGender_SelectedIndexChanged;
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
            cbFilter.Items.AddRange(new object[] { resources.GetString("cbFilter.Items"), resources.GetString("cbFilter.Items1"), resources.GetString("cbFilter.Items2"), resources.GetString("cbFilter.Items3"), resources.GetString("cbFilter.Items4"), resources.GetString("cbFilter.Items5"), resources.GetString("cbFilter.Items6") });
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
            // dgvCustomers
            // 
            resources.ApplyResources(dgvCustomers, "dgvCustomers");
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToOrderColumns = true;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.ContextMenuStrip = contextMenuStrip1;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, showRentHistoryToolStripMenuItem });
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
            // showRentHistoryToolStripMenuItem
            // 
            resources.ApplyResources(showRentHistoryToolStripMenuItem, "showRentHistoryToolStripMenuItem");
            showRentHistoryToolStripMenuItem.Image = Properties.Resources.icon_History;
            showRentHistoryToolStripMenuItem.Name = "showRentHistoryToolStripMenuItem";
            showRentHistoryToolStripMenuItem.Click += showRentHistoryToolStripMenuItem_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Image = Properties.Resources.icon_Add;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.png_People;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.Icon_Filter;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // frmListCustomers
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(cbGender);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(lblRecordsNumber);
            Controls.Add(lblRecords);
            Controls.Add(btnClose);
            Controls.Add(dgvCustomers);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmListCustomers";
            Load += frmListCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRentHistoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}