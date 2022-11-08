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
using WF_Prestamo.Forms;

namespace WF_Prestamo.Forms
{
    public partial class fmBajaProfesores : Form
    {
        public fmBajaProfesores(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            profesorBindingSource.Add(pProfesor.GetById(id));
            

        }

        public fmBajaProfesores(Profesor p)
        {
            InitializeComponent();
            profesorBindingSource.Add(p);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Conexion.OpenConexion();
                pProfesor.Delete((Profesor)profesorBindingSource.Current);
                pProfesor.GetAll();
                Conexion.CloseConexion();
                Close();
            }

        }

        private void fmBajaProfesores_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
