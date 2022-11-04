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
    public partial class fmProfesor : Form
    {
        public fmProfesor()
        {
            InitializeComponent();
            profesorBindingSource.DataSource = pProfesor.GetAll();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fmProfesor p = (fmProfesor)profesorBindingSource.Current;
            dataProfesores.Visible = false;
            dataProfesores.DataSource = profesorBindingSource;
            dataProfesores.Refresh();
            //refresh data after insert 
            profesorBindingSource.DataSource = pProfesor.GetAll();


        }

        private void btnAltaProfe_Click(object sender, EventArgs e)
        {
            AltaProfesor ap = new AltaProfesor();
            ap.ShowDialog();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            Conexion.CloseConexion();
        }

        private void ModificarProfesor_Click(object sender, EventArgs e)
        {
            new fmModificarProfesor((Profesor)profesorBindingSource.Current).ShowDialog();

            Conexion.OpenConexion();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            Conexion.CloseConexion();


        }

        private void BajaProfesor_Click(object sender, EventArgs e)
        {
            new fmBajaProfesores(((Profesor)profesorBindingSource.Current)).ShowDialog();
            Conexion.OpenConexion();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            Conexion.CloseConexion();

        }

        private void altaBajaModificacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
