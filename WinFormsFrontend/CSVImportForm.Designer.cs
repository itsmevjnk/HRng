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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSVImportForm));
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
            resources.ApplyResources(this.lblCSVConfig, "lblCSVConfig");
            this.lblCSVConfig.Name = "lblCSVConfig";
            // 
            // lblCSVBOM
            // 
            resources.ApplyResources(this.lblCSVBOM, "lblCSVBOM");
            this.lblCSVBOM.Name = "lblCSVBOM";
            // 
            // rbtCSVBOMYes
            // 
            resources.ApplyResources(this.rbtCSVBOMYes, "rbtCSVBOMYes");
            this.rbtCSVBOMYes.Checked = true;
            this.rbtCSVBOMYes.Name = "rbtCSVBOMYes";
            this.rbtCSVBOMYes.TabStop = true;
            this.rbtCSVBOMYes.UseVisualStyleBackColor = true;
            // 
            // rbtCSVBOMNo
            // 
            resources.ApplyResources(this.rbtCSVBOMNo, "rbtCSVBOMNo");
            this.rbtCSVBOMNo.Name = "rbtCSVBOMNo";
            this.rbtCSVBOMNo.UseVisualStyleBackColor = true;
            // 
            // tbxCSVDelim
            // 
            this.tbxCSVDelim.AcceptsTab = true;
            resources.ApplyResources(this.tbxCSVDelim, "tbxCSVDelim");
            this.tbxCSVDelim.Name = "tbxCSVDelim";
            // 
            // lblCSVDelim
            // 
            resources.ApplyResources(this.lblCSVDelim, "lblCSVDelim");
            this.lblCSVDelim.Name = "lblCSVDelim";
            // 
            // tbxCSVEscape
            // 
            this.tbxCSVEscape.AcceptsTab = true;
            resources.ApplyResources(this.tbxCSVEscape, "tbxCSVEscape");
            this.tbxCSVEscape.Name = "tbxCSVEscape";
            // 
            // lblCSVEscape
            // 
            resources.ApplyResources(this.lblCSVEscape, "lblCSVEscape");
            this.lblCSVEscape.Name = "lblCSVEscape";
            // 
            // btnCSVOK
            // 
            this.btnCSVOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnCSVOK, "btnCSVOK");
            this.btnCSVOK.Name = "btnCSVOK";
            this.btnCSVOK.UseVisualStyleBackColor = true;
            // 
            // btnCSVCancel
            // 
            this.btnCSVCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCSVCancel, "btnCSVCancel");
            this.btnCSVCancel.Name = "btnCSVCancel";
            this.btnCSVCancel.UseVisualStyleBackColor = true;
            // 
            // CSVImportForm
            // 
            this.AcceptButton = this.btnCSVOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCSVCancel;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CSVImportForm";
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