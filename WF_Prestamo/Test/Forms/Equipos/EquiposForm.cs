using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Prestamo.Entidades;
using WF_Prestamo.Persistencia;
using WF_Prestamo.Test.Forms.Equipos;

namespace WF_Prestamo.Test.Forms.Equipos
{
    public partial class EquiposForm : Form
    {
        public EquiposForm()
        {
            InitializeComponent();
            Conexion.OpenConexion();
            tipoEquipoBindingSource.DataSource = pTipoEquipo.GetAll();
            equipoBindingSource.DataSource = pEquipo.GetDisponible();

        }

        private void dataGridProfe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Conexion.OpenConexion();
            equipoBindingSource.DataSource = pEquipo.GetAll();
        }
        private void msgError(string msg)
        {
            lblmsg.Text = msg;
            lblmsg.Visible = true;
            lblmsg.ForeColor = Color.Red;
        }
        private void msgOk(string msg)
        {
            lblmsg.Text = msg;
            lblmsg.Visible = true;
            lblmsg.ForeColor = Color.Green;
        }
        public void altaEquipo()
        {
            Equipo eq = new Equipo();
            eq.NombreEquipo = txtEquipoNombre.Text;
            int id = ((TipoEquipo)tipoEquipoBindingSource.Current).Id;

            foreach (Equipo equipo in pEquipo.GetAll())
            {
                if (equipo.NombreEquipo == equipo.NombreEquipo && eq.NombreEquipo == equipo.NombreEquipo)
                {
                    msgError("El equipo  ya existe");
                    return;
                }
                if (eq.NombreEquipo == "" || eq.NombreEquipo == "Equipo")
                {
                    msgError("El nombre del equipo no puede estar vacio");
                    return;
                }

            }
            if (txtEquipoNombre.Text != null && comboBoxTipoEquipo.SelectedItem != null)
            {
                Conexion.OpenConexion();
                pEquipo.Save(eq, id);
                msgOk("Equipo agregado correctamente");
            }
            else { msgError("No puede dejar campos vacios!"); }
            equipoBindingSource.DataSource = pEquipo.GetAll();
            equipoBindingSource.ResetBindings(false);


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
            new modificarEquipos(((Equipo)equipoBindingSource.Current).Id).ShowDialog();
            Conexion.OpenConexion();
            equipoBindingSource.DataSource = pEquipo.GetAll();
            equipoBindingSource.ResetBindings(false);
            Conexion.CloseConexion();



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            new bajaEquipos((Equipo)equipoBindingSource.Current).ShowDialog();
            Conexion.OpenConexion();
            equipoBindingSource.DataSource = pEquipo.GetAll();
            equipoBindingSource.ResetBindings(false);
            Conexion.CloseConexion();

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

        private void txtEquipoNombre_Enter(object sender, EventArgs e)
        {
            if (txtEquipoNombre.Text == "Equipo")
            {
                txtEquipoNombre.Text = "";
                txtEquipoNombre.ForeColor = Color.Silver;
            }
        }

        private void txtEquipoNombre_Leave(object sender, EventArgs e)
        {
            if (txtEquipoNombre.Text == "")
            {
                txtEquipoNombre.Text = "Equipo";
                txtEquipoNombre.ForeColor = Color.Silver;
            }
        }
    }
}
