namespace CarRental
{
    partial class frmAddUpdatePerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.brnCLose = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rbMale
            // 
            resources.ApplyResources(this.rbMale, "rbMale");
            this.rbMale.Checked = true;
            this.ep.SetError(this.rbMale, resources.GetString("rbMale.Error"));
            this.ep.SetIconAlignment(this.rbMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rbMale.IconAlignment"))));
            this.ep.SetIconPadding(this.rbMale, ((int)(resources.GetObject("rbMale.IconPadding"))));
            this.rbMale.Name = "rbMale";
            this.rbMale.TabStop = true;
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // dtpDateOfBirth
            // 
            resources.ApplyResources(this.dtpDateOfBirth, "dtpDateOfBirth");
            this.ep.SetError(this.dtpDateOfBirth, resources.GetString("dtpDateOfBirth.Error"));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ep.SetIconAlignment(this.dtpDateOfBirth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dtpDateOfBirth.IconAlignment"))));
            this.ep.SetIconPadding(this.dtpDateOfBirth, ((int)(resources.GetObject("dtpDateOfBirth.IconPadding"))));
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.ep.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.ep.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.ep.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.ep.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.ep.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
            this.ep.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
            this.lblTitle.Name = "lblTitle";
            // 
            // rbFemale
            // 
            resources.ApplyResources(this.rbFemale, "rbFemale");
            this.ep.SetError(this.rbFemale, resources.GetString("rbFemale.Error"));
            this.ep.SetIconAlignment(this.rbFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rbFemale.IconAlignment"))));
            this.ep.SetIconPadding(this.rbFemale, ((int)(resources.GetObject("rbFemale.IconPadding"))));
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.ep.SetError(this.label1, resources.GetString("label1.Error"));
            this.ep.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.ep.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // txtSecondName
            // 
            resources.ApplyResources(this.txtSecondName, "txtSecondName");
            this.ep.SetError(this.txtSecondName, resources.GetString("txtSecondName.Error"));
            this.ep.SetIconAlignment(this.txtSecondName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSecondName.IconAlignment"))));
            this.ep.SetIconPadding(this.txtSecondName, ((int)(resources.GetObject("txtSecondName.IconPadding"))));
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecondName_Validating);
            // 
            // txtThirdName
            // 
            resources.ApplyResources(this.txtThirdName, "txtThirdName");
            this.ep.SetError(this.txtThirdName, resources.GetString("txtThirdName.Error"));
            this.ep.SetIconAlignment(this.txtThirdName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtThirdName.IconAlignment"))));
            this.ep.SetIconPadding(this.txtThirdName, ((int)(resources.GetObject("txtThirdName.IconPadding"))));
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.txtThirdName_Validating);
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.ep.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.ep.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.ep.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.ep.SetError(this.label4, resources.GetString("label4.Error"));
            this.ep.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.ep.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.ep.SetError(this.label5, resources.GetString("label5.Error"));
            this.ep.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.ep.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.ep.SetError(this.label6, resources.GetString("label6.Error"));
            this.ep.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.ep.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.ep.SetError(this.label7, resources.GetString("label7.Error"));
            this.ep.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.ep.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.ep.SetError(this.label8, resources.GetString("label8.Error"));
            this.ep.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.ep.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.ep.SetError(this.label9, resources.GetString("label9.Error"));
            this.ep.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.ep.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.ep.SetError(this.label10, resources.GetString("label10.Error"));
            this.ep.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.ep.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.ep.SetError(this.label11, resources.GetString("label11.Error"));
            this.ep.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.ep.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            // 
            // txtNationalNo
            // 
            resources.ApplyResources(this.txtNationalNo, "txtNationalNo");
            this.ep.SetError(this.txtNationalNo, resources.GetString("txtNationalNo.Error"));
            this.ep.SetIconAlignment(this.txtNationalNo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNationalNo.IconAlignment"))));
            this.ep.SetIconPadding(this.txtNationalNo, ((int)(resources.GetObject("txtNationalNo.IconPadding"))));
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.ep.SetError(this.txtPhone, resources.GetString("txtPhone.Error"));
            this.ep.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment"))));
            this.ep.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding"))));
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.ep.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.ep.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.ep.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.txtEmail.Name = "txtEmail";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.ep.SetError(this.txtAddress, resources.GetString("txtAddress.Error"));
            this.ep.SetIconAlignment(this.txtAddress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress.IconAlignment"))));
            this.ep.SetIconPadding(this.txtAddress, ((int)(resources.GetObject("txtAddress.IconPadding"))));
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.ep.SetError(this.label12, resources.GetString("label12.Error"));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.ep.SetIconAlignment(this.label12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label12.IconAlignment"))));
            this.ep.SetIconPadding(this.label12, ((int)(resources.GetObject("label12.IconPadding"))));
            this.label12.Name = "label12";
            // 
            // lblPersonID
            // 
            resources.ApplyResources(this.lblPersonID, "lblPersonID");
            this.ep.SetError(this.lblPersonID, resources.GetString("lblPersonID.Error"));
            this.lblPersonID.ForeColor = System.Drawing.Color.Black;
            this.ep.SetIconAlignment(this.lblPersonID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPersonID.IconAlignment"))));
            this.ep.SetIconPadding(this.lblPersonID, ((int)(resources.GetObject("lblPersonID.IconPadding"))));
            this.lblPersonID.Name = "lblPersonID";
            // 
            // brnCLose
            // 
            resources.ApplyResources(this.brnCLose, "brnCLose");
            this.brnCLose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ep.SetError(this.brnCLose, resources.GetString("brnCLose.Error"));
            this.ep.SetIconAlignment(this.brnCLose, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("brnCLose.IconAlignment"))));
            this.ep.SetIconPadding(this.brnCLose, ((int)(resources.GetObject("brnCLose.IconPadding"))));
            this.brnCLose.Name = "brnCLose";
            this.brnCLose.UseVisualStyleBackColor = true;
            this.brnCLose.Click += new System.EventHandler(this.brnCLose_Click);
            // 
            // btnRemoveImage
            // 
            resources.ApplyResources(this.btnRemoveImage, "btnRemoveImage");
            this.ep.SetError(this.btnRemoveImage, resources.GetString("btnRemoveImage.Error"));
            this.ep.SetIconAlignment(this.btnRemoveImage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnRemoveImage.IconAlignment"))));
            this.ep.SetIconPadding(this.btnRemoveImage, ((int)(resources.GetObject("btnRemoveImage.IconPadding"))));
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnChooseImage
            // 
            resources.ApplyResources(this.btnChooseImage, "btnChooseImage");
            this.ep.SetError(this.btnChooseImage, resources.GetString("btnChooseImage.Error"));
            this.ep.SetIconAlignment(this.btnChooseImage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChooseImage.IconAlignment"))));
            this.ep.SetIconPadding(this.btnChooseImage, ((int)(resources.GetObject("btnChooseImage.IconPadding"))));
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnChooseImage);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.btnRemoveImage);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNationalNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtThirdName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSecondName);
            this.ep.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.ep.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.ep.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            resources.ApplyResources(this.ep, "ep");
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
            // pictureBox8
            // 
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pictureBox8, resources.GetString("pictureBox8.Error"));
            this.ep.SetIconAlignment(this.pictureBox8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox8.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox8, ((int)(resources.GetObject("pictureBox8.IconPadding"))));
            this.pictureBox8.Image = global::CarRental.Properties.Resources.Icon_UserName;
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pictureBox7, resources.GetString("pictureBox7.Error"));
            this.ep.SetIconAlignment(this.pictureBox7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox7.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox7, ((int)(resources.GetObject("pictureBox7.IconPadding"))));
            this.pictureBox7.Image = global::CarRental.Properties.Resources.icon_BirthDate;
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pictureBox6, resources.GetString("pictureBox6.Error"));
            this.ep.SetIconAlignment(this.pictureBox6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox6.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox6, ((int)(resources.GetObject("pictureBox6.IconPadding"))));
            this.pictureBox6.Image = global::CarRental.Properties.Resources.icon_PhoneCall;
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pictureBox5, resources.GetString("pictureBox5.Error"));
            this.ep.SetIconAlignment(this.pictureBox5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox5.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox5, ((int)(resources.GetObject("pictureBox5.IconPadding"))));
            this.pictureBox5.Image = global::CarRental.Properties.Resources.icon_Address;
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pictureBox4, resources.GetString("pictureBox4.Error"));
            this.ep.SetIconAlignment(this.pictureBox4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox4.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox4, ((int)(resources.GetObject("pictureBox4.IconPadding"))));
            this.pictureBox4.Image = global::CarRental.Properties.Resources.icon_Gender;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pictureBox3, resources.GetString("pictureBox3.Error"));
            this.ep.SetIconAlignment(this.pictureBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox3.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox3, ((int)(resources.GetObject("pictureBox3.IconPadding"))));
            this.pictureBox3.Image = global::CarRental.Properties.Resources.icon_Email;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error"));
            this.ep.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding"))));
            this.pictureBox2.Image = global::CarRental.Properties.Resources.icon_National;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.ep.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.ep.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Image = global::CarRental.Properties.Resources.icon_Name;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.ep.SetError(this.pbImage, resources.GetString("pbImage.Error"));
            this.ep.SetIconAlignment(this.pbImage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pbImage.IconAlignment"))));
            this.ep.SetIconPadding(this.pbImage, ((int)(resources.GetObject("pbImage.IconPadding"))));
            this.pbImage.Image = global::CarRental.Properties.Resources.png_Male;
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // frmAddUpdatePerson
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.brnCLose;
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.brnCLose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddUpdatePerson";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button brnCLose;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}