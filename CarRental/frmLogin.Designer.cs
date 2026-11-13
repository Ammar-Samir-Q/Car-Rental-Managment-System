namespace CarRental
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnClose = new Button();
            btnLogin = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblSubTitle = new Label();
            lblTitle = new Label();
            txtUserName = new TextBox();
            cbRememberMe = new CheckBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lblVersion = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDatabaseStatus = new Button();
            btnEnterAsCustomer = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            chbAutoLogin = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.BackColor = Color.SteelBlue;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.ForeColor = Color.White;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.DialogResult = DialogResult.Cancel;
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSubTitle);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnClose);
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.MainLogo;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblSubTitle
            // 
            resources.ApplyResources(lblSubTitle, "lblSubTitle");
            lblSubTitle.ForeColor = Color.White;
            lblSubTitle.Name = "lblSubTitle";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.White;
            lblTitle.Name = "lblTitle";
            // 
            // txtUserName
            // 
            resources.ApplyResources(txtUserName, "txtUserName");
            txtUserName.Name = "txtUserName";
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // cbRememberMe
            // 
            resources.ApplyResources(cbRememberMe, "cbRememberMe");
            cbRememberMe.Name = "cbRememberMe";
            cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(lblVersion);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Name = "panel2";
            // 
            // lblVersion
            // 
            resources.ApplyResources(lblVersion, "lblVersion");
            lblVersion.ForeColor = Color.White;
            lblVersion.Name = "lblVersion";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.White;
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.White;
            label7.Name = "label7";
            // 
            // btnDatabaseStatus
            // 
            resources.ApplyResources(btnDatabaseStatus, "btnDatabaseStatus");
            btnDatabaseStatus.BackColor = Color.SteelBlue;
            btnDatabaseStatus.DialogResult = DialogResult.Cancel;
            btnDatabaseStatus.ForeColor = Color.White;
            btnDatabaseStatus.Name = "btnDatabaseStatus";
            btnDatabaseStatus.UseVisualStyleBackColor = false;
            // 
            // btnEnterAsCustomer
            // 
            resources.ApplyResources(btnEnterAsCustomer, "btnEnterAsCustomer");
            btnEnterAsCustomer.BackColor = Color.SteelBlue;
            btnEnterAsCustomer.DialogResult = DialogResult.Cancel;
            btnEnterAsCustomer.ForeColor = Color.White;
            btnEnterAsCustomer.Name = "btnEnterAsCustomer";
            btnEnterAsCustomer.UseVisualStyleBackColor = false;
            btnEnterAsCustomer.Click += btnEnterAsCustomer_Click;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Image = Properties.Resources.icons8_person_48;
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Image = Properties.Resources.iconPassword;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Image = Properties.Resources.icon_remeberme;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // chbAutoLogin
            // 
            resources.ApplyResources(chbAutoLogin, "chbAutoLogin");
            chbAutoLogin.Name = "chbAutoLogin";
            chbAutoLogin.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            Controls.Add(chbAutoLogin);
            Controls.Add(btnEnterAsCustomer);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(cbRememberMe);
            Controls.Add(txtUserName);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Controls.Add(btnDatabaseStatus);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmLogin";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnDatabaseStatus;
        private System.Windows.Forms.Button btnEnterAsCustomer;
        private CheckBox chbAutoLogin;
    }
}