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
            
            p.ProfesorPrestamo.Id = idProfesor;
            p.UbicacionPrestamo.IdUbicacion = idUbicacion;
            p.EquipoPrestamo.Id = idEquipo;
            p.UsuarioPrestamo.IdUsuario = idUsuario;

            p.FechaPrestamo = dateTimeFechaPrestamo.Text = dateTimeFechaPrestamo.Value.ToString("yyyy-MM-dd");
            p.HoraInicio = dateTimeHoraInicio.Value.ToString("HH:mm");
            p.HoraFin = dateTimeHoraFin.Value.ToString("HH:mm");
            p.EstadoPrestamo = comboBoxEstadoPrestamo.Text;

            Conexion.OpenConexion();
            pPrestamo.Save(p, idEquipo, idUbicacion, idUsuario, idProfesor);
        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
