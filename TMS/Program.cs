namespace TMS
{
    class Global
    {
        public static string Database = "C:\\Users\\Keith\\source\\repos\\TMS\\TMS\\Database\\TMS.mdf";
        public static string Emp_ID;

    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

    }
}