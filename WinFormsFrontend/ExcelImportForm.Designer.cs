namespace WinFormsFrontend
{
    partial class ExcelImportForm
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
            this.lblExcelSheet = new System.Windows.Forms.Label();
            this.cbxExcelSheet = new System.Windows.Forms.ComboBox();
            this.btnExcelOK = new System.Windows.Forms.Button();
            this.btnExcelCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExcelSheet
            // 
            this.lblExcelSheet.AutoSize = true;
            this.lblExcelSheet.Location = new System.Drawing.Point(12, 9);
            this.lblExcelSheet.Name = "lblExcelSheet";
            this.lblExcelSheet.Size = new System.Drawing.Size(240, 15);
            this.lblExcelSheet.TabIndex = 0;
            this.lblExcelSheet.Text = "Please select the worksheet you want to use:";
            // 
            // cbxExcelSheet
            // 
            this.cbxExcelSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExcelSheet.FormattingEnabled = true;
            this.cbxExcelSheet.Location = new System.Drawing.Point(12, 27);
            this.cbxExcelSheet.Name = "cbxExcelSheet";
            this.cbxExcelSheet.Size = new System.Drawing.Size(304, 23);
            this.cbxExcelSheet.TabIndex = 1;
            // 
            // btnExcelOK
            // 
            this.btnExcelOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExcelOK.Location = new System.Drawing.Point(69, 56);
            this.btnExcelOK.Name = "btnExcelOK";
            this.btnExcelOK.Size = new System.Drawing.Size(75, 23);
            this.btnExcelOK.TabIndex = 2;
            this.btnExcelOK.Text = "OK";
            this.btnExcelOK.UseVisualStyleBackColor = true;
            // 
            // btnExcelCancel
            // 
            this.btnExcelCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcelCancel.Location = new System.Drawing.Point(177, 56);
            this.btnExcelCancel.Name = "btnExcelCancel";
            this.btnExcelCancel.Size = new System.Drawing.Size(75, 23);
            this.btnExcelCancel.TabIndex = 3;
            this.btnExcelCancel.Text = "Cancel";
            this.btnExcelCancel.UseVisualStyleBackColor = true;
            // 
            // ExcelImportForm
            // 
            this.AcceptButton = this.btnExcelOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExcelCancel;
            this.ClientSize = new System.Drawing.Size(328, 95);
            this.Controls.Add(this.btnExcelCancel);
            this.Controls.Add(this.btnExcelOK);
            this.Controls.Add(this.cbxExcelSheet);
            this.Controls.Add(this.lblExcelSheet);
            this.Name = "ExcelImportForm";
            this.Text = "Microsoft Excel workbook import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblExcelSheet;
        public ComboBox cbxExcelSheet;
        private Button btnExcelOK;
        private Button btnExcelCancel;
    }
}