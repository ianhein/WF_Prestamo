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

namespace WF_Prestamo.Test.Forms.Prestamos
{
    public partial class modificarPrestamo : Form
    {
        public Prestamo p;
        
        public modificarPrestamo(int idPrestamo)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            p = pPrestamo.GetById(idPrestamo);
            

            profesorBindingSource.DataSource = pProfesor.GetAll();
            //profesorBindingSource.Find("Id", p.ProfesorPrestamo.Id);
            equipoBindingSource.DataSource = pEquipo.GetAll();

            ubicacionBindingSource.DataSource = pUbicacion.GetAll();

            tipoEquipoBindingSource.DataSource = pTipoEquipo.GetAll();

            usuarioBindingSource.DataSource = pUsuario.GetAll();

            //Object reference not set to an instance of an object 
            //prestamoBindingSource.DataSource = pPrestamo.GetById(idPrestamo);

            comboBoxProfesor.DataSource = pProfesor.GetAll();
            comboBoxProfesor.SelectedValue = p.ProfesorPrestamo.Id;
            
            //cargo el combo con las listas, en teoria con el bindingsource alcanza pero por alguna razon no funciona
            //tengo que ver si es por algun cambio en las nuevas versiones, pero con esto funciona
            comboBoxEquipo.DataSource = pEquipo.GetAll();
            comboBoxEquipo.SelectedValue = p.EquipoPrestamo.Id;

            comboBoxUbicacion.DataSource = pUbicacion.GetAll();
            comboBoxUbicacion.SelectedValue = p.UbicacionPrestamo.IdUbicacion;
            
            comboBoxEstadoEquipo.DataSource = pTipoEquipo.GetAll();
            comboBoxEstadoEquipo.SelectedValue = p.TipoEquipoPrestamo.Id;
            
            comboBoxUsuario.DataSource = pUsuario.GetAll();
            comboBoxUsuario.SelectedValue = p.UsuarioPrestamo.IdUsuario;

            comboBoxEstadoPrestamo.SelectedIndex = 1;
            prestamoBindingSource.Add(p);
        }
     

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            Prestamo p = (Prestamo)prestamoBindingSource.Current;
            Profesor prof = (Profesor)profesorBindingSource.Current;
            //ubicacion current data member
            Ubicacion ubi = (Ubicacion)ubicacionBindingSource.Current;
            //equipo current data member
            Equipo equi = (Equipo)equipoBindingSource.Current;
            //usuario current data member
            //El usuario no me lo tomaba bien del bindingsource por eso lo toma del combo directamente.
            Usuario usu = (Usuario)comboBoxUsuario.SelectedItem; //usuarioBindingSource.Current;
            //tipoEquipo current data member
            TipoEquipo tipoEqui = (TipoEquipo)tipoEquipoBindingSource.Current;
            
            pPrestamo.Update(p, prof.Id, ubi.IdUbicacion, equi.Id, usu.IdUsuario, tipoEqui.Id);
            pPrestamo.GetAll();
            prestamoBindingSource.ResetBindings(false);
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAltaPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxProfesor.SelectedValue);
            profesorBindingSource.DataSource = pProfesor.GetById(i);
        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxUsuario.SelectedValue);
            usuarioBindingSource.DataSource = pUsuario.GetById(i);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxEstadoEquipo.SelectedValue);
            tipoEquipoBindingSource.DataSource = pTipoEquipo.GetById(i);
        }

        private void comboBoxEstadoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxEquipo.SelectedValue);
            equipoBindingSource.DataSource = pEquipo.GetById(i);
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prestamosForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxUbicacion.SelectedValue);
            ubicacionBindingSource.DataSource = pUbicacion.GetById(i);
        }
    }
}
