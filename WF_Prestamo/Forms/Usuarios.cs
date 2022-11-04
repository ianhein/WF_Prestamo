﻿using System;
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
using WF_Prestamo.Forms.Ubicaciones;

namespace WF_Prestamo.Forms
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = pUsuario.GetAll();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void préstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sobreNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void profesoresYUbicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listarProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            fmProfesor u = new fmProfesor();
            u.ShowDialog();
        }

        private void listarUbicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion.OpenConexion();
            fmUbicacion u = new fmUbicacion();
            u.ShowDialog();
        }
    }
}
