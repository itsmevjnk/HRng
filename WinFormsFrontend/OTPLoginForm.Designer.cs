namespace WinFormsFrontend
{
    partial class OTPLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPLoginForm));
            this.lblLoginOTP = new System.Windows.Forms.Label();
            this.tbxLoginOTP = new System.Windows.Forms.TextBox();
            this.btnLoginOTPSubmit = new System.Windows.Forms.Button();
            this.btnLoginOTPCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginOTP
            // 
            resources.ApplyResources(this.lblLoginOTP, "lblLoginOTP");
            this.lblLoginOTP.Name = "lblLoginOTP";
            // 
            // tbxLoginOTP
            // 
            resources.ApplyResources(this.tbxLoginOTP, "tbxLoginOTP");
            this.tbxLoginOTP.Name = "tbxLoginOTP";
            // 
            // btnLoginOTPSubmit
            // 
            this.btnLoginOTPSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnLoginOTPSubmit, "btnLoginOTPSubmit");
            this.btnLoginOTPSubmit.Name = "btnLoginOTPSubmit";
            this.btnLoginOTPSubmit.UseVisualStyleBackColor = true;
            // 
            // btnLoginOTPCancel
            // 
            this.btnLoginOTPCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnLoginOTPCancel, "btnLoginOTPCancel");
            this.btnLoginOTPCancel.Name = "btnLoginOTPCancel";
            this.btnLoginOTPCancel.UseVisualStyleBackColor = true;
            // 
            // OTPLoginForm
            // 
            this.AcceptButton = this.btnLoginOTPSubmit;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLoginOTPCancel;
            this.Controls.Add(this.btnLoginOTPCancel);
            this.Controls.Add(this.btnLoginOTPSubmit);
            this.Controls.Add(this.tbxLoginOTP);
            this.Controls.Add(this.lblLoginOTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OTPLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLoginOTP;
        public TextBox tbxLoginOTP;
        private Button btnLoginOTPSubmit;
        private Button btnLoginOTPCancel;
    }
}