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
            Equipo e = new Entidades.Equipo();
            e.NombreEquipo = btnAlta.Text;
            e.CantidadEquipo = txtCantidad.Text;

            foreach (Equipo eq in pEquipo.GetAll())
            {
                if (eq.NombreEquipo == e.NombreEquipo)
                {
                    MessageBox.Show("El equipo ya existe");
                    return;
                }
            }
            if (btnAlta.Text != "" && txtCantidad.Text !="")
            {
                Conexion.OpenConexion();
                pEquipo.Save(e);
                MessageBox.Show("Se ha registrado Correctamente!");
            }
            else { MessageBox.Show("No puede dejar campos vacios!", "Error"); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

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
    }
}
