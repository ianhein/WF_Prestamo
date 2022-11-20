using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Prestamo.Forms;
using WF_Prestamo.Persistencia;
using WF_Prestamo.Test.Forms;
using WF_Prestamo.Test;
using WF_Prestamo.Forms.Equipos;

namespace WF_Prestamo
{
    internal static class Program
    {
        public static string user;
        public static string passwd;

        ///conmas
        /// <summary>s
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Conexion.OpenConexion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            Conexion.Connection.Close();

        }
    }
}
