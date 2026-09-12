using System;
using System.Linq;
using System.Windows.Forms;
using SteamTradeCardDropper.Properties;

namespace SteamTradeCardDropper
{
    public partial class frmWhitelist : Form
    {
        frmMain mainForm;

        public frmWhitelist(frmMain parentForm)
        {
            this.mainForm = parentForm;
            InitializeComponent();
        }

        public void SaveWhitelist()
        {
            Settings.Default.whitelist.Clear();
            Settings.Default.whitelist.AddRange(lstWhitelist.Items.Cast<string>().ToArray());
            Settings.Default.Save();
        }

        private void frmWhitelist_Load(object sender, EventArgs e)
        {
            try
            {
                if (Resources.appIcon != null) this.Icon = Resources.appIcon;
            }
            catch { }

            this.Text = "Whitelist Management";
            btnAdd.Text = "&Add";
            btnSave.Text = "&Save && Close";
            btnRemove.Text = "Remove Selected";

            lstWhitelist.Items.AddRange(Settings.Default.whitelist.Cast<string>().ToArray());

            applyTheme();
        }

        private void applyTheme()
        {
            this.BackColor = ThemeManager.WindowBg;
            this.ForeColor = ThemeManager.TextPrimary;

            ThemeManager.ApplyHeader(picIcon, lblTitle, lblSubtitle, pnlDivider, "check", "Whitelist Management", "Only collect cards for games in your whitelist.");

            lblAppId.ForeColor = ThemeManager.TextPrimary;
            ThemeManager.StyleInput(txtAppid);
            ThemeManager.StyleSecondaryButton(btnAdd);

            ThemeManager.StyleListBox(lstWhitelist);

            ThemeManager.StyleSecondaryButton(btnRemove);
            ThemeManager.StylePrimaryButton(btnSave);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            SaveWhitelist();

            if (Settings.Default.IdlingModeWhitelist)
            {
                mainForm.StopIdle();
                await mainForm.LoadBadgesAsync();

                if (lstWhitelist.Items.Count == 1)
                {
                    mainForm.StartSoloIdle(
                        mainForm.AllBadges.FirstOrDefault(b => b.AppId == int.Parse(lstWhitelist.Items[0].ToString()))
                    );
                }
                else if (lstWhitelist.Items.Count > 1)
                {
                    mainForm.StartMultipleIdle();
                }

                mainForm.DisableCardDropCheckTimer();
                mainForm.UpdateStateInfo();
            }
            else
            {
                mainForm.EnableCardDropCheckTimer();
            }

            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result;
            
            if (int.TryParse(txtAppid.Text, out result)
                && lstWhitelist.Items.Cast<string>().All(blApp => blApp != txtAppid.Text))
            {
                lstWhitelist.Items.Add(txtAppid.Text);
            }

            txtAppid.Text = string.Empty;
            txtAppid.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstWhitelist.SelectedItem != null)
            {
                lstWhitelist.Items.Remove(lstWhitelist.SelectedItem);
            }
        }
    }
}
