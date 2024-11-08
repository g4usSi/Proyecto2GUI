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
    public partial class BiblioAgregarUsuario : Form
    {
        Biblioteca _biblioteca;
        public BiblioAgregarUsuario(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
            InitializeComponent();
            lblMensajeUsuario.Visible = false;
            lblConfirmacion.Visible = false;
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RecibirID.Text) ||
                string.IsNullOrWhiteSpace(RecibirNombre.Text) ||
                string.IsNullOrWhiteSpace(RecibirContraseña.Text) ||
                RecibirRol.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_biblioteca.UsuarioExistente(RecibirID.Text))
            {
                lblMensajeUsuario.Visible = true;
                RecibirID.Clear();
                return;
            }

            int rol = RecibirRol.SelectedIndex + 1;
            
            _biblioteca.RegistrarUsuarioNuevo(RecibirID.Text, RecibirNombre.Text, RecibirContraseña.Text, rol);
            lblConfirmacion.Visible=true;
            LimpiarCampos();
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            RecibirID.Clear();
            RecibirNombre.Clear();
            RecibirContraseña.Clear();
            RecibirRol.SelectedIndex = -1;
            lblMensajeUsuario.Visible = false;
        }

    }
}
