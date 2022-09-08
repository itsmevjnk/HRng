using HRngBackend;
using HRngSelenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFrontend
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void rbtBackendSelenium_CheckedChanged(object sender, EventArgs e)
        {
            gbxSeSettings.Enabled = rbtBackendSelenium.Checked;
            if (rbtBackendSelenium.Checked && cbxSeBrowser.SelectedIndex == -1) btnStart.Enabled = false; // Disable start button if browser is not selected
            else btnStart.Enabled = true;
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            string lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            if (lang == "vi") cbxLanguage.SelectedIndex = 1;
            else cbxLanguage.SelectedIndex = 0;
        }

        private void cbxSeBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSeBrowser.SelectedIndex == -1) btnStart.Enabled = false; // Disable start button if browser is not selected
            else btnStart.Enabled = true;
        }

        private bool ProgressIndicator(float perc)
        {
            pbrInitialize.Value = (int) perc;
            return true;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (rbtBackendSelenium.Checked)
            {
                /* HRngSelenium */
                if (SevenZip.Exists()) lblStatus.Text = Properties.Resources.StaInit7zFound;
                else
                {
                    lblStatus.Text = Properties.Resources.StaInit7zDownload;
                    await SevenZip.Initialize();
                }

                switch (cbxSeBrowser.SelectedIndex)
                {
                    case 0: GlobalData.Browser = new ChromeHelper(chkSeLocalInst.Checked); break;
                    case 1: GlobalData.Browser = new FirefoxHelper(chkSeLocalInst.Checked); break;
                }

                if (chkSeLocalInst.Checked)
                {
                    if (File.Exists(GlobalData.Browser.BrowserPath)) lblStatus.Text = Properties.Resources.StaInitBrowserFound;
                    else lblStatus.Text = Properties.Resources.StaInitBrowserNotFound;
                }
                if (File.Exists(GlobalData.Browser.DriverPath)) lblStatus.Text = Properties.Resources.StaInitDriverFound;
                else lblStatus.Text = Properties.Resources.StaInitDriverNotFound;

                lblStatus.Text = Properties.Resources.StaInitBrowserFetchVer;
                string browser_ver = (File.Exists(GlobalData.Browser.BrowserPath)) ? GlobalData.Browser.LocalVersion() : "";
                Task<Release> latest_browser_task = null, latest_driver_task;
                Release r_browser = null, r_driver;
                if (browser_ver != "")
                {
                    latest_driver_task = GlobalData.Browser.LatestDriverRelease(browser_ver);
                    latest_browser_task = GlobalData.Browser.LatestRelease();
                }
                else
                {
                    r_browser = await GlobalData.Browser.LatestRelease();
                    browser_ver = r_browser.Version;
                    latest_driver_task = GlobalData.Browser.LatestDriverRelease(browser_ver);
                }
                if (latest_browser_task != null) r_browser = await latest_browser_task;
                uint update = 0; // 0 - do not update, 1 - ask the user to update, 2 - update anyway
                if (r_browser != null) update = r_browser.Update;
                r_driver = await latest_driver_task;
                if (update != 2 && r_driver != null && r_driver.Update != 0) update = r_driver.Update;
                if (update != 0)
                {
                    if (update == 1)
                    {
                        /* Ask user to update */
                        DialogResult res = MessageBox.Show(String.Format(Properties.Resources.MsgInitUpdate_Body, (r_browser == null ? Properties.Resources.StrUnknown : r_browser.Version), (r_driver == null ? Properties.Resources.StrUnknown : r_driver.Version)), Properties.Resources.MsgInitUpdate_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes) update = 2;
                        else update = 0;
                    }

                    if (update == 2)
                    {
                        lblStatus.Text = Properties.Resources.StaInitBrowserUpdate;
                        int ret = await GlobalData.Browser.Update(cb: ProgressIndicator);
                        if(ret == 0) lblStatus.Text = Properties.Resources.StaInitBrowserUpdated;
                        else
                        {
                            MessageBox.Show(String.Format(Properties.Resources.MsgInitUpdateFail_Body, ret), Properties.Resources.MsgInitUpdateFail_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            GlobalData.Browser = null;
                            return;
                        }
                    }
                }

                lblStatus.Text = Properties.Resources.StaInitBrowserStart;
                GlobalData.SeDriver = GlobalData.Browser.InitializeSelenium(!chkSeConsole.Checked, chkSeHeadless.Checked, chkSeDisableLog.Checked, chkSeHeadless.Checked, !chkSeLoadImg.Checked);
            }
            /* HRngLite doesn't need any initialization at this stage */

            /* Switch to main form */
            Form main_form = new MainForm();
            this.Hide();
            main_form.ShowDialog();
            this.Close();
        }

        private void ApplyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                ApplyResources(resources, ctl.Controls);
            }
        }

        private void cbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo((cbxLanguage.SelectedIndex == 1) ? "vi-VN" : "en-US");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(InitForm));
            resources.ApplyResources(this, "$this");
            ApplyResources(resources, this.Controls);
        }
    }
}
