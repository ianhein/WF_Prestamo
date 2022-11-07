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
using System.Data.SQLite;
using WF_Prestamo;
namespace WF_Prestamo.Forms
{
    public partial class AltaProfesor : Form
    {
        
        public AltaProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            altaProfesor();
           
            this.Close();



        }

        public void altaProfesor()
        {
            Entidades.Profesor p = new Entidades.Profesor();
            
            p.Nombre = profeNombreTxt.Text;
            p.Apellido= profeApellidoTxt.Text;

            foreach (Entidades.Profesor pr in pProfesor.GetAll())
            {
                if (pr.Nombre == p.Nombre && pr.Apellido == p.Apellido)
                {
                    MessageBox.Show("El profesor ya existe");
                    return;
                }
            }
            if (profeNombreTxt.Text != "" && profeApellidoTxt.Text != "")
            {
                Conexion.OpenConexion();
                pProfesor.Save(p);
                MessageBox.Show("Se ha registrado Correctamente!");            
            }
            else { MessageBox.Show("No puede dejar campos vacios!", "Error"); }
            
           


        }

        private void profeNombreTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void profeApellidoTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
