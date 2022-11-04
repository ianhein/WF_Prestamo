using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Prestamo.Persistencia;
using WF_Prestamo.Entidades;

namespace WF_Prestamo.Forms.Ubicaciones
{
    public partial class fmModificarUbicacion : Form
    {
        public fmModificarUbicacion(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            ubicacionBindingSource.Add(pUbicacion.GetById(id));
            Conexion.CloseConexion();
        }

        public fmModificarUbicacion(Ubicacion u)
        {
            InitializeComponent();
            ubicacionBindingSource.Add(u);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            pUbicacion.Update((Ubicacion)ubicacionBindingSource.Current);
            pUbicacion.GetAll();
            Conexion.CloseConexion();
            Close();
        }
    }
}
