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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_Prestamo.Forms.Préstamos
{
    public partial class fmAltaPrestamo : Form
    {
        public fmAltaPrestamo()
        {
            InitializeComponent();
            equipoBindingSource.DataSource = pEquipo.GetAll();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
            prestamoBindingSource.DataSource = pPrestamo.GetAll();
            usuarioBindingSource.DataSource = pUsuario.GetAll();
            prestamoBindingSource.DataSource = pPrestamo.GetAll();

        }

        private void fmAltaPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void altaPrestamo()
        {
            Prestamo p = new Entidades.Prestamo();
            Equipo e = new Entidades.Equipo();
            p.FechaPrestamo = datePrestamo.Value.ToString("HH:mm");
            p.HoraInicio = dateTimeHoraInicio.Value.ToString("HH:mm");
            p.HoraFin = dateTimeHoraFin.Value.ToString("HH:mm");

            foreach (Prestamo pr in pPrestamo.GetAll())
            {
                if (p.EquipoPrestamo == p.EquipoPrestamo)
                {
                    MessageBox.Show("El equipo ya esta prestado");
                    return;
                }
                if (p.FechaPrestamo == p.FechaPrestamo)
                {
                    MessageBox.Show("El equipo ya esta prestado");
                    return;
                }
               
            }
            if (datePrestamo.Value != null && dateTimeHoraInicio.Value != null && dateTimeHoraFin.Value != null && textBox1.Text != "" && comboBoxProfesor.SelectedItem != null && comboBoxAula.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                Conexion.OpenConexion();
                pPrestamo.Save(p);
                MessageBox.Show("Se ha registrado Correctamente!");
            }
            else { MessageBox.Show("No puede dejar campos vacios!", "Error"); }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
