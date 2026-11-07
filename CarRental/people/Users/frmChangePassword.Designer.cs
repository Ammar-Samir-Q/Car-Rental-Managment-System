namespace CarRental
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserInfo1 = new CarRental.ctrlUserInfo();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.ep.SetError(this.label3, resources.GetString("label3.Error"));
            this.ep.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.ep.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // txtNewPassword
            // 
            resources.ApplyResources(this.txtNewPassword, "txtNewPassword");
            this.ep.SetError(this.txtNewPassword, resources.GetString("txtNewPassword.Error"));
            this.ep.SetIconAlignment(this.txtNewPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNewPassword.IconAlignment"))));
            this.ep.SetIconPadding(this.txtNewPassword, ((int)(resources.GetObject("txtNewPassword.IconPadding"))));
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.ep.SetError(this.label4, resources.GetString("label4.Error"));
            this.ep.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.ep.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.ep.SetError(this.btnClose, resources.GetString("btnClose.Error"));
            this.ep.SetIconAlignment(this.btnClose, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnClose.IconAlignment"))));
            this.ep.SetIconPadding(this.btnClose, ((int)(resources.GetObject("btnClose.IconPadding"))));
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            resources.ApplyResources(this.ep, "ep");
            // 
            // ctrlUserInfo1
            // 
            resources.ApplyResources(this.ctrlUserInfo1, "ctrlUserInfo1");
            this.ep.SetError(this.ctrlUserInfo1, resources.GetString("ctrlUserInfo1.Error"));
            this.ep.SetIconAlignment(this.ctrlUserInfo1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ctrlUserInfo1.IconAlignment"))));
            this.ep.SetIconPadding(this.ctrlUserInfo1, ((int)(resources.GetObject("ctrlUserInfo1.IconPadding"))));
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            // 
            // frmChangePassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlUserInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider ep;
    }
}