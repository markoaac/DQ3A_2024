using Unidad_III_Formularios.Ejercicio_1;
using Unidad_III_Formularios.Ejercicio_2;
using Unidad_III_Formularios.Ejercicio_3;

namespace Unidad_III_Formularios
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
            Application.Run(new frmControles());
        }
    }
}