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
            this.lblLoginOTP = new System.Windows.Forms.Label();
            this.tbxLoginOTP = new System.Windows.Forms.TextBox();
            this.btnLoginOTPSubmit = new System.Windows.Forms.Button();
            this.btnLoginOTPCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginOTP
            // 
            this.lblLoginOTP.Location = new System.Drawing.Point(12, 9);
            this.lblLoginOTP.Name = "lblLoginOTP";
            this.lblLoginOTP.Size = new System.Drawing.Size(385, 34);
            this.lblLoginOTP.TabIndex = 0;
            this.lblLoginOTP.Text = "Two-factor authentication is required. Please enter the verification code (OTP) f" +
    "rom your code generator in the text box below:";
            // 
            // tbxLoginOTP
            // 
            this.tbxLoginOTP.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxLoginOTP.Location = new System.Drawing.Point(122, 46);
            this.tbxLoginOTP.MaxLength = 10;
            this.tbxLoginOTP.Name = "tbxLoginOTP";
            this.tbxLoginOTP.Size = new System.Drawing.Size(165, 35);
            this.tbxLoginOTP.TabIndex = 1;
            this.tbxLoginOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoginOTPSubmit
            // 
            this.btnLoginOTPSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLoginOTPSubmit.Location = new System.Drawing.Point(101, 94);
            this.btnLoginOTPSubmit.Name = "btnLoginOTPSubmit";
            this.btnLoginOTPSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnLoginOTPSubmit.TabIndex = 2;
            this.btnLoginOTPSubmit.Text = "Submit";
            this.btnLoginOTPSubmit.UseVisualStyleBackColor = true;
            // 
            // btnLoginOTPCancel
            // 
            this.btnLoginOTPCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoginOTPCancel.Location = new System.Drawing.Point(207, 94);
            this.btnLoginOTPCancel.Name = "btnLoginOTPCancel";
            this.btnLoginOTPCancel.Size = new System.Drawing.Size(100, 23);
            this.btnLoginOTPCancel.TabIndex = 3;
            this.btnLoginOTPCancel.Text = "Cancel";
            this.btnLoginOTPCancel.UseVisualStyleBackColor = true;
            // 
            // OTPLoginForm
            // 
            this.AcceptButton = this.btnLoginOTPSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLoginOTPCancel;
            this.ClientSize = new System.Drawing.Size(416, 129);
            this.Controls.Add(this.btnLoginOTPCancel);
            this.Controls.Add(this.btnLoginOTPSubmit);
            this.Controls.Add(this.tbxLoginOTP);
            this.Controls.Add(this.lblLoginOTP);
            this.Name = "OTPLoginForm";
            this.Text = "Facebook two-factor authentication";
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