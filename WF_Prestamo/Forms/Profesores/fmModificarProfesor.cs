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

namespace WF_Prestamo.Forms
{
    public partial class fmModificarProfesor : Form
    {
        public fmModificarProfesor(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            profesorBindingSource.Add(pProfesor.GetById(id));
            Conexion.CloseConexion();
        }

        public fmModificarProfesor(Profesor p)
        {
            InitializeComponent();
            profesorBindingSource.Add(p);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            pProfesor.Update((Profesor)profesorBindingSource.Current);
            pProfesor.GetAll();
            Conexion.CloseConexion();
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarProfesor_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
