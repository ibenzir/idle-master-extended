using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
using IdleMasterExtended.Properties;
using Steamworks;

namespace IdleMasterExtended
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Check if launched in worker idling mode for a specific AppId
            if (args != null && args.Length > 0)
            {
                long appId;
                string arg = args[0].TrimStart('-', '/');
                if (arg.StartsWith("idle=", StringComparison.OrdinalIgnoreCase))
                {
                    arg = arg.Substring(5);
                }

                if (long.TryParse(arg, out appId) && appId > 0)
                {
                    Environment.SetEnvironmentVariable("SteamAppId", appId.ToString());
                    if (!SteamAPI.Init())
                    {
                        return;
                    }

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormSteamIdle(appId));
                    return;
                }
            }

            // Set the Browser emulation version for embedded browser control
            try
            {
                RegistryKey ie_root = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION");
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
                String programName = Path.GetFileName(Environment.GetCommandLineArgs()[0]);
                key.SetValue(programName, (int)10001, RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex, "Program -> Main -> Registry and environment modifications resulted in an exception.");
            }

            Application.ThreadException += (o, a) => Logger.Exception(a.Exception);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // First-run EULA & Open Source Terms acceptance
            if (!Settings.Default.AcceptedEula)
            {
                using (var eula = new frmEula())
                {
                    if (eula.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    Settings.Default.AcceptedEula = true;
                    Settings.Default.Save();
                }
            }

            Application.Run(new frmMain());
        }
    }
}
