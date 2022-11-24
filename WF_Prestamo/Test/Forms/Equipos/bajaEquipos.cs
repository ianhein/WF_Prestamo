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

namespace WF_Prestamo.Test.Forms.Equipos
{
    public partial class bajaEquipos : Form
    {
        
        public bajaEquipos()
        {
            InitializeComponent();
            Conexion.OpenConexion();
            equipoBindingSource.DataSource = pEquipo.GetAll();
        }
        
        public bajaEquipos(Equipo eq)
        {
            InitializeComponent();
            equipoBindingSource.Add(eq);

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            pEquipo.Delete((Equipo)equipoBindingSource.Current);
            pProfesor.GetAll();
            Conexion.CloseConexion();
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void bajaEquipos_Load(object sender, EventArgs e)
        {

        }
        
        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void bajaEquipos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
