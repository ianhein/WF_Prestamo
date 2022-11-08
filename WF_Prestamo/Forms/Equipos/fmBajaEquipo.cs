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

namespace WF_Prestamo.Forms.Equipos
{
    public partial class fmBajaEquipo : Form
    {
        public fmBajaEquipo(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            equipoBindingSource.Add(pEquipo.GetById(id));
        }

        public fmBajaEquipo(Equipo e)
        {
            InitializeComponent();
            equipoBindingSource.Add(e);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Conexion.OpenConexion();
                pEquipo.Delete((Equipo)equipoBindingSource.Current);
                pEquipo.GetAll();
                pTipoEquipo.GetAll();
                Conexion.CloseConexion();
                Close();
            }
        }
    }
}
