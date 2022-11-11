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

namespace WF_Prestamo.Forms.Préstamos
{
    public partial class fmPrestamo : Form
    {
        public fmPrestamo()
        {
            InitializeComponent();
            prestamoBindingSource.DataSource = pPrestamo.GetAll();
        }

        private void dataPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Conexion.OpenConexion();
            prestamoBindingSource.DataSource = pPrestamo.GetAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmAltaPrestamo fmAltaPrestamo = new fmAltaPrestamo();
            fmAltaPrestamo.ShowDialog();
            Conexion.OpenConexion();
            prestamoBindingSource.DataSource = pPrestamo.GetAll();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
