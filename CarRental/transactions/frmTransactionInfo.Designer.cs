namespace CarRental
{
    partial class frmTransactionInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionInfo));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTransactionInfo1 = new CarRental.ctrlTransactionInfo();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ctrlTransactionInfo1
            // 
            resources.ApplyResources(this.ctrlTransactionInfo1, "ctrlTransactionInfo1");
            this.ctrlTransactionInfo1.Name = "ctrlTransactionInfo1";
            this.ctrlTransactionInfo1.TransactionID = 0;
            this.ctrlTransactionInfo1.Load += new System.EventHandler(this.ctrlTransactionInfo1_Load);
            // 
            // frmTransactionInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlTransactionInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmTransactionInfo";
            this.Load += new System.EventHandler(this.frmTransactionInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlTransactionInfo ctrlTransactionInfo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}