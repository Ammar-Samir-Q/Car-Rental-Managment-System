namespace CarRental
{
    partial class frmAddUpdateRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateRent));
            tcRent = new TabControl();
            tpPerson = new TabPage();
            label15 = new Label();
            pictureBox24 = new PictureBox();
            btnNext = new Button();
            gbSelectPerosn = new GroupBox();
            ctrlPersonInfoWithFilter1 = new ctrlPersonInfoWithFilter();
            tpVehicle = new TabPage();
            label13 = new Label();
            gbSelectVehicle = new GroupBox();
            button3 = new Button();
            ctrlVehicleInfo1 = new ctrlVehicleInfo();
            pictureBox23 = new PictureBox();
            btnNextVehicle = new Button();
            tpRentInfo = new TabPage();
            label11 = new Label();
            gbRentInfo = new GroupBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            txtPaymentDetails = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtInitialNotes = new TextBox();
            label4 = new Label();
            txtDropOffLocation = new TextBox();
            txtPickupLocation = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            pictureBox22 = new PictureBox();
            btnNextRent = new Button();
            tpSummary = new TabPage();
            gbSummary = new GroupBox();
            label1 = new Label();
            pictureBox21 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox17 = new PictureBox();
            linklblVehicleInfo = new LinkLabel();
            linklblCustomerInfo = new LinkLabel();
            lblEndDate = new Label();
            lblStartDate = new Label();
            groupBox3 = new GroupBox();
            pictureBox16 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox13 = new PictureBox();
            label25 = new Label();
            label22 = new Label();
            lblTransactionID = new Label();
            lblTotalDays = new Label();
            lblTransactionIDTitla = new Label();
            label24 = new Label();
            lblRentID = new Label();
            lblTotalInitialAmount = new Label();
            groupBox2 = new GroupBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            label16 = new Label();
            label14 = new Label();
            lblVehicleModel = new Label();
            lblRentalPricePerDay = new Label();
            label18 = new Label();
            lblCurrentMilage = new Label();
            groupBox1 = new GroupBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            label12 = new Label();
            label9 = new Label();
            lblCustomerName = new Label();
            lblDriverLicenseNumber = new Label();
            lblTitle = new Label();
            btnClose = new Button();
            ep = new ErrorProvider(components);
            btnSave = new Button();
            tcRent.SuspendLayout();
            tpPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            gbSelectPerosn.SuspendLayout();
            tpVehicle.SuspendLayout();
            gbSelectVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            tpRentInfo.SuspendLayout();
            gbRentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            tpSummary.SuspendLayout();
            gbSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // tcRent
            // 
            resources.ApplyResources(tcRent, "tcRent");
            tcRent.Controls.Add(tpPerson);
            tcRent.Controls.Add(tpVehicle);
            tcRent.Controls.Add(tpRentInfo);
            tcRent.Controls.Add(tpSummary);
            ep.SetError(tcRent, resources.GetString("tcRent.Error"));
            ep.SetIconAlignment(tcRent, (ErrorIconAlignment)resources.GetObject("tcRent.IconAlignment"));
            ep.SetIconPadding(tcRent, (int)resources.GetObject("tcRent.IconPadding"));
            tcRent.Name = "tcRent";
            tcRent.SelectedIndex = 0;
            // 
            // tpPerson
            // 
            resources.ApplyResources(tpPerson, "tpPerson");
            tpPerson.Controls.Add(label15);
            tpPerson.Controls.Add(pictureBox24);
            tpPerson.Controls.Add(btnNext);
            tpPerson.Controls.Add(gbSelectPerosn);
            ep.SetError(tpPerson, resources.GetString("tpPerson.Error"));
            ep.SetIconAlignment(tpPerson, (ErrorIconAlignment)resources.GetObject("tpPerson.IconAlignment"));
            ep.SetIconPadding(tpPerson, (int)resources.GetObject("tpPerson.IconPadding"));
            tpPerson.Name = "tpPerson";
            tpPerson.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            ep.SetError(label15, resources.GetString("label15.Error"));
            ep.SetIconAlignment(label15, (ErrorIconAlignment)resources.GetObject("label15.IconAlignment"));
            ep.SetIconPadding(label15, (int)resources.GetObject("label15.IconPadding"));
            label15.Name = "label15";
            // 
            // pictureBox24
            // 
            resources.ApplyResources(pictureBox24, "pictureBox24");
            ep.SetError(pictureBox24, resources.GetString("pictureBox24.Error"));
            ep.SetIconAlignment(pictureBox24, (ErrorIconAlignment)resources.GetObject("pictureBox24.IconAlignment"));
            ep.SetIconPadding(pictureBox24, (int)resources.GetObject("pictureBox24.IconPadding"));
            pictureBox24.Image = Properties.Resources.icons8_1_100;
            pictureBox24.Name = "pictureBox24";
            pictureBox24.TabStop = false;
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            ep.SetError(btnNext, resources.GetString("btnNext.Error"));
            ep.SetIconAlignment(btnNext, (ErrorIconAlignment)resources.GetObject("btnNext.IconAlignment"));
            ep.SetIconPadding(btnNext, (int)resources.GetObject("btnNext.IconPadding"));
            btnNext.Image = Properties.Resources.icon_NextBlack;
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // gbSelectPerosn
            // 
            resources.ApplyResources(gbSelectPerosn, "gbSelectPerosn");
            gbSelectPerosn.Controls.Add(ctrlPersonInfoWithFilter1);
            ep.SetError(gbSelectPerosn, resources.GetString("gbSelectPerosn.Error"));
            ep.SetIconAlignment(gbSelectPerosn, (ErrorIconAlignment)resources.GetObject("gbSelectPerosn.IconAlignment"));
            ep.SetIconPadding(gbSelectPerosn, (int)resources.GetObject("gbSelectPerosn.IconPadding"));
            gbSelectPerosn.Name = "gbSelectPerosn";
            gbSelectPerosn.TabStop = false;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            resources.ApplyResources(ctrlPersonInfoWithFilter1, "ctrlPersonInfoWithFilter1");
            ep.SetError(ctrlPersonInfoWithFilter1, resources.GetString("ctrlPersonInfoWithFilter1.Error"));
            ep.SetIconAlignment(ctrlPersonInfoWithFilter1, (ErrorIconAlignment)resources.GetObject("ctrlPersonInfoWithFilter1.IconAlignment"));
            ep.SetIconPadding(ctrlPersonInfoWithFilter1, (int)resources.GetObject("ctrlPersonInfoWithFilter1.IconPadding"));
            ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            // 
            // tpVehicle
            // 
            resources.ApplyResources(tpVehicle, "tpVehicle");
            tpVehicle.Controls.Add(label13);
            tpVehicle.Controls.Add(gbSelectVehicle);
            tpVehicle.Controls.Add(pictureBox23);
            tpVehicle.Controls.Add(btnNextVehicle);
            ep.SetError(tpVehicle, resources.GetString("tpVehicle.Error"));
            ep.SetIconAlignment(tpVehicle, (ErrorIconAlignment)resources.GetObject("tpVehicle.IconAlignment"));
            ep.SetIconPadding(tpVehicle, (int)resources.GetObject("tpVehicle.IconPadding"));
            tpVehicle.Name = "tpVehicle";
            tpVehicle.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            ep.SetError(label13, resources.GetString("label13.Error"));
            ep.SetIconAlignment(label13, (ErrorIconAlignment)resources.GetObject("label13.IconAlignment"));
            ep.SetIconPadding(label13, (int)resources.GetObject("label13.IconPadding"));
            label13.Name = "label13";
            // 
            // gbSelectVehicle
            // 
            resources.ApplyResources(gbSelectVehicle, "gbSelectVehicle");
            gbSelectVehicle.Controls.Add(button3);
            gbSelectVehicle.Controls.Add(ctrlVehicleInfo1);
            ep.SetError(gbSelectVehicle, resources.GetString("gbSelectVehicle.Error"));
            ep.SetIconAlignment(gbSelectVehicle, (ErrorIconAlignment)resources.GetObject("gbSelectVehicle.IconAlignment"));
            ep.SetIconPadding(gbSelectVehicle, (int)resources.GetObject("gbSelectVehicle.IconPadding"));
            gbSelectVehicle.Name = "gbSelectVehicle";
            gbSelectVehicle.TabStop = false;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            ep.SetError(button3, resources.GetString("button3.Error"));
            ep.SetIconAlignment(button3, (ErrorIconAlignment)resources.GetObject("button3.IconAlignment"));
            ep.SetIconPadding(button3, (int)resources.GetObject("button3.IconPadding"));
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ctrlVehicleInfo1
            // 
            resources.ApplyResources(ctrlVehicleInfo1, "ctrlVehicleInfo1");
            ep.SetError(ctrlVehicleInfo1, resources.GetString("ctrlVehicleInfo1.Error"));
            ep.SetIconAlignment(ctrlVehicleInfo1, (ErrorIconAlignment)resources.GetObject("ctrlVehicleInfo1.IconAlignment"));
            ep.SetIconPadding(ctrlVehicleInfo1, (int)resources.GetObject("ctrlVehicleInfo1.IconPadding"));
            ctrlVehicleInfo1.Name = "ctrlVehicleInfo1";
            // 
            // pictureBox23
            // 
            resources.ApplyResources(pictureBox23, "pictureBox23");
            ep.SetError(pictureBox23, resources.GetString("pictureBox23.Error"));
            ep.SetIconAlignment(pictureBox23, (ErrorIconAlignment)resources.GetObject("pictureBox23.IconAlignment"));
            ep.SetIconPadding(pictureBox23, (int)resources.GetObject("pictureBox23.IconPadding"));
            pictureBox23.Image = Properties.Resources.icons8_2_100;
            pictureBox23.Name = "pictureBox23";
            pictureBox23.TabStop = false;
            // 
            // btnNextVehicle
            // 
            resources.ApplyResources(btnNextVehicle, "btnNextVehicle");
            ep.SetError(btnNextVehicle, resources.GetString("btnNextVehicle.Error"));
            ep.SetIconAlignment(btnNextVehicle, (ErrorIconAlignment)resources.GetObject("btnNextVehicle.IconAlignment"));
            ep.SetIconPadding(btnNextVehicle, (int)resources.GetObject("btnNextVehicle.IconPadding"));
            btnNextVehicle.Image = Properties.Resources.icon_NextBlack;
            btnNextVehicle.Name = "btnNextVehicle";
            btnNextVehicle.UseVisualStyleBackColor = true;
            btnNextVehicle.Click += btnNextVehicle_Click;
            // 
            // tpRentInfo
            // 
            resources.ApplyResources(tpRentInfo, "tpRentInfo");
            tpRentInfo.Controls.Add(label11);
            tpRentInfo.Controls.Add(gbRentInfo);
            tpRentInfo.Controls.Add(pictureBox22);
            tpRentInfo.Controls.Add(btnNextRent);
            ep.SetError(tpRentInfo, resources.GetString("tpRentInfo.Error"));
            ep.SetIconAlignment(tpRentInfo, (ErrorIconAlignment)resources.GetObject("tpRentInfo.IconAlignment"));
            ep.SetIconPadding(tpRentInfo, (int)resources.GetObject("tpRentInfo.IconPadding"));
            tpRentInfo.Name = "tpRentInfo";
            tpRentInfo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            ep.SetError(label11, resources.GetString("label11.Error"));
            ep.SetIconAlignment(label11, (ErrorIconAlignment)resources.GetObject("label11.IconAlignment"));
            ep.SetIconPadding(label11, (int)resources.GetObject("label11.IconPadding"));
            label11.Name = "label11";
            // 
            // gbRentInfo
            // 
            resources.ApplyResources(gbRentInfo, "gbRentInfo");
            gbRentInfo.Controls.Add(pictureBox7);
            gbRentInfo.Controls.Add(pictureBox6);
            gbRentInfo.Controls.Add(pictureBox5);
            gbRentInfo.Controls.Add(pictureBox4);
            gbRentInfo.Controls.Add(pictureBox3);
            gbRentInfo.Controls.Add(pictureBox2);
            gbRentInfo.Controls.Add(pictureBox1);
            gbRentInfo.Controls.Add(label10);
            gbRentInfo.Controls.Add(txtPaymentDetails);
            gbRentInfo.Controls.Add(label8);
            gbRentInfo.Controls.Add(label7);
            gbRentInfo.Controls.Add(txtInitialNotes);
            gbRentInfo.Controls.Add(label4);
            gbRentInfo.Controls.Add(txtDropOffLocation);
            gbRentInfo.Controls.Add(txtPickupLocation);
            gbRentInfo.Controls.Add(label6);
            gbRentInfo.Controls.Add(label5);
            gbRentInfo.Controls.Add(dtpEndDate);
            gbRentInfo.Controls.Add(dtpStartDate);
            ep.SetError(gbRentInfo, resources.GetString("gbRentInfo.Error"));
            ep.SetIconAlignment(gbRentInfo, (ErrorIconAlignment)resources.GetObject("gbRentInfo.IconAlignment"));
            ep.SetIconPadding(gbRentInfo, (int)resources.GetObject("gbRentInfo.IconPadding"));
            gbRentInfo.Name = "gbRentInfo";
            gbRentInfo.TabStop = false;
            // 
            // pictureBox7
            // 
            resources.ApplyResources(pictureBox7, "pictureBox7");
            ep.SetError(pictureBox7, resources.GetString("pictureBox7.Error"));
            ep.SetIconAlignment(pictureBox7, (ErrorIconAlignment)resources.GetObject("pictureBox7.IconAlignment"));
            ep.SetIconPadding(pictureBox7, (int)resources.GetObject("pictureBox7.IconPadding"));
            pictureBox7.Name = "pictureBox7";
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            resources.ApplyResources(pictureBox6, "pictureBox6");
            ep.SetError(pictureBox6, resources.GetString("pictureBox6.Error"));
            ep.SetIconAlignment(pictureBox6, (ErrorIconAlignment)resources.GetObject("pictureBox6.IconAlignment"));
            ep.SetIconPadding(pictureBox6, (int)resources.GetObject("pictureBox6.IconPadding"));
            pictureBox6.Image = Properties.Resources.icon_PaymentMethod;
            pictureBox6.Name = "pictureBox6";
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(pictureBox5, "pictureBox5");
            ep.SetError(pictureBox5, resources.GetString("pictureBox5.Error"));
            ep.SetIconAlignment(pictureBox5, (ErrorIconAlignment)resources.GetObject("pictureBox5.IconAlignment"));
            ep.SetIconPadding(pictureBox5, (int)resources.GetObject("pictureBox5.IconPadding"));
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(pictureBox4, "pictureBox4");
            ep.SetError(pictureBox4, resources.GetString("pictureBox4.Error"));
            ep.SetIconAlignment(pictureBox4, (ErrorIconAlignment)resources.GetObject("pictureBox4.IconAlignment"));
            ep.SetIconPadding(pictureBox4, (int)resources.GetObject("pictureBox4.IconPadding"));
            pictureBox4.Image = Properties.Resources.Icno_Edit;
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            ep.SetError(pictureBox3, resources.GetString("pictureBox3.Error"));
            ep.SetIconAlignment(pictureBox3, (ErrorIconAlignment)resources.GetObject("pictureBox3.IconAlignment"));
            ep.SetIconPadding(pictureBox3, (int)resources.GetObject("pictureBox3.IconPadding"));
            pictureBox3.Image = Properties.Resources.icons8_date_50;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            ep.SetError(pictureBox2, resources.GetString("pictureBox2.Error"));
            ep.SetIconAlignment(pictureBox2, (ErrorIconAlignment)resources.GetObject("pictureBox2.IconAlignment"));
            ep.SetIconPadding(pictureBox2, (int)resources.GetObject("pictureBox2.IconPadding"));
            pictureBox2.Image = Properties.Resources.icon_To;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            ep.SetError(pictureBox1, resources.GetString("pictureBox1.Error"));
            ep.SetIconAlignment(pictureBox1, (ErrorIconAlignment)resources.GetObject("pictureBox1.IconAlignment"));
            ep.SetIconPadding(pictureBox1, (int)resources.GetObject("pictureBox1.IconPadding"));
            pictureBox1.Image = Properties.Resources.icons8_date_50;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            ep.SetError(label10, resources.GetString("label10.Error"));
            ep.SetIconAlignment(label10, (ErrorIconAlignment)resources.GetObject("label10.IconAlignment"));
            ep.SetIconPadding(label10, (int)resources.GetObject("label10.IconPadding"));
            label10.Name = "label10";
            // 
            // txtPaymentDetails
            // 
            resources.ApplyResources(txtPaymentDetails, "txtPaymentDetails");
            ep.SetError(txtPaymentDetails, resources.GetString("txtPaymentDetails.Error"));
            ep.SetIconAlignment(txtPaymentDetails, (ErrorIconAlignment)resources.GetObject("txtPaymentDetails.IconAlignment"));
            ep.SetIconPadding(txtPaymentDetails, (int)resources.GetObject("txtPaymentDetails.IconPadding"));
            txtPaymentDetails.Name = "txtPaymentDetails";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            ep.SetError(label8, resources.GetString("label8.Error"));
            ep.SetIconAlignment(label8, (ErrorIconAlignment)resources.GetObject("label8.IconAlignment"));
            ep.SetIconPadding(label8, (int)resources.GetObject("label8.IconPadding"));
            label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            ep.SetError(label7, resources.GetString("label7.Error"));
            ep.SetIconAlignment(label7, (ErrorIconAlignment)resources.GetObject("label7.IconAlignment"));
            ep.SetIconPadding(label7, (int)resources.GetObject("label7.IconPadding"));
            label7.Name = "label7";
            // 
            // txtInitialNotes
            // 
            resources.ApplyResources(txtInitialNotes, "txtInitialNotes");
            ep.SetError(txtInitialNotes, resources.GetString("txtInitialNotes.Error"));
            ep.SetIconAlignment(txtInitialNotes, (ErrorIconAlignment)resources.GetObject("txtInitialNotes.IconAlignment"));
            ep.SetIconPadding(txtInitialNotes, (int)resources.GetObject("txtInitialNotes.IconPadding"));
            txtInitialNotes.Name = "txtInitialNotes";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            ep.SetError(label4, resources.GetString("label4.Error"));
            ep.SetIconAlignment(label4, (ErrorIconAlignment)resources.GetObject("label4.IconAlignment"));
            ep.SetIconPadding(label4, (int)resources.GetObject("label4.IconPadding"));
            label4.Name = "label4";
            // 
            // txtDropOffLocation
            // 
            resources.ApplyResources(txtDropOffLocation, "txtDropOffLocation");
            ep.SetError(txtDropOffLocation, resources.GetString("txtDropOffLocation.Error"));
            ep.SetIconAlignment(txtDropOffLocation, (ErrorIconAlignment)resources.GetObject("txtDropOffLocation.IconAlignment"));
            ep.SetIconPadding(txtDropOffLocation, (int)resources.GetObject("txtDropOffLocation.IconPadding"));
            txtDropOffLocation.Name = "txtDropOffLocation";
            // 
            // txtPickupLocation
            // 
            resources.ApplyResources(txtPickupLocation, "txtPickupLocation");
            ep.SetError(txtPickupLocation, resources.GetString("txtPickupLocation.Error"));
            ep.SetIconAlignment(txtPickupLocation, (ErrorIconAlignment)resources.GetObject("txtPickupLocation.IconAlignment"));
            ep.SetIconPadding(txtPickupLocation, (int)resources.GetObject("txtPickupLocation.IconPadding"));
            txtPickupLocation.Name = "txtPickupLocation";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            ep.SetError(label6, resources.GetString("label6.Error"));
            ep.SetIconAlignment(label6, (ErrorIconAlignment)resources.GetObject("label6.IconAlignment"));
            ep.SetIconPadding(label6, (int)resources.GetObject("label6.IconPadding"));
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            ep.SetError(label5, resources.GetString("label5.Error"));
            ep.SetIconAlignment(label5, (ErrorIconAlignment)resources.GetObject("label5.IconAlignment"));
            ep.SetIconPadding(label5, (int)resources.GetObject("label5.IconPadding"));
            label5.Name = "label5";
            // 
            // dtpEndDate
            // 
            resources.ApplyResources(dtpEndDate, "dtpEndDate");
            ep.SetError(dtpEndDate, resources.GetString("dtpEndDate.Error"));
            dtpEndDate.Format = DateTimePickerFormat.Short;
            ep.SetIconAlignment(dtpEndDate, (ErrorIconAlignment)resources.GetObject("dtpEndDate.IconAlignment"));
            ep.SetIconPadding(dtpEndDate, (int)resources.GetObject("dtpEndDate.IconPadding"));
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // dtpStartDate
            // 
            resources.ApplyResources(dtpStartDate, "dtpStartDate");
            ep.SetError(dtpStartDate, resources.GetString("dtpStartDate.Error"));
            dtpStartDate.Format = DateTimePickerFormat.Short;
            ep.SetIconAlignment(dtpStartDate, (ErrorIconAlignment)resources.GetObject("dtpStartDate.IconAlignment"));
            ep.SetIconPadding(dtpStartDate, (int)resources.GetObject("dtpStartDate.IconPadding"));
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // pictureBox22
            // 
            resources.ApplyResources(pictureBox22, "pictureBox22");
            ep.SetError(pictureBox22, resources.GetString("pictureBox22.Error"));
            ep.SetIconAlignment(pictureBox22, (ErrorIconAlignment)resources.GetObject("pictureBox22.IconAlignment"));
            ep.SetIconPadding(pictureBox22, (int)resources.GetObject("pictureBox22.IconPadding"));
            pictureBox22.Image = Properties.Resources.icons8_3_100;
            pictureBox22.Name = "pictureBox22";
            pictureBox22.TabStop = false;
            // 
            // btnNextRent
            // 
            resources.ApplyResources(btnNextRent, "btnNextRent");
            ep.SetError(btnNextRent, resources.GetString("btnNextRent.Error"));
            ep.SetIconAlignment(btnNextRent, (ErrorIconAlignment)resources.GetObject("btnNextRent.IconAlignment"));
            ep.SetIconPadding(btnNextRent, (int)resources.GetObject("btnNextRent.IconPadding"));
            btnNextRent.Image = Properties.Resources.icon_NextBlack;
            btnNextRent.Name = "btnNextRent";
            btnNextRent.UseVisualStyleBackColor = true;
            btnNextRent.Click += btnNextRent_Click;
            // 
            // tpSummary
            // 
            resources.ApplyResources(tpSummary, "tpSummary");
            tpSummary.Controls.Add(gbSummary);
            ep.SetError(tpSummary, resources.GetString("tpSummary.Error"));
            ep.SetIconAlignment(tpSummary, (ErrorIconAlignment)resources.GetObject("tpSummary.IconAlignment"));
            ep.SetIconPadding(tpSummary, (int)resources.GetObject("tpSummary.IconPadding"));
            tpSummary.Name = "tpSummary";
            tpSummary.UseVisualStyleBackColor = true;
            // 
            // gbSummary
            // 
            resources.ApplyResources(gbSummary, "gbSummary");
            gbSummary.Controls.Add(label1);
            gbSummary.Controls.Add(pictureBox21);
            gbSummary.Controls.Add(pictureBox20);
            gbSummary.Controls.Add(pictureBox19);
            gbSummary.Controls.Add(pictureBox18);
            gbSummary.Controls.Add(pictureBox17);
            gbSummary.Controls.Add(linklblVehicleInfo);
            gbSummary.Controls.Add(linklblCustomerInfo);
            gbSummary.Controls.Add(lblEndDate);
            gbSummary.Controls.Add(lblStartDate);
            gbSummary.Controls.Add(groupBox3);
            gbSummary.Controls.Add(groupBox2);
            gbSummary.Controls.Add(groupBox1);
            ep.SetError(gbSummary, resources.GetString("gbSummary.Error"));
            ep.SetIconAlignment(gbSummary, (ErrorIconAlignment)resources.GetObject("gbSummary.IconAlignment"));
            ep.SetIconPadding(gbSummary, (int)resources.GetObject("gbSummary.IconPadding"));
            gbSummary.Name = "gbSummary";
            gbSummary.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            ep.SetError(label1, resources.GetString("label1.Error"));
            ep.SetIconAlignment(label1, (ErrorIconAlignment)resources.GetObject("label1.IconAlignment"));
            ep.SetIconPadding(label1, (int)resources.GetObject("label1.IconPadding"));
            label1.Name = "label1";
            // 
            // pictureBox21
            // 
            resources.ApplyResources(pictureBox21, "pictureBox21");
            ep.SetError(pictureBox21, resources.GetString("pictureBox21.Error"));
            ep.SetIconAlignment(pictureBox21, (ErrorIconAlignment)resources.GetObject("pictureBox21.IconAlignment"));
            ep.SetIconPadding(pictureBox21, (int)resources.GetObject("pictureBox21.IconPadding"));
            pictureBox21.Image = Properties.Resources.icons8_summary_100;
            pictureBox21.Name = "pictureBox21";
            pictureBox21.TabStop = false;
            // 
            // pictureBox20
            // 
            resources.ApplyResources(pictureBox20, "pictureBox20");
            ep.SetError(pictureBox20, resources.GetString("pictureBox20.Error"));
            ep.SetIconAlignment(pictureBox20, (ErrorIconAlignment)resources.GetObject("pictureBox20.IconAlignment"));
            ep.SetIconPadding(pictureBox20, (int)resources.GetObject("pictureBox20.IconPadding"));
            pictureBox20.Image = Properties.Resources.icon_Rent100;
            pictureBox20.Name = "pictureBox20";
            pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            resources.ApplyResources(pictureBox19, "pictureBox19");
            ep.SetError(pictureBox19, resources.GetString("pictureBox19.Error"));
            ep.SetIconAlignment(pictureBox19, (ErrorIconAlignment)resources.GetObject("pictureBox19.IconAlignment"));
            ep.SetIconPadding(pictureBox19, (int)resources.GetObject("pictureBox19.IconPadding"));
            pictureBox19.Image = Properties.Resources.icons8_date_50;
            pictureBox19.Name = "pictureBox19";
            pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            resources.ApplyResources(pictureBox18, "pictureBox18");
            ep.SetError(pictureBox18, resources.GetString("pictureBox18.Error"));
            ep.SetIconAlignment(pictureBox18, (ErrorIconAlignment)resources.GetObject("pictureBox18.IconAlignment"));
            ep.SetIconPadding(pictureBox18, (int)resources.GetObject("pictureBox18.IconPadding"));
            pictureBox18.Image = Properties.Resources.icons8_date_50;
            pictureBox18.Name = "pictureBox18";
            pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            resources.ApplyResources(pictureBox17, "pictureBox17");
            ep.SetError(pictureBox17, resources.GetString("pictureBox17.Error"));
            ep.SetIconAlignment(pictureBox17, (ErrorIconAlignment)resources.GetObject("pictureBox17.IconAlignment"));
            ep.SetIconPadding(pictureBox17, (int)resources.GetObject("pictureBox17.IconPadding"));
            pictureBox17.Image = Properties.Resources.icon_To;
            pictureBox17.Name = "pictureBox17";
            pictureBox17.TabStop = false;
            // 
            // linklblVehicleInfo
            // 
            resources.ApplyResources(linklblVehicleInfo, "linklblVehicleInfo");
            ep.SetError(linklblVehicleInfo, resources.GetString("linklblVehicleInfo.Error"));
            ep.SetIconAlignment(linklblVehicleInfo, (ErrorIconAlignment)resources.GetObject("linklblVehicleInfo.IconAlignment"));
            ep.SetIconPadding(linklblVehicleInfo, (int)resources.GetObject("linklblVehicleInfo.IconPadding"));
            linklblVehicleInfo.Name = "linklblVehicleInfo";
            linklblVehicleInfo.TabStop = true;
            linklblVehicleInfo.LinkClicked += linklblVehicleInfo_LinkClicked;
            // 
            // linklblCustomerInfo
            // 
            resources.ApplyResources(linklblCustomerInfo, "linklblCustomerInfo");
            ep.SetError(linklblCustomerInfo, resources.GetString("linklblCustomerInfo.Error"));
            ep.SetIconAlignment(linklblCustomerInfo, (ErrorIconAlignment)resources.GetObject("linklblCustomerInfo.IconAlignment"));
            ep.SetIconPadding(linklblCustomerInfo, (int)resources.GetObject("linklblCustomerInfo.IconPadding"));
            linklblCustomerInfo.Name = "linklblCustomerInfo";
            linklblCustomerInfo.TabStop = true;
            linklblCustomerInfo.LinkClicked += linklblCustomerInfo_LinkClicked;
            // 
            // lblEndDate
            // 
            resources.ApplyResources(lblEndDate, "lblEndDate");
            ep.SetError(lblEndDate, resources.GetString("lblEndDate.Error"));
            lblEndDate.ForeColor = Color.Black;
            ep.SetIconAlignment(lblEndDate, (ErrorIconAlignment)resources.GetObject("lblEndDate.IconAlignment"));
            ep.SetIconPadding(lblEndDate, (int)resources.GetObject("lblEndDate.IconPadding"));
            lblEndDate.Name = "lblEndDate";
            // 
            // lblStartDate
            // 
            resources.ApplyResources(lblStartDate, "lblStartDate");
            ep.SetError(lblStartDate, resources.GetString("lblStartDate.Error"));
            lblStartDate.ForeColor = Color.Black;
            ep.SetIconAlignment(lblStartDate, (ErrorIconAlignment)resources.GetObject("lblStartDate.IconAlignment"));
            ep.SetIconPadding(lblStartDate, (int)resources.GetObject("lblStartDate.IconPadding"));
            lblStartDate.Name = "lblStartDate";
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(pictureBox16);
            groupBox3.Controls.Add(pictureBox15);
            groupBox3.Controls.Add(pictureBox14);
            groupBox3.Controls.Add(pictureBox13);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(lblTransactionID);
            groupBox3.Controls.Add(lblTotalDays);
            groupBox3.Controls.Add(lblTransactionIDTitla);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(lblRentID);
            groupBox3.Controls.Add(lblTotalInitialAmount);
            ep.SetError(groupBox3, resources.GetString("groupBox3.Error"));
            ep.SetIconAlignment(groupBox3, (ErrorIconAlignment)resources.GetObject("groupBox3.IconAlignment"));
            ep.SetIconPadding(groupBox3, (int)resources.GetObject("groupBox3.IconPadding"));
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // pictureBox16
            // 
            resources.ApplyResources(pictureBox16, "pictureBox16");
            ep.SetError(pictureBox16, resources.GetString("pictureBox16.Error"));
            ep.SetIconAlignment(pictureBox16, (ErrorIconAlignment)resources.GetObject("pictureBox16.IconAlignment"));
            ep.SetIconPadding(pictureBox16, (int)resources.GetObject("pictureBox16.IconPadding"));
            pictureBox16.Image = Properties.Resources.icon_Transaction;
            pictureBox16.Name = "pictureBox16";
            pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            resources.ApplyResources(pictureBox15, "pictureBox15");
            ep.SetError(pictureBox15, resources.GetString("pictureBox15.Error"));
            ep.SetIconAlignment(pictureBox15, (ErrorIconAlignment)resources.GetObject("pictureBox15.IconAlignment"));
            ep.SetIconPadding(pictureBox15, (int)resources.GetObject("pictureBox15.IconPadding"));
            pictureBox15.Image = Properties.Resources.icon_Rent;
            pictureBox15.Name = "pictureBox15";
            pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            resources.ApplyResources(pictureBox14, "pictureBox14");
            ep.SetError(pictureBox14, resources.GetString("pictureBox14.Error"));
            ep.SetIconAlignment(pictureBox14, (ErrorIconAlignment)resources.GetObject("pictureBox14.IconAlignment"));
            ep.SetIconPadding(pictureBox14, (int)resources.GetObject("pictureBox14.IconPadding"));
            pictureBox14.Image = Properties.Resources.icon_Days;
            pictureBox14.Name = "pictureBox14";
            pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            resources.ApplyResources(pictureBox13, "pictureBox13");
            ep.SetError(pictureBox13, resources.GetString("pictureBox13.Error"));
            ep.SetIconAlignment(pictureBox13, (ErrorIconAlignment)resources.GetObject("pictureBox13.IconAlignment"));
            ep.SetIconPadding(pictureBox13, (int)resources.GetObject("pictureBox13.IconPadding"));
            pictureBox13.Name = "pictureBox13";
            pictureBox13.TabStop = false;
            // 
            // label25
            // 
            resources.ApplyResources(label25, "label25");
            ep.SetError(label25, resources.GetString("label25.Error"));
            ep.SetIconAlignment(label25, (ErrorIconAlignment)resources.GetObject("label25.IconAlignment"));
            ep.SetIconPadding(label25, (int)resources.GetObject("label25.IconPadding"));
            label25.Name = "label25";
            // 
            // label22
            // 
            resources.ApplyResources(label22, "label22");
            ep.SetError(label22, resources.GetString("label22.Error"));
            ep.SetIconAlignment(label22, (ErrorIconAlignment)resources.GetObject("label22.IconAlignment"));
            ep.SetIconPadding(label22, (int)resources.GetObject("label22.IconPadding"));
            label22.Name = "label22";
            // 
            // lblTransactionID
            // 
            resources.ApplyResources(lblTransactionID, "lblTransactionID");
            ep.SetError(lblTransactionID, resources.GetString("lblTransactionID.Error"));
            lblTransactionID.ForeColor = Color.Red;
            ep.SetIconAlignment(lblTransactionID, (ErrorIconAlignment)resources.GetObject("lblTransactionID.IconAlignment"));
            ep.SetIconPadding(lblTransactionID, (int)resources.GetObject("lblTransactionID.IconPadding"));
            lblTransactionID.Name = "lblTransactionID";
            // 
            // lblTotalDays
            // 
            resources.ApplyResources(lblTotalDays, "lblTotalDays");
            ep.SetError(lblTotalDays, resources.GetString("lblTotalDays.Error"));
            ep.SetIconAlignment(lblTotalDays, (ErrorIconAlignment)resources.GetObject("lblTotalDays.IconAlignment"));
            ep.SetIconPadding(lblTotalDays, (int)resources.GetObject("lblTotalDays.IconPadding"));
            lblTotalDays.Name = "lblTotalDays";
            // 
            // lblTransactionIDTitla
            // 
            resources.ApplyResources(lblTransactionIDTitla, "lblTransactionIDTitla");
            ep.SetError(lblTransactionIDTitla, resources.GetString("lblTransactionIDTitla.Error"));
            ep.SetIconAlignment(lblTransactionIDTitla, (ErrorIconAlignment)resources.GetObject("lblTransactionIDTitla.IconAlignment"));
            ep.SetIconPadding(lblTransactionIDTitla, (int)resources.GetObject("lblTransactionIDTitla.IconPadding"));
            lblTransactionIDTitla.Name = "lblTransactionIDTitla";
            // 
            // label24
            // 
            resources.ApplyResources(label24, "label24");
            ep.SetError(label24, resources.GetString("label24.Error"));
            ep.SetIconAlignment(label24, (ErrorIconAlignment)resources.GetObject("label24.IconAlignment"));
            ep.SetIconPadding(label24, (int)resources.GetObject("label24.IconPadding"));
            label24.Name = "label24";
            // 
            // lblRentID
            // 
            resources.ApplyResources(lblRentID, "lblRentID");
            ep.SetError(lblRentID, resources.GetString("lblRentID.Error"));
            lblRentID.ForeColor = Color.Red;
            ep.SetIconAlignment(lblRentID, (ErrorIconAlignment)resources.GetObject("lblRentID.IconAlignment"));
            ep.SetIconPadding(lblRentID, (int)resources.GetObject("lblRentID.IconPadding"));
            lblRentID.Name = "lblRentID";
            // 
            // lblTotalInitialAmount
            // 
            resources.ApplyResources(lblTotalInitialAmount, "lblTotalInitialAmount");
            ep.SetError(lblTotalInitialAmount, resources.GetString("lblTotalInitialAmount.Error"));
            ep.SetIconAlignment(lblTotalInitialAmount, (ErrorIconAlignment)resources.GetObject("lblTotalInitialAmount.IconAlignment"));
            ep.SetIconPadding(lblTotalInitialAmount, (int)resources.GetObject("lblTotalInitialAmount.IconPadding"));
            lblTotalInitialAmount.Name = "lblTotalInitialAmount";
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(pictureBox12);
            groupBox2.Controls.Add(pictureBox11);
            groupBox2.Controls.Add(pictureBox10);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(lblVehicleModel);
            groupBox2.Controls.Add(lblRentalPricePerDay);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(lblCurrentMilage);
            ep.SetError(groupBox2, resources.GetString("groupBox2.Error"));
            ep.SetIconAlignment(groupBox2, (ErrorIconAlignment)resources.GetObject("groupBox2.IconAlignment"));
            ep.SetIconPadding(groupBox2, (int)resources.GetObject("groupBox2.IconPadding"));
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // pictureBox12
            // 
            resources.ApplyResources(pictureBox12, "pictureBox12");
            ep.SetError(pictureBox12, resources.GetString("pictureBox12.Error"));
            ep.SetIconAlignment(pictureBox12, (ErrorIconAlignment)resources.GetObject("pictureBox12.IconAlignment"));
            ep.SetIconPadding(pictureBox12, (int)resources.GetObject("pictureBox12.IconPadding"));
            pictureBox12.Image = Properties.Resources.icon_Milage;
            pictureBox12.Name = "pictureBox12";
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            resources.ApplyResources(pictureBox11, "pictureBox11");
            ep.SetError(pictureBox11, resources.GetString("pictureBox11.Error"));
            ep.SetIconAlignment(pictureBox11, (ErrorIconAlignment)resources.GetObject("pictureBox11.IconAlignment"));
            ep.SetIconPadding(pictureBox11, (int)resources.GetObject("pictureBox11.IconPadding"));
            pictureBox11.Image = Properties.Resources.icons8_vehicle_50;
            pictureBox11.Name = "pictureBox11";
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            resources.ApplyResources(pictureBox10, "pictureBox10");
            ep.SetError(pictureBox10, resources.GetString("pictureBox10.Error"));
            ep.SetIconAlignment(pictureBox10, (ErrorIconAlignment)resources.GetObject("pictureBox10.IconAlignment"));
            ep.SetIconPadding(pictureBox10, (int)resources.GetObject("pictureBox10.IconPadding"));
            pictureBox10.Name = "pictureBox10";
            pictureBox10.TabStop = false;
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            ep.SetError(label16, resources.GetString("label16.Error"));
            ep.SetIconAlignment(label16, (ErrorIconAlignment)resources.GetObject("label16.IconAlignment"));
            ep.SetIconPadding(label16, (int)resources.GetObject("label16.IconPadding"));
            label16.Name = "label16";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            ep.SetError(label14, resources.GetString("label14.Error"));
            ep.SetIconAlignment(label14, (ErrorIconAlignment)resources.GetObject("label14.IconAlignment"));
            ep.SetIconPadding(label14, (int)resources.GetObject("label14.IconPadding"));
            label14.Name = "label14";
            // 
            // lblVehicleModel
            // 
            resources.ApplyResources(lblVehicleModel, "lblVehicleModel");
            ep.SetError(lblVehicleModel, resources.GetString("lblVehicleModel.Error"));
            ep.SetIconAlignment(lblVehicleModel, (ErrorIconAlignment)resources.GetObject("lblVehicleModel.IconAlignment"));
            ep.SetIconPadding(lblVehicleModel, (int)resources.GetObject("lblVehicleModel.IconPadding"));
            lblVehicleModel.Name = "lblVehicleModel";
            // 
            // lblRentalPricePerDay
            // 
            resources.ApplyResources(lblRentalPricePerDay, "lblRentalPricePerDay");
            ep.SetError(lblRentalPricePerDay, resources.GetString("lblRentalPricePerDay.Error"));
            ep.SetIconAlignment(lblRentalPricePerDay, (ErrorIconAlignment)resources.GetObject("lblRentalPricePerDay.IconAlignment"));
            ep.SetIconPadding(lblRentalPricePerDay, (int)resources.GetObject("lblRentalPricePerDay.IconPadding"));
            lblRentalPricePerDay.Name = "lblRentalPricePerDay";
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            ep.SetError(label18, resources.GetString("label18.Error"));
            ep.SetIconAlignment(label18, (ErrorIconAlignment)resources.GetObject("label18.IconAlignment"));
            ep.SetIconPadding(label18, (int)resources.GetObject("label18.IconPadding"));
            label18.Name = "label18";
            // 
            // lblCurrentMilage
            // 
            resources.ApplyResources(lblCurrentMilage, "lblCurrentMilage");
            ep.SetError(lblCurrentMilage, resources.GetString("lblCurrentMilage.Error"));
            ep.SetIconAlignment(lblCurrentMilage, (ErrorIconAlignment)resources.GetObject("lblCurrentMilage.IconAlignment"));
            ep.SetIconPadding(lblCurrentMilage, (int)resources.GetObject("lblCurrentMilage.IconPadding"));
            lblCurrentMilage.Name = "lblCurrentMilage";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblCustomerName);
            groupBox1.Controls.Add(lblDriverLicenseNumber);
            ep.SetError(groupBox1, resources.GetString("groupBox1.Error"));
            ep.SetIconAlignment(groupBox1, (ErrorIconAlignment)resources.GetObject("groupBox1.IconAlignment"));
            ep.SetIconPadding(groupBox1, (int)resources.GetObject("groupBox1.IconPadding"));
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            resources.ApplyResources(pictureBox9, "pictureBox9");
            ep.SetError(pictureBox9, resources.GetString("pictureBox9.Error"));
            ep.SetIconAlignment(pictureBox9, (ErrorIconAlignment)resources.GetObject("pictureBox9.IconAlignment"));
            ep.SetIconPadding(pictureBox9, (int)resources.GetObject("pictureBox9.IconPadding"));
            pictureBox9.Image = Properties.Resources.icon_Name;
            pictureBox9.Name = "pictureBox9";
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            resources.ApplyResources(pictureBox8, "pictureBox8");
            ep.SetError(pictureBox8, resources.GetString("pictureBox8.Error"));
            ep.SetIconAlignment(pictureBox8, (ErrorIconAlignment)resources.GetObject("pictureBox8.IconAlignment"));
            ep.SetIconPadding(pictureBox8, (int)resources.GetObject("pictureBox8.IconPadding"));
            pictureBox8.Image = Properties.Resources.iconLicense;
            pictureBox8.Name = "pictureBox8";
            pictureBox8.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            ep.SetError(label12, resources.GetString("label12.Error"));
            ep.SetIconAlignment(label12, (ErrorIconAlignment)resources.GetObject("label12.IconAlignment"));
            ep.SetIconPadding(label12, (int)resources.GetObject("label12.IconPadding"));
            label12.Name = "label12";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            ep.SetError(label9, resources.GetString("label9.Error"));
            ep.SetIconAlignment(label9, (ErrorIconAlignment)resources.GetObject("label9.IconAlignment"));
            ep.SetIconPadding(label9, (int)resources.GetObject("label9.IconPadding"));
            label9.Name = "label9";
            // 
            // lblCustomerName
            // 
            resources.ApplyResources(lblCustomerName, "lblCustomerName");
            ep.SetError(lblCustomerName, resources.GetString("lblCustomerName.Error"));
            ep.SetIconAlignment(lblCustomerName, (ErrorIconAlignment)resources.GetObject("lblCustomerName.IconAlignment"));
            ep.SetIconPadding(lblCustomerName, (int)resources.GetObject("lblCustomerName.IconPadding"));
            lblCustomerName.Name = "lblCustomerName";
            // 
            // lblDriverLicenseNumber
            // 
            resources.ApplyResources(lblDriverLicenseNumber, "lblDriverLicenseNumber");
            ep.SetError(lblDriverLicenseNumber, resources.GetString("lblDriverLicenseNumber.Error"));
            ep.SetIconAlignment(lblDriverLicenseNumber, (ErrorIconAlignment)resources.GetObject("lblDriverLicenseNumber.IconAlignment"));
            ep.SetIconPadding(lblDriverLicenseNumber, (int)resources.GetObject("lblDriverLicenseNumber.IconPadding"));
            lblDriverLicenseNumber.Name = "lblDriverLicenseNumber";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            ep.SetError(lblTitle, resources.GetString("lblTitle.Error"));
            ep.SetIconAlignment(lblTitle, (ErrorIconAlignment)resources.GetObject("lblTitle.IconAlignment"));
            ep.SetIconPadding(lblTitle, (int)resources.GetObject("lblTitle.IconPadding"));
            lblTitle.Name = "lblTitle";
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            ep.SetError(btnClose, resources.GetString("btnClose.Error"));
            ep.SetIconAlignment(btnClose, (ErrorIconAlignment)resources.GetObject("btnClose.IconAlignment"));
            ep.SetIconPadding(btnClose, (int)resources.GetObject("btnClose.IconPadding"));
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            resources.ApplyResources(ep, "ep");
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            ep.SetError(btnSave, resources.GetString("btnSave.Error"));
            ep.SetIconAlignment(btnSave, (ErrorIconAlignment)resources.GetObject("btnSave.IconAlignment"));
            ep.SetIconPadding(btnSave, (int)resources.GetObject("btnSave.IconPadding"));
            btnSave.Image = Properties.Resources.icon_Save;
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateRent
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(tcRent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmAddUpdateRent";
            Load += frmAddRent_Load;
            tcRent.ResumeLayout(false);
            tpPerson.ResumeLayout(false);
            tpPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            gbSelectPerosn.ResumeLayout(false);
            tpVehicle.ResumeLayout(false);
            tpVehicle.PerformLayout();
            gbSelectVehicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            tpRentInfo.ResumeLayout(false);
            tpRentInfo.PerformLayout();
            gbRentInfo.ResumeLayout(false);
            gbRentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            tpSummary.ResumeLayout(false);
            gbSummary.ResumeLayout(false);
            gbSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcRent;
        private System.Windows.Forms.TabPage tpPerson;
        private System.Windows.Forms.TabPage tpVehicle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tpRentInfo;
        private System.Windows.Forms.TabPage tpSummary;
        private ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNextVehicle;
        private System.Windows.Forms.Button btnNextRent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPickupLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInitialNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDropOffLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label5;
        private ctrlVehicleInfo ctrlVehicleInfo1;
        private System.Windows.Forms.GroupBox gbSelectPerosn;
        private System.Windows.Forms.GroupBox gbSelectVehicle;
        private System.Windows.Forms.GroupBox gbRentInfo;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblRentID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblTotalDays;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCurrentMilage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblRentalPricePerDay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDriverLicenseNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalInitialAmount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label lblTransactionIDTitla;
        private System.Windows.Forms.LinkLabel linklblCustomerInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linklblVehicleInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPaymentDetails;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox21;
    }
}