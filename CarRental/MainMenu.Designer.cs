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
            menuStrip1 = new MenuStrip();
            ايجارToolStripMenuItem = new ToolStripMenuItem();
            addRentToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            manageRentsToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            VehiclesToolMenuStrip = new ToolStripMenuItem();
            showVehiclesToolStripMenuItem = new ToolStripMenuItem();
            manageVehiclesToolStripMenuItem = new ToolStripMenuItem();
            PeopleToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem1 = new ToolStripMenuItem();
            allPeopleToolStripMenuItem = new ToolStripMenuItem();
            mainteanceToolStripMenuItem = new ToolStripMenuItem();
            staticsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            lblUsernameTitle = new Label();
            lblUsername = new Label();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblTotalVehicles = new Label();
            lblTitleTotalVehicles = new Label();
            lblTitleTotalCustomers = new Label();
            panel2 = new Panel();
            lblTotalCustomers = new Label();
            lblTitleTotalRents = new Label();
            panel3 = new Panel();
            lblTotalRents = new Label();
            lblTitleTotalBookings = new Label();
            panel4 = new Panel();
            lblTotalBookings = new Label();
            lblRole = new Label();
            pbUserImage = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ايجارToolStripMenuItem, transactionsToolStripMenuItem, VehiclesToolMenuStrip, PeopleToolStripMenuItem, mainteanceToolStripMenuItem, staticsToolStripMenuItem, settingsToolStripMenuItem, exitApplicationToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // ايجارToolStripMenuItem
            // 
            resources.ApplyResources(ايجارToolStripMenuItem, "ايجارToolStripMenuItem");
            ايجارToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addRentToolStripMenuItem, returnToolStripMenuItem, manageRentsToolStripMenuItem });
            ايجارToolStripMenuItem.Image = Properties.Resources.icon_Booking;
            ايجارToolStripMenuItem.Name = "ايجارToolStripMenuItem";
            // 
            // addRentToolStripMenuItem
            // 
            resources.ApplyResources(addRentToolStripMenuItem, "addRentToolStripMenuItem");
            addRentToolStripMenuItem.Image = Properties.Resources.icon_AddRent;
            addRentToolStripMenuItem.Name = "addRentToolStripMenuItem";
            addRentToolStripMenuItem.Click += addRentToolStripMenuItem_Click;
            // 
            // returnToolStripMenuItem
            // 
            resources.ApplyResources(returnToolStripMenuItem, "returnToolStripMenuItem");
            returnToolStripMenuItem.Image = Properties.Resources.icon_Rent;
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Click += returnToolStripMenuItem_Click;
            // 
            // manageRentsToolStripMenuItem
            // 
            resources.ApplyResources(manageRentsToolStripMenuItem, "manageRentsToolStripMenuItem");
            manageRentsToolStripMenuItem.Image = Properties.Resources.icon_ManageRents;
            manageRentsToolStripMenuItem.Name = "manageRentsToolStripMenuItem";
            manageRentsToolStripMenuItem.Click += manageRentsToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            resources.ApplyResources(transactionsToolStripMenuItem, "transactionsToolStripMenuItem");
            transactionsToolStripMenuItem.Image = Properties.Resources.icon_Transactions;
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // VehiclesToolMenuStrip
            // 
            resources.ApplyResources(VehiclesToolMenuStrip, "VehiclesToolMenuStrip");
            VehiclesToolMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { showVehiclesToolStripMenuItem, manageVehiclesToolStripMenuItem });
            VehiclesToolMenuStrip.Image = Properties.Resources.icons8_vehicle_50;
            VehiclesToolMenuStrip.Name = "VehiclesToolMenuStrip";
            // 
            // showVehiclesToolStripMenuItem
            // 
            resources.ApplyResources(showVehiclesToolStripMenuItem, "showVehiclesToolStripMenuItem");
            showVehiclesToolStripMenuItem.Image = Properties.Resources.icon_Description;
            showVehiclesToolStripMenuItem.Name = "showVehiclesToolStripMenuItem";
            showVehiclesToolStripMenuItem.Click += showVehiclesToolStripMenuItem_Click;
            // 
            // manageVehiclesToolStripMenuItem
            // 
            resources.ApplyResources(manageVehiclesToolStripMenuItem, "manageVehiclesToolStripMenuItem");
            manageVehiclesToolStripMenuItem.Image = Properties.Resources.icons8_vehicle_50;
            manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            manageVehiclesToolStripMenuItem.Click += manageVehiiclesToolStripMenuItem_Click;
            // 
            // PeopleToolStripMenuItem
            // 
            resources.ApplyResources(PeopleToolStripMenuItem, "PeopleToolStripMenuItem");
            PeopleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customersToolStripMenuItem, usersToolStripMenuItem1, allPeopleToolStripMenuItem });
            PeopleToolStripMenuItem.Image = Properties.Resources.Users;
            PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem";
            // 
            // customersToolStripMenuItem
            // 
            resources.ApplyResources(customersToolStripMenuItem, "customersToolStripMenuItem");
            customersToolStripMenuItem.Image = Properties.Resources.icon_Customer;
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem1
            // 
            resources.ApplyResources(usersToolStripMenuItem1, "usersToolStripMenuItem1");
            usersToolStripMenuItem1.Image = Properties.Resources.icon_User;
            usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            usersToolStripMenuItem1.Click += usersToolStripMenuItem1_Click;
            // 
            // allPeopleToolStripMenuItem
            // 
            resources.ApplyResources(allPeopleToolStripMenuItem, "allPeopleToolStripMenuItem");
            allPeopleToolStripMenuItem.Image = Properties.Resources.icon_Arrow;
            allPeopleToolStripMenuItem.Name = "allPeopleToolStripMenuItem";
            allPeopleToolStripMenuItem.Click += allPeopleToolStripMenuItem_Click;
            // 
            // mainteanceToolStripMenuItem
            // 
            resources.ApplyResources(mainteanceToolStripMenuItem, "mainteanceToolStripMenuItem");
            mainteanceToolStripMenuItem.Image = Properties.Resources.icon_Maintenance;
            mainteanceToolStripMenuItem.Name = "mainteanceToolStripMenuItem";
            mainteanceToolStripMenuItem.Click += mainteanceToolStripMenuItem_Click;
            // 
            // staticsToolStripMenuItem
            // 
            resources.ApplyResources(staticsToolStripMenuItem, "staticsToolStripMenuItem");
            staticsToolStripMenuItem.Image = Properties.Resources.icon_FuelLevel;
            staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            staticsToolStripMenuItem.Click += staticsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(settingsToolStripMenuItem, "settingsToolStripMenuItem");
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountSettingsToolStripMenuItem, systemToolStripMenuItem, signOutToolStripMenuItem });
            settingsToolStripMenuItem.Image = Properties.Resources.Icon_Manage2;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // accountSettingsToolStripMenuItem
            // 
            resources.ApplyResources(accountSettingsToolStripMenuItem, "accountSettingsToolStripMenuItem");
            accountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem });
            accountSettingsToolStripMenuItem.Image = Properties.Resources.icon_accountsettings;
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            resources.ApplyResources(currentUserInfoToolStripMenuItem, "currentUserInfoToolStripMenuItem");
            currentUserInfoToolStripMenuItem.Image = Properties.Resources.icon_Name;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            resources.ApplyResources(changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            changePasswordToolStripMenuItem.Image = Properties.Resources.iconPassword;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            resources.ApplyResources(systemToolStripMenuItem, "systemToolStripMenuItem");
            systemToolStripMenuItem.Image = Properties.Resources.icon_Settings;
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Click += systemToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            resources.ApplyResources(signOutToolStripMenuItem, "signOutToolStripMenuItem");
            signOutToolStripMenuItem.Image = Properties.Resources.icon_SignOut;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            resources.ApplyResources(exitApplicationToolStripMenuItem, "exitApplicationToolStripMenuItem");
            exitApplicationToolStripMenuItem.Image = Properties.Resources.icon_Shutdown2;
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // lblUsernameTitle
            // 
            resources.ApplyResources(lblUsernameTitle, "lblUsernameTitle");
            lblUsernameTitle.BackColor = Color.Transparent;
            lblUsernameTitle.ForeColor = Color.White;
            lblUsernameTitle.Name = "lblUsernameTitle";
            // 
            // lblUsername
            // 
            resources.ApplyResources(lblUsername, "lblUsername");
            lblUsername.BackColor = Color.Transparent;
            lblUsername.ForeColor = Color.White;
            lblUsername.Name = "lblUsername";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.BackColor = Color.Transparent;
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Name = "lblTitle";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MainLogo;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTotalVehicles);
            panel1.ForeColor = Color.White;
            panel1.Name = "panel1";
            // 
            // lblTotalVehicles
            // 
            resources.ApplyResources(lblTotalVehicles, "lblTotalVehicles");
            lblTotalVehicles.BackColor = Color.Transparent;
            lblTotalVehicles.ForeColor = SystemColors.ButtonHighlight;
            lblTotalVehicles.Name = "lblTotalVehicles";
            // 
            // lblTitleTotalVehicles
            // 
            resources.ApplyResources(lblTitleTotalVehicles, "lblTitleTotalVehicles");
            lblTitleTotalVehicles.BackColor = Color.Transparent;
            lblTitleTotalVehicles.ForeColor = SystemColors.ButtonHighlight;
            lblTitleTotalVehicles.Name = "lblTitleTotalVehicles";
            // 
            // lblTitleTotalCustomers
            // 
            resources.ApplyResources(lblTitleTotalCustomers, "lblTitleTotalCustomers");
            lblTitleTotalCustomers.BackColor = Color.Transparent;
            lblTitleTotalCustomers.ForeColor = SystemColors.ButtonHighlight;
            lblTitleTotalCustomers.Name = "lblTitleTotalCustomers";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTotalCustomers);
            panel2.ForeColor = Color.White;
            panel2.Name = "panel2";
            // 
            // lblTotalCustomers
            // 
            resources.ApplyResources(lblTotalCustomers, "lblTotalCustomers");
            lblTotalCustomers.BackColor = Color.Transparent;
            lblTotalCustomers.ForeColor = SystemColors.ButtonHighlight;
            lblTotalCustomers.Name = "lblTotalCustomers";
            // 
            // lblTitleTotalRents
            // 
            resources.ApplyResources(lblTitleTotalRents, "lblTitleTotalRents");
            lblTitleTotalRents.BackColor = Color.Transparent;
            lblTitleTotalRents.ForeColor = SystemColors.ButtonHighlight;
            lblTitleTotalRents.Name = "lblTitleTotalRents";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTotalRents);
            panel3.ForeColor = Color.White;
            panel3.Name = "panel3";
            // 
            // lblTotalRents
            // 
            resources.ApplyResources(lblTotalRents, "lblTotalRents");
            lblTotalRents.BackColor = Color.Transparent;
            lblTotalRents.ForeColor = SystemColors.ButtonHighlight;
            lblTotalRents.Name = "lblTotalRents";
            // 
            // lblTitleTotalBookings
            // 
            resources.ApplyResources(lblTitleTotalBookings, "lblTitleTotalBookings");
            lblTitleTotalBookings.BackColor = Color.Transparent;
            lblTitleTotalBookings.ForeColor = SystemColors.ButtonHighlight;
            lblTitleTotalBookings.Name = "lblTitleTotalBookings";
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblTotalBookings);
            panel4.ForeColor = Color.White;
            panel4.Name = "panel4";
            // 
            // lblTotalBookings
            // 
            resources.ApplyResources(lblTotalBookings, "lblTotalBookings");
            lblTotalBookings.BackColor = Color.Transparent;
            lblTotalBookings.ForeColor = SystemColors.ButtonHighlight;
            lblTotalBookings.Name = "lblTotalBookings";
            // 
            // lblRole
            // 
            resources.ApplyResources(lblRole, "lblRole");
            lblRole.BackColor = Color.Transparent;
            lblRole.ForeColor = Color.WhiteSmoke;
            lblRole.Name = "lblRole";
            // 
            // pbUserImage
            // 
            resources.ApplyResources(pbUserImage, "pbUserImage");
            pbUserImage.BackColor = Color.Transparent;
            pbUserImage.Image = Properties.Resources.icon_User;
            pbUserImage.Name = "pbUserImage";
            pbUserImage.TabStop = false;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(pbUserImage);
            Controls.Add(lblRole);
            Controls.Add(lblTitleTotalBookings);
            Controls.Add(panel4);
            Controls.Add(lblTitleTotalRents);
            Controls.Add(panel3);
            Controls.Add(lblTitleTotalCustomers);
            Controls.Add(panel2);
            Controls.Add(lblTitleTotalVehicles);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(lblUsernameTitle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainMenu";
            WindowState = FormWindowState.Maximized;
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

