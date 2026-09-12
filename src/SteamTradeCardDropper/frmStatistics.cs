using System;
using System.Drawing;
using System.Windows.Forms;

namespace SteamTradeCardDropper
{
    public partial class frmStatistics : Form
    {
        private Statistics statistics;
        public frmStatistics(Statistics statistics)
        {
            InitializeComponent();
            this.statistics = statistics;
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Resources.appIcon != null)
                {
                    this.Icon = Properties.Resources.appIcon;
                }
                picIcon.Image = ThemeManager.IsDarkTheme ? Properties.Resources.imgStatistics_w : Properties.Resources.imgStatistics;
            }
            catch { }

            // Localize Form
            this.Text = localization.strings.statistics.Replace("&", "");
            lblTitle.Text = localization.strings.statistics.Replace("&", "");
            btnOK.Text = localization.strings.accept;
            lblSessionHeader.Text = localization.strings.this_session;
            lblTotalHeader.Text = localization.strings.total;

            TimeSpan sessionMinutesIdled = TimeSpan.FromMinutes(statistics.getSessionMinutesIdled());
            TimeSpan totalMinutesIdled = TimeSpan.FromMinutes(Properties.Settings.Default.totalMinutesIdled);

            int sessionHoursIdled = (sessionMinutesIdled.Days * 24) + sessionMinutesIdled.Hours;
            int totalHoursIdled = (totalMinutesIdled.Days * 24) + totalMinutesIdled.Hours;

            // Session
            if (sessionHoursIdled > 0)
            {
                lblSessionTime.Text = String.Format("{0} hour{1}, {2} minute{3} idled",
                        sessionHoursIdled,
                        sessionHoursIdled == 1 ? "" : "s",
                        sessionMinutesIdled.Minutes,
                        sessionMinutesIdled.Minutes == 1 ? "" : "s");
            }
            else
            {
                lblSessionTime.Text = String.Format("{0} minute{1} idled",
                        sessionMinutesIdled.Minutes,
                        sessionMinutesIdled.Minutes == 1 ? "" : "s");
            }
            lblSessionCards.Text = statistics.getSessionCardIdled().ToString() + " cards idled";

            // Total
            if (totalHoursIdled > 0)
            {
                lblTotalTime.Text = String.Format("{0} hour{1}, {2} minute{3} idled",
                    totalHoursIdled,
                    totalHoursIdled == 1 ? "" : "s",
                    totalMinutesIdled.Minutes,
                    totalMinutesIdled.Minutes == 1 ? "" : "s");
            }
            else
            {
                lblTotalTime.Text = String.Format("{0} minute{1} idled",
                    totalMinutesIdled.Minutes,
                    totalMinutesIdled.Minutes == 1 ? "" : "s");
            }
            lblTotalCards.Text = Properties.Settings.Default.totalCardIdled.ToString() + " cards idled";

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = ThemeManager.WindowBg;
            this.ForeColor = ThemeManager.TextPrimary;

            ThemeManager.StyleHeader(lblTitle, lblSubtitle, pnlDivider);

            pnlSessionCard.BackColor = ThemeManager.CardBg;
            pnlTotalCard.BackColor = ThemeManager.CardBg;

            lblSessionHeader.ForeColor = ThemeManager.TextPrimary;
            lblTotalHeader.ForeColor = ThemeManager.TextPrimary;

            lblSessionCards.ForeColor = ThemeManager.IsDarkTheme ? Color.FromArgb(96, 165, 250) : Color.FromArgb(37, 99, 235);
            lblTotalCards.ForeColor = ThemeManager.IsDarkTheme ? Color.FromArgb(96, 165, 250) : Color.FromArgb(37, 99, 235);

            lblSessionTime.ForeColor = ThemeManager.TextSecondary;
            lblTotalTime.ForeColor = ThemeManager.TextSecondary;

            ThemeManager.StylePrimaryButton(btnOK);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
