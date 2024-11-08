using Proyecto2;
using Proyecto2.Proyecto2;
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
    public partial class LectorDevolverLibrocs : Form
    {
        Libro libroBuscar;
        Biblioteca Biblioteca;
        Prestamo prestamoUsuario;
        public LectorDevolverLibrocs(Biblioteca biblioteca)
        {

            InitializeComponent();
            Biblioteca = biblioteca;
            LimpiarLabel();
            ImprimirLibroLigado();

        }
        private void ImprimirLibroLigado()
        {
            Lector lectorActual = Biblioteca.LectorUser();
            if (lectorActual == null)
            {
                lblMensajeUsuario.Text = "No se encontró un usuario lector activo.";
                return;
            }

            prestamoUsuario = Biblioteca.DevolverLibro(lectorActual);

            if (prestamoUsuario == null)
            {
                lblMensajeUsuario.Text = "No has prestado un libro.";
                LimpiarLabel();
                return;
            }

            Libro libroLigado = prestamoUsuario.LibroPrestado;
            lblTituloLibro.Text = libroLigado.Titulo;
            lblRecibirAutor.Text = libroLigado.Autor;
            lblRecibirGenero.Text = libroLigado.Genero;
            lblRecibirDisponibilidad.Text = prestamoUsuario.FechaPrestamo.ToString();
        }

        //Devolver Libro
        // Método para devolver el libro
        private void btnSolicitarLibro_Click(object sender, EventArgs e)
        {
            if (prestamoUsuario != null)
            {
                LimpiarLabel();
                prestamoUsuario.LibroPrestado.Disponible = true;

                Biblioteca.EliminarPrestamo(prestamoUsuario);

                lblMensajeUsuario.Text = "Libro devuelto exitosamente.";
                prestamoUsuario = null;
            }
            else
            {
                lblMensajeUsuario.Text = "No has prestado un libro.";
            }
        }
        public void LimpiarLabel()
        {
            lblRecibirAutor.Text = string.Empty;
            lblRecibirDisponibilidad.Text = string.Empty;
            lblRecibirGenero.Text = string.Empty;
            lblTituloLibro.Text = string.Empty;
            lblMensajeUsuario.Text = string.Empty;
        }

    }
}
