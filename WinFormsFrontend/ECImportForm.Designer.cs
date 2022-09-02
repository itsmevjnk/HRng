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
            this.lblECConfig.AutoSize = true;
            this.lblECConfig.Location = new System.Drawing.Point(12, 9);
            this.lblECConfig.Name = "lblECConfig";
            this.lblECConfig.Size = new System.Drawing.Size(273, 15);
            this.lblECConfig.TabIndex = 0;
            this.lblECConfig.Text = "Please set the spreadsheet\'s settings for importing.";
            // 
            // lblECStartRow
            // 
            this.lblECStartRow.AutoSize = true;
            this.lblECStartRow.Location = new System.Drawing.Point(12, 35);
            this.lblECStartRow.Name = "lblECStartRow";
            this.lblECStartRow.Size = new System.Drawing.Size(84, 15);
            this.lblECStartRow.TabIndex = 1;
            this.lblECStartRow.Text = "Starting row #:";
            // 
            // numECStartRow
            // 
            this.numECStartRow.Location = new System.Drawing.Point(102, 33);
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
            this.numECStartRow.Size = new System.Drawing.Size(99, 23);
            this.numECStartRow.TabIndex = 2;
            this.numECStartRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtECUIDColName
            // 
            this.rbtECUIDColName.AutoSize = true;
            this.rbtECUIDColName.Checked = true;
            this.rbtECUIDColName.Location = new System.Drawing.Point(2, 1);
            this.rbtECUIDColName.Name = "rbtECUIDColName";
            this.rbtECUIDColName.Size = new System.Drawing.Size(60, 19);
            this.rbtECUIDColName.TabIndex = 3;
            this.rbtECUIDColName.TabStop = true;
            this.rbtECUIDColName.Text = "Name:";
            this.rbtECUIDColName.UseVisualStyleBackColor = true;
            this.rbtECUIDColName.CheckedChanged += new System.EventHandler(this.rbtECUIDColName_CheckedChanged);
            // 
            // lblECUIDCol
            // 
            this.lblECUIDCol.AutoSize = true;
            this.lblECUIDCol.Location = new System.Drawing.Point(12, 64);
            this.lblECUIDCol.Name = "lblECUIDCol";
            this.lblECUIDCol.Size = new System.Drawing.Size(73, 15);
            this.lblECUIDCol.TabIndex = 4;
            this.lblECUIDCol.Text = "UID column:";
            // 
            // tbxECUIDCol
            // 
            this.tbxECUIDCol.Location = new System.Drawing.Point(66, 0);
            this.tbxECUIDCol.Name = "tbxECUIDCol";
            this.tbxECUIDCol.Size = new System.Drawing.Size(100, 23);
            this.tbxECUIDCol.TabIndex = 5;
            this.tbxECUIDCol.Text = "UID";
            // 
            // rbtECUIDColNum
            // 
            this.rbtECUIDColNum.AutoSize = true;
            this.rbtECUIDColNum.Location = new System.Drawing.Point(2, 26);
            this.rbtECUIDColNum.Name = "rbtECUIDColNum";
            this.rbtECUIDColNum.Size = new System.Drawing.Size(72, 19);
            this.rbtECUIDColNum.TabIndex = 6;
            this.rbtECUIDColNum.TabStop = true;
            this.rbtECUIDColNum.Text = "Number:";
            this.rbtECUIDColNum.UseVisualStyleBackColor = true;
            this.rbtECUIDColNum.CheckedChanged += new System.EventHandler(this.rbtECUIDColNum_CheckedChanged);
            // 
            // numECUIDCol
            // 
            this.numECUIDCol.Enabled = false;
            this.numECUIDCol.Location = new System.Drawing.Point(78, 26);
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
            this.numECUIDCol.Size = new System.Drawing.Size(88, 23);
            this.numECUIDCol.TabIndex = 7;
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
            this.pnlECUIDCol.Location = new System.Drawing.Point(91, 62);
            this.pnlECUIDCol.Name = "pnlECUIDCol";
            this.pnlECUIDCol.Size = new System.Drawing.Size(178, 50);
            this.pnlECUIDCol.TabIndex = 8;
            // 
            // lblECUIDDelim
            // 
            this.lblECUIDDelim.AutoSize = true;
            this.lblECUIDDelim.Location = new System.Drawing.Point(12, 114);
            this.lblECUIDDelim.Name = "lblECUIDDelim";
            this.lblECUIDDelim.Size = new System.Drawing.Size(79, 15);
            this.lblECUIDDelim.TabIndex = 9;
            this.lblECUIDDelim.Text = "UID delimiter:";
            // 
            // pnlECUIDDelim
            // 
            this.pnlECUIDDelim.Controls.Add(this.tbxECUIDDelim);
            this.pnlECUIDDelim.Controls.Add(this.rbtECUIDDelimCustom);
            this.pnlECUIDDelim.Controls.Add(this.rbtECUIDDelimNL);
            this.pnlECUIDDelim.Location = new System.Drawing.Point(90, 113);
            this.pnlECUIDDelim.Name = "pnlECUIDDelim";
            this.pnlECUIDDelim.Size = new System.Drawing.Size(194, 51);
            this.pnlECUIDDelim.TabIndex = 10;
            // 
            // tbxECUIDDelim
            // 
            this.tbxECUIDDelim.Enabled = false;
            this.tbxECUIDDelim.Location = new System.Drawing.Point(73, 24);
            this.tbxECUIDDelim.Name = "tbxECUIDDelim";
            this.tbxECUIDDelim.Size = new System.Drawing.Size(100, 23);
            this.tbxECUIDDelim.TabIndex = 11;
            this.tbxECUIDDelim.TextChanged += new System.EventHandler(this.tbxECUIDDelim_TextChanged);
            // 
            // rbtECUIDDelimCustom
            // 
            this.rbtECUIDDelimCustom.AutoSize = true;
            this.rbtECUIDDelimCustom.Location = new System.Drawing.Point(3, 25);
            this.rbtECUIDDelimCustom.Name = "rbtECUIDDelimCustom";
            this.rbtECUIDDelimCustom.Size = new System.Drawing.Size(70, 19);
            this.rbtECUIDDelimCustom.TabIndex = 1;
            this.rbtECUIDDelimCustom.Text = "Custom:";
            this.rbtECUIDDelimCustom.UseVisualStyleBackColor = true;
            this.rbtECUIDDelimCustom.CheckedChanged += new System.EventHandler(this.rbtECUIDDelimCustom_CheckedChanged);
            // 
            // rbtECUIDDelimNL
            // 
            this.rbtECUIDDelimNL.AutoSize = true;
            this.rbtECUIDDelimNL.Checked = true;
            this.rbtECUIDDelimNL.Location = new System.Drawing.Point(3, 1);
            this.rbtECUIDDelimNL.Name = "rbtECUIDDelimNL";
            this.rbtECUIDDelimNL.Size = new System.Drawing.Size(68, 19);
            this.rbtECUIDDelimNL.TabIndex = 0;
            this.rbtECUIDDelimNL.TabStop = true;
            this.rbtECUIDDelimNL.Text = "Newline";
            this.rbtECUIDDelimNL.UseVisualStyleBackColor = true;
            // 
            // btnECOK
            // 
            this.btnECOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnECOK.Location = new System.Drawing.Point(51, 170);
            this.btnECOK.Name = "btnECOK";
            this.btnECOK.Size = new System.Drawing.Size(75, 23);
            this.btnECOK.TabIndex = 11;
            this.btnECOK.Text = "OK";
            this.btnECOK.UseVisualStyleBackColor = true;
            // 
            // btnECCancel
            // 
            this.btnECCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnECCancel.Location = new System.Drawing.Point(169, 170);
            this.btnECCancel.Name = "btnECCancel";
            this.btnECCancel.Size = new System.Drawing.Size(75, 23);
            this.btnECCancel.TabIndex = 12;
            this.btnECCancel.Text = "Cancel";
            this.btnECCancel.UseVisualStyleBackColor = true;
            // 
            // ECImportForm
            // 
            this.AcceptButton = this.btnECOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnECCancel;
            this.ClientSize = new System.Drawing.Size(302, 201);
            this.Controls.Add(this.btnECCancel);
            this.Controls.Add(this.btnECOK);
            this.Controls.Add(this.pnlECUIDDelim);
            this.Controls.Add(this.lblECUIDDelim);
            this.Controls.Add(this.pnlECUIDCol);
            this.Controls.Add(this.lblECUIDCol);
            this.Controls.Add(this.numECStartRow);
            this.Controls.Add(this.lblECStartRow);
            this.Controls.Add(this.lblECConfig);
            this.Name = "ECImportForm";
            this.Text = "EntryCollection import";
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