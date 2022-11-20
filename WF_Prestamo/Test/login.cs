using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Prestamo.Forms;
using WF_Prestamo.Persistencia;
using WF_Prestamo.Entidades;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using WF_Prestamo.Test;
namespace WF_Prestamo.Test
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnlogin_EnabledChanged(object sender, EventArgs e)
        {

        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;

                txtpass.UseSystemPasswordChar = true;

            }

        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Transparent;
            }

        }


        private void txtpass_Leave(object sender, EventArgs e)
        {
            //hide password
            txtpass.UseSystemPasswordChar = false;
            //show text "password" when textbox is empty
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Transparent;

            }
            if (txtpass.Text != "CONTRASEÑA")
            {
                txtpass.UseSystemPasswordChar = true;
            }


        }

        public void Ingresar()
        {
            Usuario u = new Usuario();
            u = pUsuario.GetByUser1(txtuser.Text);


            if (txtuser.Text == "USUARIO" || txtpass.Text == "CONTRASEÑA" || txtuser.Text == "" || txtpass.Text == "")
            {
                errormsg("Ingrese Usuario y Contraseña");
                
                /*MessageBox.Show("Ingrese Usuario y Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
            else
            {
                if (u == null)
                {
                    errormsg("Usuario no existe");

                }
                else
                {
                    if (u.Password == CreateMD5(txtpass.Text))
                    {
                        MessageBox.Show("Bienvenido, " + u.NombreUsuario, "Usuario correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        /*Usuarios mp = new Usuarios();
                        mp.ShowDialog();*/
                        Main m = new Main();
                        m.Show();

                    }
                    else
                    {
                        errormsg("Contraseña incorrecta");
                    }
                }
            }

        }

        public void Registrarse()
        {

            Usuario u = new Usuario();
            {
                u.User = txtuser.Text;
                u.Password = CreateMD5(txtpass.Text);
            };


            foreach (Usuario a in pUsuario.GetAll())
            {
                if (u.User == a.User)
                {
                    errormsg("El usuario ya existe");
                    return;
                }
                if (u.User == "" || u.Password == "" || u.User == "USUARIO" || u.Password == "CONTRASEÑA")
                {
                    errormsg("Debe completar todos los campos");
                    return;
                }

            }
            if (txtuser.Text != "" && txtpass.Text != "")
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

       

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.ActiveForm.Hide();
            MessageBox.Show("Contacte al administrador del sistema", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new login().Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void errormsg(string msg)
        {
            lblerrormsg.Text = msg;
            lblerrormsg.Visible = true;
            lblerrormsg.ForeColor = Color.Red;
        }


        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }

}
