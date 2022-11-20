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
using WF_Prestamo.Test.Forms;

namespace WF_Prestamo.Test.Forms.Ubicaciones
{
    public partial class UbicacionForm : Form
    {
        public UbicacionForm()
        {
            InitializeComponent();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            altaUbicacion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new modificarUbicacion((Ubicacion)ubicacionBindingSource.Current).ShowDialog();
            Conexion.OpenConexion();
            msgUpdate("¡Se ha modificado la ubicación");
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
            ubicacionBindingSource.ResetBindings(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            new bajaUbicacion((Ubicacion)ubicacionBindingSource.Current).ShowDialog();
            Conexion.OpenConexion();
            msgOk("¡Se ha eliminado correctamente!");
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
            ubicacionBindingSource.ResetBindings(false);
        }

        private void txtProfesorNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtProfesorNombre_Enter(object sender, EventArgs e)
        {

        }

        private void txtProfesorNombre_Leave(object sender, EventArgs e)
        {

            if (txtAula.Text == "")
            {
                txtAula.Text = "Aula";
                txtAula.ForeColor = Color.Silver;
            }
        }

        private void txtProfesorApellido_Enter(object sender, EventArgs e)
        {
            if (txtEdificio.Text == "Edificio")
            {
                txtAula.Text = "";
                txtAula.ForeColor = Color.Silver;
            }
        }

        private void txtProfesorApellido_Leave(object sender, EventArgs e)
        {
            if (txtEdificio.Text == "")
            {
                txtEdificio.Text = "Edificio";
                txtEdificio.ForeColor = Color.Silver;
            }
        }

        private void ubicacionForm_Load(object sender, EventArgs e)
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
        private void altaUbicacion()
        {
            Ubicacion u = new Ubicacion();
            u.Aula = txtAula.Text;
            u.Edificio = txtEdificio.Text;
            
            foreach(Ubicacion ub in pUbicacion.GetAll())
            {
                if (ub.Aula == u.Aula && ub.Edificio == u.Edificio)
                {
                    msgError("La ubicación ya existe");
                    return;
                }
                if (u.Aula == "" || u.Edificio == "" || u.Aula== "Aula" || u.Edificio == "Edificio")
                {
                    msgError("No puede dejar campos vacíos!");
                    return;
                }
                
            }
            if (txtAula.Text != null && txtEdificio.Text != null)
            {
                Conexion.OpenConexion();
                pUbicacion.Save(u);
                msgOk("Se ha registrado correctamente!");
            }
            else { msgError("No puede dejar campos vacíos!"); }
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
            ubicacionBindingSource.ResetBindings(false);
        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }

        private void txtAula_Enter(object sender, EventArgs e)
        {
            if (txtAula.Text == "Aula")
            {
                txtAula.Text = "";
                txtAula.ForeColor = Color.Silver;
            }
        }

        private void txtAula_Leave(object sender, EventArgs e)
        {
            if (txtAula.Text == "")
            {
                txtAula.Text = "Aula";
                txtAula.ForeColor = Color.Silver;
            }
        }

        private void txtEdificio_Enter(object sender, EventArgs e)
        {
            if (txtEdificio.Text == "Edificio")
            {
                txtEdificio.Text = "";
                txtEdificio.ForeColor = Color.Silver;
            }
        }

        private void txtEdificio_Leave(object sender, EventArgs e)
        {
            if (txtEdificio.Text == "")
            {
                txtEdificio.Text = "Edificio";
                txtEdificio.ForeColor = Color.Silver;
            }
        }
    }
}
