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
namespace WF_Prestamo.Test.Forms.Equipos
{
    public partial class modificarEquipos : Form
    {
        public Equipo eq;
        public modificarEquipos(int idEquipo)
        {
            InitializeComponent();
            Conexion.OpenConexion();
            eq = pEquipo.GetById(idEquipo);

            /*txtBoxNombre.Text = eq.NombreEquipo;*/

            comboBoxTipoEquipo.DataSource = pTipoEquipo.GetAll();
            comboBoxTipoEquipo.SelectedValue = eq.TipoEquipo.Id;
            /*equipoBindingSource.Add(pEquipo.GetById(idEquipo));*/
            equipoBindingSource.Add(eq);
            

        }

        public modificarEquipos(Equipo eq)
        {
            InitializeComponent();
            equipoBindingSource.Add(eq);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificarPrestamo_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            TipoEquipo tipoEqui = (TipoEquipo)comboBoxTipoEquipo.SelectedItem;
            Equipo eq = (Equipo)equipoBindingSource.Current;
            pEquipo.Update(eq, tipoEqui.Id);
            pEquipo.GetAll();
            prestamoBindingSource.ResetBindings(false);
            Close();
        }
    }
}
