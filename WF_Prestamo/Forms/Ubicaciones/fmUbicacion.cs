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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fmUbicacion p = (fmUbicacion)ubicacionBindingSource.Current;
            dataUbicacion.Visible = false;
            dataUbicacion.DataSource = ubicacionBindingSource;
            dataUbicacion.Refresh();
            //refresh data after insert 
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
        }

        private void btnBajaUbicacion_Click(object sender, EventArgs e)
        {
            new fmBajaUbicacion(((Ubicacion)ubicacionBindingSource.Current)).ShowDialog();
            Conexion.OpenConexion();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
            Conexion.CloseConexion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new fmModificarUbicacion((Ubicacion)ubicacionBindingSource.Current).ShowDialog();

            Conexion.OpenConexion();
            ubicacionBindingSource.DataSource = pProfesor.GetAll();
        }

        private void btnRefrescarUbicacion_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();
        }
    }
}
