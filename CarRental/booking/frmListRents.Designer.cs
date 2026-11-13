namespace CarRental
{
    partial class frmListRents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListRents));
            label1 = new Label();
            txtFilter = new TextBox();
            cbFilter = new ComboBox();
            lblRecordsNumber = new Label();
            lblRecords = new Label();
            lblTitle = new Label();
            btnClose = new Button();
            dgvRents = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            infoToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            setReturnToolStripMenuItem = new ToolStripMenuItem();
            returnInfoToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            btnAdd = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRents).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            cbFilter.Items.AddRange(new object[] { resources.GetString("cbFilter.Items"), resources.GetString("cbFilter.Items1"), resources.GetString("cbFilter.Items2"), resources.GetString("cbFilter.Items3"), resources.GetString("cbFilter.Items4") });
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
            // dgvRents
            // 
            resources.ApplyResources(dgvRents, "dgvRents");
            dgvRents.AllowUserToAddRows = false;
            dgvRents.AllowUserToDeleteRows = false;
            dgvRents.AllowUserToOrderColumns = true;
            dgvRents.BackgroundColor = Color.White;
            dgvRents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRents.ContextMenuStrip = contextMenuStrip1;
            dgvRents.MultiSelect = false;
            dgvRents.Name = "dgvRents";
            dgvRents.ReadOnly = true;
            dgvRents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, editToolStripMenuItem, setReturnToolStripMenuItem, returnInfoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
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
            // setReturnToolStripMenuItem
            // 
            resources.ApplyResources(setReturnToolStripMenuItem, "setReturnToolStripMenuItem");
            setReturnToolStripMenuItem.Image = Properties.Resources.icon_Arrow;
            setReturnToolStripMenuItem.Name = "setReturnToolStripMenuItem";
            setReturnToolStripMenuItem.Click += setReturnToolStripMenuItem_Click;
            // 
            // returnInfoToolStripMenuItem
            // 
            resources.ApplyResources(returnInfoToolStripMenuItem, "returnInfoToolStripMenuItem");
            returnInfoToolStripMenuItem.Image = Properties.Resources.icon_Rent;
            returnInfoToolStripMenuItem.Name = "returnInfoToolStripMenuItem";
            returnInfoToolStripMenuItem.Click += returnInfoToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.Icon_Filter;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Image = Properties.Resources.icon_Add;
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.png_RentKey;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // frmListRents
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(lblRecordsNumber);
            Controls.Add(lblRecords);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(dgvRents);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmListRents";
            Load += frmListRents_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRents).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRents;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnInfoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}