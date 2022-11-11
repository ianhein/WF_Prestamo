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
using System.Data.SQLite;


namespace WF_Prestamo.Forms.Equipos
{
    public partial class fmAltaEquipo : Form
    {
        public fmAltaEquipo()
        {
            InitializeComponent();
            
            equipoBindingSource.DataSource = pEquipo.GetAll();
            tipoEquipoBindingSource.DataSource = pTipoEquipo.GetAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            altaEquipo();
            this.Close();
            
        }

        public void altaEquipo()
        {
            Equipo eq = new Equipo();
            eq.NombreEquipo= btnAlta.Text;
            int id = ((TipoEquipo)tipoEquipoBindingSource.Current).Id;
            pEquipo.Save(eq, id);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(cbTipoEquipo.SelectedValue);
            equipoBindingSource.DataSource = pEquipo.GetById(i);


        }

        private void btnAlta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmAltaEquipo_Load(object sender, EventArgs e)
        {

        }
    }
}
