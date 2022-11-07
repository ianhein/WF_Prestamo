using System;
using System.Windows.Forms;
using WF_Prestamo.Persistencia;

namespace WF_Prestamo.Forms.Equipos
{
    public partial class fmEquipo : Form
    {
        public fmEquipo()
        {
            InitializeComponent();
            equipoBindingSource.DataSource = pEquipo.GetAll();
        }

        private void btnAltaEquipo_Click(object sender, EventArgs e)
        {
            fmAltaEquipo fmA = new fmAltaEquipo();
            fmA.ShowDialog();
            Conexion.OpenConexion();
            equipoBindingSource.DataSource = pEquipo.GetAll();
            Conexion.CloseConexion();
        }

        private void fmEquipo_Load(object sender, EventArgs e)
        {
            dataEquipo.DataSource = equipoBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Conexion.OpenConexion();
            
            equipoBindingSource.DataSource = pEquipo.GetAll();

        }

       
    }
}
