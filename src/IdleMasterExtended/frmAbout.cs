using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using IdleMasterExtended.Properties;

namespace IdleMasterExtended
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
                var appIcon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
                if (appIcon != null)
                {
                    this.Icon = appIcon;
                    picAppIcon.Image = appIcon.ToBitmap();
                }
            }
            catch
            {
                // Fallback gracefully
            }

            SetVersion();

            var settings = Settings.Default;
            if (settings.customTheme)
            {
                this.BackColor = settings.colorBgd;
                this.ForeColor = settings.colorTxt;

                lblSubtitle.ForeColor = Color.DarkGray;
                lblLicense.ForeColor = Color.Gray;

                btnOK.FlatStyle = FlatStyle.Flat;
                btnOK.BackColor = settings.colorBgd;
                btnOK.ForeColor = settings.colorTxt;

                linkLabelVersion.LinkColor = settings.colorTxt;
                lnkWebsite.LinkColor = settings.colorTxt;
                pnlDivider.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void SetVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            linkLabelVersion.Text = string.Format("v{0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

        private void linkLabelVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ibenzir/idle-master-extended/releases");
        }

        private void lnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ibenzir.me");
        }
    }
}
