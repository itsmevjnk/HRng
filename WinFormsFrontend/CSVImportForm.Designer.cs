namespace WinFormsFrontend
{
    partial class CSVImportForm
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
            this.lblCSVConfig = new System.Windows.Forms.Label();
            this.lblCSVBOM = new System.Windows.Forms.Label();
            this.rbtCSVBOMYes = new System.Windows.Forms.RadioButton();
            this.rbtCSVBOMNo = new System.Windows.Forms.RadioButton();
            this.tbxCSVDelim = new System.Windows.Forms.TextBox();
            this.lblCSVDelim = new System.Windows.Forms.Label();
            this.tbxCSVEscape = new System.Windows.Forms.TextBox();
            this.lblCSVEscape = new System.Windows.Forms.Label();
            this.btnCSVOK = new System.Windows.Forms.Button();
            this.btnCSVCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCSVConfig
            // 
            this.lblCSVConfig.Location = new System.Drawing.Point(12, 9);
            this.lblCSVConfig.Name = "lblCSVConfig";
            this.lblCSVConfig.Size = new System.Drawing.Size(348, 34);
            this.lblCSVConfig.TabIndex = 0;
            this.lblCSVConfig.Text = "Please set the spreadsheet\'s CSV settings below. Please note that this is only re" +
    "quired for non-standard CSV files.";
            // 
            // lblCSVBOM
            // 
            this.lblCSVBOM.AutoSize = true;
            this.lblCSVBOM.Location = new System.Drawing.Point(12, 43);
            this.lblCSVBOM.Name = "lblCSVBOM";
            this.lblCSVBOM.Size = new System.Drawing.Size(173, 15);
            this.lblCSVBOM.TabIndex = 1;
            this.lblCSVBOM.Text = "Byte-order mark (BOM) header:";
            // 
            // rbtCSVBOMYes
            // 
            this.rbtCSVBOMYes.AutoSize = true;
            this.rbtCSVBOMYes.Checked = true;
            this.rbtCSVBOMYes.Location = new System.Drawing.Point(191, 41);
            this.rbtCSVBOMYes.Name = "rbtCSVBOMYes";
            this.rbtCSVBOMYes.Size = new System.Drawing.Size(42, 19);
            this.rbtCSVBOMYes.TabIndex = 2;
            this.rbtCSVBOMYes.TabStop = true;
            this.rbtCSVBOMYes.Text = "Yes";
            this.rbtCSVBOMYes.UseVisualStyleBackColor = true;
            // 
            // rbtCSVBOMNo
            // 
            this.rbtCSVBOMNo.AutoSize = true;
            this.rbtCSVBOMNo.Location = new System.Drawing.Point(239, 41);
            this.rbtCSVBOMNo.Name = "rbtCSVBOMNo";
            this.rbtCSVBOMNo.Size = new System.Drawing.Size(41, 19);
            this.rbtCSVBOMNo.TabIndex = 3;
            this.rbtCSVBOMNo.Text = "No";
            this.rbtCSVBOMNo.UseVisualStyleBackColor = true;
            // 
            // tbxCSVDelim
            // 
            this.tbxCSVDelim.AcceptsTab = true;
            this.tbxCSVDelim.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCSVDelim.Location = new System.Drawing.Point(128, 61);
            this.tbxCSVDelim.MaxLength = 1;
            this.tbxCSVDelim.Name = "tbxCSVDelim";
            this.tbxCSVDelim.Size = new System.Drawing.Size(57, 24);
            this.tbxCSVDelim.TabIndex = 4;
            this.tbxCSVDelim.Text = ",";
            // 
            // lblCSVDelim
            // 
            this.lblCSVDelim.AutoSize = true;
            this.lblCSVDelim.Location = new System.Drawing.Point(12, 64);
            this.lblCSVDelim.Name = "lblCSVDelim";
            this.lblCSVDelim.Size = new System.Drawing.Size(110, 15);
            this.lblCSVDelim.TabIndex = 5;
            this.lblCSVDelim.Text = "Delimiter character:";
            // 
            // tbxCSVEscape
            // 
            this.tbxCSVEscape.AcceptsTab = true;
            this.tbxCSVEscape.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCSVEscape.Location = new System.Drawing.Point(128, 90);
            this.tbxCSVEscape.MaxLength = 1;
            this.tbxCSVEscape.Name = "tbxCSVEscape";
            this.tbxCSVEscape.Size = new System.Drawing.Size(57, 24);
            this.tbxCSVEscape.TabIndex = 6;
            this.tbxCSVEscape.Text = "\"";
            // 
            // lblCSVEscape
            // 
            this.lblCSVEscape.AutoSize = true;
            this.lblCSVEscape.Location = new System.Drawing.Point(12, 93);
            this.lblCSVEscape.Name = "lblCSVEscape";
            this.lblCSVEscape.Size = new System.Drawing.Size(98, 15);
            this.lblCSVEscape.TabIndex = 7;
            this.lblCSVEscape.Text = "Escape character:";
            // 
            // btnCSVOK
            // 
            this.btnCSVOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCSVOK.Location = new System.Drawing.Point(88, 120);
            this.btnCSVOK.Name = "btnCSVOK";
            this.btnCSVOK.Size = new System.Drawing.Size(75, 23);
            this.btnCSVOK.TabIndex = 8;
            this.btnCSVOK.Text = "OK";
            this.btnCSVOK.UseVisualStyleBackColor = true;
            // 
            // btnCSVCancel
            // 
            this.btnCSVCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCSVCancel.Location = new System.Drawing.Point(197, 120);
            this.btnCSVCancel.Name = "btnCSVCancel";
            this.btnCSVCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCSVCancel.TabIndex = 9;
            this.btnCSVCancel.Text = "button2";
            this.btnCSVCancel.UseVisualStyleBackColor = true;
            // 
            // CSVImportForm
            // 
            this.AcceptButton = this.btnCSVOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCSVCancel;
            this.ClientSize = new System.Drawing.Size(368, 157);
            this.Controls.Add(this.btnCSVCancel);
            this.Controls.Add(this.btnCSVOK);
            this.Controls.Add(this.lblCSVEscape);
            this.Controls.Add(this.tbxCSVEscape);
            this.Controls.Add(this.lblCSVDelim);
            this.Controls.Add(this.tbxCSVDelim);
            this.Controls.Add(this.rbtCSVBOMNo);
            this.Controls.Add(this.rbtCSVBOMYes);
            this.Controls.Add(this.lblCSVBOM);
            this.Controls.Add(this.lblCSVConfig);
            this.Name = "CSVImportForm";
            this.Text = "CSV spreadsheet import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCSVConfig;
        private Label lblCSVBOM;
        public RadioButton rbtCSVBOMYes;
        public RadioButton rbtCSVBOMNo;
        public TextBox tbxCSVDelim;
        private Label lblCSVDelim;
        public TextBox tbxCSVEscape;
        private Label lblCSVEscape;
        private Button btnCSVOK;
        private Button btnCSVCancel;
    }
}