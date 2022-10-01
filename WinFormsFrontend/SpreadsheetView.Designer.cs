namespace WinFormsFrontend
{
    partial class SpreadsheetView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetView));
            this.dgvSheet = new System.Windows.Forms.DataGridView();
            this.btnSheetClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSheet
            // 
            this.dgvSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvSheet, "dgvSheet");
            this.dgvSheet.Name = "dgvSheet";
            this.dgvSheet.ReadOnly = true;
            this.dgvSheet.RowTemplate.Height = 25;
            // 
            // btnSheetClose
            // 
            this.btnSheetClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnSheetClose, "btnSheetClose");
            this.btnSheetClose.Name = "btnSheetClose";
            this.btnSheetClose.UseVisualStyleBackColor = true;
            // 
            // SpreadsheetView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSheetClose);
            this.Controls.Add(this.dgvSheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SpreadsheetView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvSheet;
        private Button btnSheetClose;
    }
}