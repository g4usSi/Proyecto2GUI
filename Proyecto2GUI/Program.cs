using Proyecto2;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Drawing2D;

namespace Proyecto2GUI
{
    public static class Program
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

            Biblioteca biblioteca = new Biblioteca();
            biblioteca.LibrosUsuariosPredeterminados();
            Application.Run(new Login(biblioteca));



        }

    }
}