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

namespace WF_Prestamo.Test.Forms.Equipos
{
    public partial class EquiposForm : Form
    {
        public EquiposForm()
        {
            InitializeComponent();
            Conexion.OpenConexion();
            tipoEquipoBindingSource.DataSource = pTipoEquipo.GetAll();
            equipoBindingSource.DataSource = pEquipo.GetAll();

        }

        private void dataGridProfe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void altaEquipo()
        {
            Equipo eq = new Equipo();
            eq.NombreEquipo = txtEquipoNombre.Text;
            int id = ((TipoEquipo)tipoEquipoBindingSource.Current).Id;
            pEquipo.Save(eq, id);
        }

        private void txtProfesorNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProfesorNombre_Enter(object sender, EventArgs e)
        {

        }

        private void txtProfesorNombre_Leave(object sender, EventArgs e)
        {

        }

        private void txtProfesorApellido_Enter(object sender, EventArgs e)
        {

        }

        private void txtProfesorApellido_Leave(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            altaEquipo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }

        private void EquiposForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxTipoEquipo.SelectedValue);
            equipoBindingSource.DataSource = pEquipo.GetById(i);
        }
    }
}
