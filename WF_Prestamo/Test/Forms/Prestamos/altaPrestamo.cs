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
using WF_Prestamo.Persistencia;
using WF_Prestamo.Entidades;

namespace WF_Prestamo.Test.Forms.Prestamos
{
    public partial class altaPrestamo : Form
    {
        public altaPrestamo()
        {
            InitializeComponent();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            //profesorBindingSource.Find("Id", p.ProfesorPrestamo.Id);
            equipoBindingSource.DataSource = pEquipo.GetAll();

            ubicacionBindingSource.DataSource = pUbicacion.GetAll();

            tipoEquipoBindingSource.DataSource = pTipoEquipo.GetAll();

            usuarioBindingSource.DataSource = pUsuario.GetAll();
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

        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEstadoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void altaPrestamo_Load(object sender, EventArgs e)
        {

        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void altaPrestamo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btncerrar_Click(object sender, EventArgs e)
        {
            btncerrar.Click += new EventHandler(btncerrar_Click);
            this.Close();

        }
    }
}
