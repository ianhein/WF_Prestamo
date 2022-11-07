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


            //'Unable to cast object of type 'WF_Prestamo.Entidades.Profesor' to type 'WF_Prestamo.Forms.fmProfesor'.' 
            fmProfesor p = (fmProfesor)profesorBindingSource.Current;
            profesorBindingSource.DataSource = p;
            profesorBindingSource.ResetBindings(false);

            // fmProfesor p = (fmProfesor)dataProfesores.CurrentRow.DataBoundItem;
            // dataProfesores.Visible = false;
            // profesorBindingSource.DataSource = dataProfesores.CurrentRow.DataBoundItem;
            // dataProfesores.Refresh();
            // profesorBindingSource.DataSource = pProfesor.GetAll(); 











            /* fmProfesor p = (fmProfesor)profesorBindingSource.Current;
             dataProfesores.Visible = false;
             dataProfesores.DataSource = profesorBindingSource;
             dataProfesores.Refresh();
             //refresh data after insert 
             profesorBindingSource.DataSource = pProfesor.GetAll();*/
            //unable to cast type profesores to system.windows.forms.form



        }

        private void btnAltaProfe_Click(object sender, EventArgs e)
        {
            AltaProfesor ap = new AltaProfesor();
            ap.ShowDialog();
            Conexion.OpenConexion();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            Conexion.CloseConexion();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
           /* Conexion.OpenConexion();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            Conexion.CloseConexion();*/
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
            new fmBajaProfesores((Profesor)profesorBindingSource.Current).ShowDialog();
            Conexion.OpenConexion();
            profesorBindingSource.DataSource = pProfesor.GetAll();
            Conexion.CloseConexion();

        }

        private void altaBajaModificacion_Enter(object sender, EventArgs e)
        {

        }

        private void fmProfesor_Load(object sender, EventArgs e)
        {
            dataProfesores.DataSource = profesorBindingSource;
        }
    }
}
