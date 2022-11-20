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

namespace WF_Prestamo.Test.Forms
{
    public partial class bajaProfesor : Form
    {
        public bajaProfesor(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            profesorBindingSource.Add(pProfesor.GetById(id));

        }

        public bajaProfesor(Profesor p)
        {
            InitializeComponent();
            profesorBindingSource.Add(p);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            pProfesor.Delete((Profesor)profesorBindingSource.Current);
            pProfesor.GetAll();
            Conexion.CloseConexion();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
