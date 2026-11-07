namespace CarRental
{
    partial class frmReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturn));
            this.tc = new System.Windows.Forms.TabControl();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.ctrlRentInfoWithFilter1 = new CarRental.ctrlRentInfoWithFilter();
            this.tpReturnDetails = new System.Windows.Forms.TabPage();
            this.gbReturn = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFuelLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbReturnCondation = new System.Windows.Forms.ComboBox();
            this.lblTotalDueAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRentalDays = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddtionalCharges = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMilage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tc.SuspendLayout();
            this.tpBookingInfo.SuspendLayout();
            this.tpReturnDetails.SuspendLayout();
            this.gbReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            resources.ApplyResources(this.tc, "tc");
            this.tc.Controls.Add(this.tpBookingInfo);
            this.tc.Controls.Add(this.tpReturnDetails);
            this.ep.SetError(this.tc, resources.GetString("tc.Error"));
            this.ep.SetIconAlignment(this.tc, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tc.IconAlignment"))));
            this.ep.SetIconPadding(this.tc, ((int)(resources.GetObject("tc.IconPadding"))));
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            // 
            // tpBookingInfo
            // 
            resources.ApplyResources(this.tpBookingInfo, "tpBookingInfo");
            this.tpBookingInfo.Controls.Add(this.label15);
            this.tpBookingInfo.Controls.Add(this.pictureBox24);
            this.tpBookingInfo.Controls.Add(this.btnNext);
            this.tpBookingInfo.Controls.Add(this.ctrlRentInfoWithFilter1);
            this.ep.SetError(this.tpBookingInfo, resources.GetString("tpBookingInfo.Error"));
            this.ep.SetIconAlignment(this.tpBookingInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tpBookingInfo.IconAlignment"))));
            this.ep.SetIconPadding(this.tpBookingInfo, ((int)(resources.GetObject("tpBookingInfo.IconPadding"))));
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.ep.SetError(this.label15, resources.GetString("label15.Error"));
            this.ep.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment"))));
            this.ep.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding"))));
            this.label15.Name = "label15";
            // 
            // ctrlRentInfoWithFilter1
            // 
            resources.ApplyResources(this.ctrlRentInfoWithFilter1, "ctrlRentInfoWithFilter1");
            this.ep.SetError(this.ctrlRentInfoWithFilter1, resources.GetString("ctrlRentInfoWithFilter1.Error"));
            this.ctrlRentInfoWithFilter1.FilterEnabled = true;
            this.ep.SetIconAlignment(this.ctrlRentInfoWithFilter1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ctrlRentInfoWithFilter1.IconAlignment"))));
            this.ep.SetIconPadding(this.ctrlRentInfoWithFilter1, ((int)(resources.GetObject("ctrlRentInfoWithFilter1.IconPadding"))));
            this.ctrlRentInfoWithFilter1.Name = "ctrlRentInfoWithFilter1";
            // 
            // tpReturnDetails
            // 
            resources.ApplyResources(this.tpReturnDetails, "tpReturnDetails");
            this.tpReturnDetails.Controls.Add(this.gbReturn);
            this.ep.SetError(this.tpReturnDetails, resources.GetString("tpReturnDetails.Error"));
            this.ep.SetIconAlignment(this.tpReturnDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tpReturnDetails.IconAlignment"))));
            this.ep.SetIconPadding(this.tpReturnDetails, ((int)(resources.GetObject("tpReturnDetails.IconPadding"))));
            this.tpReturnDetails.Name = "tpReturnDetails";
            this.tpReturnDetails.UseVisualStyleBackColor = true;
            // 
            // gbReturn
            // 
            resources.ApplyResources(this.gbReturn, "gbReturn");
            this.gbReturn.Controls.Add(this.pictureBox10);
            this.gbReturn.Controls.Add(this.pictureBox9);
            this.gbReturn.Controls.Add(this.pictureBox8);
            this.gbReturn.Controls.Add(this.pictureBox7);
            this.gbReturn.Controls.Add(this.pictureBox6);
            this.gbReturn.Controls.Add(this.pictureBox5);
            this.gbReturn.Controls.Add(this.pictureBox4);
            this.gbReturn.Controls.Add(this.pictureBox3);
            this.gbReturn.Controls.Add(this.pictureBox2);
            this.gbReturn.Controls.Add(this.label5);
            this.gbReturn.Controls.Add(this.pictureBox1);
            this.gbReturn.Controls.Add(this.btnSave);
            this.gbReturn.Controls.Add(this.label12);
            this.gbReturn.Controls.Add(this.dtpReturnDate);
            this.gbReturn.Controls.Add(this.lblReturnID);
            this.gbReturn.Controls.Add(this.label11);
            this.gbReturn.Controls.Add(this.label9);
            this.gbReturn.Controls.Add(this.cbFuelLevel);
            this.gbReturn.Controls.Add(this.label8);
            this.gbReturn.Controls.Add(this.cbReturnCondation);
            this.gbReturn.Controls.Add(this.lblTotalDueAmount);
            this.gbReturn.Controls.Add(this.label7);
            this.gbReturn.Controls.Add(this.lblRentalDays);
            this.gbReturn.Controls.Add(this.label4);
            this.gbReturn.Controls.Add(this.txtAddtionalCharges);
            this.gbReturn.Controls.Add(this.label3);
            this.gbReturn.Controls.Add(this.txtNotes);
            this.gbReturn.Controls.Add(this.label2);
            this.gbReturn.Controls.Add(this.txtMilage);
            this.gbReturn.Controls.Add(this.label1);
            this.ep.SetError(this.gbReturn, resources.GetString("gbReturn.Error"));
            this.ep.SetIconAlignment(this.gbReturn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("gbReturn.IconAlignment"))));
            this.ep.SetIconPadding(this.gbReturn, ((int)(resources.GetObject("gbReturn.IconPadding"))));
            this.gbReturn.Name = "gbReturn";
            this.gbReturn.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.ep.SetError(this.label5, resources.GetString("label5.Error"));
            this.ep.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.ep.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.ep.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.ep.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.ep.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.ep.SetError(this.label12, resources.GetString("label12.Error"));
            this.ep.SetIconAlignment(this.label12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label12.IconAlignment"))));
            this.ep.SetIconPadding(this.label12, ((int)(resources.GetObject("label12.IconPadding"))));
            this.label12.Name = "label12";
            // 
            // dtpReturnDate
            // 
            resources.ApplyResources(this.dtpReturnDate, "dtpReturnDate");
            this.ep.SetError(this.dtpReturnDate, resources.GetString("dtpReturnDate.Error"));
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ep.SetIconAlignment(this.dtpReturnDate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dtpReturnDate.IconAlignment"))));
            this.ep.SetIconPadding(this.dtpReturnDate, ((int)(resources.GetObject("dtpReturnDate.IconPadding"))));
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // lblReturnID
            // 
            resources.ApplyResources(this.lblReturnID, "lblReturnID");
            this.ep.SetError(this.lblReturnID, resources.GetString("lblReturnID.Error"));
            this.ep.SetIconAlignment(this.lblReturnID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblReturnID.IconAlignment"))));
            this.ep.SetIconPadding(this.lblReturnID, ((int)(resources.GetObject("lblReturnID.IconPadding"))));
            this.lblReturnID.Name = "lblReturnID";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.ep.SetError(this.label11, resources.GetString("label11.Error"));
            this.ep.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.ep.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.ep.SetError(this.label9, resources.GetString("label9.Error"));
            this.ep.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.ep.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            // 
            // cbFuelLevel
            // 
            resources.ApplyResources(this.cbFuelLevel, "cbFuelLevel");
            this.ep.SetError(this.cbFuelLevel, resources.GetString("cbFuelLevel.Error"));
            this.cbFuelLevel.FormattingEnabled = true;
            this.ep.SetIconAlignment(this.cbFuelLevel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbFuelLevel.IconAlignment"))));
            this.ep.SetIconPadding(this.cbFuelLevel, ((int)(resources.GetObject("cbFuelLevel.IconPadding"))));
            this.cbFuelLevel.Items.AddRange(new object[] {
            resources.GetString("cbFuelLevel.Items"),
            resources.GetString("cbFuelLevel.Items1"),
            resources.GetString("cbFuelLevel.Items2"),
            resources.GetString("cbFuelLevel.Items3"),
            resources.GetString("cbFuelLevel.Items4")});
            this.cbFuelLevel.Name = "cbFuelLevel";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.ep.SetError(this.label8, resources.GetString("label8.Error"));
            this.ep.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.ep.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            // 
            // cbReturnCondation
            // 
            resources.ApplyResources(this.cbReturnCondation, "cbReturnCondation");
            this.ep.SetError(this.cbReturnCondation, resources.GetString("cbReturnCondation.Error"));
            this.cbReturnCondation.FormattingEnabled = true;
            this.ep.SetIconAlignment(this.cbReturnCondation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbReturnCondation.IconAlignment"))));
            this.ep.SetIconPadding(this.cbReturnCondation, ((int)(resources.GetObject("cbReturnCondation.IconPadding"))));
            this.cbReturnCondation.Items.AddRange(new object[] {
            resources.GetString("cbReturnCondation.Items"),
            resources.GetString("cbReturnCondation.Items1"),
            resources.GetString("cbReturnCondation.Items2"),
            resources.GetString("cbReturnCondation.Items3"),
            resources.GetString("cbReturnCondation.Items4"),
            resources.GetString("cbReturnCondation.Items5")});
            this.cbReturnCondation.Name = "cbReturnCondation";
            // 
            // lblTotalDueAmount
            // 
            resources.ApplyResources(this.lblTotalDueAmount, "lblTotalDueAmount");
            this.ep.SetError(this.lblTotalDueAmount, resources.GetString("lblTotalDueAmount.Error"));
            this.ep.SetIconAlignment(this.lblTotalDueAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTotalDueAmount.IconAlignment"))));
            this.ep.SetIconPadding(this.lblTotalDueAmount, ((int)(resources.GetObject("lblTotalDueAmount.IconPadding"))));
            this.lblTotalDueAmount.Name = "lblTotalDueAmount";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.ep.SetError(this.label7, resources.GetString("label7.Error"));
            this.ep.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.ep.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // lblRentalDays
            // 
            resources.ApplyResources(this.lblRentalDays, "lblRentalDays");
            this.ep.SetError(this.lblRentalDays, resources.GetString("lblRentalDays.Error"));
            this.ep.SetIconAlignment(this.lblRentalDays, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblRentalDays.IconAlignment"))));
            this.ep.SetIconPadding(this.lblRentalDays, ((int)(resources.GetObject("lblRentalDays.IconPadding"))));
            this.lblRentalDays.Name = "lblRentalDays";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.ep.SetError(this.label4, resources.GetString("label4.Error"));
            this.ep.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.ep.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // txtAddtionalCharges
            // 
            resources.ApplyResources(this.txtAddtionalCharges, "txtAddtionalCharges");
            this.ep.SetError(this.txtAddtionalCharges, resources.GetString("txtAddtionalCharges.Error"));
            this.ep.SetIconAlignment(this.txtAddtionalCharges, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddtionalCharges.IconAlignment"))));
            this.ep.SetIconPadding(this.txtAddtionalCharges, ((int)(resources.GetObject("txtAddtionalCharges.IconPadding"))));
            this.txtAddtionalCharges.Name = "txtAddtionalCharges";
            this.txtAddtionalCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddtionalCharges_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.ep.SetError(this.label3, resources.GetString("label3.Error"));
            this.ep.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.ep.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // txtNotes
            // 
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.ep.SetError(this.txtNotes, resources.GetString("txtNotes.Error"));
            this.ep.SetIconAlignment(this.txtNotes, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNotes.IconAlignment"))));
            this.ep.SetIconPadding(this.txtNotes, ((int)(resources.GetObject("txtNotes.IconPadding"))));
            this.txtNotes.Name = "txtNotes";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.ep.SetError(this.label2, resources.GetString("label2.Error"));
            this.ep.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.ep.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // txtMilage
            // 
            resources.ApplyResources(this.txtMilage, "txtMilage");
            this.ep.SetError(this.txtMilage, resources.GetString("txtMilage.Error"));
            this.ep.SetIconAlignment(this.txtMilage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtMilage.IconAlignment"))));
            this.ep.SetIconPadding(this.txtMilage, ((int)(resources.GetObject("txtMilage.IconPadding"))));
            this.txtMilage.Name = "txtMilage";
            this.txtMilage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMilage_KeyPress);
            this.txtMilage.Validating += new System.ComponentModel.CancelEventHandler(this.txtMilage_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.ep.SetError(this.label1, resources.GetString("label1.Error"));
            this.ep.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.ep.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            resources.ApplyResources(this.ep, "ep");
            // 
            // pictureBox24
            // 
            resources.ApplyResources(this.pictureBox24, "pictureBox24");
            this.ep.SetError(this.pictureBox24, resources.GetString("pictureBox24.Error"));
            this.ep.SetIconAlignment(this.pictureBox24, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox24.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox24, ((int)(resources.GetObject("pictureBox24.IconPadding"))));
            this.pictureBox24.Image = global::CarRental.Properties.Resources.icons8_1_100;
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.TabStop = false;
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
            // pictureBox10
            // 
            resources.ApplyResources(this.pictureBox10, "pictureBox10");
            this.ep.SetError(this.pictureBox10, resources.GetString("pictureBox10.Error"));
            this.ep.SetIconAlignment(this.pictureBox10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox10.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox10, ((int)(resources.GetObject("pictureBox10.IconPadding"))));
            this.pictureBox10.Image = global::CarRental.Properties.Resources.Icno_Edit;
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.ep.SetError(this.pictureBox9, resources.GetString("pictureBox9.Error"));
            this.ep.SetIconAlignment(this.pictureBox9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox9.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox9, ((int)(resources.GetObject("pictureBox9.IconPadding"))));
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.ep.SetError(this.pictureBox8, resources.GetString("pictureBox8.Error"));
            this.ep.SetIconAlignment(this.pictureBox8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox8.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox8, ((int)(resources.GetObject("pictureBox8.IconPadding"))));
            this.pictureBox8.Image = global::CarRental.Properties.Resources.icon_Days;
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.ep.SetError(this.pictureBox7, resources.GetString("pictureBox7.Error"));
            this.ep.SetIconAlignment(this.pictureBox7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox7.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox7, ((int)(resources.GetObject("pictureBox7.IconPadding"))));
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.ep.SetError(this.pictureBox6, resources.GetString("pictureBox6.Error"));
            this.ep.SetIconAlignment(this.pictureBox6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox6.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox6, ((int)(resources.GetObject("pictureBox6.IconPadding"))));
            this.pictureBox6.Image = global::CarRental.Properties.Resources.icon_Milage;
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.ep.SetError(this.pictureBox5, resources.GetString("pictureBox5.Error"));
            this.ep.SetIconAlignment(this.pictureBox5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox5.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox5, ((int)(resources.GetObject("pictureBox5.IconPadding"))));
            this.pictureBox5.Image = global::CarRental.Properties.Resources.icon_FuelLevel;
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.ep.SetError(this.pictureBox4, resources.GetString("pictureBox4.Error"));
            this.ep.SetIconAlignment(this.pictureBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox4.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox4, ((int)(resources.GetObject("pictureBox4.IconPadding"))));
            this.pictureBox4.Image = global::CarRental.Properties.Resources.icons8_status_50;
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
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.ep.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error"));
            this.ep.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding"))));
            this.pictureBox2.Image = global::CarRental.Properties.Resources.icon_Transaction;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.ep.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.ep.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Image = global::CarRental.Properties.Resources.icon_Rent100;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmReturn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmReturn";
            this.Load += new System.EventHandler(this.frmAddRent_Load);
            this.tc.ResumeLayout(false);
            this.tpBookingInfo.ResumeLayout(false);
            this.tpBookingInfo.PerformLayout();
            this.tpReturnDetails.ResumeLayout(false);
            this.gbReturn.ResumeLayout(false);
            this.gbReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpBookingInfo;
        private ctrlRentInfoWithFilter ctrlRentInfoWithFilter1;
        private System.Windows.Forms.TabPage tpReturnDetails;
        private System.Windows.Forms.GroupBox gbReturn;
        private System.Windows.Forms.TextBox txtAddtionalCharges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMilage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFuelLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbReturnCondation;
        private System.Windows.Forms.Label lblTotalDueAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRentalDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}