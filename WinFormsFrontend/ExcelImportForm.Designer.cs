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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelImportForm));
            this.lblExcelSheet = new System.Windows.Forms.Label();
            this.cbxExcelSheet = new System.Windows.Forms.ComboBox();
            this.btnExcelOK = new System.Windows.Forms.Button();
            this.btnExcelCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExcelSheet
            // 
            resources.ApplyResources(this.lblExcelSheet, "lblExcelSheet");
            this.lblExcelSheet.Name = "lblExcelSheet";
            // 
            // cbxExcelSheet
            // 
            this.cbxExcelSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExcelSheet.FormattingEnabled = true;
            resources.ApplyResources(this.cbxExcelSheet, "cbxExcelSheet");
            this.cbxExcelSheet.Name = "cbxExcelSheet";
            // 
            // btnExcelOK
            // 
            this.btnExcelOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnExcelOK, "btnExcelOK");
            this.btnExcelOK.Name = "btnExcelOK";
            this.btnExcelOK.UseVisualStyleBackColor = true;
            // 
            // btnExcelCancel
            // 
            this.btnExcelCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnExcelCancel, "btnExcelCancel");
            this.btnExcelCancel.Name = "btnExcelCancel";
            this.btnExcelCancel.UseVisualStyleBackColor = true;
            // 
            // ExcelImportForm
            // 
            this.AcceptButton = this.btnExcelOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExcelCancel;
            this.Controls.Add(this.btnExcelCancel);
            this.Controls.Add(this.btnExcelOK);
            this.Controls.Add(this.cbxExcelSheet);
            this.Controls.Add(this.lblExcelSheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ExcelImportForm";
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