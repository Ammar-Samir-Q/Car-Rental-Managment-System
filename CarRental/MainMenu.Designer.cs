namespace CarRental
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ايجارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VehiclesToolMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.showVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allPeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainteanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsernameTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalVehicles = new System.Windows.Forms.Label();
            this.lblTitleTotalVehicles = new System.Windows.Forms.Label();
            this.lblTitleTotalCustomers = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTitleTotalRents = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalRents = new System.Windows.Forms.Label();
            this.lblTitleTotalBookings = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalBookings = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ايجارToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.VehiclesToolMenuStrip,
            this.PeopleToolStripMenuItem,
            this.mainteanceToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ايجارToolStripMenuItem
            // 
            resources.ApplyResources(this.ايجارToolStripMenuItem, "ايجارToolStripMenuItem");
            this.ايجارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.manageRentsToolStripMenuItem});
            this.ايجارToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Booking;
            this.ايجارToolStripMenuItem.Name = "ايجارToolStripMenuItem";
            // 
            // addRentToolStripMenuItem
            // 
            resources.ApplyResources(this.addRentToolStripMenuItem, "addRentToolStripMenuItem");
            this.addRentToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_AddRent;
            this.addRentToolStripMenuItem.Name = "addRentToolStripMenuItem";
            this.addRentToolStripMenuItem.Click += new System.EventHandler(this.addRentToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            resources.ApplyResources(this.returnToolStripMenuItem, "returnToolStripMenuItem");
            this.returnToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Rent;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // manageRentsToolStripMenuItem
            // 
            resources.ApplyResources(this.manageRentsToolStripMenuItem, "manageRentsToolStripMenuItem");
            this.manageRentsToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_ManageRents;
            this.manageRentsToolStripMenuItem.Name = "manageRentsToolStripMenuItem";
            this.manageRentsToolStripMenuItem.Click += new System.EventHandler(this.manageRentsToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            resources.ApplyResources(this.transactionsToolStripMenuItem, "transactionsToolStripMenuItem");
            this.transactionsToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Transactions;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // VehiclesToolMenuStrip
            // 
            resources.ApplyResources(this.VehiclesToolMenuStrip, "VehiclesToolMenuStrip");
            this.VehiclesToolMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showVehiclesToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem});
            this.VehiclesToolMenuStrip.Image = global::CarRental.Properties.Resources.icons8_vehicle_50;
            this.VehiclesToolMenuStrip.Name = "VehiclesToolMenuStrip";
            // 
            // showVehiclesToolStripMenuItem
            // 
            resources.ApplyResources(this.showVehiclesToolStripMenuItem, "showVehiclesToolStripMenuItem");
            this.showVehiclesToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Description;
            this.showVehiclesToolStripMenuItem.Name = "showVehiclesToolStripMenuItem";
            this.showVehiclesToolStripMenuItem.Click += new System.EventHandler(this.showVehiclesToolStripMenuItem_Click);
            // 
            // manageVehiclesToolStripMenuItem
            // 
            resources.ApplyResources(this.manageVehiclesToolStripMenuItem, "manageVehiclesToolStripMenuItem");
            this.manageVehiclesToolStripMenuItem.Image = global::CarRental.Properties.Resources.icons8_vehicle_50;
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Click += new System.EventHandler(this.manageVehiiclesToolStripMenuItem_Click);
            // 
            // PeopleToolStripMenuItem
            // 
            resources.ApplyResources(this.PeopleToolStripMenuItem, "PeopleToolStripMenuItem");
            this.PeopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.usersToolStripMenuItem1,
            this.allPeopleToolStripMenuItem});
            this.PeopleToolStripMenuItem.Image = global::CarRental.Properties.Resources.Users;
            this.PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem";
            // 
            // customersToolStripMenuItem
            // 
            resources.ApplyResources(this.customersToolStripMenuItem, "customersToolStripMenuItem");
            this.customersToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Customer;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem1
            // 
            resources.ApplyResources(this.usersToolStripMenuItem1, "usersToolStripMenuItem1");
            this.usersToolStripMenuItem1.Image = global::CarRental.Properties.Resources.icon_User;
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem1_Click);
            // 
            // allPeopleToolStripMenuItem
            // 
            resources.ApplyResources(this.allPeopleToolStripMenuItem, "allPeopleToolStripMenuItem");
            this.allPeopleToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Arrow;
            this.allPeopleToolStripMenuItem.Name = "allPeopleToolStripMenuItem";
            this.allPeopleToolStripMenuItem.Click += new System.EventHandler(this.allPeopleToolStripMenuItem_Click);
            // 
            // mainteanceToolStripMenuItem
            // 
            resources.ApplyResources(this.mainteanceToolStripMenuItem, "mainteanceToolStripMenuItem");
            this.mainteanceToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Maintenance;
            this.mainteanceToolStripMenuItem.Name = "mainteanceToolStripMenuItem";
            this.mainteanceToolStripMenuItem.Click += new System.EventHandler(this.mainteanceToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            resources.ApplyResources(this.staticsToolStripMenuItem, "staticsToolStripMenuItem");
            this.staticsToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_FuelLevel;
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Click += new System.EventHandler(this.staticsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSettingsToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = global::CarRental.Properties.Resources.Icon_Manage2;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // accountSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.accountSettingsToolStripMenuItem, "accountSettingsToolStripMenuItem");
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_accountsettings;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            resources.ApplyResources(this.currentUserInfoToolStripMenuItem, "currentUserInfoToolStripMenuItem");
            this.currentUserInfoToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Name;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Image = global::CarRental.Properties.Resources.iconPassword;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            resources.ApplyResources(this.systemToolStripMenuItem, "systemToolStripMenuItem");
            this.systemToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Settings;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Click += new System.EventHandler(this.systemToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            resources.ApplyResources(this.signOutToolStripMenuItem, "signOutToolStripMenuItem");
            this.signOutToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_SignOut;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            resources.ApplyResources(this.exitApplicationToolStripMenuItem, "exitApplicationToolStripMenuItem");
            this.exitApplicationToolStripMenuItem.Image = global::CarRental.Properties.Resources.icon_Shutdown2;
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // lblUsernameTitle
            // 
            resources.ApplyResources(this.lblUsernameTitle, "lblUsernameTitle");
            this.lblUsernameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameTitle.ForeColor = System.Drawing.Color.White;
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Name = "lblTitle";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CarRental.Properties.Resources.MainLogo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalVehicles);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Name = "panel1";
            // 
            // lblTotalVehicles
            // 
            resources.ApplyResources(this.lblTotalVehicles, "lblTotalVehicles");
            this.lblTotalVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVehicles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalVehicles.Name = "lblTotalVehicles";
            // 
            // lblTitleTotalVehicles
            // 
            resources.ApplyResources(this.lblTitleTotalVehicles, "lblTitleTotalVehicles");
            this.lblTitleTotalVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTotalVehicles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleTotalVehicles.Name = "lblTitleTotalVehicles";
            // 
            // lblTitleTotalCustomers
            // 
            resources.ApplyResources(this.lblTitleTotalCustomers, "lblTitleTotalCustomers");
            this.lblTitleTotalCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTotalCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleTotalCustomers.Name = "lblTitleTotalCustomers";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalCustomers);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Name = "panel2";
            // 
            // lblTotalCustomers
            // 
            resources.ApplyResources(this.lblTotalCustomers, "lblTotalCustomers");
            this.lblTotalCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            // 
            // lblTitleTotalRents
            // 
            resources.ApplyResources(this.lblTitleTotalRents, "lblTitleTotalRents");
            this.lblTitleTotalRents.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTotalRents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleTotalRents.Name = "lblTitleTotalRents";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalRents);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Name = "panel3";
            // 
            // lblTotalRents
            // 
            resources.ApplyResources(this.lblTotalRents, "lblTotalRents");
            this.lblTotalRents.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalRents.Name = "lblTotalRents";
            // 
            // lblTitleTotalBookings
            // 
            resources.ApplyResources(this.lblTitleTotalBookings, "lblTitleTotalBookings");
            this.lblTitleTotalBookings.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTotalBookings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleTotalBookings.Name = "lblTitleTotalBookings";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTotalBookings);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Name = "panel4";
            // 
            // lblTotalBookings
            // 
            resources.ApplyResources(this.lblTotalBookings, "lblTotalBookings");
            this.lblTotalBookings.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBookings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalBookings.Name = "lblTotalBookings";
            // 
            // lblRole
            // 
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRole.Name = "lblRole";
            // 
            // pbUserImage
            // 
            resources.ApplyResources(this.pbUserImage, "pbUserImage");
            this.pbUserImage.BackColor = System.Drawing.Color.Transparent;
            this.pbUserImage.Image = global::CarRental.Properties.Resources.icon_User;
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.TabStop = false;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblTitleTotalBookings);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblTitleTotalRents);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTitleTotalCustomers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitleTotalVehicles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUsernameTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ايجارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VehiclesToolMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainteanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allPeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalVehicles;
        private System.Windows.Forms.Label lblTitleTotalVehicles;
        private System.Windows.Forms.Label lblTitleTotalCustomers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTitleTotalRents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalRents;
        private System.Windows.Forms.Label lblTitleTotalBookings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalBookings;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ToolStripMenuItem showVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbUserImage;
    }
}

