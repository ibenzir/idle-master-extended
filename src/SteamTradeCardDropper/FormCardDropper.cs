using System;
using System.Windows.Forms;

namespace SteamTradeCardDropper
{
    public partial class FormCardDropper : Form
    {
        public FormCardDropper(long appid)
        {
            InitializeComponent();
            try
            {
                picApp.Load(string.Format("https://cdn.akamai.steamstatic.com/steam/apps/{0}/header_292x136.jpg", appid));
            }
            catch { }
        }
    }
}
