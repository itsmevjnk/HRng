namespace WinFormsFrontend
{
    partial class ECImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECImportForm));
            this.lblECConfig = new System.Windows.Forms.Label();
            this.lblECStartRow = new System.Windows.Forms.Label();
            this.numECStartRow = new System.Windows.Forms.NumericUpDown();
            this.rbtECUIDColName = new System.Windows.Forms.RadioButton();
            this.lblECUIDCol = new System.Windows.Forms.Label();
            this.tbxECUIDCol = new System.Windows.Forms.TextBox();
            this.rbtECUIDColNum = new System.Windows.Forms.RadioButton();
            this.numECUIDCol = new System.Windows.Forms.NumericUpDown();
            this.pnlECUIDCol = new System.Windows.Forms.Panel();
            this.lblECUIDDelim = new System.Windows.Forms.Label();
            this.pnlECUIDDelim = new System.Windows.Forms.Panel();
            this.tbxECUIDDelim = new System.Windows.Forms.TextBox();
            this.rbtECUIDDelimCustom = new System.Windows.Forms.RadioButton();
            this.rbtECUIDDelimNL = new System.Windows.Forms.RadioButton();
            this.btnECOK = new System.Windows.Forms.Button();
            this.btnECCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numECStartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numECUIDCol)).BeginInit();
            this.pnlECUIDCol.SuspendLayout();
            this.pnlECUIDDelim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblECConfig
            // 
            resources.ApplyResources(this.lblECConfig, "lblECConfig");
            this.lblECConfig.Name = "lblECConfig";
            // 
            // lblECStartRow
            // 
            resources.ApplyResources(this.lblECStartRow, "lblECStartRow");
            this.lblECStartRow.Name = "lblECStartRow";
            // 
            // numECStartRow
            // 
            resources.ApplyResources(this.numECStartRow, "numECStartRow");
            this.numECStartRow.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.numECStartRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numECStartRow.Name = "numECStartRow";
            this.numECStartRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtECUIDColName
            // 
            resources.ApplyResources(this.rbtECUIDColName, "rbtECUIDColName");
            this.rbtECUIDColName.Checked = true;
            this.rbtECUIDColName.Name = "rbtECUIDColName";
            this.rbtECUIDColName.TabStop = true;
            this.rbtECUIDColName.UseVisualStyleBackColor = true;
            this.rbtECUIDColName.CheckedChanged += new System.EventHandler(this.rbtECUIDColName_CheckedChanged);
            // 
            // lblECUIDCol
            // 
            resources.ApplyResources(this.lblECUIDCol, "lblECUIDCol");
            this.lblECUIDCol.Name = "lblECUIDCol";
            // 
            // tbxECUIDCol
            // 
            resources.ApplyResources(this.tbxECUIDCol, "tbxECUIDCol");
            this.tbxECUIDCol.Name = "tbxECUIDCol";
            // 
            // rbtECUIDColNum
            // 
            resources.ApplyResources(this.rbtECUIDColNum, "rbtECUIDColNum");
            this.rbtECUIDColNum.Name = "rbtECUIDColNum";
            this.rbtECUIDColNum.TabStop = true;
            this.rbtECUIDColNum.UseVisualStyleBackColor = true;
            this.rbtECUIDColNum.CheckedChanged += new System.EventHandler(this.rbtECUIDColNum_CheckedChanged);
            // 
            // numECUIDCol
            // 
            resources.ApplyResources(this.numECUIDCol, "numECUIDCol");
            this.numECUIDCol.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.numECUIDCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numECUIDCol.Name = "numECUIDCol";
            this.numECUIDCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlECUIDCol
            // 
            this.pnlECUIDCol.Controls.Add(this.rbtECUIDColNum);
            this.pnlECUIDCol.Controls.Add(this.numECUIDCol);
            this.pnlECUIDCol.Controls.Add(this.rbtECUIDColName);
            this.pnlECUIDCol.Controls.Add(this.tbxECUIDCol);
            resources.ApplyResources(this.pnlECUIDCol, "pnlECUIDCol");
            this.pnlECUIDCol.Name = "pnlECUIDCol";
            // 
            // lblECUIDDelim
            // 
            resources.ApplyResources(this.lblECUIDDelim, "lblECUIDDelim");
            this.lblECUIDDelim.Name = "lblECUIDDelim";
            // 
            // pnlECUIDDelim
            // 
            this.pnlECUIDDelim.Controls.Add(this.tbxECUIDDelim);
            this.pnlECUIDDelim.Controls.Add(this.rbtECUIDDelimCustom);
            this.pnlECUIDDelim.Controls.Add(this.rbtECUIDDelimNL);
            resources.ApplyResources(this.pnlECUIDDelim, "pnlECUIDDelim");
            this.pnlECUIDDelim.Name = "pnlECUIDDelim";
            // 
            // tbxECUIDDelim
            // 
            resources.ApplyResources(this.tbxECUIDDelim, "tbxECUIDDelim");
            this.tbxECUIDDelim.Name = "tbxECUIDDelim";
            this.tbxECUIDDelim.TextChanged += new System.EventHandler(this.tbxECUIDDelim_TextChanged);
            // 
            // rbtECUIDDelimCustom
            // 
            resources.ApplyResources(this.rbtECUIDDelimCustom, "rbtECUIDDelimCustom");
            this.rbtECUIDDelimCustom.Name = "rbtECUIDDelimCustom";
            this.rbtECUIDDelimCustom.UseVisualStyleBackColor = true;
            this.rbtECUIDDelimCustom.CheckedChanged += new System.EventHandler(this.rbtECUIDDelimCustom_CheckedChanged);
            // 
            // rbtECUIDDelimNL
            // 
            resources.ApplyResources(this.rbtECUIDDelimNL, "rbtECUIDDelimNL");
            this.rbtECUIDDelimNL.Checked = true;
            this.rbtECUIDDelimNL.Name = "rbtECUIDDelimNL";
            this.rbtECUIDDelimNL.TabStop = true;
            this.rbtECUIDDelimNL.UseVisualStyleBackColor = true;
            // 
            // btnECOK
            // 
            this.btnECOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnECOK, "btnECOK");
            this.btnECOK.Name = "btnECOK";
            this.btnECOK.UseVisualStyleBackColor = true;
            // 
            // btnECCancel
            // 
            this.btnECCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnECCancel, "btnECCancel");
            this.btnECCancel.Name = "btnECCancel";
            this.btnECCancel.UseVisualStyleBackColor = true;
            // 
            // ECImportForm
            // 
            this.AcceptButton = this.btnECOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnECCancel;
            this.Controls.Add(this.btnECCancel);
            this.Controls.Add(this.btnECOK);
            this.Controls.Add(this.pnlECUIDDelim);
            this.Controls.Add(this.lblECUIDDelim);
            this.Controls.Add(this.pnlECUIDCol);
            this.Controls.Add(this.lblECUIDCol);
            this.Controls.Add(this.numECStartRow);
            this.Controls.Add(this.lblECStartRow);
            this.Controls.Add(this.lblECConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ECImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.numECStartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numECUIDCol)).EndInit();
            this.pnlECUIDCol.ResumeLayout(false);
            this.pnlECUIDCol.PerformLayout();
            this.pnlECUIDDelim.ResumeLayout(false);
            this.pnlECUIDDelim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblECConfig;
        private Label lblECStartRow;
        public NumericUpDown numECStartRow;
        public RadioButton rbtECUIDColName;
        private Label lblECUIDCol;
        public TextBox tbxECUIDCol;
        public RadioButton rbtECUIDColNum;
        public NumericUpDown numECUIDCol;
        private Panel pnlECUIDCol;
        private Label lblECUIDDelim;
        private Panel pnlECUIDDelim;
        public TextBox tbxECUIDDelim;
        public RadioButton rbtECUIDDelimCustom;
        public RadioButton rbtECUIDDelimNL;
        private Button btnECOK;
        private Button btnECCancel;
    }
}