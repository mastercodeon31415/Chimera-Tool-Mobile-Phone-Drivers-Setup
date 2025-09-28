using System.Diagnostics;
using System.Security.Principal;

namespace ChimeraToolMobilePhoneDriversSetup
{
    internal static class Program
    {
        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IsAdministrator() == false)
            {
                // Restart program and run as admin
                var exeName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                startInfo.Verb = "runas";
                Process.Start(startInfo);
                Application.Exit();
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.SetCompatibleTextRenderingDefault(true);
            Application.SetColorMode(SystemColorMode.Dark);
            Application.Run(new Form1());
        }
    }
}