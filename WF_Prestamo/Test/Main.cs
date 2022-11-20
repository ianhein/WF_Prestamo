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
using WF_Prestamo.Entidades;
using WF_Prestamo.Persistencia;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using WF_Prestamo.Forms.Ubicaciones;
using WF_Prestamo.Forms.Préstamos;
using WF_Prestamo.Forms.Equipos;
using WF_Prestamo.Test.Forms.Equipos;
using WF_Prestamo.Test.Forms.Ubicaciones;
using WF_Prestamo.Test.Forms;

namespace WF_Prestamo.Test
{
    public partial class Main : Form
    {
        private IconButton currentBtn;
        private Panel leftPanel;
        private Form currentChildForm;
        public Main()
        {
            InitializeComponent();
            leftPanel = new Panel();
            leftPanel.Size = new Size(7, 50);
            panelMain.Controls.Add(leftPanel);

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
           
        }

        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(17, 40, 71);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Botones de la barra de menu
                leftPanel.BackColor = color;
                leftPanel.Location = new Point(0, currentBtn.Location.Y);
                leftPanel.Visible = true;
                leftPanel.BringToFront();
                //Icono del boton hijo
                iconHijo.IconChar = currentBtn.IconChar;
                iconHijo.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(17, 40, 71);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void openChild(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;
        }

        private void iconEquipo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChild(new EquiposForm());

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void iconProfesor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChild(new ProfesorForm());
        }

        private void iconUbicacion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            openChild(new UbicacionForm());

        }

        private void iconPrestamo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            openChild(new fmPrestamo());

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftPanel.Visible = false;
            iconHijo.IconChar = IconChar.Home;
            iconHijo.IconColor = Color.Gainsboro;
            //change label to button name
            lblHome.Text = "Home";
            
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelT_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
