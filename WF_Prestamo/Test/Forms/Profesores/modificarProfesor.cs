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

namespace WF_Prestamo.Test.Forms
{
    public partial class modificarProfesor : Form
    {
        public modificarProfesor(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            profesorBindingSource.Add(pProfesor.GetById(id));
        }
        public modificarProfesor(Profesor p)
        {
            InitializeComponent();
            profesorBindingSource.Add(p);
        }


        private void textNombreP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            pProfesor.Update((Profesor)profesorBindingSource.Current);
            pProfesor.GetAll();
            Conexion.CloseConexion();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textApellidoP_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificarProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
