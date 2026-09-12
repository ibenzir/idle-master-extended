using System.ComponentModel;
using System.Windows.Forms;

namespace SteamTradeCardDropper
{
    partial class FormCardDropper
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.SuspendLayout();
            // 
            // picApp
            // 
            this.picApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picApp.Location = new System.Drawing.Point(0, 0);
            this.picApp.Name = "picApp";
            this.picApp.Size = new System.Drawing.Size(292, 136);
            this.picApp.TabIndex = 0;
            this.picApp.TabStop = false;
            // 
            // FormCardDropper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 136);
            this.Controls.Add(this.picApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCardDropper";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Card Dropper";
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.ResumeLayout(false);
        }

        private PictureBox picApp;
    }
}
