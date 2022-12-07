using mock_examen_07449.Business;

namespace mock_examen_07449
{
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
            MainService.GetInstance().StartApplication();
        }
    }
}