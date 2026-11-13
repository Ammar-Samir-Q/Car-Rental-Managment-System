namespace CarRental
{
    partial class frmListPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPeople));
            dgvPeople = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            infoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            emailToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            convertToToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            lblRecords = new Label();
            lblRecordsNumber = new Label();
            cbFilter = new ComboBox();
            txtFilter = new TextBox();
            label1 = new Label();
            cbGender = new ComboBox();
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvPeople
            // 
            resources.ApplyResources(dgvPeople, "dgvPeople");
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToOrderColumns = true;
            dgvPeople.BackgroundColor = Color.White;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = contextMenuStrip1;
            dgvPeople.MultiSelect = false;
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, toolStripSeparator1, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator2, phoneCallToolStripMenuItem, emailToolStripMenuItem, toolStripSeparator3, convertToToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            resources.ApplyResources(infoToolStripMenuItem, "infoToolStripMenuItem");
            infoToolStripMenuItem.Image = Properties.Resources.icon_info;
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.Name = "toolStripSeparator1";
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
            // toolStripSeparator2
            // 
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // phoneCallToolStripMenuItem
            // 
            resources.ApplyResources(phoneCallToolStripMenuItem, "phoneCallToolStripMenuItem");
            phoneCallToolStripMenuItem.Image = Properties.Resources.icon_Phone;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            // 
            // emailToolStripMenuItem
            // 
            resources.ApplyResources(emailToolStripMenuItem, "emailToolStripMenuItem");
            emailToolStripMenuItem.Image = Properties.Resources.icon_email32;
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // convertToToolStripMenuItem
            // 
            resources.ApplyResources(convertToToolStripMenuItem, "convertToToolStripMenuItem");
            convertToToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, customerToolStripMenuItem });
            convertToToolStripMenuItem.Image = Properties.Resources.icon_Arrow;
            convertToToolStripMenuItem.Name = "convertToToolStripMenuItem";
            // 
            // userToolStripMenuItem
            // 
            resources.ApplyResources(userToolStripMenuItem, "userToolStripMenuItem");
            userToolStripMenuItem.Image = Properties.Resources.icon_User;
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            resources.ApplyResources(customerToolStripMenuItem, "customerToolStripMenuItem");
            customerToolStripMenuItem.Image = Properties.Resources.icon_Customer;
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblRecords
            // 
            resources.ApplyResources(lblRecords, "lblRecords");
            lblRecords.Name = "lblRecords";
            // 
            // lblRecordsNumber
            // 
            resources.ApplyResources(lblRecordsNumber, "lblRecordsNumber");
            lblRecordsNumber.Name = "lblRecordsNumber";
            // 
            // cbFilter
            // 
            resources.ApplyResources(cbFilter, "cbFilter");
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Name = "cbFilter";
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // txtFilter
            // 
            resources.ApplyResources(txtFilter, "txtFilter");
            txtFilter.Name = "txtFilter";
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
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
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.BackColor = Color.Transparent;
            lblTitle.ForeColor = Color.Black;
            lblTitle.Name = "lblTitle";
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
            pictureBox1.Image = Properties.Resources.png_Users;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Image = Properties.Resources.icon_Add;
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmListPeople
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            Controls.Add(pictureBox2);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(cbGender);
            Controls.Add(label1);
            Controls.Add(txtFilter);
            Controls.Add(cbFilter);
            Controls.Add(lblRecordsNumber);
            Controls.Add(lblRecords);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(dgvPeople);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmListPeople";
            Load += frmListPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}