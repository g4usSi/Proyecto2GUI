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
    public partial class BiblioEditarUsuario : Form
    {
        Biblioteca _biblioteca;
        Usuario usuarioBuscar;
        public BiblioEditarUsuario(Biblioteca biblioteca)
        {
            usuarioBuscar = null;
            _biblioteca = biblioteca;
            InitializeComponent();
            lblTituloID.Visible = false;
            lblRecibirIDUser.Visible = false;
            lblRecibirRol.Visible = false;
            lblMensajeUsuario.Visible = false;
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
            usuarioBuscar = _biblioteca.BuscarUsuario(RecibirBuscar.Text);

            if (usuarioBuscar != null)
            {
                lblTituloID.Visible = true;
                lblRecibirIDUser.Visible = true;
                lblRecibirRol.Visible = true;
                lblRecibirIDUser.Text = usuarioBuscar.ID;
                RecibirNombre.Text = usuarioBuscar.Name;
                RecibirContraseña.Text = usuarioBuscar.Password;
                lblRecibirRol.Text = usuarioBuscar.Rol;
            }
            else
            {
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "Usuario no encontrado.";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioBuscar != null)
            {
                usuarioBuscar.Name = RecibirNombre.Text;
                usuarioBuscar.Password = RecibirContraseña.Text;
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "Usuario editado con éxito.";
                lblMensajeUsuario.ForeColor = Color.FromArgb(230, 165, 36);
            }
            else
            {
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "Primero debes buscar un usuario.";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
            }
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioBuscar != null)
            {
                if (_biblioteca.EliminarUsuario(usuarioBuscar))
                {
                    LimpiarTexto();
                    lblMensajeUsuario.Visible = true;
                    lblMensajeUsuario.Text = "Usuario eliminado con éxito!";
                    lblMensajeUsuario.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblMensajeUsuario.Visible = true;
                    lblMensajeUsuario.Text = "Error al eliminar el usuario.";
                    lblMensajeUsuario.ForeColor = Color.DarkRed;
                }
            }
            else
            {
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "Primero debes buscar un usuario para eliminar.";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
            }
        }

        private void LimpiarTexto()
        {
            lblTituloID.Visible = false;
            lblRecibirIDUser.Visible = false;
            lblRecibirRol.Visible = false;
            lblMensajeUsuario.Visible = false;

            RecibirNombre.Clear();
            RecibirContraseña.Clear();
            lblRecibirIDUser.Text = string.Empty;
        }
    }
}
