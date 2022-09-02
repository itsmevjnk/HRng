namespace WinFormsFrontend
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tctMain = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnLoginCookiesCopy = new System.Windows.Forms.Button();
            this.lblLoginCookiesOutput = new System.Windows.Forms.Label();
            this.tbxLoginCookiesOutput = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.tbxLoginPassword = new System.Windows.Forms.TextBox();
            this.tbxLoginEmail = new System.Windows.Forms.TextBox();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.rbtLoginCreds = new System.Windows.Forms.RadioButton();
            this.btnLoginLoadCookiesTxt = new System.Windows.Forms.Button();
            this.tbxLoginCookiesInput = new System.Windows.Forms.TextBox();
            this.rbtLoginCookies = new System.Windows.Forms.RadioButton();
            this.lblLoginMethod = new System.Windows.Forms.Label();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.lblLoginStatusTitle = new System.Windows.Forms.Label();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.gbxActionsSummary = new System.Windows.Forms.GroupBox();
            this.lblActionsSummaryTextNo = new System.Windows.Forms.Label();
            this.tbxActionsSummaryTextNo = new System.Windows.Forms.TextBox();
            this.tbxActionsSummaryTextPartial = new System.Windows.Forms.TextBox();
            this.lblActionsSummaryTextPartial = new System.Windows.Forms.Label();
            this.tbxActionsSummaryTextFull = new System.Windows.Forms.TextBox();
            this.lblActionsSummaryTextFull = new System.Windows.Forms.Label();
            this.lblActionsSummaryText = new System.Windows.Forms.Label();
            this.tbxActionsSummaryCol = new System.Windows.Forms.TextBox();
            this.cbxActionsSummary = new System.Windows.Forms.CheckBox();
            this.gbxActionsEC = new System.Windows.Forms.GroupBox();
            this.btnActionsECShow = new System.Windows.Forms.Button();
            this.btnActionsECSave = new System.Windows.Forms.Button();
            this.btnActionsECLoad = new System.Windows.Forms.Button();
            this.lblActionsStatus = new System.Windows.Forms.Label();
            this.pbrActions = new System.Windows.Forms.ProgressBar();
            this.btnActionsStart = new System.Windows.Forms.Button();
            this.gbxActionsShares = new System.Windows.Forms.GroupBox();
            this.tbxActionsSharesDetailsCol = new System.Windows.Forms.TextBox();
            this.cbxActionsShareDetails = new System.Windows.Forms.CheckBox();
            this.numActionsMinShares = new System.Windows.Forms.NumericUpDown();
            this.cbxActionsCheckShares = new System.Windows.Forms.CheckBox();
            this.tbxActionsSharesCountCol = new System.Windows.Forms.TextBox();
            this.cbxActionsGetShares = new System.Windows.Forms.CheckBox();
            this.gbxActionsMentions = new System.Windows.Forms.GroupBox();
            this.tbxActionsMentionedUIDCol = new System.Windows.Forms.TextBox();
            this.cbxActionsMentionsExclude = new System.Windows.Forms.CheckBox();
            this.cbxActionsMentionsDetails = new System.Windows.Forms.CheckBox();
            this.numActionsMinMentions = new System.Windows.Forms.NumericUpDown();
            this.cbxActionsCheckMentions = new System.Windows.Forms.CheckBox();
            this.tbxActionsMentionsCountCol = new System.Windows.Forms.TextBox();
            this.cbxActionsGetMentions = new System.Windows.Forms.CheckBox();
            this.gbxActionsComments = new System.Windows.Forms.GroupBox();
            this.tbxActionsCommentTxtCol = new System.Windows.Forms.TextBox();
            this.numActionsMinComments = new System.Windows.Forms.NumericUpDown();
            this.tbxActionsCommentsCountCol = new System.Windows.Forms.TextBox();
            this.rbtActionsCommentsBothPasses = new System.Windows.Forms.RadioButton();
            this.rbtActionsCommentsP2Only = new System.Windows.Forms.RadioButton();
            this.rbtActionsCommentsP1Only = new System.Windows.Forms.RadioButton();
            this.lblActionsCommentsPasses = new System.Windows.Forms.Label();
            this.cbxActionsGetReplies = new System.Windows.Forms.CheckBox();
            this.cbxActionsCommentsDetails = new System.Windows.Forms.CheckBox();
            this.cbxActionsCheckComments = new System.Windows.Forms.CheckBox();
            this.cbxActionsGetComments = new System.Windows.Forms.CheckBox();
            this.gbxActionsReactions = new System.Windows.Forms.GroupBox();
            this.tbxActionsReactionsDetailsCol = new System.Windows.Forms.TextBox();
            this.cbxActionsReactionsDetails = new System.Windows.Forms.CheckBox();
            this.tbxActionsReactionsCountCol = new System.Windows.Forms.TextBox();
            this.numActionsMinReactions = new System.Windows.Forms.NumericUpDown();
            this.cbxActionsCheckReactions = new System.Windows.Forms.CheckBox();
            this.cbxActionsGetReactions = new System.Windows.Forms.CheckBox();
            this.tbxActionsFBLink = new System.Windows.Forms.TextBox();
            this.lblActionsFBLink = new System.Windows.Forms.Label();
            this.tctMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabActions.SuspendLayout();
            this.gbxActionsSummary.SuspendLayout();
            this.gbxActionsEC.SuspendLayout();
            this.gbxActionsShares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionsMinShares)).BeginInit();
            this.gbxActionsMentions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionsMinMentions)).BeginInit();
            this.gbxActionsComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionsMinComments)).BeginInit();
            this.gbxActionsReactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionsMinReactions)).BeginInit();
            this.SuspendLayout();
            // 
            // tctMain
            // 
            this.tctMain.Controls.Add(this.tabLogin);
            this.tctMain.Controls.Add(this.tabActions);
            this.tctMain.Location = new System.Drawing.Point(12, 12);
            this.tctMain.Name = "tctMain";
            this.tctMain.SelectedIndex = 0;
            this.tctMain.Size = new System.Drawing.Size(584, 814);
            this.tctMain.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnLoginCookiesCopy);
            this.tabLogin.Controls.Add(this.lblLoginCookiesOutput);
            this.tabLogin.Controls.Add(this.tbxLoginCookiesOutput);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.lblLoginPassword);
            this.tabLogin.Controls.Add(this.tbxLoginPassword);
            this.tabLogin.Controls.Add(this.tbxLoginEmail);
            this.tabLogin.Controls.Add(this.lblLoginEmail);
            this.tabLogin.Controls.Add(this.rbtLoginCreds);
            this.tabLogin.Controls.Add(this.btnLoginLoadCookiesTxt);
            this.tabLogin.Controls.Add(this.tbxLoginCookiesInput);
            this.tabLogin.Controls.Add(this.rbtLoginCookies);
            this.tabLogin.Controls.Add(this.lblLoginMethod);
            this.tabLogin.Controls.Add(this.lblLoginStatus);
            this.tabLogin.Controls.Add(this.lblLoginStatusTitle);
            this.tabLogin.Location = new System.Drawing.Point(4, 24);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(576, 786);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLoginCookiesCopy
            // 
            this.btnLoginCookiesCopy.Enabled = false;
            this.btnLoginCookiesCopy.Location = new System.Drawing.Point(495, 311);
            this.btnLoginCookiesCopy.Name = "btnLoginCookiesCopy";
            this.btnLoginCookiesCopy.Size = new System.Drawing.Size(75, 23);
            this.btnLoginCookiesCopy.TabIndex = 14;
            this.btnLoginCookiesCopy.Text = "Copy";
            this.btnLoginCookiesCopy.UseVisualStyleBackColor = true;
            this.btnLoginCookiesCopy.Click += new System.EventHandler(this.btnLoginCookiesCopy_Click);
            // 
            // lblLoginCookiesOutput
            // 
            this.lblLoginCookiesOutput.AutoSize = true;
            this.lblLoginCookiesOutput.Location = new System.Drawing.Point(6, 315);
            this.lblLoginCookiesOutput.Name = "lblLoginCookiesOutput";
            this.lblLoginCookiesOutput.Size = new System.Drawing.Size(93, 15);
            this.lblLoginCookiesOutput.TabIndex = 13;
            this.lblLoginCookiesOutput.Text = "Current cookies:";
            // 
            // tbxLoginCookiesOutput
            // 
            this.tbxLoginCookiesOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxLoginCookiesOutput.Location = new System.Drawing.Point(6, 340);
            this.tbxLoginCookiesOutput.Multiline = true;
            this.tbxLoginCookiesOutput.Name = "tbxLoginCookiesOutput";
            this.tbxLoginCookiesOutput.ReadOnly = true;
            this.tbxLoginCookiesOutput.Size = new System.Drawing.Size(564, 99);
            this.tbxLoginCookiesOutput.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(213, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 23);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(300, 209);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(60, 15);
            this.lblLoginPassword.TabIndex = 10;
            this.lblLoginPassword.Text = "Password:";
            // 
            // tbxLoginPassword
            // 
            this.tbxLoginPassword.Enabled = false;
            this.tbxLoginPassword.Location = new System.Drawing.Point(300, 227);
            this.tbxLoginPassword.Name = "tbxLoginPassword";
            this.tbxLoginPassword.Size = new System.Drawing.Size(270, 23);
            this.tbxLoginPassword.TabIndex = 9;
            this.tbxLoginPassword.UseSystemPasswordChar = true;
            this.tbxLoginPassword.TextChanged += new System.EventHandler(this.tbxLoginPassword_TextChanged);
            // 
            // tbxLoginEmail
            // 
            this.tbxLoginEmail.Enabled = false;
            this.tbxLoginEmail.Location = new System.Drawing.Point(6, 227);
            this.tbxLoginEmail.Name = "tbxLoginEmail";
            this.tbxLoginEmail.Size = new System.Drawing.Size(274, 23);
            this.tbxLoginEmail.TabIndex = 8;
            this.tbxLoginEmail.TextChanged += new System.EventHandler(this.tbxLoginEmail_TextChanged);
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Location = new System.Drawing.Point(6, 209);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(178, 15);
            this.lblLoginEmail.TabIndex = 7;
            this.lblLoginEmail.Text = "Email address or phone number:";
            // 
            // rbtLoginCreds
            // 
            this.rbtLoginCreds.AutoSize = true;
            this.rbtLoginCreds.Location = new System.Drawing.Point(10, 187);
            this.rbtLoginCreds.Name = "rbtLoginCreds";
            this.rbtLoginCreds.Size = new System.Drawing.Size(84, 19);
            this.rbtLoginCreds.TabIndex = 6;
            this.rbtLoginCreds.Text = "Credentials";
            this.rbtLoginCreds.UseVisualStyleBackColor = true;
            this.rbtLoginCreds.CheckedChanged += new System.EventHandler(this.rbtLoginCreds_CheckedChanged);
            // 
            // btnLoginLoadCookiesTxt
            // 
            this.btnLoginLoadCookiesTxt.Location = new System.Drawing.Point(429, 53);
            this.btnLoginLoadCookiesTxt.Name = "btnLoginLoadCookiesTxt";
            this.btnLoginLoadCookiesTxt.Size = new System.Drawing.Size(141, 23);
            this.btnLoginLoadCookiesTxt.TabIndex = 5;
            this.btnLoginLoadCookiesTxt.Text = "Load cookies.txt...";
            this.btnLoginLoadCookiesTxt.UseVisualStyleBackColor = true;
            this.btnLoginLoadCookiesTxt.Click += new System.EventHandler(this.btnLoginLoadCookiesTxt_Click);
            // 
            // tbxLoginCookiesInput
            // 
            this.tbxLoginCookiesInput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxLoginCookiesInput.Location = new System.Drawing.Point(6, 82);
            this.tbxLoginCookiesInput.Multiline = true;
            this.tbxLoginCookiesInput.Name = "tbxLoginCookiesInput";
            this.tbxLoginCookiesInput.Size = new System.Drawing.Size(564, 99);
            this.tbxLoginCookiesInput.TabIndex = 4;
            this.tbxLoginCookiesInput.TextChanged += new System.EventHandler(this.tbxLoginCookiesInput_TextChanged);
            // 
            // rbtLoginCookies
            // 
            this.rbtLoginCookies.AutoSize = true;
            this.rbtLoginCookies.Checked = true;
            this.rbtLoginCookies.Location = new System.Drawing.Point(10, 57);
            this.rbtLoginCookies.Name = "rbtLoginCookies";
            this.rbtLoginCookies.Size = new System.Drawing.Size(156, 19);
            this.rbtLoginCookies.TabIndex = 3;
            this.rbtLoginCookies.TabStop = true;
            this.rbtLoginCookies.Text = "Cookies (recommended)";
            this.rbtLoginCookies.UseVisualStyleBackColor = true;
            this.rbtLoginCookies.CheckedChanged += new System.EventHandler(this.rbtLoginCookies_CheckedChanged);
            // 
            // lblLoginMethod
            // 
            this.lblLoginMethod.AutoSize = true;
            this.lblLoginMethod.Location = new System.Drawing.Point(10, 39);
            this.lblLoginMethod.Name = "lblLoginMethod";
            this.lblLoginMethod.Size = new System.Drawing.Size(85, 15);
            this.lblLoginMethod.TabIndex = 2;
            this.lblLoginMethod.Text = "Login method:";
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.AutoSize = true;
            this.lblLoginStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginStatus.Location = new System.Drawing.Point(141, 15);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(0, 15);
            this.lblLoginStatus.TabIndex = 1;
            // 
            // lblLoginStatusTitle
            // 
            this.lblLoginStatusTitle.AutoSize = true;
            this.lblLoginStatusTitle.Location = new System.Drawing.Point(10, 15);
            this.lblLoginStatusTitle.Name = "lblLoginStatusTitle";
            this.lblLoginStatusTitle.Size = new System.Drawing.Size(125, 15);
            this.lblLoginStatusTitle.TabIndex = 0;
            this.lblLoginStatusTitle.Text = "Facebook login status:";
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.gbxActionsSummary);
            this.tabActions.Controls.Add(this.gbxActionsEC);
            this.tabActions.Controls.Add(this.lblActionsStatus);
            this.tabActions.Controls.Add(this.pbrActions);
            this.tabActions.Controls.Add(this.btnActionsStart);
            this.tabActions.Controls.Add(this.gbxActionsShares);
            this.tabActions.Controls.Add(this.gbxActionsMentions);
            this.tabActions.Controls.Add(this.gbxActionsComments);
            this.tabActions.Controls.Add(this.gbxActionsReactions);
            this.tabActions.Controls.Add(this.tbxActionsFBLink);
            this.tabActions.Controls.Add(this.lblActionsFBLink);
            this.tabActions.Location = new System.Drawing.Point(4, 24);
            this.tabActions.Name = "tabActions";
            this.tabActions.Size = new System.Drawing.Size(576, 786);
            this.tabActions.TabIndex = 1;
            this.tabActions.Text = "Actions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // gbxActionsSummary
            // 
            this.gbxActionsSummary.Controls.Add(this.lblActionsSummaryTextNo);
            this.gbxActionsSummary.Controls.Add(this.tbxActionsSummaryTextNo);
            this.gbxActionsSummary.Controls.Add(this.tbxActionsSummaryTextPartial);
            this.gbxActionsSummary.Controls.Add(this.lblActionsSummaryTextPartial);
            this.gbxActionsSummary.Controls.Add(this.tbxActionsSummaryTextFull);
            this.gbxActionsSummary.Controls.Add(this.lblActionsSummaryTextFull);
            this.gbxActionsSummary.Controls.Add(this.lblActionsSummaryText);
            this.gbxActionsSummary.Controls.Add(this.tbxActionsSummaryCol);
            this.gbxActionsSummary.Controls.Add(this.cbxActionsSummary);
            this.gbxActionsSummary.Location = new System.Drawing.Point(10, 593);
            this.gbxActionsSummary.Name = "gbxActionsSummary";
            this.gbxActionsSummary.Size = new System.Drawing.Size(556, 137);
            this.gbxActionsSummary.TabIndex = 10;
            this.gbxActionsSummary.TabStop = false;
            this.gbxActionsSummary.Text = "Summary";
            // 
            // lblActionsSummaryTextNo
            // 
            this.lblActionsSummaryTextNo.AutoSize = true;
            this.lblActionsSummaryTextNo.Location = new System.Drawing.Point(60, 106);
            this.lblActionsSummaryTextNo.Name = "lblActionsSummaryTextNo";
            this.lblActionsSummaryTextNo.Size = new System.Drawing.Size(90, 15);
            this.lblActionsSummaryTextNo.TabIndex = 8;
            this.lblActionsSummaryTextNo.Text = "No completion:";
            // 
            // tbxActionsSummaryTextNo
            // 
            this.tbxActionsSummaryTextNo.Location = new System.Drawing.Point(173, 103);
            this.tbxActionsSummaryTextNo.Name = "tbxActionsSummaryTextNo";
            this.tbxActionsSummaryTextNo.Size = new System.Drawing.Size(377, 23);
            this.tbxActionsSummaryTextNo.TabIndex = 7;
            this.tbxActionsSummaryTextNo.Text = "Not completed";
            this.tbxActionsSummaryTextNo.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // tbxActionsSummaryTextPartial
            // 
            this.tbxActionsSummaryTextPartial.Location = new System.Drawing.Point(173, 74);
            this.tbxActionsSummaryTextPartial.Name = "tbxActionsSummaryTextPartial";
            this.tbxActionsSummaryTextPartial.Size = new System.Drawing.Size(377, 23);
            this.tbxActionsSummaryTextPartial.TabIndex = 6;
            this.tbxActionsSummaryTextPartial.Text = "Partially completed";
            this.tbxActionsSummaryTextPartial.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // lblActionsSummaryTextPartial
            // 
            this.lblActionsSummaryTextPartial.AutoSize = true;
            this.lblActionsSummaryTextPartial.Location = new System.Drawing.Point(60, 77);
            this.lblActionsSummaryTextPartial.Name = "lblActionsSummaryTextPartial";
            this.lblActionsSummaryTextPartial.Size = new System.Drawing.Size(107, 15);
            this.lblActionsSummaryTextPartial.TabIndex = 5;
            this.lblActionsSummaryTextPartial.Text = "Partial completion:";
            // 
            // tbxActionsSummaryTextFull
            // 
            this.tbxActionsSummaryTextFull.Location = new System.Drawing.Point(173, 47);
            this.tbxActionsSummaryTextFull.Name = "tbxActionsSummaryTextFull";
            this.tbxActionsSummaryTextFull.Size = new System.Drawing.Size(377, 23);
            this.tbxActionsSummaryTextFull.TabIndex = 4;
            this.tbxActionsSummaryTextFull.Text = "Fully completed";
            this.tbxActionsSummaryTextFull.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // lblActionsSummaryTextFull
            // 
            this.lblActionsSummaryTextFull.AutoSize = true;
            this.lblActionsSummaryTextFull.Location = new System.Drawing.Point(60, 50);
            this.lblActionsSummaryTextFull.Name = "lblActionsSummaryTextFull";
            this.lblActionsSummaryTextFull.Size = new System.Drawing.Size(93, 15);
            this.lblActionsSummaryTextFull.TabIndex = 3;
            this.lblActionsSummaryTextFull.Text = "Full completion:";
            // 
            // lblActionsSummaryText
            // 
            this.lblActionsSummaryText.AutoSize = true;
            this.lblActionsSummaryText.Location = new System.Drawing.Point(6, 50);
            this.lblActionsSummaryText.Name = "lblActionsSummaryText";
            this.lblActionsSummaryText.Size = new System.Drawing.Size(49, 15);
            this.lblActionsSummaryText.TabIndex = 2;
            this.lblActionsSummaryText.Text = "Text for:";
            // 
            // tbxActionsSummaryCol
            // 
            this.tbxActionsSummaryCol.Location = new System.Drawing.Point(287, 20);
            this.tbxActionsSummaryCol.Name = "tbxActionsSummaryCol";
            this.tbxActionsSummaryCol.Size = new System.Drawing.Size(263, 23);
            this.tbxActionsSummaryCol.TabIndex = 1;
            this.tbxActionsSummaryCol.Text = "Summary";
            this.tbxActionsSummaryCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // cbxActionsSummary
            // 
            this.cbxActionsSummary.AutoSize = true;
            this.cbxActionsSummary.Checked = true;
            this.cbxActionsSummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsSummary.Location = new System.Drawing.Point(6, 22);
            this.cbxActionsSummary.Name = "cbxActionsSummary";
            this.cbxActionsSummary.Size = new System.Drawing.Size(275, 19);
            this.cbxActionsSummary.TabIndex = 0;
            this.cbxActionsSummary.Text = "Summarize checking data and write to column:";
            this.cbxActionsSummary.UseVisualStyleBackColor = true;
            this.cbxActionsSummary.CheckedChanged += new System.EventHandler(this.cbxActionsSummary_CheckedChanged);
            // 
            // gbxActionsEC
            // 
            this.gbxActionsEC.Controls.Add(this.btnActionsECShow);
            this.gbxActionsEC.Controls.Add(this.btnActionsECSave);
            this.gbxActionsEC.Controls.Add(this.btnActionsECLoad);
            this.gbxActionsEC.Location = new System.Drawing.Point(10, 41);
            this.gbxActionsEC.Name = "gbxActionsEC";
            this.gbxActionsEC.Size = new System.Drawing.Size(556, 42);
            this.gbxActionsEC.TabIndex = 9;
            this.gbxActionsEC.TabStop = false;
            this.gbxActionsEC.Text = "EntryCollection";
            // 
            // btnActionsECShow
            // 
            this.btnActionsECShow.Enabled = false;
            this.btnActionsECShow.Location = new System.Drawing.Point(251, 13);
            this.btnActionsECShow.Name = "btnActionsECShow";
            this.btnActionsECShow.Size = new System.Drawing.Size(75, 23);
            this.btnActionsECShow.TabIndex = 2;
            this.btnActionsECShow.Text = "Show";
            this.btnActionsECShow.UseVisualStyleBackColor = true;
            this.btnActionsECShow.Click += new System.EventHandler(this.btnActionsECShow_Click);
            // 
            // btnActionsECSave
            // 
            this.btnActionsECSave.Enabled = false;
            this.btnActionsECSave.Location = new System.Drawing.Point(341, 13);
            this.btnActionsECSave.Name = "btnActionsECSave";
            this.btnActionsECSave.Size = new System.Drawing.Size(75, 23);
            this.btnActionsECSave.TabIndex = 1;
            this.btnActionsECSave.Text = "Save";
            this.btnActionsECSave.UseVisualStyleBackColor = true;
            this.btnActionsECSave.Click += new System.EventHandler(this.btnActionsECSave_Click);
            // 
            // btnActionsECLoad
            // 
            this.btnActionsECLoad.Location = new System.Drawing.Point(163, 13);
            this.btnActionsECLoad.Name = "btnActionsECLoad";
            this.btnActionsECLoad.Size = new System.Drawing.Size(75, 23);
            this.btnActionsECLoad.TabIndex = 0;
            this.btnActionsECLoad.Text = "Load";
            this.btnActionsECLoad.UseVisualStyleBackColor = true;
            this.btnActionsECLoad.Click += new System.EventHandler(this.btnActionsECLoad_Click);
            // 
            // lblActionsStatus
            // 
            this.lblActionsStatus.AutoSize = true;
            this.lblActionsStatus.Location = new System.Drawing.Point(10, 762);
            this.lblActionsStatus.Name = "lblActionsStatus";
            this.lblActionsStatus.Size = new System.Drawing.Size(92, 15);
            this.lblActionsStatus.TabIndex = 8;
            this.lblActionsStatus.Text = "lblActionsStatus";
            // 
            // pbrActions
            // 
            this.pbrActions.Location = new System.Drawing.Point(88, 736);
            this.pbrActions.Maximum = 300;
            this.pbrActions.Name = "pbrActions";
            this.pbrActions.Size = new System.Drawing.Size(478, 23);
            this.pbrActions.TabIndex = 7;
            // 
            // btnActionsStart
            // 
            this.btnActionsStart.Enabled = false;
            this.btnActionsStart.Location = new System.Drawing.Point(10, 736);
            this.btnActionsStart.Name = "btnActionsStart";
            this.btnActionsStart.Size = new System.Drawing.Size(72, 23);
            this.btnActionsStart.TabIndex = 6;
            this.btnActionsStart.Text = "Start";
            this.btnActionsStart.UseVisualStyleBackColor = true;
            this.btnActionsStart.Click += new System.EventHandler(this.btnActionsStart_Click);
            // 
            // gbxActionsShares
            // 
            this.gbxActionsShares.Controls.Add(this.tbxActionsSharesDetailsCol);
            this.gbxActionsShares.Controls.Add(this.cbxActionsShareDetails);
            this.gbxActionsShares.Controls.Add(this.numActionsMinShares);
            this.gbxActionsShares.Controls.Add(this.cbxActionsCheckShares);
            this.gbxActionsShares.Controls.Add(this.tbxActionsSharesCountCol);
            this.gbxActionsShares.Controls.Add(this.cbxActionsGetShares);
            this.gbxActionsShares.Location = new System.Drawing.Point(10, 487);
            this.gbxActionsShares.Name = "gbxActionsShares";
            this.gbxActionsShares.Size = new System.Drawing.Size(556, 100);
            this.gbxActionsShares.TabIndex = 5;
            this.gbxActionsShares.TabStop = false;
            this.gbxActionsShares.Text = "Shares";
            // 
            // tbxActionsSharesDetailsCol
            // 
            this.tbxActionsSharesDetailsCol.Enabled = false;
            this.tbxActionsSharesDetailsCol.Location = new System.Drawing.Point(184, 70);
            this.tbxActionsSharesDetailsCol.Name = "tbxActionsSharesDetailsCol";
            this.tbxActionsSharesDetailsCol.Size = new System.Drawing.Size(366, 23);
            this.tbxActionsSharesDetailsCol.TabIndex = 10;
            this.tbxActionsSharesDetailsCol.Text = "Share details";
            this.tbxActionsSharesDetailsCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // cbxActionsShareDetails
            // 
            this.cbxActionsShareDetails.AutoSize = true;
            this.cbxActionsShareDetails.Location = new System.Drawing.Point(6, 72);
            this.cbxActionsShareDetails.Name = "cbxActionsShareDetails";
            this.cbxActionsShareDetails.Size = new System.Drawing.Size(172, 19);
            this.cbxActionsShareDetails.TabIndex = 9;
            this.cbxActionsShareDetails.Text = "List share details in column:";
            this.cbxActionsShareDetails.UseVisualStyleBackColor = true;
            this.cbxActionsShareDetails.CheckedChanged += new System.EventHandler(this.cbxActionsShareDetails_CheckedChanged);
            // 
            // numActionsMinShares
            // 
            this.numActionsMinShares.Location = new System.Drawing.Point(374, 46);
            this.numActionsMinShares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numActionsMinShares.Name = "numActionsMinShares";
            this.numActionsMinShares.Size = new System.Drawing.Size(38, 23);
            this.numActionsMinShares.TabIndex = 8;
            this.numActionsMinShares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxActionsCheckShares
            // 
            this.cbxActionsCheckShares.AutoSize = true;
            this.cbxActionsCheckShares.Checked = true;
            this.cbxActionsCheckShares.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsCheckShares.Location = new System.Drawing.Point(6, 47);
            this.cbxActionsCheckShares.Name = "cbxActionsCheckShares";
            this.cbxActionsCheckShares.Size = new System.Drawing.Size(362, 19);
            this.cbxActionsCheckShares.TabIndex = 2;
            this.cbxActionsCheckShares.Text = "Check shares count: Minimum number of shares for each entry:";
            this.cbxActionsCheckShares.UseVisualStyleBackColor = true;
            this.cbxActionsCheckShares.CheckedChanged += new System.EventHandler(this.cbxActionsCheckShares_CheckedChanged);
            // 
            // tbxActionsSharesCountCol
            // 
            this.tbxActionsSharesCountCol.Location = new System.Drawing.Point(247, 20);
            this.tbxActionsSharesCountCol.Name = "tbxActionsSharesCountCol";
            this.tbxActionsSharesCountCol.Size = new System.Drawing.Size(303, 23);
            this.tbxActionsSharesCountCol.TabIndex = 1;
            this.tbxActionsSharesCountCol.Text = "Shares";
            this.tbxActionsSharesCountCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // cbxActionsGetShares
            // 
            this.cbxActionsGetShares.AutoSize = true;
            this.cbxActionsGetShares.Checked = true;
            this.cbxActionsGetShares.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsGetShares.Location = new System.Drawing.Point(6, 22);
            this.cbxActionsGetShares.Name = "cbxActionsGetShares";
            this.cbxActionsGetShares.Size = new System.Drawing.Size(235, 19);
            this.cbxActionsGetShares.TabIndex = 0;
            this.cbxActionsGetShares.Text = "Get shares and list the count in column:";
            this.cbxActionsGetShares.UseVisualStyleBackColor = true;
            this.cbxActionsGetShares.CheckedChanged += new System.EventHandler(this.cbxActionsGetShares_CheckedChanged);
            // 
            // gbxActionsMentions
            // 
            this.gbxActionsMentions.Controls.Add(this.tbxActionsMentionedUIDCol);
            this.gbxActionsMentions.Controls.Add(this.cbxActionsMentionsExclude);
            this.gbxActionsMentions.Controls.Add(this.cbxActionsMentionsDetails);
            this.gbxActionsMentions.Controls.Add(this.numActionsMinMentions);
            this.gbxActionsMentions.Controls.Add(this.cbxActionsCheckMentions);
            this.gbxActionsMentions.Controls.Add(this.tbxActionsMentionsCountCol);
            this.gbxActionsMentions.Controls.Add(this.cbxActionsGetMentions);
            this.gbxActionsMentions.Location = new System.Drawing.Point(10, 361);
            this.gbxActionsMentions.Name = "gbxActionsMentions";
            this.gbxActionsMentions.Size = new System.Drawing.Size(556, 123);
            this.gbxActionsMentions.TabIndex = 4;
            this.gbxActionsMentions.TabStop = false;
            this.gbxActionsMentions.Text = "Mentions";
            // 
            // tbxActionsMentionedUIDCol
            // 
            this.tbxActionsMentionedUIDCol.Enabled = false;
            this.tbxActionsMentionedUIDCol.Location = new System.Drawing.Point(204, 70);
            this.tbxActionsMentionedUIDCol.Name = "tbxActionsMentionedUIDCol";
            this.tbxActionsMentionedUIDCol.Size = new System.Drawing.Size(346, 23);
            this.tbxActionsMentionedUIDCol.TabIndex = 13;
            this.tbxActionsMentionedUIDCol.Text = "Mentioned UID(s)";
            this.tbxActionsMentionedUIDCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // cbxActionsMentionsExclude
            // 
            this.cbxActionsMentionsExclude.AutoSize = true;
            this.cbxActionsMentionsExclude.Checked = true;
            this.cbxActionsMentionsExclude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsMentionsExclude.Enabled = false;
            this.cbxActionsMentionsExclude.Location = new System.Drawing.Point(6, 97);
            this.cbxActionsMentionsExclude.Name = "cbxActionsMentionsExclude";
            this.cbxActionsMentionsExclude.Size = new System.Drawing.Size(235, 19);
            this.cbxActionsMentionsExclude.TabIndex = 12;
            this.cbxActionsMentionsExclude.Text = "Exclude accounts in the EntryCollection";
            this.cbxActionsMentionsExclude.UseVisualStyleBackColor = true;
            // 
            // cbxActionsMentionsDetails
            // 
            this.cbxActionsMentionsDetails.AutoSize = true;
            this.cbxActionsMentionsDetails.Enabled = false;
            this.cbxActionsMentionsDetails.Location = new System.Drawing.Point(6, 72);
            this.cbxActionsMentionsDetails.Name = "cbxActionsMentionsDetails";
            this.cbxActionsMentionsDetails.Size = new System.Drawing.Size(192, 19);
            this.cbxActionsMentionsDetails.TabIndex = 11;
            this.cbxActionsMentionsDetails.Text = "List mentioned UIDs in column:";
            this.cbxActionsMentionsDetails.UseVisualStyleBackColor = true;
            this.cbxActionsMentionsDetails.CheckedChanged += new System.EventHandler(this.cbxActionsMentionsDetails_CheckedChanged);
            // 
            // numActionsMinMentions
            // 
            this.numActionsMinMentions.Enabled = false;
            this.numActionsMinMentions.Location = new System.Drawing.Point(408, 46);
            this.numActionsMinMentions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numActionsMinMentions.Name = "numActionsMinMentions";
            this.numActionsMinMentions.Size = new System.Drawing.Size(38, 23);
            this.numActionsMinMentions.TabIndex = 10;
            this.numActionsMinMentions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cbxActionsCheckMentions
            // 
            this.cbxActionsCheckMentions.AutoSize = true;
            this.cbxActionsCheckMentions.Checked = true;
            this.cbxActionsCheckMentions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsCheckMentions.Enabled = false;
            this.cbxActionsCheckMentions.Location = new System.Drawing.Point(6, 47);
            this.cbxActionsCheckMentions.Name = "cbxActionsCheckMentions";
            this.cbxActionsCheckMentions.Size = new System.Drawing.Size(396, 19);
            this.cbxActionsCheckMentions.TabIndex = 2;
            this.cbxActionsCheckMentions.Text = "Check mentions count: Minimum number of mentions for each entry:";
            this.cbxActionsCheckMentions.UseVisualStyleBackColor = true;
            this.cbxActionsCheckMentions.CheckedChanged += new System.EventHandler(this.cbxActionsCheckMentions_CheckedChanged);
            // 
            // tbxActionsMentionsCountCol
            // 
            this.tbxActionsMentionsCountCol.Enabled = false;
            this.tbxActionsMentionsCountCol.Location = new System.Drawing.Point(263, 18);
            this.tbxActionsMentionsCountCol.Name = "tbxActionsMentionsCountCol";
            this.tbxActionsMentionsCountCol.Size = new System.Drawing.Size(287, 23);
            this.tbxActionsMentionsCountCol.TabIndex = 1;
            this.tbxActionsMentionsCountCol.Text = "Mentions";
            this.tbxActionsMentionsCountCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // cbxActionsGetMentions
            // 
            this.cbxActionsGetMentions.AutoSize = true;
            this.cbxActionsGetMentions.Location = new System.Drawing.Point(6, 22);
            this.cbxActionsGetMentions.Name = "cbxActionsGetMentions";
            this.cbxActionsGetMentions.Size = new System.Drawing.Size(252, 19);
            this.cbxActionsGetMentions.TabIndex = 0;
            this.cbxActionsGetMentions.Text = "Get mentions and list the count in column:";
            this.cbxActionsGetMentions.UseVisualStyleBackColor = true;
            this.cbxActionsGetMentions.CheckedChanged += new System.EventHandler(this.cbxActionsGetMentions_CheckedChanged);
            // 
            // gbxActionsComments
            // 
            this.gbxActionsComments.Controls.Add(this.tbxActionsCommentTxtCol);
            this.gbxActionsComments.Controls.Add(this.numActionsMinComments);
            this.gbxActionsComments.Controls.Add(this.tbxActionsCommentsCountCol);
            this.gbxActionsComments.Controls.Add(this.rbtActionsCommentsBothPasses);
            this.gbxActionsComments.Controls.Add(this.rbtActionsCommentsP2Only);
            this.gbxActionsComments.Controls.Add(this.rbtActionsCommentsP1Only);
            this.gbxActionsComments.Controls.Add(this.lblActionsCommentsPasses);
            this.gbxActionsComments.Controls.Add(this.cbxActionsGetReplies);
            this.gbxActionsComments.Controls.Add(this.cbxActionsCommentsDetails);
            this.gbxActionsComments.Controls.Add(this.cbxActionsCheckComments);
            this.gbxActionsComments.Controls.Add(this.cbxActionsGetComments);
            this.gbxActionsComments.Location = new System.Drawing.Point(10, 190);
            this.gbxActionsComments.Name = "gbxActionsComments";
            this.gbxActionsComments.Size = new System.Drawing.Size(556, 165);
            this.gbxActionsComments.TabIndex = 3;
            this.gbxActionsComments.TabStop = false;
            this.gbxActionsComments.Text = "Comments";
            // 
            // tbxActionsCommentTxtCol
            // 
            this.tbxActionsCommentTxtCol.Enabled = false;
            this.tbxActionsCommentTxtCol.Location = new System.Drawing.Point(176, 70);
            this.tbxActionsCommentTxtCol.Name = "tbxActionsCommentTxtCol";
            this.tbxActionsCommentTxtCol.Size = new System.Drawing.Size(374, 23);
            this.tbxActionsCommentTxtCol.TabIndex = 9;
            this.tbxActionsCommentTxtCol.Text = "Comment text";
            this.tbxActionsCommentTxtCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // numActionsMinComments
            // 
            this.numActionsMinComments.Location = new System.Drawing.Point(422, 46);
            this.numActionsMinComments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numActionsMinComments.Name = "numActionsMinComments";
            this.numActionsMinComments.Size = new System.Drawing.Size(38, 23);
            this.numActionsMinComments.TabIndex = 8;
            this.numActionsMinComments.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tbxActionsCommentsCountCol
            // 
            this.tbxActionsCommentsCountCol.Location = new System.Drawing.Point(272, 18);
            this.tbxActionsCommentsCountCol.Name = "tbxActionsCommentsCountCol";
            this.tbxActionsCommentsCountCol.Size = new System.Drawing.Size(278, 23);
            this.tbxActionsCommentsCountCol.TabIndex = 8;
            this.tbxActionsCommentsCountCol.Text = "Comments";
            this.tbxActionsCommentsCountCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // rbtActionsCommentsBothPasses
            // 
            this.rbtActionsCommentsBothPasses.AutoSize = true;
            this.rbtActionsCommentsBothPasses.Checked = true;
            this.rbtActionsCommentsBothPasses.Location = new System.Drawing.Point(163, 140);
            this.rbtActionsCommentsBothPasses.Name = "rbtActionsCommentsBothPasses";
            this.rbtActionsCommentsBothPasses.Size = new System.Drawing.Size(176, 19);
            this.rbtActionsCommentsBothPasses.TabIndex = 7;
            this.rbtActionsCommentsBothPasses.TabStop = true;
            this.rbtActionsCommentsBothPasses.Text = "Both passes (recommended)";
            this.rbtActionsCommentsBothPasses.UseVisualStyleBackColor = true;
            // 
            // rbtActionsCommentsP2Only
            // 
            this.rbtActionsCommentsP2Only.AutoSize = true;
            this.rbtActionsCommentsP2Only.Location = new System.Drawing.Point(313, 118);
            this.rbtActionsCommentsP2Only.Name = "rbtActionsCommentsP2Only";
            this.rbtActionsCommentsP2Only.Size = new System.Drawing.Size(165, 19);
            this.rbtActionsCommentsP2Only.TabIndex = 6;
            this.rbtActionsCommentsP2Only.Text = "Pass 2 (not logged in) only";
            this.rbtActionsCommentsP2Only.UseVisualStyleBackColor = true;
            // 
            // rbtActionsCommentsP1Only
            // 
            this.rbtActionsCommentsP1Only.AutoSize = true;
            this.rbtActionsCommentsP1Only.Location = new System.Drawing.Point(163, 118);
            this.rbtActionsCommentsP1Only.Name = "rbtActionsCommentsP1Only";
            this.rbtActionsCommentsP1Only.Size = new System.Drawing.Size(144, 19);
            this.rbtActionsCommentsP1Only.TabIndex = 5;
            this.rbtActionsCommentsP1Only.Text = "Pass 1 (logged in) only";
            this.rbtActionsCommentsP1Only.UseVisualStyleBackColor = true;
            // 
            // lblActionsCommentsPasses
            // 
            this.lblActionsCommentsPasses.AutoSize = true;
            this.lblActionsCommentsPasses.Location = new System.Drawing.Point(5, 120);
            this.lblActionsCommentsPasses.Name = "lblActionsCommentsPasses";
            this.lblActionsCommentsPasses.Size = new System.Drawing.Size(154, 15);
            this.lblActionsCommentsPasses.TabIndex = 4;
            this.lblActionsCommentsPasses.Text = "Comment retrieval method:";
            // 
            // cbxActionsGetReplies
            // 
            this.cbxActionsGetReplies.AutoSize = true;
            this.cbxActionsGetReplies.Location = new System.Drawing.Point(6, 97);
            this.cbxActionsGetReplies.Name = "cbxActionsGetReplies";
            this.cbxActionsGetReplies.Size = new System.Drawing.Size(155, 19);
            this.cbxActionsGetReplies.TabIndex = 3;
            this.cbxActionsGetReplies.Text = "Get replies to comments";
            this.cbxActionsGetReplies.UseVisualStyleBackColor = true;
            // 
            // cbxActionsCommentsDetails
            // 
            this.cbxActionsCommentsDetails.AutoSize = true;
            this.cbxActionsCommentsDetails.Location = new System.Drawing.Point(6, 72);
            this.cbxActionsCommentsDetails.Name = "cbxActionsCommentsDetails";
            this.cbxActionsCommentsDetails.Size = new System.Drawing.Size(164, 19);
            this.cbxActionsCommentsDetails.TabIndex = 2;
            this.cbxActionsCommentsDetails.Text = "List comments in column:";
            this.cbxActionsCommentsDetails.UseVisualStyleBackColor = true;
            this.cbxActionsCommentsDetails.CheckedChanged += new System.EventHandler(this.cbxActionsCommentsDetails_CheckedChanged);
            // 
            // cbxActionsCheckComments
            // 
            this.cbxActionsCheckComments.AutoSize = true;
            this.cbxActionsCheckComments.Checked = true;
            this.cbxActionsCheckComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsCheckComments.Location = new System.Drawing.Point(6, 47);
            this.cbxActionsCheckComments.Name = "cbxActionsCheckComments";
            this.cbxActionsCheckComments.Size = new System.Drawing.Size(410, 19);
            this.cbxActionsCheckComments.TabIndex = 1;
            this.cbxActionsCheckComments.Text = "Check comments count: Minimum number of comments for each entry:";
            this.cbxActionsCheckComments.UseVisualStyleBackColor = true;
            this.cbxActionsCheckComments.CheckedChanged += new System.EventHandler(this.cbxActionsCheckComments_CheckedChanged);
            // 
            // cbxActionsGetComments
            // 
            this.cbxActionsGetComments.AutoSize = true;
            this.cbxActionsGetComments.Checked = true;
            this.cbxActionsGetComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsGetComments.Location = new System.Drawing.Point(6, 22);
            this.cbxActionsGetComments.Name = "cbxActionsGetComments";
            this.cbxActionsGetComments.Size = new System.Drawing.Size(259, 19);
            this.cbxActionsGetComments.TabIndex = 0;
            this.cbxActionsGetComments.Text = "Get comments and list the count in column:";
            this.cbxActionsGetComments.UseVisualStyleBackColor = true;
            this.cbxActionsGetComments.CheckedChanged += new System.EventHandler(this.cbxActionsGetComments_CheckedChanged);
            // 
            // gbxActionsReactions
            // 
            this.gbxActionsReactions.Controls.Add(this.tbxActionsReactionsDetailsCol);
            this.gbxActionsReactions.Controls.Add(this.cbxActionsReactionsDetails);
            this.gbxActionsReactions.Controls.Add(this.tbxActionsReactionsCountCol);
            this.gbxActionsReactions.Controls.Add(this.numActionsMinReactions);
            this.gbxActionsReactions.Controls.Add(this.cbxActionsCheckReactions);
            this.gbxActionsReactions.Controls.Add(this.cbxActionsGetReactions);
            this.gbxActionsReactions.Location = new System.Drawing.Point(10, 81);
            this.gbxActionsReactions.Name = "gbxActionsReactions";
            this.gbxActionsReactions.Size = new System.Drawing.Size(556, 103);
            this.gbxActionsReactions.TabIndex = 2;
            this.gbxActionsReactions.TabStop = false;
            this.gbxActionsReactions.Text = "Reactions";
            // 
            // tbxActionsReactionsDetailsCol
            // 
            this.tbxActionsReactionsDetailsCol.Enabled = false;
            this.tbxActionsReactionsDetailsCol.Location = new System.Drawing.Point(200, 70);
            this.tbxActionsReactionsDetailsCol.Name = "tbxActionsReactionsDetailsCol";
            this.tbxActionsReactionsDetailsCol.Size = new System.Drawing.Size(350, 23);
            this.tbxActionsReactionsDetailsCol.TabIndex = 7;
            this.tbxActionsReactionsDetailsCol.Text = "Reaction details";
            this.tbxActionsReactionsDetailsCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // cbxActionsReactionsDetails
            // 
            this.cbxActionsReactionsDetails.AutoSize = true;
            this.cbxActionsReactionsDetails.Location = new System.Drawing.Point(6, 72);
            this.cbxActionsReactionsDetails.Name = "cbxActionsReactionsDetails";
            this.cbxActionsReactionsDetails.Size = new System.Drawing.Size(187, 19);
            this.cbxActionsReactionsDetails.TabIndex = 6;
            this.cbxActionsReactionsDetails.Text = "List reaction details in column:";
            this.cbxActionsReactionsDetails.UseVisualStyleBackColor = true;
            this.cbxActionsReactionsDetails.CheckedChanged += new System.EventHandler(this.cbxActionsReactionsDetails_CheckedChanged);
            // 
            // tbxActionsReactionsCountCol
            // 
            this.tbxActionsReactionsCountCol.Location = new System.Drawing.Point(263, 20);
            this.tbxActionsReactionsCountCol.Name = "tbxActionsReactionsCountCol";
            this.tbxActionsReactionsCountCol.Size = new System.Drawing.Size(287, 23);
            this.tbxActionsReactionsCountCol.TabIndex = 5;
            this.tbxActionsReactionsCountCol.Text = "Reactions";
            this.tbxActionsReactionsCountCol.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // numActionsMinReactions
            // 
            this.numActionsMinReactions.Location = new System.Drawing.Point(404, 46);
            this.numActionsMinReactions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numActionsMinReactions.Name = "numActionsMinReactions";
            this.numActionsMinReactions.Size = new System.Drawing.Size(38, 23);
            this.numActionsMinReactions.TabIndex = 3;
            this.numActionsMinReactions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxActionsCheckReactions
            // 
            this.cbxActionsCheckReactions.AutoSize = true;
            this.cbxActionsCheckReactions.Checked = true;
            this.cbxActionsCheckReactions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsCheckReactions.Location = new System.Drawing.Point(6, 47);
            this.cbxActionsCheckReactions.Name = "cbxActionsCheckReactions";
            this.cbxActionsCheckReactions.Size = new System.Drawing.Size(392, 19);
            this.cbxActionsCheckReactions.TabIndex = 1;
            this.cbxActionsCheckReactions.Text = "Check reactions count: Minimum number of reactions for each entry:";
            this.cbxActionsCheckReactions.UseVisualStyleBackColor = true;
            this.cbxActionsCheckReactions.CheckedChanged += new System.EventHandler(this.cbxActionsCheckReactions_CheckedChanged);
            // 
            // cbxActionsGetReactions
            // 
            this.cbxActionsGetReactions.AutoSize = true;
            this.cbxActionsGetReactions.Checked = true;
            this.cbxActionsGetReactions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsGetReactions.Location = new System.Drawing.Point(6, 22);
            this.cbxActionsGetReactions.Name = "cbxActionsGetReactions";
            this.cbxActionsGetReactions.Size = new System.Drawing.Size(250, 19);
            this.cbxActionsGetReactions.TabIndex = 0;
            this.cbxActionsGetReactions.Text = "Get reactions and list the count in column:";
            this.cbxActionsGetReactions.UseVisualStyleBackColor = true;
            this.cbxActionsGetReactions.CheckedChanged += new System.EventHandler(this.cbxActionsGetReactions_CheckedChanged);
            // 
            // tbxActionsFBLink
            // 
            this.tbxActionsFBLink.Location = new System.Drawing.Point(125, 12);
            this.tbxActionsFBLink.Name = "tbxActionsFBLink";
            this.tbxActionsFBLink.Size = new System.Drawing.Size(441, 23);
            this.tbxActionsFBLink.TabIndex = 1;
            this.tbxActionsFBLink.TextChanged += new System.EventHandler(this.ValidateStartButton);
            // 
            // lblActionsFBLink
            // 
            this.lblActionsFBLink.AutoSize = true;
            this.lblActionsFBLink.Location = new System.Drawing.Point(10, 15);
            this.lblActionsFBLink.Name = "lblActionsFBLink";
            this.lblActionsFBLink.Size = new System.Drawing.Size(109, 15);
            this.lblActionsFBLink.TabIndex = 0;
            this.lblActionsFBLink.Text = "Facebook post link:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 831);
            this.Controls.Add(this.tctMain);
            this.Name = "MainForm";
            this.Text = "HRng WinForms Frontend";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tctMain.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabActions.ResumeLayout(false);
            this.tabActions.PerformLayout();
            this.gbxActionsSummary.ResumeLayout(false);
            this.gbxActionsSummary.PerformLayout();
            this.gbxActionsEC.ResumeLayout(false);
            this.gbxActionsShares.ResumeLayout(false);
            this.gbxActionsShares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionsMinShares)).EndInit();
            this.gbxActionsMentions.ResumeLayout(false);
            this.gbxActionsMentions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionsMinMentions)).EndInit();
            this.gbxActionsComments.ResumeLayout(false);
            this.gbxActionsComments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionsMinComments)).EndInit();
            this.gbxActionsReactions.ResumeLayout(false);
            this.gbxActionsReactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionsMinReactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tctMain;
        private TabPage tabLogin;
        private Label lblLoginStatus;
        private Label lblLoginStatusTitle;
        private RadioButton rbtLoginCookies;
        private Label lblLoginMethod;
        private RadioButton rbtLoginCreds;
        private Button btnLoginLoadCookiesTxt;
        private TextBox tbxLoginCookiesInput;
        private Label lblLoginPassword;
        private TextBox tbxLoginPassword;
        private TextBox tbxLoginEmail;
        private Label lblLoginEmail;
        private Button btnLogin;
        private Button btnLoginCookiesCopy;
        private Label lblLoginCookiesOutput;
        private TextBox tbxLoginCookiesOutput;
        private TabPage tabActions;
        private Label lblActionsFBLink;
        private GroupBox gbxActionsReactions;
        private CheckBox cbxActionsGetReactions;
        private TextBox tbxActionsFBLink;
        private CheckBox cbxActionsCheckReactions;
        private NumericUpDown numActionsMinReactions;
        private TextBox tbxActionsReactionsDetailsCol;
        private CheckBox cbxActionsReactionsDetails;
        private TextBox tbxActionsReactionsCountCol;
        private GroupBox gbxActionsComments;
        private CheckBox cbxActionsGetComments;
        private CheckBox cbxActionsCheckComments;
        private CheckBox cbxActionsGetReplies;
        private CheckBox cbxActionsCommentsDetails;
        private RadioButton rbtActionsCommentsBothPasses;
        private RadioButton rbtActionsCommentsP2Only;
        private RadioButton rbtActionsCommentsP1Only;
        private Label lblActionsCommentsPasses;
        private GroupBox gbxActionsMentions;
        private CheckBox cbxActionsGetMentions;
        private TextBox tbxActionsCommentTxtCol;
        private NumericUpDown numActionsMinComments;
        private TextBox tbxActionsCommentsCountCol;
        private TextBox tbxActionsMentionsCountCol;
        private CheckBox cbxActionsCheckMentions;
        private NumericUpDown numActionsMinMentions;
        private TextBox tbxActionsMentionedUIDCol;
        private CheckBox cbxActionsMentionsExclude;
        private CheckBox cbxActionsMentionsDetails;
        private GroupBox gbxActionsShares;
        private TextBox tbxActionsSharesCountCol;
        private CheckBox cbxActionsGetShares;
        private CheckBox cbxActionsShareDetails;
        private NumericUpDown numActionsMinShares;
        private CheckBox cbxActionsCheckShares;
        private TextBox tbxActionsSharesDetailsCol;
        private ProgressBar pbrActions;
        private Button btnActionsStart;
        private Label lblActionsStatus;
        private GroupBox gbxActionsEC;
        private Button btnActionsECSave;
        private Button btnActionsECLoad;
        private Button btnActionsECShow;
        private GroupBox gbxActionsSummary;
        private Label lblActionsSummaryTextNo;
        private TextBox tbxActionsSummaryTextNo;
        private TextBox tbxActionsSummaryTextPartial;
        private Label lblActionsSummaryTextPartial;
        private TextBox tbxActionsSummaryTextFull;
        private Label lblActionsSummaryTextFull;
        private Label lblActionsSummaryText;
        private TextBox tbxActionsSummaryCol;
        private CheckBox cbxActionsSummary;
    }
}