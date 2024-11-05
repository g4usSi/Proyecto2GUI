using Proyecto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Proyecto2GUI
{
    public partial class mainBibliotecario : Form
    {
        Biblioteca _biblioteca;
        public Login _login;
        public mainBibliotecario(Biblioteca biblioteca, Login login)
        {
            _biblioteca = biblioteca;
            _login = login;
            InitializeComponent();
            BienvenudoUsuario();
            customizeDesign();

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
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        //Metodos diseño
        //Mensajes bienvenudo
        private void BienvenudoUsuario()
        {
            lblMensajeUser.Text = _biblioteca.UsuarioActual.ID;
        }

        private void customizeDesign()
        {
            PanelSubGestLibros.Visible = false;
            PanelGestUsuarios.Visible = false;
            PanelGenInformes.Visible = false;
        }
        private void hideSubMenu()
        {
            if (PanelSubGestLibros.Visible == true)
            {
                PanelSubGestLibros.Visible = false;
            }

            if (PanelGestUsuarios.Visible == true)
            {
                PanelGestUsuarios.Visible = false;
            }
            if (PanelGenInformes.Visible == true)
            {
                PanelGenInformes.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void OcultarBienvenida()
        {
            lblBienvenida.Visible = false;
            lblMensajeUser.Visible = false;
        }

        //Eventos Click
        #region GestionLibros
        private void BotonGestionLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubGestLibros);
        }
        
        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            OcultarBienvenida();
            openChildForm(new BiblioAgregarUsuario(_biblioteca));
            //Code...
            hideSubMenu();

        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {

            OcultarBienvenida();
            openChildForm(new BiblioBuscarLibro(_biblioteca));
            //Code...

            hideSubMenu();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            //Code...

            hideSubMenu();
        }
        #endregion

        #region GestionUsuarios
        private void BotonGestLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelGestUsuarios);
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            //Code...

            hideSubMenu();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            //Code...

            hideSubMenu();
        }
        #endregion
        #region GenerarInformes
        private void BotonGenInformes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelGenInformes);
            //Codigo
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            //Code...

            hideSubMenu();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            //Code...

            hideSubMenu();
        }
        #endregion

        #region LogicaVentana
        //Logica Basica entre ventanas
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            _biblioteca.CerrarSesion();
            _login.Show();
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private Form activeForm = null;
        //Llamada a formulario
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
    
    }
}
