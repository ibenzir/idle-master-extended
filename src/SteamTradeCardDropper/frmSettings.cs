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

            Settings.Default.Save();

            Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                if (Resources.appIcon != null) this.Icon = Resources.appIcon;
            }
            catch { }

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

            this.Text = "Settings";
            grpGeneral.Text = "General Options";
            grpIdlingQuantity.Text = "Idling Behavior";
            grpPriority.Text = "Idling Order";
            btnOK.Text = "&Save";
            btnCancel.Text = "&Cancel";
            btnAdvanced.Text = "  Authentication";
            ttHints.SetToolTip(btnAdvanced, "Display Steam session authentication cookie settings");
            chkMinToTray.Text = "Minimize to system tray";
            chkIgnoreClientStatus.Text = "Ignore Steam client status";
            chkShowUsername.Text = "Show Steam username of signed on user";
            radFastMode.Text = "Fast mode (Recommended)";
            radWhitelistMode.Text = "Whitelist mode (File > Whitelist)";
            radOneGameOnly.Text = "Idle each game individually (Slow)";
            radManyThenOne.Text = "Idle games simultaneously up to 2 hours, then individually";
            radOneThenMany.Text = "Idle games with more than 2 hours individually, then simultaneously";
            radIdleDefault.Text = "Default (Alphabetical Order)";
            radIdleMostDrops.Text = "Prioritize games with the highest number of available drops";
            radIdleLeastDrops.Text = "Prioritize games with the lowest number of available drops";

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

            applyTheme();
        }

        private void applyTheme()
        {
            this.BackColor = ThemeManager.WindowBg;
            this.ForeColor = ThemeManager.TextPrimary;

            ThemeManager.ApplyHeader(picIcon, lblTitle, lblSubtitle, pnlDivider, "settings", "Settings", "Customize idling behavior, queue priority, and automation.");

            grpGeneral.ForeColor = ThemeManager.TextPrimary;
            chkMinToTray.ForeColor = ThemeManager.TextPrimary;
            chkIgnoreClientStatus.ForeColor = ThemeManager.TextPrimary;
            chkShowUsername.ForeColor = ThemeManager.TextPrimary;
            chkPreventSleep.ForeColor = ThemeManager.TextPrimary;
            chkShutdown.ForeColor = ThemeManager.TextPrimary;
            chkIdleOnlyPlayed.ForeColor = ThemeManager.TextPrimary;

            grpIdlingQuantity.ForeColor = ThemeManager.TextPrimary;
            radFastMode.ForeColor = ThemeManager.TextPrimary;
            radWhitelistMode.ForeColor = ThemeManager.TextPrimary;
            radOneGameOnly.ForeColor = ThemeManager.TextPrimary;
            radManyThenOne.ForeColor = ThemeManager.TextPrimary;
            radOneThenMany.ForeColor = ThemeManager.TextPrimary;

            grpPriority.ForeColor = ThemeManager.TextPrimary;
            radIdleDefault.ForeColor = ThemeManager.TextPrimary;
            radIdleMostDrops.ForeColor = ThemeManager.TextPrimary;
            radIdleLeastDrops.ForeColor = ThemeManager.TextPrimary;

            linkLabelAppData.LinkColor = ThemeManager.LinkColor;
            lnkGitHubWiki.LinkColor = ThemeManager.LinkColor;

            ThemeManager.StyleSecondaryButton(btnAdvanced);
            Color lockColor = ThemeManager.IsDarkTheme ? Color.FromArgb(220, 225, 235) : Color.FromArgb(30, 41, 59);
            btnAdvanced.Image = ThemeManager.RenderIcon("lock", 16, lockColor);
            btnAdvanced.ImageAlign = ContentAlignment.MiddleCenter;
            btnAdvanced.TextAlign = ContentAlignment.MiddleCenter;
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
