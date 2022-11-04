using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Prestamo.Forms;
using WF_Prestamo.Persistencia;

namespace WF_Prestamo
{
    internal static class Program
    {
        public static string user;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Conexion.OpenConexion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            Conexion.Connection.Close();

        }
    }
}
