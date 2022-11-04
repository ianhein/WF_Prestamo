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
    public partial class fmAltaUbicacion : Form
    {
        public fmAltaUbicacion()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            altaUbicacion();
            this.Close();
        }

        public void altaUbicacion()
        {
            Entidades.Ubicacion u = new Entidades.Ubicacion();
            u.Aula = txtAula.Text;
            u.Edificio= txtEdificio.Text;

            foreach (Entidades.Ubicacion ub in pUbicacion.GetAll())
            {
                if (ub.Aula == u.Aula)
                {
                    MessageBox.Show("La ubicacion ya existe");
                    return;
                }
            }
            if (txtAula.Text != "" && txtEdificio.Text != "")
            {
                pUbicacion.Save(u);
                MessageBox.Show("Se ha registrado Correctamente!");
            }
            else { MessageBox.Show("No puede dejar campos vacios!", "Error"); }
        }
    }
}
