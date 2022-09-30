using HRngBackend;
using HRngSelenium;
using OpenQA.Selenium.Interactions;
using static System.Windows.Forms.AxHost;

namespace WinFormsFrontend
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rbtLoginCookies_CheckedChanged(object sender, EventArgs e)
        {
            tbxLoginCookiesInput.Enabled = btnLoginLoadCookiesTxt.Enabled = rbtLoginCookies.Checked;
            if (rbtLoginCookies.Checked && tbxLoginCookiesInput.Text.Trim().Length == 0) btnLogin.Enabled = false;
        }

        private void rbtLoginCreds_CheckedChanged(object sender, EventArgs e)
        {
            tbxLoginEmail.Enabled = tbxLoginPassword.Enabled = rbtLoginCreds.Checked;
            if (rbtLoginCreds.Checked && (tbxLoginEmail.Text.Trim().Length == 0 || tbxLoginPassword.Text.Trim().Length == 0)) btnLogin.Enabled = false;
        }

        private void tbxLoginCookiesInput_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = (tbxLoginCookiesInput.Text.Trim().Length != 0);
        }

        private void tbxLoginEmail_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = (tbxLoginEmail.Text.Trim().Length != 0 && tbxLoginPassword.Text.Length != 0);
        }

        private void tbxLoginPassword_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = (tbxLoginEmail.Text.Trim().Length != 0 && tbxLoginPassword.Text.Length != 0);
        }

        private void btnLoginCookiesCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbxLoginCookiesOutput.Text);
        }

        private void btnLoginLoadCookiesTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_cookies = new OpenFileDialog
            {
                Title = Properties.Resources.DlgOpenCookiesTxt,

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = $"{Properties.Resources.StrTextFiles}|*.txt|{Properties.Resources.StrAllFiles}|*.*",
                FilterIndex = 0,

                RestoreDirectory = true
            };

            if (open_cookies.ShowDialog() == DialogResult.OK)
            {
                tbxLoginCookiesInput.Text = Cookies.ToKVPString(cookies: Cookies.FromTxt_File(open_cookies.FileName));
                btnLogin.Enabled = (tbxLoginCookiesInput.Text.Length != 0);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblLoginStatus.Text = Properties.Resources.StrNotLoggedIn;
            lblLoginStatus.ForeColor = Color.Red;

            lblActionsStatus.Text = Properties.Resources.StaActionsReady;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            ((Control)tabLogin).Enabled = false;

            GlobalData.FBLoggedIn = false;
            lblLoginStatus.Text = Properties.Resources.StrNotLoggedIn;
            lblLoginStatus.ForeColor = Color.Red;

            Dictionary<string, string> cookies = new Dictionary<string, string>();
            if (rbtLoginCookies.Checked)
            {
                /* Log in using cookies */
                cookies = Cookies.FromKVPString(tbxLoginCookiesInput.Text.Trim());
                CommonHTTP.AddCookies("facebook.com", cookies);
                if (GlobalData.SeDriver != null) SeCookies.LoadCookies(GlobalData.SeDriver, cookies, "https://m.facebook.com");
            }
            else
            {
                /* Log in using credentials */

                /* Log out by clearing cookies */
                if (GlobalData.SeDriver != null) SeCookies.ClearCookies(GlobalData.SeDriver, "https://m.facebook.com");
                CommonHTTP.ClearCookies("facebook.com");

                int ret = 0;
                if (GlobalData.SeDriver != null) ret = HRngSelenium.FBLogin.Login(GlobalData.SeDriver, tbxLoginEmail.Text, tbxLoginPassword.Text, cookies);
                else ret = await HRngLite.FBLogin.Login(tbxLoginEmail.Text, tbxLoginPassword.Text, cookies);
                if (ret != 0)
                {
                    if (ret == -3)
                    {
                        while (true)
                        {
                            OTPLoginForm otp_form = new OTPLoginForm();
                            DialogResult dlg_ret = otp_form.ShowDialog();
                            if (dlg_ret == DialogResult.Cancel)
                            {
                                MessageBox.Show(String.Format(Properties.Resources.MsgLoginFail_Body, Properties.Resources.StrOTPRefused), Properties.Resources.MsgLoginFail_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ((Control)tabLogin).Enabled = false;
                                return;
                            }
                            if (GlobalData.SeDriver != null) ret = HRngSelenium.FBLogin.LoginOTP(GlobalData.SeDriver, otp_form.tbxLoginOTP.Text, cookies);
                            else ret = await HRngLite.FBLogin.LoginOTP(otp_form.tbxLoginOTP.Text, cookies);
                            if (ret == 0 || ret == -1) break;
                            if (ret == -4)
                            {
                                MessageBox.Show(Properties.Resources.MsgLoginWrongOTP_Body, Properties.Resources.MsgLoginWrongOTP_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                continue;
                            }
                            else
                            {
                                MessageBox.Show(String.Format(Properties.Resources.MsgLoginFail_Body, String.Format(Properties.Resources.StrFuncReturnVal, "FBLogin.LoginOTP", ret)), Properties.Resources.MsgLoginFail_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ((Control)tabLogin).Enabled = true;
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(String.Format(Properties.Resources.MsgLoginFail_Body, String.Format(Properties.Resources.StrFuncReturnVal, "FBLogin.Login", ret)), Properties.Resources.MsgLoginFail_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ((Control)tabLogin).Enabled = true;
                        return;
                    }
                }
            }

            bool login_verify = true;
            if (GlobalData.SeDriver != null) login_verify = HRngSelenium.FBLogin.VerifyLogin(GlobalData.SeDriver);
            else login_verify = await HRngLite.FBLogin.VerifyLogin();
            
            GlobalData.FBLoggedIn = login_verify;
            ((Control)tabLogin).Enabled = true;

            if (login_verify)
            {
                lblLoginStatus.Text = String.Format(Properties.Resources.StrLoggedInUID, HRngLite.FBLogin.GetUID(cookies));
                lblLoginStatus.ForeColor = Color.Green;
                tbxLoginCookiesOutput.Text = Cookies.ToKVPString(cookies);
                btnLoginCookiesCopy.Enabled = true;
                MessageBox.Show(Properties.Resources.MsgLoginSuccess_Body, Properties.Resources.MsgLoginSuccess_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show(String.Format(Properties.Resources.MsgLoginFail_Body, String.Format(Properties.Resources.StrFuncReturnVal, "FBLogin.VerifyLogin", login_verify)), Properties.Resources.MsgLoginFail_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            ValidateStartButton(sender, e);
        }

        private void ValidateStartButton(object sender, EventArgs e)
        {
            btnActionsStart.Enabled = (GlobalData.FBLoggedIn
                && (tbxActionsFBLink.Text.Trim().Length != 0)
                && (GlobalData.EC != null)
                && (cbxActionsGetReactions.Checked || cbxActionsGetComments.Checked || cbxActionsGetShares.Checked)
                && (!cbxActionsGetReactions.Checked || (tbxActionsReactionsCountCol.Text.Trim().Length != 0 && (!cbxActionsReactionsDetails.Checked || tbxActionsReactionsDetailsCol.Text.Trim().Length != 0)))
                && (!cbxActionsGetComments.Checked || (tbxActionsCommentsCountCol.Text.Trim().Length != 0 && (!cbxActionsCommentsDetails.Checked || tbxActionsCommentTxtCol.Text.Trim().Length != 0)
                && (!gbxActionsMentions.Enabled || !cbxActionsGetMentions.Checked || (tbxActionsMentionsCountCol.Text.Trim().Length != 0 && (!cbxActionsMentionsDetails.Checked || tbxActionsMentionedUIDCol.Text.Trim().Length != 0)))))
                && (!cbxActionsGetShares.Checked || (tbxActionsSharesCountCol.Text.Trim().Length != 0 && (!cbxActionsShareDetails.Checked || tbxActionsSharesDetailsCol.Text.Trim().Length != 0)))
                && (!gbxActionsSummary.Enabled || !cbxActionsSummary.Checked || (tbxActionsSummaryTextFull.Text.Trim().Length != 0 && tbxActionsSummaryTextPartial.Text.Trim().Length != 0 && tbxActionsSummaryTextNo.Text.Trim().Length != 0)));
        }

        private void ValidateSummary()
        {
            gbxActionsSummary.Enabled = ((cbxActionsCheckReactions.Enabled && cbxActionsCheckReactions.Checked)
                || (cbxActionsCheckComments.Enabled && cbxActionsCheckComments.Checked)
                || (cbxActionsCheckShares.Enabled && cbxActionsCheckShares.Checked));
        }

        private void cbxActionsGetReactions_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxActionsGetReactions.Checked) tbxActionsReactionsCountCol.Enabled = tbxActionsReactionsDetailsCol.Enabled = cbxActionsCheckReactions.Enabled = cbxActionsReactionsDetails.Enabled = numActionsMinReactions.Enabled = false;
            else
            {
                tbxActionsReactionsCountCol.Enabled = cbxActionsCheckReactions.Enabled = cbxActionsReactionsDetails.Enabled = true;
                if (cbxActionsCheckReactions.Checked) numActionsMinReactions.Enabled = true;
                if (cbxActionsReactionsDetails.Checked) tbxActionsReactionsDetailsCol.Enabled = true;
            }
            ValidateSummary();
        }

        private void cbxActionsCheckReactions_CheckedChanged(object sender, EventArgs e)
        {
            numActionsMinReactions.Enabled = cbxActionsCheckReactions.Checked;
            ValidateSummary();
        }

        private void cbxActionsReactionsDetails_CheckedChanged(object sender, EventArgs e)
        {
            tbxActionsReactionsDetailsCol.Enabled = cbxActionsReactionsDetails.Checked;
        }

        private void cbxActionsGetComments_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxActionsGetComments.Checked) tbxActionsCommentsCountCol.Enabled = tbxActionsCommentTxtCol.Enabled = cbxActionsCheckComments.Enabled = cbxActionsCommentsDetails.Enabled = cbxActionsGetReplies.Enabled = numActionsMinComments.Enabled = rbtActionsCommentsP1Only.Enabled = rbtActionsCommentsP2Only.Enabled = rbtActionsCommentsBothPasses.Enabled = gbxActionsMentions.Enabled = false;
            else
            {
                tbxActionsCommentsCountCol.Enabled = cbxActionsCheckComments.Enabled = cbxActionsCommentsDetails.Enabled = cbxActionsGetReplies.Enabled = rbtActionsCommentsP1Only.Enabled = rbtActionsCommentsP2Only.Enabled = rbtActionsCommentsBothPasses.Enabled = gbxActionsMentions.Enabled = true;
                if (cbxActionsCheckComments.Checked) numActionsMinComments.Enabled = true;
                if (cbxActionsCommentsDetails.Checked) tbxActionsCommentTxtCol.Enabled = true;
            }
            ValidateSummary();
        }

        private void cbxActionsGetMentions_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxActionsGetMentions.Checked) tbxActionsMentionsCountCol.Enabled = tbxActionsMentionedUIDCol.Enabled = cbxActionsCheckMentions.Enabled = cbxActionsMentionsDetails.Enabled = cbxActionsMentionsExclude.Enabled = numActionsMinMentions.Enabled = false;
            else
            {
                tbxActionsMentionsCountCol.Enabled = cbxActionsCheckMentions.Enabled = cbxActionsMentionsDetails.Enabled = cbxActionsMentionsExclude.Enabled = true;
                if (cbxActionsCheckMentions.Checked) numActionsMinMentions.Enabled = true;
                if (cbxActionsMentionsDetails.Checked) tbxActionsMentionedUIDCol.Enabled = true;
            }
        }

        private void cbxActionsCheckComments_CheckedChanged(object sender, EventArgs e)
        {
            numActionsMinComments.Enabled = cbxActionsCheckComments.Checked;
            ValidateSummary();
        }

        private void cbxActionsCommentsDetails_CheckedChanged(object sender, EventArgs e)
        {
            tbxActionsCommentTxtCol.Enabled = cbxActionsCommentsDetails.Checked;
        }

        private void cbxActionsCheckMentions_CheckedChanged(object sender, EventArgs e)
        {
            numActionsMinMentions.Enabled = cbxActionsCheckMentions.Checked;
        }

        private void cbxActionsMentionsDetails_CheckedChanged(object sender, EventArgs e)
        {
            tbxActionsMentionedUIDCol.Enabled = cbxActionsMentionsDetails.Checked;
        }

        private void cbxActionsGetShares_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxActionsGetShares.Checked) tbxActionsSharesCountCol.Enabled = tbxActionsSharesDetailsCol.Enabled = cbxActionsCheckShares.Enabled = cbxActionsShareDetails.Enabled = numActionsMinShares.Enabled = false;
            else
            {
                tbxActionsSharesCountCol.Enabled = cbxActionsCheckShares.Enabled = cbxActionsShareDetails.Enabled = true;
                if (cbxActionsCheckShares.Checked) numActionsMinShares.Enabled = true;
                if (cbxActionsShareDetails.Checked) tbxActionsSharesDetailsCol.Enabled = true;
            }
            ValidateSummary();
        }

        private void cbxActionsCheckShares_CheckedChanged(object sender, EventArgs e)
        {
            numActionsMinShares.Enabled = cbxActionsCheckShares.Checked;
            ValidateSummary();
        }

        private void cbxActionsShareDetails_CheckedChanged(object sender, EventArgs e)
        {
            tbxActionsSharesDetailsCol.Enabled = cbxActionsShareDetails.Checked;
        }

        private void btnActionsECLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_ec = new OpenFileDialog
            {
                Title = Properties.Resources.DlgOpenEC,

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = $"{Properties.Resources.StrExcelWorkbook}|*.xlsx;*.xls|{Properties.Resources.StrCSVSpreadsheet}|*.csv",
                FilterIndex = 0,

                RestoreDirectory = true
            };

            if (open_ec.ShowDialog() == DialogResult.OK)
            {
                Spreadsheet sheet = null;
                if (Path.GetExtension(open_ec.FileName).ToLower().StartsWith(".xls"))
                {
                    /* Excel file */
                    ExcelImportForm imp_form = new ExcelImportForm();
                    var sheets = ExcelWorkbook.FromFile(open_ec.FileName);
                    foreach (var s in sheets) imp_form.cbxExcelSheet.Items.Add(s.Key);
                    imp_form.cbxExcelSheet.SelectedIndex = 0;
                    if (imp_form.ShowDialog() == DialogResult.OK)
                    {
                        sheet = sheets[imp_form.cbxExcelSheet.SelectedIndex].Value;
                    }
                }
                else
                {
                    /* CSV file */
                    CSVImportForm imp_form = new CSVImportForm();
                    if (imp_form.ShowDialog() == DialogResult.OK)
                    {
                        sheet = CSV.FromFile(open_ec.FileName, bom: imp_form.rbtCSVBOMYes.Checked, delimiter: imp_form.tbxCSVDelim.Text[0], escape: imp_form.tbxCSVEscape.Text[0]);
                    }
                }

                if (sheet != null)
                {
                    ECImportForm imp_form = new ECImportForm();
                    if (imp_form.ShowDialog() == DialogResult.OK)
                    {
                        GlobalData.EC = new EntryCollection();
                        GlobalData.EC.FromSpreadsheet(sheet, (int)imp_form.numECStartRow.Value - 1, imp_form.tbxECUIDCol.Text, ((imp_form.rbtECUIDColNum.Checked) ? ((int)imp_form.numECUIDCol.Value - 1) : -1), ((imp_form.rbtECUIDDelimCustom.Checked) ? imp_form.rbtECUIDDelimCustom.Text : null));
                    }
                    btnActionsECShow.Enabled = btnActionsECSave.Enabled = true;
                    ValidateStartButton(sender, e);
                    MessageBox.Show(Properties.Resources.MsgActionsECImportSuccess_Body, Properties.Resources.MsgActionsECImportSuccess_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnActionsECShow_Click(object sender, EventArgs e)
        {

        }

        private void btnActionsECSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_ec = new SaveFileDialog
            {
                Title = Properties.Resources.DlgSaveEC,

                DefaultExt = "xlsx",
                Filter = $"{Properties.Resources.StrCSVSpreadsheet}|*.csv",
                FilterIndex = 0,

                RestoreDirectory = true
            };

            if (save_ec.ShowDialog() == DialogResult.OK)
            {
                CSV.ToFile(GlobalData.EC.ToSpreadsheet(), save_ec.FileName);
                MessageBox.Show(Properties.Resources.MsgActionsECExportSuccess_Body, Properties.Resources.MsgActionsECExportSuccess_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int AddECColumn(TextBox tbx)
        {
            return (tbx.Enabled) ? GlobalData.EC.AddColumn(tbx.Text.Trim()) : -1;
        }

        /* Callback functions for 1st, 2nd and 3rd steps */
        private bool PostCB1(float perc)
        {
            pbrActions.Value = 0 + (int)perc;
            return true;
        }

        private bool PostCB2(float perc)
        {
            pbrActions.Value = 100 + (int)perc;
            return true;
        }

        private bool PostCB3(float perc)
        {
            pbrActions.Value = 200 + (int)perc;
            return true;
        }

        private async void btnActionsStart_Click(object sender, EventArgs e)
        {
            Func<float, bool>[] cb_funcs = { PostCB1, PostCB2, PostCB3 };

            lblActionsStatus.Text = Properties.Resources.StaActionsAddECColumns;
            int col_react_count = AddECColumn(tbxActionsReactionsCountCol);
            int col_react_details = AddECColumn(tbxActionsReactionsDetailsCol);
            int col_comment_count = AddECColumn(tbxActionsCommentsCountCol);
            int col_comment_text = AddECColumn(tbxActionsCommentTxtCol);
            int col_mention_count = (gbxActionsMentions.Enabled) ? AddECColumn(tbxActionsMentionsCountCol) : -1;
            int col_mention_uid = (gbxActionsMentions.Enabled) ? AddECColumn(tbxActionsMentionedUIDCol) : -1;
            int col_share_count = AddECColumn(tbxActionsSharesCountCol);
            int col_share_details = AddECColumn(tbxActionsSharesDetailsCol);
            int col_summary = AddECColumn(tbxActionsSummaryCol);

            ((Control)tabActions).Enabled = false;

            /* Count number of steps needed to run */
            int steps = 0;
            if (col_react_count != -1) steps++;
            if (col_comment_count != -1) steps++;
            if (col_share_count != -1) steps++;
            pbrActions.Maximum = steps * 100;
            int step_cnt = 0;

            lblActionsStatus.Text = Properties.Resources.StaActionsGetLut;
            await FBReactUtil.GetLut();

            lblActionsStatus.Text = Properties.Resources.StaActionsLoadPost;
            IFBPost post = (GlobalData.SeDriver != null) ? new HRngSelenium.FBPost(GlobalData.SeDriver) : new HRngLite.FBPost();
            await post.Initialize(tbxActionsFBLink.Text.Trim());

            if (col_react_count != -1)
            {
                lblActionsStatus.Text = Properties.Resources.StaActionsGetReactions;
                var reactions = await post.GetReactions(cb_funcs[step_cnt++]);
                if (reactions == null)
                {
                    ((Control)tabActions).Enabled = true;
                    MessageBox.Show(Properties.Resources.MsgActionsCancelled_Body, Properties.Resources.MsgActionsCancelled_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto finalize;
                }
                GlobalData.EC.CountReactions(reactions.Values.ToList(), col_react_count, col_react_details);
            }

            if (col_comment_count != -1)
            {
                lblActionsStatus.Text = (col_mention_count == -1) ? Properties.Resources.StaActionsGetComments : Properties.Resources.StaActionsGetCommentsMentions;
                var comments = await post.GetComments(cb_funcs[step_cnt++], p1: (rbtActionsCommentsBothPasses.Checked || rbtActionsCommentsP1Only.Checked), p2: (rbtActionsCommentsBothPasses.Checked || rbtActionsCommentsP2Only.Checked));
                if (comments == null)
                {
                    ((Control)tabActions).Enabled = true;
                    MessageBox.Show(Properties.Resources.MsgActionsCancelled_Body, Properties.Resources.MsgActionsCancelled_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto finalize;
                }
                GlobalData.EC.CountComments(comments.Values.ToList(), col: col_comment_count, col_cmts: col_comment_text, col_ment: col_mention_count, col_mdet: col_mention_uid, replies: cbxActionsGetReplies.Checked, ment_exc: cbxActionsMentionsExclude.Checked);
            }

            if (col_share_count != -1)
            {
                lblActionsStatus.Text = Properties.Resources.StaActionsGetShares;
                var shares = await post.GetShares(cb_funcs[step_cnt++]);
                if (shares == null)
                {
                    ((Control)tabActions).Enabled = true;
                    MessageBox.Show(Properties.Resources.MsgActionsCancelled_Body, Properties.Resources.MsgActionsCancelled_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto finalize;
                }
                GlobalData.EC.CountShares(shares.Keys.ToList(), col_share_count, col_share_details);
            }

            if (col_summary != -1)
            {
                lblActionsStatus.Text = Properties.Resources.StaActionsSummarize;
                foreach (var entry in GlobalData.EC.Entries)
                {
                    List<int> diff = new List<int>();
                    if (col_react_count != -1 && cbxActionsCheckReactions.Checked) diff.Add(entry.IntData[col_react_count] - (int)numActionsMinReactions.Value);
                    if (col_comment_count != -1 && cbxActionsCheckComments.Checked) diff.Add(entry.IntData[col_comment_count] - (int)numActionsMinComments.Value);
                    if (col_mention_count != -1 && cbxActionsCheckMentions.Checked) diff.Add(entry.IntData[col_mention_count] - (int)numActionsMinMentions.Value);
                    if (col_share_count != -1 && cbxActionsCheckShares.Checked) diff.Add(entry.IntData[col_share_count] - (int)numActionsMinShares.Value);
                    string stat = tbxActionsSummaryTextNo.Text;
                    if (diff.All(x => (x >= 0))) stat = tbxActionsSummaryTextFull.Text;
                    else if (diff.Any(x => (x >= 0))) stat = tbxActionsSummaryTextPartial.Text;
                    entry.Data[col_summary] = stat;
                }
            }

            ((Control)tabActions).Enabled = true;
            if (MessageBox.Show(Properties.Resources.MsgActionsSuccess_Body, Properties.Resources.MsgActionsSuccess_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) btnActionsECSave_Click(sender, e); // save EC now
finalize:
            pbrActions.Value = 0;
            lblActionsStatus.Text = Properties.Resources.StaActionsReady;
            ActionsCancelled = false;
        }

        private void cbxActionsSummary_CheckedChanged(object sender, EventArgs e)
        {
            tbxActionsSummaryCol.Enabled = tbxActionsSummaryTextFull.Enabled = tbxActionsSummaryTextPartial.Enabled = tbxActionsSummaryTextNo.Enabled = cbxActionsSummary.Checked;
        }
    }
}