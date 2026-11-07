namespace CarRental
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlPersonInfoWithFilter1 = new CarRental.ctrlPersonInfoWithFilter();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtDriverLicnese = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.ep.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
            this.ep.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
            this.ep.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
            this.lblTitle.Name = "lblTitle";
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
            // gbCustomerInfo
            // 
            resources.ApplyResources(this.gbCustomerInfo, "gbCustomerInfo");
            this.gbCustomerInfo.Controls.Add(this.pictureBox4);
            this.gbCustomerInfo.Controls.Add(this.pictureBox3);
            this.gbCustomerInfo.Controls.Add(this.pictureBox1);
            this.gbCustomerInfo.Controls.Add(this.pictureBox2);
            this.gbCustomerInfo.Controls.Add(this.label5);
            this.gbCustomerInfo.Controls.Add(this.lblCreatedBy);
            this.gbCustomerInfo.Controls.Add(this.label4);
            this.gbCustomerInfo.Controls.Add(this.lblCreationDate);
            this.gbCustomerInfo.Controls.Add(this.label2);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerID);
            this.gbCustomerInfo.Controls.Add(this.lblID);
            this.gbCustomerInfo.Controls.Add(this.txtDriverLicnese);
            this.ep.SetError(this.gbCustomerInfo, resources.GetString("gbCustomerInfo.Error"));
            this.ep.SetIconAlignment(this.gbCustomerInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbCustomerInfo.IconAlignment"))));
            this.ep.SetIconPadding(this.gbCustomerInfo, ((int)(resources.GetObject("gbCustomerInfo.IconPadding"))));
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.ep.SetError(this.pictureBox4, resources.GetString("pictureBox4.Error"));
            this.ep.SetIconAlignment(this.pictureBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox4.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox4, ((int)(resources.GetObject("pictureBox4.IconPadding"))));
            this.pictureBox4.Image = global::CarRental.Properties.Resources.icon_ID;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.ep.SetError(this.pictureBox3, resources.GetString("pictureBox3.Error"));
            this.ep.SetIconAlignment(this.pictureBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox3.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox3, ((int)(resources.GetObject("pictureBox3.IconPadding"))));
            this.pictureBox3.Image = global::CarRental.Properties.Resources.iconLicense;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
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
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.ep.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error"));
            this.ep.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding"))));
            this.pictureBox2.Image = global::CarRental.Properties.Resources.icons8_date_50;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.ep.SetError(this.label5, resources.GetString("label5.Error"));
            this.ep.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.ep.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // lblCreatedBy
            // 
            resources.ApplyResources(this.lblCreatedBy, "lblCreatedBy");
            this.ep.SetError(this.lblCreatedBy, resources.GetString("lblCreatedBy.Error"));
            this.ep.SetIconAlignment(this.lblCreatedBy, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCreatedBy.IconAlignment"))));
            this.ep.SetIconPadding(this.lblCreatedBy, ((int)(resources.GetObject("lblCreatedBy.IconPadding"))));
            this.lblCreatedBy.Name = "lblCreatedBy";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.ep.SetError(this.label4, resources.GetString("label4.Error"));
            this.ep.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.ep.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // lblCreationDate
            // 
            resources.ApplyResources(this.lblCreationDate, "lblCreationDate");
            this.ep.SetError(this.lblCreationDate, resources.GetString("lblCreationDate.Error"));
            this.ep.SetIconAlignment(this.lblCreationDate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCreationDate.IconAlignment"))));
            this.ep.SetIconPadding(this.lblCreationDate, ((int)(resources.GetObject("lblCreationDate.IconPadding"))));
            this.lblCreationDate.Name = "lblCreationDate";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.ep.SetError(this.label2, resources.GetString("label2.Error"));
            this.ep.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.ep.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // lblCustomerID
            // 
            resources.ApplyResources(this.lblCustomerID, "lblCustomerID");
            this.ep.SetError(this.lblCustomerID, resources.GetString("lblCustomerID.Error"));
            this.ep.SetIconAlignment(this.lblCustomerID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCustomerID.IconAlignment"))));
            this.ep.SetIconPadding(this.lblCustomerID, ((int)(resources.GetObject("lblCustomerID.IconPadding"))));
            this.lblCustomerID.Name = "lblCustomerID";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.ep.SetError(this.lblID, resources.GetString("lblID.Error"));
            this.ep.SetIconAlignment(this.lblID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblID.IconAlignment"))));
            this.ep.SetIconPadding(this.lblID, ((int)(resources.GetObject("lblID.IconPadding"))));
            this.lblID.Name = "lblID";
            // 
            // txtDriverLicnese
            // 
            resources.ApplyResources(this.txtDriverLicnese, "txtDriverLicnese");
            this.ep.SetError(this.txtDriverLicnese, resources.GetString("txtDriverLicnese.Error"));
            this.ep.SetIconAlignment(this.txtDriverLicnese, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtDriverLicnese.IconAlignment"))));
            this.ep.SetIconPadding(this.txtDriverLicnese, ((int)(resources.GetObject("txtDriverLicnese.IconPadding"))));
            this.txtDriverLicnese.Name = "txtDriverLicnese";
            this.txtDriverLicnese.Validating += new System.ComponentModel.CancelEventHandler(this.txtDriverLicnese_Validating);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            resources.ApplyResources(this.ep, "ep");
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
            // frmAddCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCuso_Load);
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtDriverLicnese;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}