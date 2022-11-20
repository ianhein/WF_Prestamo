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

namespace WF_Prestamo.Test.Forms.Ubicaciones
{
    public partial class modificarUbicacion : Form
    {
        public modificarUbicacion(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            ubicacionBindingSource.Add(pUbicacion.GetById(id));
            Conexion.CloseConexion();
        }

        public modificarUbicacion(Ubicacion u)
        {
            InitializeComponent();
            ubicacionBindingSource.Add(u);
        }

        private void textNombreP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellidoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            pUbicacion.Update((Ubicacion)ubicacionBindingSource.Current);
            pUbicacion.GetAll();
            Conexion.CloseConexion();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
