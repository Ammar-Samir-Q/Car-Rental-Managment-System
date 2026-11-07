namespace CarRental
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.tcPersonInfo = new System.Windows.Forms.TabControl();
            this.tpPerson = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonInfoWithFilter1 = new CarRental.ctrlPersonInfoWithFilter();
            this.tpUserinfo = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcPersonInfo.SuspendLayout();
            this.tpPerson.SuspendLayout();
            this.tpUserinfo.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPersonInfo
            // 
            resources.ApplyResources(this.tcPersonInfo, "tcPersonInfo");
            this.tcPersonInfo.Controls.Add(this.tpPerson);
            this.tcPersonInfo.Controls.Add(this.tpUserinfo);
            this.ep.SetError(this.tcPersonInfo, resources.GetString("tcPersonInfo.Error"));
            this.ep.SetIconAlignment(this.tcPersonInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tcPersonInfo.IconAlignment"))));
            this.ep.SetIconPadding(this.tcPersonInfo, ((int)(resources.GetObject("tcPersonInfo.IconPadding"))));
            this.tcPersonInfo.Name = "tcPersonInfo";
            this.tcPersonInfo.SelectedIndex = 0;
            this.tcPersonInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tpPerson
            // 
            resources.ApplyResources(this.tpPerson, "tpPerson");
            this.tpPerson.Controls.Add(this.btnNext);
            this.tpPerson.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.ep.SetError(this.tpPerson, resources.GetString("tpPerson.Error"));
            this.ep.SetIconAlignment(this.tpPerson, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tpPerson.IconAlignment"))));
            this.ep.SetIconPadding(this.tpPerson, ((int)(resources.GetObject("tpPerson.IconPadding"))));
            this.tpPerson.Name = "tpPerson";
            this.tpPerson.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.ep.SetError(this.btnNext, resources.GetString("btnNext.Error"));
            this.ep.SetIconAlignment(this.btnNext, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnNext.IconAlignment"))));
            this.ep.SetIconPadding(this.btnNext, ((int)(resources.GetObject("btnNext.IconPadding"))));
            this.btnNext.Image = global::CarRental.Properties.Resources.icon_NextBlack;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonInfoWithFilter1
            // 
            resources.ApplyResources(this.ctrlPersonInfoWithFilter1, "ctrlPersonInfoWithFilter1");
            this.ep.SetError(this.ctrlPersonInfoWithFilter1, resources.GetString("ctrlPersonInfoWithFilter1.Error"));
            this.ctrlPersonInfoWithFilter1.FilterEnabled = true;
            this.ep.SetIconAlignment(this.ctrlPersonInfoWithFilter1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ctrlPersonInfoWithFilter1.IconAlignment"))));
            this.ep.SetIconPadding(this.ctrlPersonInfoWithFilter1, ((int)(resources.GetObject("ctrlPersonInfoWithFilter1.IconPadding"))));
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            // 
            // tpUserinfo
            // 
            resources.ApplyResources(this.tpUserinfo, "tpUserinfo");
            this.tpUserinfo.Controls.Add(this.btnSave);
            this.tpUserinfo.Controls.Add(this.gbUserInfo);
            this.ep.SetError(this.tpUserinfo, resources.GetString("tpUserinfo.Error"));
            this.ep.SetIconAlignment(this.tpUserinfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tpUserinfo.IconAlignment"))));
            this.ep.SetIconPadding(this.tpUserinfo, ((int)(resources.GetObject("tpUserinfo.IconPadding"))));
            this.tpUserinfo.Name = "tpUserinfo";
            this.tpUserinfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.ep.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.ep.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.ep.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Image = global::CarRental.Properties.Resources.icon_Save;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbUserInfo
            // 
            resources.ApplyResources(this.gbUserInfo, "gbUserInfo");
            this.gbUserInfo.Controls.Add(this.pictureBox6);
            this.gbUserInfo.Controls.Add(this.pictureBox5);
            this.gbUserInfo.Controls.Add(this.pictureBox4);
            this.gbUserInfo.Controls.Add(this.pictureBox3);
            this.gbUserInfo.Controls.Add(this.pictureBox2);
            this.gbUserInfo.Controls.Add(this.pictureBox1);
            this.gbUserInfo.Controls.Add(this.lblUserID);
            this.gbUserInfo.Controls.Add(this.cbIsActive);
            this.gbUserInfo.Controls.Add(this.label5);
            this.gbUserInfo.Controls.Add(this.txtUsername);
            this.gbUserInfo.Controls.Add(this.txtPassword);
            this.gbUserInfo.Controls.Add(this.label7);
            this.gbUserInfo.Controls.Add(this.label4);
            this.gbUserInfo.Controls.Add(this.cbRole);
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Controls.Add(this.label2);
            this.gbUserInfo.Controls.Add(this.label3);
            this.gbUserInfo.Controls.Add(this.txtConfirmPassword);
            this.ep.SetError(this.gbUserInfo, resources.GetString("gbUserInfo.Error"));
            this.ep.SetIconAlignment(this.gbUserInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbUserInfo.IconAlignment"))));
            this.ep.SetIconPadding(this.gbUserInfo, ((int)(resources.GetObject("gbUserInfo.IconPadding"))));
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.TabStop = false;
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.ep.SetError(this.pictureBox6, resources.GetString("pictureBox6.Error"));
            this.ep.SetIconAlignment(this.pictureBox6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox6.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox6, ((int)(resources.GetObject("pictureBox6.IconPadding"))));
            this.pictureBox6.Image = global::CarRental.Properties.Resources.icons8_approval_50;
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.ep.SetError(this.pictureBox5, resources.GetString("pictureBox5.Error"));
            this.ep.SetIconAlignment(this.pictureBox5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox5.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox5, ((int)(resources.GetObject("pictureBox5.IconPadding"))));
            this.pictureBox5.Image = global::CarRental.Properties.Resources.Icon_UserName;
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.ep.SetError(this.pictureBox4, resources.GetString("pictureBox4.Error"));
            this.ep.SetIconAlignment(this.pictureBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox4.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox4, ((int)(resources.GetObject("pictureBox4.IconPadding"))));
            this.pictureBox4.Image = global::CarRental.Properties.Resources.iconPassword;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.ep.SetError(this.pictureBox3, resources.GetString("pictureBox3.Error"));
            this.ep.SetIconAlignment(this.pictureBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox3.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox3, ((int)(resources.GetObject("pictureBox3.IconPadding"))));
            this.pictureBox3.Image = global::CarRental.Properties.Resources.iconPassword;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.ep.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error"));
            this.ep.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding"))));
            this.pictureBox2.Image = global::CarRental.Properties.Resources.Icon_UserName;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.ep.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.ep.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Image = global::CarRental.Properties.Resources.Icon_UserName;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblUserID
            // 
            resources.ApplyResources(this.lblUserID, "lblUserID");
            this.ep.SetError(this.lblUserID, resources.GetString("lblUserID.Error"));
            this.ep.SetIconAlignment(this.lblUserID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUserID.IconAlignment"))));
            this.ep.SetIconPadding(this.lblUserID, ((int)(resources.GetObject("lblUserID.IconPadding"))));
            this.lblUserID.Name = "lblUserID";
            // 
            // cbIsActive
            // 
            resources.ApplyResources(this.cbIsActive, "cbIsActive");
            this.ep.SetError(this.cbIsActive, resources.GetString("cbIsActive.Error"));
            this.ep.SetIconAlignment(this.cbIsActive, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbIsActive.IconAlignment"))));
            this.ep.SetIconPadding(this.cbIsActive, ((int)(resources.GetObject("cbIsActive.IconPadding"))));
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.ep.SetError(this.label5, resources.GetString("label5.Error"));
            this.ep.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.ep.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.ep.SetError(this.txtUsername, resources.GetString("txtUsername.Error"));
            this.ep.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment"))));
            this.ep.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding"))));
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.ep.SetError(this.txtPassword, resources.GetString("txtPassword.Error"));
            this.ep.SetIconAlignment(this.txtPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPassword.IconAlignment"))));
            this.ep.SetIconPadding(this.txtPassword, ((int)(resources.GetObject("txtPassword.IconPadding"))));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.ep.SetError(this.label7, resources.GetString("label7.Error"));
            this.ep.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.ep.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.ep.SetError(this.label4, resources.GetString("label4.Error"));
            this.ep.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.ep.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // cbRole
            // 
            resources.ApplyResources(this.cbRole, "cbRole");
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ep.SetError(this.cbRole, resources.GetString("cbRole.Error"));
            this.cbRole.FormattingEnabled = true;
            this.ep.SetIconAlignment(this.cbRole, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbRole.IconAlignment"))));
            this.ep.SetIconPadding(this.cbRole, ((int)(resources.GetObject("cbRole.IconPadding"))));
            this.cbRole.Items.AddRange(new object[] {
            resources.GetString("cbRole.Items"),
            resources.GetString("cbRole.Items1")});
            this.cbRole.Name = "cbRole";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.ep.SetError(this.label1, resources.GetString("label1.Error"));
            this.ep.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.ep.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.ep.SetError(this.label2, resources.GetString("label2.Error"));
            this.ep.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.ep.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.ep.SetError(this.label3, resources.GetString("label3.Error"));
            this.ep.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.ep.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // txtConfirmPassword
            // 
            resources.ApplyResources(this.txtConfirmPassword, "txtConfirmPassword");
            this.ep.SetError(this.txtConfirmPassword, resources.GetString("txtConfirmPassword.Error"));
            this.ep.SetIconAlignment(this.txtConfirmPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtConfirmPassword.IconAlignment"))));
            this.ep.SetIconPadding(this.txtConfirmPassword, ((int)(resources.GetObject("txtConfirmPassword.IconPadding"))));
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ep.SetError(this.btnClose, resources.GetString("btnClose.Error"));
            this.ep.SetIconAlignment(this.btnClose, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnClose.IconAlignment"))));
            this.ep.SetIconPadding(this.btnClose, ((int)(resources.GetObject("btnClose.IconPadding"))));
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.ep.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
            this.ep.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
            this.ep.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
            this.lblTitle.Name = "lblTitle";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            resources.ApplyResources(this.ep, "ep");
            // 
            // frmAddUpdateUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcPersonInfo);
            this.Name = "frmAddUpdateUser";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tcPersonInfo.ResumeLayout(false);
            this.tpPerson.ResumeLayout(false);
            this.tpUserinfo.ResumeLayout(false);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPersonInfo;
        private System.Windows.Forms.TabPage tpPerson;
        private System.Windows.Forms.TabPage tpUserinfo;
        private System.Windows.Forms.Button btnNext;
        private ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}