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
using System.Security.Cryptography;
using System.Security.Policy;
using System.Runtime.ConstrainedExecution;


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
            u = pUsuario.GetByUser1(Usuario.Text);
            if (u == null)
            {
                MessageBox.Show("Usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (u.Password == CreateMD5(pass.Text))
                {
                    MessageBox.Show("Bienvenido, " + u.NombreUsuario, "Usuario correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Usuarios mp = new Usuarios();
                    mp.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            {
                u.User = Usuario.Text;
                u.Password = CreateMD5(pass.Text);
            };
            
        
            foreach (Usuario a in pUsuario.GetAll())
            {
                if (u.User == a.User)
                {
                    MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (u.User == "" || u.Password == "")
                {
                    MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (Usuario.Text != "" && pass.Text != "")
            {
                pUsuario.Save(u);
                MessageBox.Show("Se ha registrado Correctamente!");
            }
            else { MessageBox.Show("No puede dejar campos vacios!", "Error"); }


        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
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
