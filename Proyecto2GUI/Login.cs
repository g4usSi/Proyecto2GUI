using Proyecto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
namespace Proyecto2GUI
{
    public partial class Login : Form
    {
        Usuario usario;
        private Biblioteca _biblioteca;
        public Login(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            // Crear una región con esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            int redondeo = 13;
            Rectangle rect = this.ClientRectangle;

            // Agregar los segmentos curvos y rectos
            path.AddArc(rect.X, rect.Y, redondeo * 2, redondeo * 2, 180, 90);
            path.AddLine(rect.X + redondeo, rect.Y, rect.Right - redondeo, rect.Y);
            path.AddArc(rect.Right - redondeo * 2, rect.Y, redondeo * 2, redondeo * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + redondeo, rect.Right, rect.Bottom - redondeo);
            path.AddArc(rect.Right - redondeo * 2, rect.Bottom - redondeo * 2, redondeo * 2, redondeo * 2, 0, 90);
            path.AddLine(rect.Right - redondeo, rect.Bottom, rect.X + redondeo, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - redondeo * 2, redondeo * 2, redondeo * 2, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            this.txtNombre.KeyDown += new KeyEventHandler(Form_KeyDown);
            this.txtPassword.KeyDown += new KeyEventHandler(Form_KeyDown);
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEntrar_Click(sender, e);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("No ha ingresado datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            if (_biblioteca.IniciarSesion(txtNombre.Text, txtPassword.Text))
            {
                if (_biblioteca.UsuarioActual.Rol == "Bibliotecario")
                {
                    var mainForm = new mainBibliotecario(_biblioteca, this);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    var mainForm = new mainFormLector(_biblioteca, this);
                    mainForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEntrar_Click(sender, e);
            }
        }

        private void lblSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
