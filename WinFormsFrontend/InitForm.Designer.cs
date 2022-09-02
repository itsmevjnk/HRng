namespace WinFormsFrontend
{
    partial class InitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBackendSelect = new System.Windows.Forms.Label();
            this.rbtBackendLite = new System.Windows.Forms.RadioButton();
            this.rbtBackendSelenium = new System.Windows.Forms.RadioButton();
            this.gbxSeSettings = new System.Windows.Forms.GroupBox();
            this.chkSeLoadImg = new System.Windows.Forms.CheckBox();
            this.chkSeHeadless = new System.Windows.Forms.CheckBox();
            this.chkSeLocalInst = new System.Windows.Forms.CheckBox();
            this.chkSeDisableLog = new System.Windows.Forms.CheckBox();
            this.chkSeVerbose = new System.Windows.Forms.CheckBox();
            this.chkSeConsole = new System.Windows.Forms.CheckBox();
            this.cbxSeBrowser = new System.Windows.Forms.ComboBox();
            this.lblSeBrowser = new System.Windows.Forms.Label();
            this.pbrInitialize = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbxSeSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblBackendSelect
            // 
            resources.ApplyResources(this.lblBackendSelect, "lblBackendSelect");
            this.lblBackendSelect.Name = "lblBackendSelect";
            // 
            // rbtBackendLite
            // 
            resources.ApplyResources(this.rbtBackendLite, "rbtBackendLite");
            this.rbtBackendLite.Checked = true;
            this.rbtBackendLite.Name = "rbtBackendLite";
            this.rbtBackendLite.TabStop = true;
            this.rbtBackendLite.UseVisualStyleBackColor = true;
            // 
            // rbtBackendSelenium
            // 
            resources.ApplyResources(this.rbtBackendSelenium, "rbtBackendSelenium");
            this.rbtBackendSelenium.Name = "rbtBackendSelenium";
            this.rbtBackendSelenium.UseVisualStyleBackColor = true;
            this.rbtBackendSelenium.CheckedChanged += new System.EventHandler(this.rbtBackendSelenium_CheckedChanged);
            // 
            // gbxSeSettings
            // 
            resources.ApplyResources(this.gbxSeSettings, "gbxSeSettings");
            this.gbxSeSettings.Controls.Add(this.chkSeLoadImg);
            this.gbxSeSettings.Controls.Add(this.chkSeHeadless);
            this.gbxSeSettings.Controls.Add(this.chkSeLocalInst);
            this.gbxSeSettings.Controls.Add(this.chkSeDisableLog);
            this.gbxSeSettings.Controls.Add(this.chkSeVerbose);
            this.gbxSeSettings.Controls.Add(this.chkSeConsole);
            this.gbxSeSettings.Controls.Add(this.cbxSeBrowser);
            this.gbxSeSettings.Controls.Add(this.lblSeBrowser);
            this.gbxSeSettings.Name = "gbxSeSettings";
            this.gbxSeSettings.TabStop = false;
            // 
            // chkSeLoadImg
            // 
            resources.ApplyResources(this.chkSeLoadImg, "chkSeLoadImg");
            this.chkSeLoadImg.Name = "chkSeLoadImg";
            this.chkSeLoadImg.UseVisualStyleBackColor = true;
            // 
            // chkSeHeadless
            // 
            resources.ApplyResources(this.chkSeHeadless, "chkSeHeadless");
            this.chkSeHeadless.Checked = true;
            this.chkSeHeadless.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeHeadless.Name = "chkSeHeadless";
            this.chkSeHeadless.UseVisualStyleBackColor = true;
            // 
            // chkSeLocalInst
            // 
            resources.ApplyResources(this.chkSeLocalInst, "chkSeLocalInst");
            this.chkSeLocalInst.Checked = true;
            this.chkSeLocalInst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeLocalInst.Name = "chkSeLocalInst";
            this.chkSeLocalInst.UseVisualStyleBackColor = true;
            // 
            // chkSeDisableLog
            // 
            resources.ApplyResources(this.chkSeDisableLog, "chkSeDisableLog");
            this.chkSeDisableLog.Name = "chkSeDisableLog";
            this.chkSeDisableLog.UseVisualStyleBackColor = true;
            // 
            // chkSeVerbose
            // 
            resources.ApplyResources(this.chkSeVerbose, "chkSeVerbose");
            this.chkSeVerbose.Name = "chkSeVerbose";
            this.chkSeVerbose.UseVisualStyleBackColor = true;
            // 
            // chkSeConsole
            // 
            resources.ApplyResources(this.chkSeConsole, "chkSeConsole");
            this.chkSeConsole.Name = "chkSeConsole";
            this.chkSeConsole.UseVisualStyleBackColor = true;
            // 
            // cbxSeBrowser
            // 
            resources.ApplyResources(this.cbxSeBrowser, "cbxSeBrowser");
            this.cbxSeBrowser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeBrowser.FormattingEnabled = true;
            this.cbxSeBrowser.Items.AddRange(new object[] {
            resources.GetString("cbxSeBrowser.Items"),
            resources.GetString("cbxSeBrowser.Items1")});
            this.cbxSeBrowser.Name = "cbxSeBrowser";
            this.cbxSeBrowser.SelectedIndexChanged += new System.EventHandler(this.cbxSeBrowser_SelectedIndexChanged);
            // 
            // lblSeBrowser
            // 
            resources.ApplyResources(this.lblSeBrowser, "lblSeBrowser");
            this.lblSeBrowser.Name = "lblSeBrowser";
            // 
            // pbrInitialize
            // 
            resources.ApplyResources(this.pbrInitialize, "pbrInitialize");
            this.pbrInitialize.Name = "pbrInitialize";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxLanguage
            // 
            resources.ApplyResources(this.cbxLanguage, "cbxLanguage");
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            resources.GetString("cbxLanguage.Items"),
            resources.GetString("cbxLanguage.Items1")});
            this.cbxLanguage.Name = "cbxLanguage";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // InitForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbxLanguage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbrInitialize);
            this.Controls.Add(this.gbxSeSettings);
            this.Controls.Add(this.rbtBackendSelenium);
            this.Controls.Add(this.rbtBackendLite);
            this.Controls.Add(this.lblBackendSelect);
            this.Controls.Add(this.lblWelcome);
            this.Name = "InitForm";
            this.Load += new System.EventHandler(this.InitForm_Load);
            this.gbxSeSettings.ResumeLayout(false);
            this.gbxSeSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private Label lblBackendSelect;
        private RadioButton rbtBackendLite;
        private RadioButton rbtBackendSelenium;
        private GroupBox gbxSeSettings;
        private ComboBox cbxSeBrowser;
        private Label lblSeBrowser;
        private CheckBox chkSeConsole;
        private CheckBox chkSeVerbose;
        private CheckBox chkSeDisableLog;
        private CheckBox chkSeLoadImg;
        private CheckBox chkSeHeadless;
        private CheckBox chkSeLocalInst;
        private ProgressBar pbrInitialize;
        private Button btnStart;
        private ComboBox cbxLanguage;
        private Label lblLanguage;
        private Label lblStatus;
    }
}