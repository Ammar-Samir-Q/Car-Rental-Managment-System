namespace CarRental
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //Language Handling
            string Language = Properties.Settings.Default.Language;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Language);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Language);
            //Language Handling


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}