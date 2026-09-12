using System;
using System.Drawing;
using System.Windows.Forms;
using SteamTradeCardDropper.Properties;

namespace SteamTradeCardDropper
{
    public partial class frmEula : Form
    {
        public frmEula()
        {
            InitializeComponent();
        }

        private void frmEula_Load(object sender, EventArgs e)
        {
            try
            {
                if (Resources.appIcon != null)
                {
                    this.Icon = Resources.appIcon;
                }
                if (Resources.appLogo != null)
                {
                    picIcon.Image = Resources.appLogo;
                    picIcon.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch { }

            ApplyTheme();
            LoadTermsText();
        }

        private void ApplyTheme()
        {
            bool isDark = false;
            try
            {
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        object val = key.GetValue("AppsUseLightTheme");
                        if (val != null && Convert.ToInt32(val) == 0)
                        {
                            isDark = true;
                        }
                    }
                }
            }
            catch { }

            if (isDark)
            {
                this.BackColor = Color.FromArgb(24, 24, 36);
                lblHeader.ForeColor = Color.White;
                lblSubHeader.ForeColor = Color.FromArgb(160, 165, 180);
                pnlDivider.BackColor = Color.FromArgb(45, 45, 65);
                txtTerms.BackColor = Color.FromArgb(18, 18, 28);
                txtTerms.ForeColor = Color.FromArgb(230, 235, 245);
                btnDecline.BackColor = Color.FromArgb(35, 35, 50);
                btnDecline.ForeColor = Color.FromArgb(220, 220, 220);
                btnDecline.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
                btnAccept.BackColor = Color.FromArgb(59, 130, 246);
                btnAccept.ForeColor = Color.White;
            }
        }

        private void LoadTermsText()
        {
            txtTerms.Text = 
@"STEAM TRADE CARD DROPPER — TERMS OF USE & SAFETY NOTICE

1. NON-AFFILIATION & TRADEMARKS
Steam Trade Card Dropper is an independent open-source utility maintained for personal efficiency and interoperability.
Valve Corporation, Steam, and their respective logos and marks are trademarks and/or registered trademarks of Valve Corporation. This software is NOT affiliated with, authorized, maintained, sponsored, or endorsed by Valve Corporation.

2. LOCAL EXECUTION & ZERO TELEMETRY
Steam Trade Card Dropper operates 100% locally on your personal machine.
• All web communications occur directly and securely between your computer and official Steam endpoints (https://steamcommunity.com) over encrypted HTTPS.
• Under NO circumstances are your session cookies, login credentials, Steam ID, or inventory data logged remotely, forwarded, proxied, or transmitted to any third party.
• The entire source code is fully open source and publicly auditable.

3. ANTI-CHEAT & SAFE USAGE ADVISORY
• Steam Trade Card Dropper coordinates with the running Steam desktop client via the official Steamworks API to notify Steam that an AppID is active. It does NOT inject code, hook memory, or modify game files.
• SAFETY WARNING: NEVER idle VAC-secured games (e.g., Counter-Strike 2, Team Fortress 2, Rust, Dota 2) while actively connected to VAC-secured game servers.
• Use the built-in Blacklist feature to exclude competitive or VAC-secured games.

4. LIMITATION OF LIABILITY & WARRANTY
THIS SOFTWARE IS PROVIDED ""AS IS"" WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED. UNDER NO CIRCUMSTANCES SHALL benzir OR CONTRIBUTORS BE LIABLE FOR ANY ACCOUNT RESTRICTIONS, VAC FLAGS, LOSS OF DATA, INVENTORY ITEMS, OR DAMAGES RESULTING FROM THE USE OF THIS SOFTWARE. USE IS AT YOUR OWN SOLE RISK AND DISCRETION.

5. LICENSE
This project is released under the GNU General Public License v2.0 (GPL-2.0).

By clicking ""Accept & Continue"", you acknowledge and agree to these terms.";
        }
    }
}
