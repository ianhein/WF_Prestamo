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
using System.IO;
using System.Media;
using System.Reflection;

namespace WF_Prestamo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        public void Ingresar()
        {
            Usuario u = new Usuario();

            u.User = Usuario.Text;
            u.Password = pass.Text;
            List<Usuario> usuarios = pUsuario.GetByUser(u.User, u.Password);
            u.User = Program.user;

            if (usuarios.Count == 1)
            {

                MessageBox.Show("Bienvenido");
                this.Hide();
                Usuarios mp = new Usuarios();
                mp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");

            }

        }
        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrarse();
        }
        public void Registrarse()
        {
            Usuario u = new Usuario();

            u.User = Usuario.Text;
            u.Password = pass.Text;
        
            foreach (Usuario a in pUsuario.GetAll())
            {
                if (u.User == a.User)
                {
                    if (MessageBox.Show("Ese usuario ya esta en uso! elige otro") == DialogResult.OK)
                    {
                        Usuario.Clear();
                        pass.Clear();
                    }
                }
            }
            if (Usuario.Text != "" && pass.Text != "")
            {
                pUsuario.Save(u);
                MessageBox.Show("Se ha registrado Correctamente!");
            }
            else { MessageBox.Show("No puede dejar campos vacios!", "Error"); }
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            SystemSounds.Asterisk.Play();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
