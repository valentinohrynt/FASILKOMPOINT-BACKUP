using FASILKOMPOINT.View;
using FASILKOMPOINT.View.Mahasiswa;
using FASILKOMPOINT.View.SKPI;
using FASILKOMPOINT.View.TU;

namespace FASILKOMPOINT
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Halaman());
        }
    }
}