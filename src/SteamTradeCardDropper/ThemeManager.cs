using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public static void ApplyHeader(PictureBox pic, Label lblTitle, Label lblSub, Panel pnlDivider, string iconName, string title, string subtitle)
        {
            if (lblTitle != null)
            {
                lblTitle.Text = title;
                lblTitle.ForeColor = TextPrimary;
                lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                lblTitle.AutoSize = true;
            }
            if (lblSub != null)
            {
                lblSub.Text = subtitle;
                lblSub.ForeColor = TextSecondary;
                lblSub.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                lblSub.AutoSize = true;
            }
            if (pnlDivider != null)
            {
                pnlDivider.BackColor = DividerColor;
            }
            if (pic != null && !string.IsNullOrEmpty(iconName))
            {
                Color iconColor = IsDarkTheme ? Color.White : Color.FromArgb(30, 41, 59);
                int iconSize = pic.Width > 0 ? pic.Width : 36;
                pic.Image = RenderIcon(iconName, iconSize, iconColor);
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        public static Bitmap RenderIcon(string iconName, int size, Color color)
        {
            if (size <= 0) size = 32;
            Bitmap bmp = new Bitmap(size, size, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                float s = size;

                using (SolidBrush brush = new SolidBrush(color))
                using (Pen pen = new Pen(color, s * 0.12f))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    pen.LineJoin = LineJoin.Round;

                    switch (iconName.ToLowerInvariant())
                    {
                        case "gear":
                        case "settings":
                            float cx = s / 2f, cy = s / 2f;
                            using (Pen toothPen = new Pen(color, s * 0.16f))
                            {
                                toothPen.StartCap = LineCap.Round;
                                toothPen.EndCap = LineCap.Round;
                                for (int i = 0; i < 8; i++)
                                {
                                    double angle = i * Math.PI / 4.0;
                                    float x1 = cx + (float)(Math.Cos(angle) * (s * 0.26f));
                                    float y1 = cy + (float)(Math.Sin(angle) * (s * 0.26f));
                                    float x2 = cx + (float)(Math.Cos(angle) * (s * 0.44f));
                                    float y2 = cy + (float)(Math.Sin(angle) * (s * 0.44f));
                                    g.DrawLine(toothPen, x1, y1, x2, y2);
                                }
                            }
                            using (Pen ringPen = new Pen(color, s * 0.14f))
                            {
                                float ringR = s * 0.25f;
                                g.DrawEllipse(ringPen, cx - ringR, cy - ringR, ringR * 2, ringR * 2);
                            }
                            break;

                        case "check":
                        case "whitelist":
                            pen.Width = s * 0.16f;
                            PointF[] checkPoints = new PointF[] {
                                new PointF(s * 0.20f, s * 0.52f),
                                new PointF(s * 0.42f, s * 0.74f),
                                new PointF(s * 0.82f, s * 0.28f)
                            };
                            g.DrawLines(pen, checkPoints);
                            break;

                        case "ban":
                        case "blacklist":
                            pen.Width = s * 0.13f;
                            float pad = s * 0.14f;
                            g.DrawEllipse(pen, pad, pad, s - pad * 2, s - pad * 2);
                            float slashOffset = (s - pad * 2) * 0.293f;
                            g.DrawLine(pen, pad + slashOffset, pad + slashOffset, s - pad - slashOffset, s - pad - slashOffset);
                            break;

                        case "chart":
                        case "statistics":
                            float bw = s * 0.18f;
                            float gap = s * 0.08f;
                            float startX = (s - (bw * 3 + gap * 2)) / 2f;
                            float bottomY = s * 0.82f;
                            g.FillRectangle(brush, startX, s * 0.48f, bw, bottomY - s * 0.48f);
                            g.FillRectangle(brush, startX + bw + gap, s * 0.22f, bw, bottomY - s * 0.22f);
                            g.FillRectangle(brush, startX + (bw + gap) * 2, s * 0.36f, bw, bottomY - s * 0.36f);
                            break;

                        case "lock":
                        case "auth":
                            float bx = s * 0.24f, by = s * 0.44f, bw2 = s * 0.52f, bh = s * 0.44f;
                            g.FillRectangle(brush, bx, by, bw2, bh);
                            using (Pen shacklePen = new Pen(color, s * 0.12f))
                            {
                                shacklePen.StartCap = LineCap.Round;
                                shacklePen.EndCap = LineCap.Round;
                                float sw = s * 0.30f;
                                float sx = (s - sw) / 2f;
                                GraphicsPath path = new GraphicsPath();
                                path.AddArc(sx, s * 0.16f, sw, sw, 180, 180);
                                path.AddLine(sx + sw, s * 0.31f, sx + sw, by);
                                path.StartFigure();
                                path.AddLine(sx, s * 0.31f, sx, by);
                                g.DrawPath(shacklePen, path);
                            }
                            break;

                        case "info":
                        case "about":
                            pen.Width = s * 0.10f;
                            float ipad = s * 0.12f;
                            g.DrawEllipse(pen, ipad, ipad, s - ipad * 2, s - ipad * 2);
                            g.FillEllipse(brush, s * 0.45f, s * 0.28f, s * 0.10f, s * 0.10f);
                            g.DrawLine(pen, s * 0.50f, s * 0.44f, s * 0.50f, s * 0.72f);
                            break;
                    }
                }
            }
            return bmp;
        }
    }
}
