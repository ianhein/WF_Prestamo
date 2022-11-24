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
using WF_Prestamo.Forms.Ubicaciones;
using WF_Prestamo.Persistencia;
using WF_Prestamo.Test.Forms;

namespace WF_Prestamo.Test.Forms.Prestamos
{
    public partial class prestamoForm : Form
    {
        public prestamoForm()
        {
            InitializeComponent();
            prestamoBindingSource.DataSource = pPrestamo.GetAll();

        }

        private void dataGridProfe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Conexion.OpenConexion();
            prestamoBindingSource.DataSource = pPrestamo.GetAllAct();
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

        private void btnlogin_Click(object sender, EventArgs e)
        {
            altaPrestamo alta = new altaPrestamo();
            alta.ShowDialog();
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
            new modificarPrestamo(((Prestamo)prestamoBindingSource.Current).IdPrestamo).ShowDialog();
            /*new modificarPrestamo((Prestamo)prestamoBindingSource.Current).ShowDialog();*/
            Conexion.OpenConexion();
            prestamoBindingSource.DataSource = pPrestamo.GetAll();
            prestamoBindingSource.ResetBindings(false);
            Conexion.CloseConexion();


            /* Prestamo u = (Prestamo)prestamoBindingSource.Current;
             modificarPrestamo mu = new modificarPrestamo(u.ProfesorPrestamo.Id);
             Conexion.OpenConexion();
             mu.ShowDialog();
             msgUpdate("Se ha modificado correctamente!");
             prestamoBindingSource.DataSource = pPrestamo.GetAll();
             prestamoBindingSource.ResetBindings(false);*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }

        private void prestamoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
