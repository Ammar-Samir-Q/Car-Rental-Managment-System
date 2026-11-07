namespace CarRental
{
    partial class frmAddUpdateMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateMaintenance));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaintenanceID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlVehicleInfo1 = new CarRental.ctrlVehicleInfo();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.ep.SetError(this.label1, resources.GetString("label1.Error"));
            this.ep.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.ep.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.ep.SetError(this.txtDescription, resources.GetString("txtDescription.Error"));
            this.ep.SetIconAlignment(this.txtDescription, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtDescription.IconAlignment"))));
            this.ep.SetIconPadding(this.txtDescription, ((int)(resources.GetObject("txtDescription.IconPadding"))));
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtCost
            // 
            resources.ApplyResources(this.txtCost, "txtCost");
            this.ep.SetError(this.txtCost, resources.GetString("txtCost.Error"));
            this.ep.SetIconAlignment(this.txtCost, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCost.IconAlignment"))));
            this.ep.SetIconPadding(this.txtCost, ((int)(resources.GetObject("txtCost.IconPadding"))));
            this.txtCost.Name = "txtCost";
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
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
            // lblMaintenanceID
            // 
            resources.ApplyResources(this.lblMaintenanceID, "lblMaintenanceID");
            this.ep.SetError(this.lblMaintenanceID, resources.GetString("lblMaintenanceID.Error"));
            this.ep.SetIconAlignment(this.lblMaintenanceID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblMaintenanceID.IconAlignment"))));
            this.ep.SetIconPadding(this.lblMaintenanceID, ((int)(resources.GetObject("lblMaintenanceID.IconPadding"))));
            this.lblMaintenanceID.Name = "lblMaintenanceID";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.ep.SetError(this.label4, resources.GetString("label4.Error"));
            this.ep.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.ep.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.ep.SetError(this.lblDate, resources.GetString("lblDate.Error"));
            this.ep.SetIconAlignment(this.lblDate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDate.IconAlignment"))));
            this.ep.SetIconPadding(this.lblDate, ((int)(resources.GetObject("lblDate.IconPadding"))));
            this.lblDate.Name = "lblDate";
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
            // btnSelect
            // 
            resources.ApplyResources(this.btnSelect, "btnSelect");
            this.ep.SetError(this.btnSelect, resources.GetString("btnSelect.Error"));
            this.ep.SetIconAlignment(this.btnSelect, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSelect.IconAlignment"))));
            this.ep.SetIconPadding(this.btnSelect, ((int)(resources.GetObject("btnSelect.IconPadding"))));
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.ep.SetError(this.pictureBox5, resources.GetString("pictureBox5.Error"));
            this.ep.SetIconAlignment(this.pictureBox5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox5.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox5, ((int)(resources.GetObject("pictureBox5.IconPadding"))));
            this.pictureBox5.Image = global::CarRental.Properties.Resources.icon_Maintenance;
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.ep.SetError(this.pictureBox4, resources.GetString("pictureBox4.Error"));
            this.ep.SetIconAlignment(this.pictureBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox4.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox4, ((int)(resources.GetObject("pictureBox4.IconPadding"))));
            this.pictureBox4.Image = global::CarRental.Properties.Resources.icons8_money_50;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.ep.SetError(this.pictureBox3, resources.GetString("pictureBox3.Error"));
            this.ep.SetIconAlignment(this.pictureBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox3.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox3, ((int)(resources.GetObject("pictureBox3.IconPadding"))));
            this.pictureBox3.Image = global::CarRental.Properties.Resources.icons8_date_50;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.ep.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.ep.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Image = global::CarRental.Properties.Resources.icon_Description;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.ep.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error"));
            this.ep.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding"))));
            this.pictureBox2.Image = global::CarRental.Properties.Resources.icon_Maintenance;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // ctrlVehicleInfo1
            // 
            resources.ApplyResources(this.ctrlVehicleInfo1, "ctrlVehicleInfo1");
            this.ep.SetError(this.ctrlVehicleInfo1, resources.GetString("ctrlVehicleInfo1.Error"));
            this.ep.SetIconAlignment(this.ctrlVehicleInfo1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ctrlVehicleInfo1.IconAlignment"))));
            this.ep.SetIconPadding(this.ctrlVehicleInfo1, ((int)(resources.GetObject("ctrlVehicleInfo1.IconPadding"))));
            this.ctrlVehicleInfo1.Name = "ctrlVehicleInfo1";
            // 
            // frmAddUpdateMaintenance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMaintenanceID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlVehicleInfo1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateMaintenance";
            this.Load += new System.EventHandler(this.frmAddUpdateMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlVehicleInfo ctrlVehicleInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaintenanceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}