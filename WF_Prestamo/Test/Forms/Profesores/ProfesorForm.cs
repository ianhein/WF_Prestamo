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
    public partial class ProfesorForm : Form
    {
        public ProfesorForm()
        {
            InitializeComponent();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            
        }

        public void altaProfesor()
        {
            Profesor p = new Profesor();

            p.Nombre = txtProfesorNombre.Text;
            p.Apellido = txtProfesorApellido.Text;

            foreach (Profesor pr in pProfesor.GetAll())
            {
                if (pr.Nombre == p.Nombre && pr.Apellido == p.Apellido)
                {
                    msgError("El profesor ya existe");
                    return;
                }
                if (p.Nombre == "" || p.Apellido == "" || p.Nombre == "Nombre" || p.Apellido == "Apellido")
                {
                    msgError("No puede dejar campos vacios!");
                    return;
                }
                
            }
            if (txtProfesorNombre.Text != null && txtProfesorApellido.Text != null)
            {
                Conexion.OpenConexion();
                pProfesor.Save(p);
                msgOk("Se ha registrado correctamente!");
            }
            else { msgError("No puede dejar campos vacios!"); }
            profesorBindingSource.DataSource = pProfesor.GetAll();
            profesorBindingSource.ResetBindings(false);
        }

        private void dataGridProfe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProfesorNombre_Enter(object sender, EventArgs e)
        {
            if (txtProfesorNombre.Text == "Nombre")
            {
                txtProfesorNombre.Text = "";
                txtProfesorNombre.ForeColor = Color.Silver;
            }
        }

        private void txtProfesorNombre_Leave(object sender, EventArgs e)
        {
            if (txtProfesorNombre.Text == "")
            {
                txtProfesorNombre.Text = "Nombre";
                txtProfesorNombre.ForeColor = Color.Silver;
            }
        }

        private void txtProfesorApellido_Leave(object sender, EventArgs e)
        {
            if (txtProfesorApellido.Text == "")
            {
                txtProfesorApellido.Text = "Apellido";
                txtProfesorApellido.ForeColor = Color.Silver;
            }
        }

        private void txtProfesorApellido_Enter(object sender, EventArgs e)
        {
            if (txtProfesorApellido.Text == "Apellido")
            {
                txtProfesorApellido.Text = "";
                txtProfesorApellido.ForeColor = Color.Silver;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            altaProfesor();
        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

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

        private void msgDelete(string msg)
        {
            lblmsg.Text = msg;
            lblmsg.Visible = true;
            lblmsg.ForeColor = Color.Red;
        }

        private void msgUpdate(string msg)
        {
            lblmsg.Text = msg;
            lblmsg.Visible = true;
            lblmsg.ForeColor = Color.Green;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new modificarProfesor((Profesor)profesorBindingSource.Current).ShowDialog();
            Conexion.OpenConexion();
            msgUpdate("¡Se ha actualizado correctamente!");
            profesorBindingSource.DataSource = pProfesor.GetAll();
            profesorBindingSource.ResetBindings(false);
            Conexion.CloseConexion();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            new bajaProfesor((Profesor)profesorBindingSource.Current).ShowDialog();
            Conexion.OpenConexion();
            msgOk("Se ha eliminado correctamente!");
            profesorBindingSource.DataSource = pProfesor.GetAll();
            profesorBindingSource.ResetBindings(false);
            Conexion.CloseConexion();
        }

        private void ProfesorForm_Load(object sender, EventArgs e)
        {

        }

        private void txtProfesorNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
