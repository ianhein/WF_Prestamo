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

namespace WF_Prestamo.Forms.Préstamos
{
    public partial class fmAltaPrestamo : Form
    {
        public fmAltaPrestamo()
        {
            InitializeComponent();
            prestamoBindingSource.DataSource = pPrestamo.GetAll();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
            equipoBindingSource.DataSource = pEquipo.GetDisponible();
            usuarioBindingSource.DataSource = pUsuario.GetAll();
            tipoEquipoBindingSource.DataSource = pTipoEquipo.GetAll();
            comboBoxEstadoPrestamo.SelectedIndex = 1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAltaPrestamo_Click(object sender, EventArgs e)
        {
            altaPrestamo();
            this.Close();

        }

        public void altaPrestamo()
        {
            //add new prestamo
            Prestamo p = new Prestamo();
            int idProfesor = ((Profesor)profesorBindingSource.Current).Id;
            int idUbicacion = ((Ubicacion)ubicacionBindingSource.Current).IdUbicacion;
            int idEquipo = ((Equipo)equipoBindingSource.Current).Id;
            int idUsuario = ((Usuario)usuarioBindingSource.Current).IdUsuario;
            int idTipoEquipo = ((TipoEquipo)tipoEquipoBindingSource.Current).Id;


            p.ProfesorPrestamo.Id = idProfesor;
            p.UbicacionPrestamo.IdUbicacion = idUbicacion;
            p.EquipoPrestamo.Id = idEquipo;
            p.UsuarioPrestamo.IdUsuario = idUsuario;
            p.TipoEquipoPrestamo.Id = idTipoEquipo;

            p.FechaPrestamo = dateTimeFechaPrestamo.Text = dateTimeFechaPrestamo.Value.ToString("yyyy-MM-dd");
            p.HoraInicio = dateTimeHoraInicio.Value.ToString("HH:mm");
            p.HoraFin = dateTimeHoraFin.Value.ToString("HH:mm");
            //combobox Estado prestamo to string
            p.EstadoPrestamo = comboBoxEstadoPrestamo.Text;
            //add new prestamo


            //validacion prestamo

            bool validacion = true;
            foreach (Prestamo pr in pPrestamo.GetAll())
            {
                if (pr.ProfesorPrestamo.Id == idProfesor && pr.UbicacionPrestamo.IdUbicacion == idUbicacion && pr.EquipoPrestamo.Id == idEquipo && pr.UsuarioPrestamo.IdUsuario == idUsuario && pr.FechaPrestamo == p.FechaPrestamo && pr.HoraInicio == p.HoraInicio && pr.HoraFin == p.HoraFin && pr.EstadoPrestamo == p.EstadoPrestamo)
                {
                    validacion = false;
                }
            }
            if (validacion)
            {
                if (p.FechaPrestamo == null || p.HoraInicio == null || p.HoraFin == null || p.EstadoPrestamo == null || p.ProfesorPrestamo.Id == 0 || p.UbicacionPrestamo.IdUbicacion == 0 || p.EquipoPrestamo.Id == 0 || p.UsuarioPrestamo.IdUsuario == 0 || p.TipoEquipoPrestamo.Id == 0)
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    Conexion.OpenConexion();
                    MessageBox.Show("Prestamo agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    pPrestamo.Save(p, idEquipo, idUbicacion, idUsuario, idProfesor, idTipoEquipo);
                }
            }
            else
            {
                MessageBox.Show("Prestamo ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            prestamoBindingSource.DataSource = pPrestamo.GetAll();
            
        }



        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(comboBoxEstadoPrestamo.SelectedValue);
            prestamoBindingSource.DataSource = pPrestamo.GetById(i);
        }

        private void comboBoxEstadoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
