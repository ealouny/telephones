namespace WinFormApps
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {          
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmAdmin());
            Application.Run(new frmLog());
            //Application.Run(new frmTelephoneDir());
        }
    }
}