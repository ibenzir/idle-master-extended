using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamTradeCardDropper.Properties;

namespace SteamTradeCardDropper
{
    public partial class frmSettingsAdvanced : Form
    {
        public frmSettingsAdvanced()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            bool isMasked = (txtSessionID.PasswordChar == '*');
            char newChar = isMasked ? '\0' : '*';
            txtSessionID.PasswordChar = newChar;
            txtSteamLoginSecure.PasswordChar = newChar;
            txtSteamParental.PasswordChar = newChar;

            txtSessionID.Enabled = true;
            txtSteamLoginSecure.Enabled = true;
            txtSteamParental.Enabled = true;

            btnView.Text = isMasked ? "Hide Cookies" : "Show Cookies";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSettingsAdvanced_Load(object sender, EventArgs e)
        {
            try
            {
                if (Resources.appIcon != null)
                {
                    this.Icon = Resources.appIcon;
                }
            }
            catch { }

            this.Text = "Authentication Data";
            btnUpdate.Text = "&Save && Validate";
            btnCancel.Text = "Cancel";
            ttHelp.SetToolTip(btnView, "Reveals sensitive session cookie credentials.");

            // Apply theme
            ApplyTheme();

            if (!string.IsNullOrWhiteSpace(Settings.Default.sessionid))
            {
                txtSessionID.Text = Settings.Default.sessionid;
                txtSessionID.Enabled = false;
            }
            else
            {
                txtSessionID.PasswordChar = '\0';
            }

            if (!string.IsNullOrWhiteSpace(Settings.Default.steamLoginSecure))
            {
                txtSteamLoginSecure.Text = Settings.Default.steamLoginSecure;
                txtSteamLoginSecure.Enabled = false;
            }
            else
            {
                txtSteamLoginSecure.PasswordChar = '\0';
            }

            if (!string.IsNullOrWhiteSpace(Settings.Default.steamparental))
            {
                txtSteamParental.Text = Settings.Default.steamparental;
                txtSteamParental.Enabled = false;
            }
            else
            {
                txtSteamParental.PasswordChar = '\0';
                txtSteamParental.Text = "(typically not required)";
            }

            if (txtSessionID.Enabled && txtSteamLoginSecure.Enabled && txtSteamParental.Enabled)
            {
                btnView.Text = "Hide Cookies";
            }

            btnUpdate.Enabled = false;
        }

        private void ApplyTheme()
        {
            this.BackColor = ThemeManager.WindowBg;
            this.ForeColor = ThemeManager.TextPrimary;

            ThemeManager.ApplyHeader(picIcon, lblTitle, lblSubtitle, pnlDivider, "lock", "Authentication Data", "Provide your personal Steam session cookies to synchronize badges.");

            lblSessionID.ForeColor = ThemeManager.TextPrimary;
            lblSteamLoginSecure.ForeColor = ThemeManager.TextPrimary;
            lblSteamParental.ForeColor = ThemeManager.TextPrimary;

            ThemeManager.StyleInput(txtSessionID);
            ThemeManager.StyleInput(txtSteamLoginSecure);
            ThemeManager.StyleInput(txtSteamParental);

            ThemeManager.StyleSecondaryButton(btnView);
            ThemeManager.StyleSecondaryButton(btnCancel);
            ThemeManager.StylePrimaryButton(btnUpdate);

            linkLabelWhatIsThis.LinkColor = ThemeManager.LinkColor;
        }

        private void txtSessionID_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtSteamLogin_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private void txtSteamParental_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }

        private async Task CheckAndSave()
        {
            try
            {
                Settings.Default.sessionid = txtSessionID.Text.Trim();
                Settings.Default.steamLoginSecure = txtSteamLoginSecure.Text.Trim();
                Settings.Default.myProfileURL = SteamProfile.GetSteamUrl();
                Settings.Default.steamparental = txtSteamParental.Text.Trim();

                // Test if the cookie data is valid
                if (await CookieClient.IsLogined())
                {
                    Settings.Default.Save();
                    Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "frmSettingsAdvanced -> CheckAndSave");
            }

            // Invalid cookie data, reset the form
            btnUpdate.Text = "&Save && Validate";
            txtSessionID.Text = "";
            txtSteamLoginSecure.Text = "";
            txtSteamParental.Text = "";

            txtSessionID.PasswordChar = '\0';
            txtSteamLoginSecure.PasswordChar = '\0';
            txtSteamParental.PasswordChar = '\0';

            txtSessionID.Enabled = true;
            txtSteamLoginSecure.Enabled = true;
            txtSteamParental.Enabled = true;

            txtSessionID.Focus();

            MessageBox.Show("Cookie validation failed. Please check your session credentials and try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            btnUpdate.Enabled = true;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            txtSessionID.Enabled = false;
            txtSteamLoginSecure.Enabled = false;
            txtSteamParental.Enabled = false;

            btnUpdate.Text = "Validating...";

            await CheckAndSave();
        }

        private void linkLabelWhatIsThis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ibenzir/steam-trade-card-dropper#setup--authentication");
        }
    }
}
