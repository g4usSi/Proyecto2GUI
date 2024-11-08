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
    public partial class mainFormLector : Form
    {
        Login _login;
        Biblioteca _biblioteca;
        public mainFormLector(Biblioteca biblioteca, Login login)
        {
            _login = login;
            _biblioteca = biblioteca;
            InitializeComponent();
            BienvenudoUsuario();
            lblMensajeDeshacer.Text = String.Empty;

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

        private void BotonGestionLibros_Click(object sender, EventArgs e)
        {
            OcultarBienvenida();
            openChildForm(new LectorPrestarLibro(_biblioteca));
            LimpiarLabel();
        }

        private void BotonDevolverUsuario_Click(object sender, EventArgs e)
        {
            OcultarBienvenida();
            openChildForm(new LectorDevolverLibrocs(_biblioteca));
            LimpiarLabel();
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tituloBarraBibliotecario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region LogicaVentanas
        private void BienvenudoUsuario()
        {
            lblBienvenidaUser.Text = _biblioteca.UsuarioActual.Name;
        }
        private void OcultarBienvenida()
        {
            lblBienvenida.Visible = false;
            lblBienvenidaUser.Visible = false;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            _biblioteca.CerrarSesion();
            //Se limpia el Stack de Acciones
            _login.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            _biblioteca.CerrarSesion();
            _login.Show();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Llamar Formularios
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
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void LimpiarLabel()
        {
            lblMensajeDeshacer.Text = string.Empty;
        }
        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            if (!_biblioteca.historialAcciones.EstaVacio())
            {
                AccionBiblioteca ultimaAccion = _biblioteca.historialAcciones.DeshacerUltimaAccion();

                if (ultimaAccion != null)
                {
                    if (ultimaAccion.TipoAccion == "Préstamo")
                    {
                        // Deshacer el préstamo: marcar como disponible y actualizar mensaje
                        ultimaAccion.LibroInvolucrado.Disponible = true;
                        //Logica para remover de la lista
                        lblMensajeDeshacer.Text = $"Se deshizo el préstamo del libro: '{ultimaAccion.LibroInvolucrado.Titulo}'.";
                    }
                    else if (ultimaAccion.TipoAccion == "Devolución")
                    {
                        // Deshacer la devolución: marcar como no disponible y actualizar mensaje
                        ultimaAccion.LibroInvolucrado.Disponible = false;
                        //logica para agregar a la lista
                        lblMensajeDeshacer.Text = $"Se deshizo la devolución del libro: '{ultimaAccion.LibroInvolucrado.Titulo}'.";
                    }
                }
                else
                {
                    lblMensajeDeshacer.Text = "No hay acciones para deshacer.";
                }
            }
            else
            {
                lblMensajeDeshacer.Text = "No hay acciones para deshacer.";
            }
        }
        #endregion
        /*
        //Boton deshacer accion
        private void button1_Click(object sender, EventArgs e)
        {

        }
        */


    }
}
