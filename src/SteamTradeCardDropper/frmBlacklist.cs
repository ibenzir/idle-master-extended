using System;
using System.Linq;
using System.Windows.Forms;
using SteamTradeCardDropper.Properties;

namespace SteamTradeCardDropper
{
    public partial class frmBlacklist : Form
    {
        public frmBlacklist()
        {
            InitializeComponent();
        }

        public void SaveBlacklist()
        {
            Settings.Default.blacklist.Clear();
            Settings.Default.blacklist.AddRange(lstBlacklist.Items.Cast<string>().ToArray());
            Settings.Default.Save();
        }

        private void frmBlacklist_Load(object sender, EventArgs e)
        {
            try
            {
                if (Resources.appIcon != null) this.Icon = Resources.appIcon;
            }
            catch { }

            this.Text = "Blacklist Management";
            btnAdd.Text = "&Add";
            btnSave.Text = "&Save && Close";
            btnRemove.Text = "Remove Selected";

            lstBlacklist.Items.AddRange(Settings.Default.blacklist.Cast<string>().ToArray());

            applyTheme();
        }

        private void applyTheme()
        {
            this.BackColor = ThemeManager.WindowBg;
            this.ForeColor = ThemeManager.TextPrimary;

            ThemeManager.ApplyHeader(picIcon, lblTitle, lblSubtitle, pnlDivider, "ban", "Blacklist Management", "Prevent specified games from ever being idled.");

            lblAppId.ForeColor = ThemeManager.TextPrimary;
            ThemeManager.StyleInput(txtAppid);
            ThemeManager.StyleSecondaryButton(btnAdd);

            ThemeManager.StyleListBox(lstBlacklist);

            ThemeManager.StyleSecondaryButton(btnRemove);
            ThemeManager.StylePrimaryButton(btnSave);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBlacklist();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txtAppid.Text, out result))
            {
                if (lstBlacklist.Items.Cast<string>().All(blApp => blApp != txtAppid.Text))
                    lstBlacklist.Items.Add(txtAppid.Text);
            }
            txtAppid.Text = string.Empty;
            txtAppid.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBlacklist.SelectedItem != null)
            {
                lstBlacklist.Items.Remove(lstBlacklist.SelectedItem);
            }
        }
    }
}
