using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SteamTradeCardDropper.Properties;

namespace SteamTradeCardDropper
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            try
            {
                if (Resources.appIcon != null)
                {
                    this.Icon = Resources.appIcon;
                }
                if (Resources.appLogo != null)
                {
                    picAppIcon.Image = Resources.appLogo;
                    picAppIcon.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch
            {
                // Fallback gracefully
            }

            SetVersion();

            this.BackColor = ThemeManager.WindowBg;
            this.ForeColor = ThemeManager.TextPrimary;

            ThemeManager.ApplyHeader(picAppIcon, lblTitle, lblSubtitle, pnlDivider, "info", "About", "Steam Trade Card Dropper — Automated card idling tool");
            linkLabelVersion.LinkColor = ThemeManager.LinkColor;
            lblMaintainer.ForeColor = ThemeManager.TextPrimary;
            lnkWebsite.LinkColor = ThemeManager.LinkColor;
            lblLicense.ForeColor = ThemeManager.TextMuted;

            ThemeManager.StylePrimaryButton(btnOK);
        }

        private void SetVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            linkLabelVersion.Text = string.Format("v{0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

        private void linkLabelVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ibenzir/steam-trade-card-dropper/releases");
        }

        private void lnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ibenzir.me");
        }
    }
}
