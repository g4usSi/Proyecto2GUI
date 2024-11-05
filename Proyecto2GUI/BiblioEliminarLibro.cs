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
    public partial class BiblioEliminarLibro : Form
    {
        Biblioteca _biblioteca;
        Libro libroBuscado = null;
        public BiblioEliminarLibro(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
            InitializeComponent();
            LimpiarSalidaDatos();

        }
        private void LimpiarSalidaDatos()
        {
            lblISBN.Text = String.Empty;
            lblRecibirTitulo.Text = String.Empty;
            lblRecibirAutor.Text = String.Empty;
            lblRecibirDisponibilidad.Visible = false;
        }

        private void btnBuscarLibro_Click_1(object sender, EventArgs e)
        {
            if (_biblioteca.LibroExistente(RecibirBuscar.Text))
            {
                libroBuscado = _biblioteca.BuscarLibroISBN(RecibirBuscar.Text);
                lblISBN.Text = libroBuscado.ISBN;
                lblRecibirTitulo.Text = libroBuscado.Titulo;
                lblRecibirAutor.Text = libroBuscado.Autor;
                lblRecibirDisponibilidad.Visible = true;
                lblRecibirDisponibilidad.Text = libroBuscado.Disponible ? "Disponible" : "No disponible"; ;
                lblMensajeUsuario.Visible = false;
            }
            else
            {
                LimpiarSalidaDatos();
                lblMensajeUsuario.Visible = true;
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            // Verifica si hay un libro cargado en los labels antes de proceder
            if (string.IsNullOrEmpty(lblISBN.Text))
            {
                MessageBox.Show("No hay ningún libro seleccionado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este libro?",
                "Confirmación de eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                bool eliminado = _biblioteca.EliminarLibro(libroBuscado);

                if (eliminado)
                {
                    MessageBox.Show("Libro eliminado exitosamente.", "Eliminación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarSalidaDatos();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarSalidaDatos();
        }
    }
}
