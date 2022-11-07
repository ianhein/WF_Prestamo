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

namespace WF_Prestamo.Forms
{
    public partial class Profesor_Ubicacion : Form
    {
        public Profesor_Ubicacion()
        {
            InitializeComponent();
            Conexion.OpenConexion();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            ubicacionBindingSource.DataSource = pUbicacion.GetAll();


            //refresh data
            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = profesorBindingSource;
            dataGridView1.Refresh();
            //refresh data after insert 
            profesorBindingSource.DataSource = pProfesor.GetAll();
            dataGridView1.Refresh();
            
        }

        private void btnAltaProfe_Click(object sender, EventArgs e)
        {
            AltaProfesor ap = new AltaProfesor();
            ap.ShowDialog();

        }

       
    }
}
