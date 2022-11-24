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
            tipoEquipoBindingSource.Add(pTipoEquipo.GetById(id));
        }

        public fmBajaEquipo(Equipo e, int idTipoEquipo)
        {
            InitializeComponent();
            equipoBindingSource.Add(e);
            tipoEquipoBindingSource.Add(pTipoEquipo.GetById(idTipoEquipo));
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
            bajEquipo();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void bajEquipo()
        {
            Equipo eq = new Equipo();
            TipoEquipo te = new TipoEquipo();
            eq.Id = Convert.ToInt32(txtId.Text);
            eq.NombreEquipo = txtNombre.Text;
            eq.TipoEquipo = te;
            pEquipo.Delete(eq);

        }

        private void fmBajaEquipo_Load(object sender, EventArgs e)
        {

        }
    }
}
