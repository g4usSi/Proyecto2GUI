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

namespace Proyecto2GUI
{
    public partial class mainBibliotecario : Form
    {
        private Biblioteca _biblioteca;
        public Login _login;
        public mainBibliotecario(Biblioteca biblioteca, Login login)
        {
            _biblioteca = biblioteca;
            _login = login;
            InitializeComponent();
            customizeDesign();
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
        private void CambiarColorBoton()
        {

        }

        //Eventos Click
        private void BotonGestionLibros_Click(object sender, EventArgs e)
        {
            BotonGestionLibros.BackColor = Color.White;
            showSubMenu(PanelSubGestLibros);

            //Codigo
        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            //Code...

            hideSubMenu();

        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            //Code...

            hideSubMenu();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            //Code...

            hideSubMenu();
        }

        private void BotonGestLibros_Click(object sender, EventArgs e)
        {
            BotonGestionLibros.BackColor = Color.White;
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

        private void BotonGenInformes_Click(object sender, EventArgs e)
        {
            BotonGestionLibros.BackColor = Color.White;
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
    }
}
