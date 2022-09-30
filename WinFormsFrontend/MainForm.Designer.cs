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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.tabUID = new System.Windows.Forms.TabPage();
            this.pbrUID = new System.Windows.Forms.ProgressBar();
            this.btnUIDStart = new System.Windows.Forms.Button();
            this.tbxUIDBatchOutputColName = new System.Windows.Forms.TextBox();
            this.lblUIDBatchOutputColName = new System.Windows.Forms.Label();
            this.lblUIDBatchInputOpts = new System.Windows.Forms.Label();
            this.pnlUIDBatchInputCol = new System.Windows.Forms.Panel();
            this.rbtUIDBatchInputColNum = new System.Windows.Forms.RadioButton();
            this.numUIDBatchInputCol = new System.Windows.Forms.NumericUpDown();
            this.rbtUIDBatchInputColName = new System.Windows.Forms.RadioButton();
            this.tbxUIDBatchInputCol = new System.Windows.Forms.TextBox();
            this.lblUIDBatchInputCol = new System.Windows.Forms.Label();
            this.numUIDBatchInputStartRow = new System.Windows.Forms.NumericUpDown();
            this.lblUIDBatchInputStartRow = new System.Windows.Forms.Label();
            this.btnUIDBatchBrowseInput = new System.Windows.Forms.Button();
            this.tbxUIDBatchInput = new System.Windows.Forms.TextBox();
            this.lblUIDBatchInput = new System.Windows.Forms.Label();
            this.btnUIDSingleCopy = new System.Windows.Forms.Button();
            this.tbxUIDSingleOutput = new System.Windows.Forms.TextBox();
            this.lblUIDSingleOutput = new System.Windows.Forms.Label();
            this.tbxUIDSingleInput = new System.Windows.Forms.TextBox();
            this.lblUIDSingleInput = new System.Windows.Forms.Label();
            this.rbtUIDBatch = new System.Windows.Forms.RadioButton();
            this.rbtUIDSingle = new System.Windows.Forms.RadioButton();
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
            this.tabUID.SuspendLayout();
            this.pnlUIDBatchInputCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUIDBatchInputCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIDBatchInputStartRow)).BeginInit();
            this.SuspendLayout();
            // 
            // tctMain
            // 
            this.tctMain.Controls.Add(this.tabLogin);
            this.tctMain.Controls.Add(this.tabActions);
            this.tctMain.Controls.Add(this.tabUID);
            resources.ApplyResources(this.tctMain, "tctMain");
            this.tctMain.Name = "tctMain";
            this.tctMain.SelectedIndex = 0;
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
            resources.ApplyResources(this.tabLogin, "tabLogin");
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLoginCookiesCopy
            // 
            resources.ApplyResources(this.btnLoginCookiesCopy, "btnLoginCookiesCopy");
            this.btnLoginCookiesCopy.Name = "btnLoginCookiesCopy";
            this.btnLoginCookiesCopy.UseVisualStyleBackColor = true;
            this.btnLoginCookiesCopy.Click += new System.EventHandler(this.btnLoginCookiesCopy_Click);
            // 
            // lblLoginCookiesOutput
            // 
            resources.ApplyResources(this.lblLoginCookiesOutput, "lblLoginCookiesOutput");
            this.lblLoginCookiesOutput.Name = "lblLoginCookiesOutput";
            // 
            // tbxLoginCookiesOutput
            // 
            resources.ApplyResources(this.tbxLoginCookiesOutput, "tbxLoginCookiesOutput");
            this.tbxLoginCookiesOutput.Name = "tbxLoginCookiesOutput";
            this.tbxLoginCookiesOutput.ReadOnly = true;
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginPassword
            // 
            resources.ApplyResources(this.lblLoginPassword, "lblLoginPassword");
            this.lblLoginPassword.Name = "lblLoginPassword";
            // 
            // tbxLoginPassword
            // 
            resources.ApplyResources(this.tbxLoginPassword, "tbxLoginPassword");
            this.tbxLoginPassword.Name = "tbxLoginPassword";
            this.tbxLoginPassword.UseSystemPasswordChar = true;
            this.tbxLoginPassword.TextChanged += new System.EventHandler(this.tbxLoginPassword_TextChanged);
            // 
            // tbxLoginEmail
            // 
            resources.ApplyResources(this.tbxLoginEmail, "tbxLoginEmail");
            this.tbxLoginEmail.Name = "tbxLoginEmail";
            this.tbxLoginEmail.TextChanged += new System.EventHandler(this.tbxLoginEmail_TextChanged);
            // 
            // lblLoginEmail
            // 
            resources.ApplyResources(this.lblLoginEmail, "lblLoginEmail");
            this.lblLoginEmail.Name = "lblLoginEmail";
            // 
            // rbtLoginCreds
            // 
            resources.ApplyResources(this.rbtLoginCreds, "rbtLoginCreds");
            this.rbtLoginCreds.Name = "rbtLoginCreds";
            this.rbtLoginCreds.UseVisualStyleBackColor = true;
            this.rbtLoginCreds.CheckedChanged += new System.EventHandler(this.rbtLoginCreds_CheckedChanged);
            // 
            // btnLoginLoadCookiesTxt
            // 
            resources.ApplyResources(this.btnLoginLoadCookiesTxt, "btnLoginLoadCookiesTxt");
            this.btnLoginLoadCookiesTxt.Name = "btnLoginLoadCookiesTxt";
            this.btnLoginLoadCookiesTxt.UseVisualStyleBackColor = true;
            this.btnLoginLoadCookiesTxt.Click += new System.EventHandler(this.btnLoginLoadCookiesTxt_Click);
            // 
            // tbxLoginCookiesInput
            // 
            resources.ApplyResources(this.tbxLoginCookiesInput, "tbxLoginCookiesInput");
            this.tbxLoginCookiesInput.Name = "tbxLoginCookiesInput";
            this.tbxLoginCookiesInput.TextChanged += new System.EventHandler(this.tbxLoginCookiesInput_TextChanged);
            // 
            // rbtLoginCookies
            // 
            resources.ApplyResources(this.rbtLoginCookies, "rbtLoginCookies");
            this.rbtLoginCookies.Checked = true;
            this.rbtLoginCookies.Name = "rbtLoginCookies";
            this.rbtLoginCookies.TabStop = true;
            this.rbtLoginCookies.UseVisualStyleBackColor = true;
            this.rbtLoginCookies.CheckedChanged += new System.EventHandler(this.rbtLoginCookies_CheckedChanged);
            // 
            // lblLoginMethod
            // 
            resources.ApplyResources(this.lblLoginMethod, "lblLoginMethod");
            this.lblLoginMethod.Name = "lblLoginMethod";
            // 
            // lblLoginStatus
            // 
            resources.ApplyResources(this.lblLoginStatus, "lblLoginStatus");
            this.lblLoginStatus.Name = "lblLoginStatus";
            // 
            // lblLoginStatusTitle
            // 
            resources.ApplyResources(this.lblLoginStatusTitle, "lblLoginStatusTitle");
            this.lblLoginStatusTitle.Name = "lblLoginStatusTitle";
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
            resources.ApplyResources(this.tabActions, "tabActions");
            this.tabActions.Name = "tabActions";
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
            resources.ApplyResources(this.gbxActionsSummary, "gbxActionsSummary");
            this.gbxActionsSummary.Name = "gbxActionsSummary";
            this.gbxActionsSummary.TabStop = false;
            // 
            // lblActionsSummaryTextNo
            // 
            resources.ApplyResources(this.lblActionsSummaryTextNo, "lblActionsSummaryTextNo");
            this.lblActionsSummaryTextNo.Name = "lblActionsSummaryTextNo";
            // 
            // tbxActionsSummaryTextNo
            // 
            resources.ApplyResources(this.tbxActionsSummaryTextNo, "tbxActionsSummaryTextNo");
            this.tbxActionsSummaryTextNo.Name = "tbxActionsSummaryTextNo";
            this.tbxActionsSummaryTextNo.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // tbxActionsSummaryTextPartial
            // 
            resources.ApplyResources(this.tbxActionsSummaryTextPartial, "tbxActionsSummaryTextPartial");
            this.tbxActionsSummaryTextPartial.Name = "tbxActionsSummaryTextPartial";
            this.tbxActionsSummaryTextPartial.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // lblActionsSummaryTextPartial
            // 
            resources.ApplyResources(this.lblActionsSummaryTextPartial, "lblActionsSummaryTextPartial");
            this.lblActionsSummaryTextPartial.Name = "lblActionsSummaryTextPartial";
            // 
            // tbxActionsSummaryTextFull
            // 
            resources.ApplyResources(this.tbxActionsSummaryTextFull, "tbxActionsSummaryTextFull");
            this.tbxActionsSummaryTextFull.Name = "tbxActionsSummaryTextFull";
            this.tbxActionsSummaryTextFull.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // lblActionsSummaryTextFull
            // 
            resources.ApplyResources(this.lblActionsSummaryTextFull, "lblActionsSummaryTextFull");
            this.lblActionsSummaryTextFull.Name = "lblActionsSummaryTextFull";
            // 
            // lblActionsSummaryText
            // 
            resources.ApplyResources(this.lblActionsSummaryText, "lblActionsSummaryText");
            this.lblActionsSummaryText.Name = "lblActionsSummaryText";
            // 
            // tbxActionsSummaryCol
            // 
            resources.ApplyResources(this.tbxActionsSummaryCol, "tbxActionsSummaryCol");
            this.tbxActionsSummaryCol.Name = "tbxActionsSummaryCol";
            this.tbxActionsSummaryCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // cbxActionsSummary
            // 
            resources.ApplyResources(this.cbxActionsSummary, "cbxActionsSummary");
            this.cbxActionsSummary.Checked = true;
            this.cbxActionsSummary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsSummary.Name = "cbxActionsSummary";
            this.cbxActionsSummary.UseVisualStyleBackColor = true;
            this.cbxActionsSummary.CheckedChanged += new System.EventHandler(this.cbxActionsSummary_CheckedChanged);
            // 
            // gbxActionsEC
            // 
            this.gbxActionsEC.Controls.Add(this.btnActionsECShow);
            this.gbxActionsEC.Controls.Add(this.btnActionsECSave);
            this.gbxActionsEC.Controls.Add(this.btnActionsECLoad);
            resources.ApplyResources(this.gbxActionsEC, "gbxActionsEC");
            this.gbxActionsEC.Name = "gbxActionsEC";
            this.gbxActionsEC.TabStop = false;
            // 
            // btnActionsECShow
            // 
            resources.ApplyResources(this.btnActionsECShow, "btnActionsECShow");
            this.btnActionsECShow.Name = "btnActionsECShow";
            this.btnActionsECShow.UseVisualStyleBackColor = true;
            this.btnActionsECShow.Click += new System.EventHandler(this.btnActionsECShow_Click);
            // 
            // btnActionsECSave
            // 
            resources.ApplyResources(this.btnActionsECSave, "btnActionsECSave");
            this.btnActionsECSave.Name = "btnActionsECSave";
            this.btnActionsECSave.UseVisualStyleBackColor = true;
            this.btnActionsECSave.Click += new System.EventHandler(this.btnActionsECSave_Click);
            // 
            // btnActionsECLoad
            // 
            resources.ApplyResources(this.btnActionsECLoad, "btnActionsECLoad");
            this.btnActionsECLoad.Name = "btnActionsECLoad";
            this.btnActionsECLoad.UseVisualStyleBackColor = true;
            this.btnActionsECLoad.Click += new System.EventHandler(this.btnActionsECLoad_Click);
            // 
            // lblActionsStatus
            // 
            resources.ApplyResources(this.lblActionsStatus, "lblActionsStatus");
            this.lblActionsStatus.Name = "lblActionsStatus";
            // 
            // pbrActions
            // 
            resources.ApplyResources(this.pbrActions, "pbrActions");
            this.pbrActions.Maximum = 300;
            this.pbrActions.Name = "pbrActions";
            // 
            // btnActionsStart
            // 
            resources.ApplyResources(this.btnActionsStart, "btnActionsStart");
            this.btnActionsStart.Name = "btnActionsStart";
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
            resources.ApplyResources(this.gbxActionsShares, "gbxActionsShares");
            this.gbxActionsShares.Name = "gbxActionsShares";
            this.gbxActionsShares.TabStop = false;
            // 
            // tbxActionsSharesDetailsCol
            // 
            resources.ApplyResources(this.tbxActionsSharesDetailsCol, "tbxActionsSharesDetailsCol");
            this.tbxActionsSharesDetailsCol.Name = "tbxActionsSharesDetailsCol";
            this.tbxActionsSharesDetailsCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // cbxActionsShareDetails
            // 
            resources.ApplyResources(this.cbxActionsShareDetails, "cbxActionsShareDetails");
            this.cbxActionsShareDetails.Name = "cbxActionsShareDetails";
            this.cbxActionsShareDetails.UseVisualStyleBackColor = true;
            this.cbxActionsShareDetails.CheckedChanged += new System.EventHandler(this.cbxActionsShareDetails_CheckedChanged);
            // 
            // numActionsMinShares
            // 
            resources.ApplyResources(this.numActionsMinShares, "numActionsMinShares");
            this.numActionsMinShares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numActionsMinShares.Name = "numActionsMinShares";
            this.numActionsMinShares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxActionsCheckShares
            // 
            resources.ApplyResources(this.cbxActionsCheckShares, "cbxActionsCheckShares");
            this.cbxActionsCheckShares.Checked = true;
            this.cbxActionsCheckShares.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsCheckShares.Name = "cbxActionsCheckShares";
            this.cbxActionsCheckShares.UseVisualStyleBackColor = true;
            this.cbxActionsCheckShares.CheckedChanged += new System.EventHandler(this.cbxActionsCheckShares_CheckedChanged);
            // 
            // tbxActionsSharesCountCol
            // 
            resources.ApplyResources(this.tbxActionsSharesCountCol, "tbxActionsSharesCountCol");
            this.tbxActionsSharesCountCol.Name = "tbxActionsSharesCountCol";
            this.tbxActionsSharesCountCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // cbxActionsGetShares
            // 
            resources.ApplyResources(this.cbxActionsGetShares, "cbxActionsGetShares");
            this.cbxActionsGetShares.Checked = true;
            this.cbxActionsGetShares.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsGetShares.Name = "cbxActionsGetShares";
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
            resources.ApplyResources(this.gbxActionsMentions, "gbxActionsMentions");
            this.gbxActionsMentions.Name = "gbxActionsMentions";
            this.gbxActionsMentions.TabStop = false;
            // 
            // tbxActionsMentionedUIDCol
            // 
            resources.ApplyResources(this.tbxActionsMentionedUIDCol, "tbxActionsMentionedUIDCol");
            this.tbxActionsMentionedUIDCol.Name = "tbxActionsMentionedUIDCol";
            this.tbxActionsMentionedUIDCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // cbxActionsMentionsExclude
            // 
            resources.ApplyResources(this.cbxActionsMentionsExclude, "cbxActionsMentionsExclude");
            this.cbxActionsMentionsExclude.Checked = true;
            this.cbxActionsMentionsExclude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsMentionsExclude.Name = "cbxActionsMentionsExclude";
            this.cbxActionsMentionsExclude.UseVisualStyleBackColor = true;
            // 
            // cbxActionsMentionsDetails
            // 
            resources.ApplyResources(this.cbxActionsMentionsDetails, "cbxActionsMentionsDetails");
            this.cbxActionsMentionsDetails.Name = "cbxActionsMentionsDetails";
            this.cbxActionsMentionsDetails.UseVisualStyleBackColor = true;
            this.cbxActionsMentionsDetails.CheckedChanged += new System.EventHandler(this.cbxActionsMentionsDetails_CheckedChanged);
            // 
            // numActionsMinMentions
            // 
            resources.ApplyResources(this.numActionsMinMentions, "numActionsMinMentions");
            this.numActionsMinMentions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numActionsMinMentions.Name = "numActionsMinMentions";
            this.numActionsMinMentions.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cbxActionsCheckMentions
            // 
            resources.ApplyResources(this.cbxActionsCheckMentions, "cbxActionsCheckMentions");
            this.cbxActionsCheckMentions.Checked = true;
            this.cbxActionsCheckMentions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsCheckMentions.Name = "cbxActionsCheckMentions";
            this.cbxActionsCheckMentions.UseVisualStyleBackColor = true;
            this.cbxActionsCheckMentions.CheckedChanged += new System.EventHandler(this.cbxActionsCheckMentions_CheckedChanged);
            // 
            // tbxActionsMentionsCountCol
            // 
            resources.ApplyResources(this.tbxActionsMentionsCountCol, "tbxActionsMentionsCountCol");
            this.tbxActionsMentionsCountCol.Name = "tbxActionsMentionsCountCol";
            this.tbxActionsMentionsCountCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // cbxActionsGetMentions
            // 
            resources.ApplyResources(this.cbxActionsGetMentions, "cbxActionsGetMentions");
            this.cbxActionsGetMentions.Name = "cbxActionsGetMentions";
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
            resources.ApplyResources(this.gbxActionsComments, "gbxActionsComments");
            this.gbxActionsComments.Name = "gbxActionsComments";
            this.gbxActionsComments.TabStop = false;
            // 
            // tbxActionsCommentTxtCol
            // 
            resources.ApplyResources(this.tbxActionsCommentTxtCol, "tbxActionsCommentTxtCol");
            this.tbxActionsCommentTxtCol.Name = "tbxActionsCommentTxtCol";
            this.tbxActionsCommentTxtCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // numActionsMinComments
            // 
            resources.ApplyResources(this.numActionsMinComments, "numActionsMinComments");
            this.numActionsMinComments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numActionsMinComments.Name = "numActionsMinComments";
            this.numActionsMinComments.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tbxActionsCommentsCountCol
            // 
            resources.ApplyResources(this.tbxActionsCommentsCountCol, "tbxActionsCommentsCountCol");
            this.tbxActionsCommentsCountCol.Name = "tbxActionsCommentsCountCol";
            this.tbxActionsCommentsCountCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // rbtActionsCommentsBothPasses
            // 
            resources.ApplyResources(this.rbtActionsCommentsBothPasses, "rbtActionsCommentsBothPasses");
            this.rbtActionsCommentsBothPasses.Checked = true;
            this.rbtActionsCommentsBothPasses.Name = "rbtActionsCommentsBothPasses";
            this.rbtActionsCommentsBothPasses.TabStop = true;
            this.rbtActionsCommentsBothPasses.UseVisualStyleBackColor = true;
            // 
            // rbtActionsCommentsP2Only
            // 
            resources.ApplyResources(this.rbtActionsCommentsP2Only, "rbtActionsCommentsP2Only");
            this.rbtActionsCommentsP2Only.Name = "rbtActionsCommentsP2Only";
            this.rbtActionsCommentsP2Only.UseVisualStyleBackColor = true;
            // 
            // rbtActionsCommentsP1Only
            // 
            resources.ApplyResources(this.rbtActionsCommentsP1Only, "rbtActionsCommentsP1Only");
            this.rbtActionsCommentsP1Only.Name = "rbtActionsCommentsP1Only";
            this.rbtActionsCommentsP1Only.UseVisualStyleBackColor = true;
            // 
            // lblActionsCommentsPasses
            // 
            resources.ApplyResources(this.lblActionsCommentsPasses, "lblActionsCommentsPasses");
            this.lblActionsCommentsPasses.Name = "lblActionsCommentsPasses";
            // 
            // cbxActionsGetReplies
            // 
            resources.ApplyResources(this.cbxActionsGetReplies, "cbxActionsGetReplies");
            this.cbxActionsGetReplies.Name = "cbxActionsGetReplies";
            this.cbxActionsGetReplies.UseVisualStyleBackColor = true;
            // 
            // cbxActionsCommentsDetails
            // 
            resources.ApplyResources(this.cbxActionsCommentsDetails, "cbxActionsCommentsDetails");
            this.cbxActionsCommentsDetails.Name = "cbxActionsCommentsDetails";
            this.cbxActionsCommentsDetails.UseVisualStyleBackColor = true;
            this.cbxActionsCommentsDetails.CheckedChanged += new System.EventHandler(this.cbxActionsCommentsDetails_CheckedChanged);
            // 
            // cbxActionsCheckComments
            // 
            resources.ApplyResources(this.cbxActionsCheckComments, "cbxActionsCheckComments");
            this.cbxActionsCheckComments.Checked = true;
            this.cbxActionsCheckComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsCheckComments.Name = "cbxActionsCheckComments";
            this.cbxActionsCheckComments.UseVisualStyleBackColor = true;
            this.cbxActionsCheckComments.CheckedChanged += new System.EventHandler(this.cbxActionsCheckComments_CheckedChanged);
            // 
            // cbxActionsGetComments
            // 
            resources.ApplyResources(this.cbxActionsGetComments, "cbxActionsGetComments");
            this.cbxActionsGetComments.Checked = true;
            this.cbxActionsGetComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsGetComments.Name = "cbxActionsGetComments";
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
            resources.ApplyResources(this.gbxActionsReactions, "gbxActionsReactions");
            this.gbxActionsReactions.Name = "gbxActionsReactions";
            this.gbxActionsReactions.TabStop = false;
            // 
            // tbxActionsReactionsDetailsCol
            // 
            resources.ApplyResources(this.tbxActionsReactionsDetailsCol, "tbxActionsReactionsDetailsCol");
            this.tbxActionsReactionsDetailsCol.Name = "tbxActionsReactionsDetailsCol";
            this.tbxActionsReactionsDetailsCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // cbxActionsReactionsDetails
            // 
            resources.ApplyResources(this.cbxActionsReactionsDetails, "cbxActionsReactionsDetails");
            this.cbxActionsReactionsDetails.Name = "cbxActionsReactionsDetails";
            this.cbxActionsReactionsDetails.UseVisualStyleBackColor = true;
            this.cbxActionsReactionsDetails.CheckedChanged += new System.EventHandler(this.cbxActionsReactionsDetails_CheckedChanged);
            // 
            // tbxActionsReactionsCountCol
            // 
            resources.ApplyResources(this.tbxActionsReactionsCountCol, "tbxActionsReactionsCountCol");
            this.tbxActionsReactionsCountCol.Name = "tbxActionsReactionsCountCol";
            this.tbxActionsReactionsCountCol.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // numActionsMinReactions
            // 
            resources.ApplyResources(this.numActionsMinReactions, "numActionsMinReactions");
            this.numActionsMinReactions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numActionsMinReactions.Name = "numActionsMinReactions";
            this.numActionsMinReactions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxActionsCheckReactions
            // 
            resources.ApplyResources(this.cbxActionsCheckReactions, "cbxActionsCheckReactions");
            this.cbxActionsCheckReactions.Checked = true;
            this.cbxActionsCheckReactions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsCheckReactions.Name = "cbxActionsCheckReactions";
            this.cbxActionsCheckReactions.UseVisualStyleBackColor = true;
            this.cbxActionsCheckReactions.CheckedChanged += new System.EventHandler(this.cbxActionsCheckReactions_CheckedChanged);
            // 
            // cbxActionsGetReactions
            // 
            resources.ApplyResources(this.cbxActionsGetReactions, "cbxActionsGetReactions");
            this.cbxActionsGetReactions.Checked = true;
            this.cbxActionsGetReactions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActionsGetReactions.Name = "cbxActionsGetReactions";
            this.cbxActionsGetReactions.UseVisualStyleBackColor = true;
            this.cbxActionsGetReactions.CheckedChanged += new System.EventHandler(this.cbxActionsGetReactions_CheckedChanged);
            // 
            // tbxActionsFBLink
            // 
            resources.ApplyResources(this.tbxActionsFBLink, "tbxActionsFBLink");
            this.tbxActionsFBLink.Name = "tbxActionsFBLink";
            this.tbxActionsFBLink.TextChanged += new System.EventHandler(this.ValidateActionsStartButton);
            // 
            // lblActionsFBLink
            // 
            resources.ApplyResources(this.lblActionsFBLink, "lblActionsFBLink");
            this.lblActionsFBLink.Name = "lblActionsFBLink";
            // 
            // tabUID
            // 
            this.tabUID.Controls.Add(this.pbrUID);
            this.tabUID.Controls.Add(this.btnUIDStart);
            this.tabUID.Controls.Add(this.tbxUIDBatchOutputColName);
            this.tabUID.Controls.Add(this.lblUIDBatchOutputColName);
            this.tabUID.Controls.Add(this.lblUIDBatchInputOpts);
            this.tabUID.Controls.Add(this.pnlUIDBatchInputCol);
            this.tabUID.Controls.Add(this.lblUIDBatchInputCol);
            this.tabUID.Controls.Add(this.numUIDBatchInputStartRow);
            this.tabUID.Controls.Add(this.lblUIDBatchInputStartRow);
            this.tabUID.Controls.Add(this.btnUIDBatchBrowseInput);
            this.tabUID.Controls.Add(this.tbxUIDBatchInput);
            this.tabUID.Controls.Add(this.lblUIDBatchInput);
            this.tabUID.Controls.Add(this.btnUIDSingleCopy);
            this.tabUID.Controls.Add(this.tbxUIDSingleOutput);
            this.tabUID.Controls.Add(this.lblUIDSingleOutput);
            this.tabUID.Controls.Add(this.tbxUIDSingleInput);
            this.tabUID.Controls.Add(this.lblUIDSingleInput);
            this.tabUID.Controls.Add(this.rbtUIDBatch);
            this.tabUID.Controls.Add(this.rbtUIDSingle);
            resources.ApplyResources(this.tabUID, "tabUID");
            this.tabUID.Name = "tabUID";
            this.tabUID.UseVisualStyleBackColor = true;
            // 
            // pbrUID
            // 
            resources.ApplyResources(this.pbrUID, "pbrUID");
            this.pbrUID.Name = "pbrUID";
            // 
            // btnUIDStart
            // 
            resources.ApplyResources(this.btnUIDStart, "btnUIDStart");
            this.btnUIDStart.Name = "btnUIDStart";
            this.btnUIDStart.UseVisualStyleBackColor = true;
            this.btnUIDStart.Click += new System.EventHandler(this.btnUIDStart_Click);
            // 
            // tbxUIDBatchOutputColName
            // 
            resources.ApplyResources(this.tbxUIDBatchOutputColName, "tbxUIDBatchOutputColName");
            this.tbxUIDBatchOutputColName.Name = "tbxUIDBatchOutputColName";
            this.tbxUIDBatchOutputColName.TextChanged += new System.EventHandler(this.ValidateUIDStartButton);
            // 
            // lblUIDBatchOutputColName
            // 
            resources.ApplyResources(this.lblUIDBatchOutputColName, "lblUIDBatchOutputColName");
            this.lblUIDBatchOutputColName.Name = "lblUIDBatchOutputColName";
            // 
            // lblUIDBatchInputOpts
            // 
            resources.ApplyResources(this.lblUIDBatchInputOpts, "lblUIDBatchInputOpts");
            this.lblUIDBatchInputOpts.Name = "lblUIDBatchInputOpts";
            // 
            // pnlUIDBatchInputCol
            // 
            this.pnlUIDBatchInputCol.Controls.Add(this.rbtUIDBatchInputColNum);
            this.pnlUIDBatchInputCol.Controls.Add(this.numUIDBatchInputCol);
            this.pnlUIDBatchInputCol.Controls.Add(this.rbtUIDBatchInputColName);
            this.pnlUIDBatchInputCol.Controls.Add(this.tbxUIDBatchInputCol);
            resources.ApplyResources(this.pnlUIDBatchInputCol, "pnlUIDBatchInputCol");
            this.pnlUIDBatchInputCol.Name = "pnlUIDBatchInputCol";
            // 
            // rbtUIDBatchInputColNum
            // 
            resources.ApplyResources(this.rbtUIDBatchInputColNum, "rbtUIDBatchInputColNum");
            this.rbtUIDBatchInputColNum.Name = "rbtUIDBatchInputColNum";
            this.rbtUIDBatchInputColNum.TabStop = true;
            this.rbtUIDBatchInputColNum.UseVisualStyleBackColor = true;
            this.rbtUIDBatchInputColNum.CheckedChanged += new System.EventHandler(this.rbtUIDBatchInputColNum_CheckedChanged);
            // 
            // numUIDBatchInputCol
            // 
            resources.ApplyResources(this.numUIDBatchInputCol, "numUIDBatchInputCol");
            this.numUIDBatchInputCol.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.numUIDBatchInputCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUIDBatchInputCol.Name = "numUIDBatchInputCol";
            this.numUIDBatchInputCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtUIDBatchInputColName
            // 
            resources.ApplyResources(this.rbtUIDBatchInputColName, "rbtUIDBatchInputColName");
            this.rbtUIDBatchInputColName.Checked = true;
            this.rbtUIDBatchInputColName.Name = "rbtUIDBatchInputColName";
            this.rbtUIDBatchInputColName.TabStop = true;
            this.rbtUIDBatchInputColName.UseVisualStyleBackColor = true;
            this.rbtUIDBatchInputColName.CheckedChanged += new System.EventHandler(this.rbtUIDBatchInputColName_CheckedChanged);
            // 
            // tbxUIDBatchInputCol
            // 
            resources.ApplyResources(this.tbxUIDBatchInputCol, "tbxUIDBatchInputCol");
            this.tbxUIDBatchInputCol.Name = "tbxUIDBatchInputCol";
            this.tbxUIDBatchInputCol.TextChanged += new System.EventHandler(this.ValidateUIDStartButton);
            // 
            // lblUIDBatchInputCol
            // 
            resources.ApplyResources(this.lblUIDBatchInputCol, "lblUIDBatchInputCol");
            this.lblUIDBatchInputCol.Name = "lblUIDBatchInputCol";
            // 
            // numUIDBatchInputStartRow
            // 
            resources.ApplyResources(this.numUIDBatchInputStartRow, "numUIDBatchInputStartRow");
            this.numUIDBatchInputStartRow.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.numUIDBatchInputStartRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUIDBatchInputStartRow.Name = "numUIDBatchInputStartRow";
            this.numUIDBatchInputStartRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUIDBatchInputStartRow
            // 
            resources.ApplyResources(this.lblUIDBatchInputStartRow, "lblUIDBatchInputStartRow");
            this.lblUIDBatchInputStartRow.Name = "lblUIDBatchInputStartRow";
            // 
            // btnUIDBatchBrowseInput
            // 
            resources.ApplyResources(this.btnUIDBatchBrowseInput, "btnUIDBatchBrowseInput");
            this.btnUIDBatchBrowseInput.Name = "btnUIDBatchBrowseInput";
            this.btnUIDBatchBrowseInput.UseVisualStyleBackColor = true;
            this.btnUIDBatchBrowseInput.Click += new System.EventHandler(this.btnUIDBatchBrowseInput_Click);
            // 
            // tbxUIDBatchInput
            // 
            resources.ApplyResources(this.tbxUIDBatchInput, "tbxUIDBatchInput");
            this.tbxUIDBatchInput.Name = "tbxUIDBatchInput";
            this.tbxUIDBatchInput.ReadOnly = true;
            // 
            // lblUIDBatchInput
            // 
            resources.ApplyResources(this.lblUIDBatchInput, "lblUIDBatchInput");
            this.lblUIDBatchInput.Name = "lblUIDBatchInput";
            // 
            // btnUIDSingleCopy
            // 
            resources.ApplyResources(this.btnUIDSingleCopy, "btnUIDSingleCopy");
            this.btnUIDSingleCopy.Name = "btnUIDSingleCopy";
            this.btnUIDSingleCopy.UseVisualStyleBackColor = true;
            this.btnUIDSingleCopy.Click += new System.EventHandler(this.btnUIDSingleCopy_Click);
            // 
            // tbxUIDSingleOutput
            // 
            resources.ApplyResources(this.tbxUIDSingleOutput, "tbxUIDSingleOutput");
            this.tbxUIDSingleOutput.Name = "tbxUIDSingleOutput";
            this.tbxUIDSingleOutput.ReadOnly = true;
            // 
            // lblUIDSingleOutput
            // 
            resources.ApplyResources(this.lblUIDSingleOutput, "lblUIDSingleOutput");
            this.lblUIDSingleOutput.ForeColor = System.Drawing.Color.Green;
            this.lblUIDSingleOutput.Name = "lblUIDSingleOutput";
            // 
            // tbxUIDSingleInput
            // 
            resources.ApplyResources(this.tbxUIDSingleInput, "tbxUIDSingleInput");
            this.tbxUIDSingleInput.Name = "tbxUIDSingleInput";
            this.tbxUIDSingleInput.TextChanged += new System.EventHandler(this.ValidateUIDStartButton);
            // 
            // lblUIDSingleInput
            // 
            resources.ApplyResources(this.lblUIDSingleInput, "lblUIDSingleInput");
            this.lblUIDSingleInput.Name = "lblUIDSingleInput";
            // 
            // rbtUIDBatch
            // 
            resources.ApplyResources(this.rbtUIDBatch, "rbtUIDBatch");
            this.rbtUIDBatch.Name = "rbtUIDBatch";
            this.rbtUIDBatch.UseVisualStyleBackColor = true;
            this.rbtUIDBatch.CheckedChanged += new System.EventHandler(this.rbtUIDBatch_CheckedChanged);
            // 
            // rbtUIDSingle
            // 
            resources.ApplyResources(this.rbtUIDSingle, "rbtUIDSingle");
            this.rbtUIDSingle.Checked = true;
            this.rbtUIDSingle.Name = "rbtUIDSingle";
            this.rbtUIDSingle.TabStop = true;
            this.rbtUIDSingle.UseVisualStyleBackColor = true;
            this.rbtUIDSingle.CheckedChanged += new System.EventHandler(this.rbtUIDSingle_CheckedChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tctMain);
            this.Name = "MainForm";
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
            this.tabUID.ResumeLayout(false);
            this.tabUID.PerformLayout();
            this.pnlUIDBatchInputCol.ResumeLayout(false);
            this.pnlUIDBatchInputCol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUIDBatchInputCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUIDBatchInputStartRow)).EndInit();
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
        private TabPage tabUID;
        private RadioButton rbtUIDBatch;
        private RadioButton rbtUIDSingle;
        private Label lblUIDSingleOutput;
        private TextBox tbxUIDSingleInput;
        private Label lblUIDSingleInput;
        private Button btnUIDBatchBrowseInput;
        private TextBox tbxUIDBatchInput;
        private Label lblUIDBatchInput;
        private Button btnUIDSingleCopy;
        private TextBox tbxUIDSingleOutput;
        private Panel pnlUIDBatchInputCol;
        public RadioButton rbtUIDBatchInputColNum;
        public NumericUpDown numUIDBatchInputCol;
        public RadioButton rbtUIDBatchInputColName;
        public TextBox tbxUIDBatchInputCol;
        private Label lblUIDBatchInputCol;
        public NumericUpDown numUIDBatchInputStartRow;
        private Label lblUIDBatchInputStartRow;
        private Label lblUIDBatchInputOpts;
        private Label lblUIDBatchOutputColName;
        private TextBox tbxUIDBatchOutputColName;
        private ProgressBar pbrUID;
        private Button btnUIDStart;
    }
}