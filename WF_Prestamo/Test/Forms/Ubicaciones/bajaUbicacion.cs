using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Prestamo.Entidades;
using WF_Prestamo.Persistencia;

namespace WF_Prestamo.Test.Forms.Ubicaciones
{
    public partial class bajaUbicacion : Form
    {
        public bajaUbicacion(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            ubicacionBindingSource.Add(pUbicacion.GetById(id));
        }

        public bajaUbicacion(Ubicacion u)
        {
            InitializeComponent();
            ubicacionBindingSource.Add(u);
        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            pUbicacion.Delete((Ubicacion)ubicacionBindingSource.Current);
            pUbicacion.GetAll();
            Conexion.CloseConexion();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
