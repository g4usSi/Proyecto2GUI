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
    public partial class BiblioAgregarLibro : Form
    {
        Biblioteca _biblioteca;
        public BiblioAgregarLibro(Biblioteca biliotecaActual)
        {
            _biblioteca = biliotecaActual;
            InitializeComponent();
            lblMensajeUsuario.Visible = false;

        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RecibirNombre.Text) || string.IsNullOrWhiteSpace(RecibirISBN.Text))
            {
                MessageBox.Show("El Título y el ISBN son obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_biblioteca.LibroExistente(RecibirISBN.Text))
            {
                Libro libroNuevo = new Libro(RecibirNombre.Text, RecibirAutor.Text, RecibirGenero.Text, RecibirISBN.Text);
                _biblioteca.AgregarLibro(libroNuevo);
                MessageBox.Show("Libro Agregado Exitosamente", "Se ha añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Numero de ISBN Repedito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMensajeUsuario .Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            lblMensajeUsuario.Visible = false;
            RecibirNombre.Clear();
            RecibirAutor.Clear();
            RecibirGenero.Clear();
            RecibirISBN.Clear();
        }
    }
}
