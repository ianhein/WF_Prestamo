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

namespace WF_Prestamo.Forms.Ubicaciones
{
    public partial class fmUbicacion : Form
    {
        public fmUbicacion()
        {
            InitializeComponent();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();

        }

        private void btnAltaUbicacion_Click(object sender, EventArgs e)
        {
            fmAltaUbicacion au = new fmAltaUbicacion();
            au.ShowDialog();
            Conexion.OpenConexion();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
            Conexion.CloseConexion();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnBajaUbicacion_Click(object sender, EventArgs e)
        {
            Ubicacion u = (Ubicacion)ubicacionBindingSource.Current;
            fmBajaUbicacion mu = new fmBajaUbicacion(u);
            mu.ShowDialog();
            Conexion.OpenConexion();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
            Conexion.CloseConexion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Ubicacion u = (Ubicacion)ubicacionBindingSource.Current;
            fmModificarUbicacion mu = new fmModificarUbicacion(u);
            mu.ShowDialog();
            // new fmModificarUbicacion(((Ubicacion)ubicacionBindingSource.Current)).ShowDialog();


            Conexion.OpenConexion();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
        }

        private void btnRefrescarUbicacion_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
        }
    }
}
