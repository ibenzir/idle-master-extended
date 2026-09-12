using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SteamTradeCardDropper
{
    /// <summary>
    /// Centralized theme manager that detects the Windows OS theme and provides
    /// cohesive design tokens, fonts, and control styling helpers across all forms.
    /// </summary>
    public static class ThemeManager
    {
        public static bool IsDarkTheme
        {
            get
            {
                try
                {
                    using (var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                    {
                        if (key != null)
                        {
                            object val = key.GetValue("AppsUseLightTheme");
                            if (val != null)
                            {
                                return Convert.ToInt32(val) == 0;
                            }
                        }
                    }
                }
                catch { }
                return false;
            }
        }

        // Window & Layout Backgrounds
        public static Color WindowBg
        {
            get { return IsDarkTheme ? Color.FromArgb(24, 24, 36) : Color.FromArgb(248, 250, 252); }
        }

        public static Color CardBg
        {
            get { return IsDarkTheme ? Color.FromArgb(30, 32, 48) : Color.White; }
        }

        public static Color CardBorder
        {
            get { return IsDarkTheme ? Color.FromArgb(48, 52, 72) : Color.FromArgb(226, 232, 240); }
        }

        public static Color DividerColor
        {
            get { return IsDarkTheme ? Color.FromArgb(45, 45, 65) : Color.FromArgb(226, 232, 240); }
        }

        // Input Backgrounds
        public static Color InputBg
        {
            get { return IsDarkTheme ? Color.FromArgb(18, 18, 28) : Color.White; }
        }

        public static Color InputBorder
        {
            get { return IsDarkTheme ? Color.FromArgb(55, 60, 80) : Color.FromArgb(203, 213, 225); }
        }

        // Typography Colors
        public static Color TextPrimary
        {
            get { return IsDarkTheme ? Color.White : Color.FromArgb(15, 23, 42); }
        }

        public static Color TextSecondary
        {
            get { return IsDarkTheme ? Color.FromArgb(160, 165, 180) : Color.FromArgb(100, 116, 139); }
        }

        public static Color TextMuted
        {
            get { return IsDarkTheme ? Color.FromArgb(120, 125, 145) : Color.FromArgb(148, 163, 184); }
        }

        public static Color LinkColor
        {
            get { return IsDarkTheme ? Color.FromArgb(96, 165, 250) : Color.FromArgb(37, 99, 235); }
        }

        // Buttons
        public static Color PrimaryButtonBg
        {
            get { return Color.FromArgb(37, 99, 235); }
        }

        public static Color PrimaryButtonText
        {
            get { return Color.White; }
        }

        public static Color SecondaryButtonBg
        {
            get { return IsDarkTheme ? Color.FromArgb(35, 38, 54) : Color.FromArgb(241, 245, 249); }
        }

        public static Color SecondaryButtonText
        {
            get { return IsDarkTheme ? Color.FromArgb(220, 225, 235) : Color.FromArgb(30, 41, 59); }
        }

        public static Color SecondaryButtonBorder
        {
            get { return IsDarkTheme ? Color.FromArgb(60, 65, 85) : Color.FromArgb(203, 213, 225); }
        }

        public static Color DangerButtonBg
        {
            get { return Color.FromArgb(220, 38, 38); }
        }

        public static Color DangerButtonText
        {
            get { return Color.White; }
        }

        public static void ApplyBaseTheme(Form form)
        {
            if (form == null) return;
            form.BackColor = WindowBg;
            form.ForeColor = TextPrimary;
        }

        public static void StylePrimaryButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = PrimaryButtonBg;
            btn.ForeColor = PrimaryButtonText;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        public static void ApplyPrimaryButton(Button btn)
        {
            StylePrimaryButton(btn);
        }

        public static void StyleSecondaryButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = SecondaryButtonBg;
            btn.ForeColor = SecondaryButtonText;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = SecondaryButtonBorder;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }

        public static void ApplySecondaryButton(Button btn)
        {
            StyleSecondaryButton(btn);
        }

        public static void StyleDangerButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = DangerButtonBg;
            btn.ForeColor = DangerButtonText;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        public static void StyleInput(TextBox tb)
        {
            if (tb == null) return;
            tb.BackColor = InputBg;
            tb.ForeColor = TextPrimary;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        }

        public static void StyleListBox(ListBox lb)
        {
            if (lb == null) return;
            lb.BackColor = InputBg;
            lb.ForeColor = TextPrimary;
            lb.BorderStyle = BorderStyle.FixedSingle;
            lb.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        }

        public static void StyleHeader(Label lblTitle, Label lblSub, Panel pnlDivider)
        {
            if (lblTitle != null)
            {
                lblTitle.ForeColor = TextPrimary;
                lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            }
            if (lblSub != null)
            {
                lblSub.ForeColor = TextSecondary;
                lblSub.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            }
            if (pnlDivider != null)
            {
                pnlDivider.BackColor = DividerColor;
            }
        }
    }
}
