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

namespace WF_Prestamo.Forms.Ubicaciones
{
    public partial class fmBajaUbicacion : Form
    {
        public fmBajaUbicacion(int id)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            ubicacionBindingSource.Add(pUbicacion.GetById(id));
            Conexion.CloseConexion();
        }

        public fmBajaUbicacion(Ubicacion u)
        {
            InitializeComponent();
            ubicacionBindingSource.Add(u);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //alert if the user is sure to delete the record
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Conexion.OpenConexion();
                pUbicacion.Delete((Ubicacion)ubicacionBindingSource.Current);
                pUbicacion.GetAll();
                Conexion.CloseConexion();
                Close();
            }
        }
    }
}
