using System;
using System.Windows.Forms;

namespace IdleMasterExtended
{
    public partial class FormSteamIdle : Form
    {
        public FormSteamIdle(long appid)
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
