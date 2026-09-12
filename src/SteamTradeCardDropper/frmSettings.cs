using System;
using System.Drawing;
using System.Windows.Forms;
using SteamTradeCardDropper.Properties;
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace SteamTradeCardDropper
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radIdleDefault.Checked)
            {
                Settings.Default.sort = "default";
            }
            if (radIdleLeastDrops.Checked)
            {
                Settings.Default.sort = "leastcards";
            }
            if (radIdleMostDrops.Checked)
            {
                Settings.Default.sort = "mostcards";
            }

            if (cboLanguage.Text != "")
            {
                if (cboLanguage.Text != Settings.Default.language)
                {
                    MessageBox.Show(localization.strings.please_restart);
                }
                Settings.Default.language = cboLanguage.Text;
            }

            Settings.Default.OneThenMany = Settings.Default.OnlyOneGameIdle 
                = Settings.Default.fastMode = Settings.Default.IdlingModeWhitelist = false;
            
            if (radFastMode.Checked)
            {
                Settings.Default.fastMode = true;
            }
            else if (radWhitelistMode.Checked)
            {
                Settings.Default.IdlingModeWhitelist = true;
            }
            else if (radOneThenMany.Checked)
            {
                Settings.Default.OneThenMany = true;
            }
            else
            {
                Settings.Default.OnlyOneGameIdle = !radManyThenOne.Checked;
            }

            Settings.Default.minToTray = chkMinToTray.Checked;
            Settings.Default.ignoreclient = chkIgnoreClientStatus.Checked;
            Settings.Default.showUsername = chkShowUsername.Checked;
            Settings.Default.NoSleep = chkPreventSleep.Checked;
            Settings.Default.ShutdownWindowsOnDone = chkShutdown.Checked;
            Settings.Default.IdleOnlyPlayed = chkIdleOnlyPlayed.Checked;

            Settings.Default.customTheme = ThemeManager.IsDarkTheme;
            Settings.Default.whiteIcons = ThemeManager.IsDarkTheme;
            Settings.Default.Save();

            Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                if (Resources.appIcon != null) this.Icon = Resources.appIcon;
                picIcon.Image = ThemeManager.IsDarkTheme ? Resources.imgSettings_w : Resources.imgSettings;
            }
            catch { }

            if (Settings.Default.language != "")
            {
                cboLanguage.SelectedItem = Settings.Default.language;
            }
            else
            {
                switch (Thread.CurrentThread.CurrentUICulture.EnglishName)
                {
                    case "Chinese (Simplified, China)":
                    case "Chinese (Traditional, China)":
                    case "Portuguese (Brazil)":
                        cboLanguage.SelectedItem = Thread.CurrentThread.CurrentUICulture.EnglishName;
                        break;
                    default:
                        cboLanguage.SelectedItem = Regex.Replace(Thread.CurrentThread.CurrentUICulture.EnglishName, @"\(.+\)", "").Trim();
                        break;
                }
            }

            switch (Settings.Default.sort)
            {
                case "leastcards":
                    radIdleLeastDrops.Checked = true;
                    break;
                case "mostcards":
                    radIdleMostDrops.Checked = true;
                    break;
                default:
                    break;
            }

            // Load translation
            this.Text = localization.strings.idle_master_settings;
            lblTitle.Text = localization.strings.idle_master_settings;
            grpGeneral.Text = localization.strings.general;
            grpIdlingQuantity.Text = localization.strings.idling_behavior;
            grpPriority.Text = localization.strings.idling_order;
            btnOK.Text = localization.strings.accept;
            btnCancel.Text = localization.strings.cancel;
            ttHints.SetToolTip(btnAdvanced, localization.strings.advanced_auth);
            chkMinToTray.Text = localization.strings.minimize_to_tray;
            ttHints.SetToolTip(chkMinToTray, localization.strings.minimize_to_tray);
            chkIgnoreClientStatus.Text = localization.strings.ignore_client_status;
            ttHints.SetToolTip(chkIgnoreClientStatus, localization.strings.ignore_client_status);
            chkShowUsername.Text = localization.strings.show_username;
            ttHints.SetToolTip(chkShowUsername, localization.strings.show_username);
            radOneGameOnly.Text = localization.strings.idle_individual;
            ttHints.SetToolTip(radOneGameOnly, localization.strings.idle_individual);
            radManyThenOne.Text = localization.strings.idle_simultaneous;
            ttHints.SetToolTip(radManyThenOne, localization.strings.idle_simultaneous);
            radOneThenMany.Text = localization.strings.idle_onethenmany;
            ttHints.SetToolTip(radOneThenMany, localization.strings.idle_onethenmany);
            radIdleDefault.Text = localization.strings.order_default;
            ttHints.SetToolTip(radIdleDefault, localization.strings.order_default);
            radIdleMostDrops.Text = localization.strings.order_most;
            ttHints.SetToolTip(radIdleMostDrops, localization.strings.order_most);
            radIdleLeastDrops.Text = localization.strings.order_least;
            ttHints.SetToolTip(radIdleLeastDrops, localization.strings.order_least);
            lblLanguage.Text = localization.strings.interface_language;

            if (Settings.Default.fastMode)
            {
                radFastMode.Checked = true;
            }
            else if (Settings.Default.IdlingModeWhitelist)
            {
                radWhitelistMode.Checked = true;
            }
            else if (Settings.Default.OneThenMany)
            {
                radOneThenMany.Checked = true;
            }
            else
            {
                radOneGameOnly.Checked = Settings.Default.OnlyOneGameIdle;
                radManyThenOne.Checked = !Settings.Default.OnlyOneGameIdle;
            }

            if (Settings.Default.minToTray)
            {
                chkMinToTray.Checked = true;
            }

            if (Settings.Default.ignoreclient)
            {
                chkIgnoreClientStatus.Checked = true;
            }

            if (Settings.Default.showUsername)
            {
                chkShowUsername.Checked = true;
            }

            if (Settings.Default.NoSleep)
            {
                chkPreventSleep.Checked = true;
            }

            if (Settings.Default.ShutdownWindowsOnDone)
            {
                chkShutdown.Checked = true;
            }

            if (Settings.Default.IdleOnlyPlayed)
            {
                chkIdleOnlyPlayed.Checked = true;
            }

            runtimeCustomThemeSettings();
        }

        private void runtimeCustomThemeSettings()
        {
            this.BackColor = ThemeManager.WindowBg;
            this.ForeColor = ThemeManager.TextPrimary;

            ThemeManager.StyleHeader(lblTitle, lblSubtitle, pnlDivider);

            grpGeneral.ForeColor = ThemeManager.TextPrimary;
            grpIdlingQuantity.ForeColor = ThemeManager.TextPrimary;
            grpPriority.ForeColor = ThemeManager.TextPrimary;

            chkMinToTray.ForeColor = ThemeManager.TextPrimary;
            chkIgnoreClientStatus.ForeColor = ThemeManager.TextPrimary;
            chkShowUsername.ForeColor = ThemeManager.TextPrimary;
            chkPreventSleep.ForeColor = ThemeManager.TextPrimary;
            chkShutdown.ForeColor = ThemeManager.TextPrimary;
            chkIdleOnlyPlayed.ForeColor = ThemeManager.TextPrimary;

            radFastMode.ForeColor = ThemeManager.TextPrimary;
            radWhitelistMode.ForeColor = ThemeManager.TextPrimary;
            radOneGameOnly.ForeColor = ThemeManager.TextPrimary;
            radManyThenOne.ForeColor = ThemeManager.TextPrimary;
            radOneThenMany.ForeColor = ThemeManager.TextPrimary;

            radIdleDefault.ForeColor = ThemeManager.TextPrimary;
            radIdleMostDrops.ForeColor = ThemeManager.TextPrimary;
            radIdleLeastDrops.ForeColor = ThemeManager.TextPrimary;

            lblLanguage.ForeColor = ThemeManager.TextSecondary;
            cboLanguage.BackColor = ThemeManager.InputBg;
            cboLanguage.ForeColor = ThemeManager.TextPrimary;
            cboLanguage.FlatStyle = FlatStyle.Flat;

            linkLabelAppData.LinkColor = ThemeManager.LinkColor;
            lnkGitHubWiki.LinkColor = ThemeManager.LinkColor;

            ThemeManager.StyleSecondaryButton(btnAdvanced);
            btnAdvanced.Image = ThemeManager.IsDarkTheme ? Resources.imgLock_w : Resources.imgLock;
            btnAdvanced.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdvanced.TextAlign = ContentAlignment.MiddleRight;
            btnAdvanced.TextImageRelation = TextImageRelation.ImageBeforeText;

            ThemeManager.StyleSecondaryButton(btnCancel);
            ThemeManager.StylePrimaryButton(btnOK);
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            var frm = new frmSettingsAdvanced();
            frm.ShowDialog();
        }

        private void chkShutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShutdown.Checked)
            {
                if (MessageBox.Show("Are you sure you want Steam Trade Card Dropper to shutdown Windows when idling is done?\n\nNote: This setting will only be active once.",
                                    "Shutdown Windows", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Settings.Default.ShutdownWindowsOnDone = true;
                }
                else
                {
                    chkShutdown.Checked = false;
                }
            }
            else
            {
                Settings.Default.ShutdownWindowsOnDone = false;
            }
        }

        private void linkLabelSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SteamTradeCardDropper");
        }

        private void lnkGitHubWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ibenzir/steam-trade-card-dropper#readme");
        }
    }
}
