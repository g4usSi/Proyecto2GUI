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
    public partial class LectorPrestarLibro : Form
    {
        Libro libroPrestar;
        Biblioteca _biblioteca;
        public LectorPrestarLibro(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
            InitializeComponent();
            LimpiarLabels();
            RellenarGrid();
            lblMensajeUsuario.Text = string.Empty;
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            LimpiarLabels();
            lblMensajeUsuario.Text = string.Empty;

            libroPrestar = _biblioteca.BuscarLibroISBN(RecibirBuscar.Text);

            if (libroPrestar != null)
            {
                lblRecibirTitulo.Text = libroPrestar.Titulo;
                lblRecibirAutor.Text = libroPrestar.Autor;
                lblRecibirGenero.Text = libroPrestar.Genero;
                lblRecibirDisponibilidad.Text = libroPrestar.Disponible ? "Disponible" : "No disponible";
            }
            else
            {
                lblMensajeUsuario.Text = "Error: El libro no se encuentra en la biblioteca.";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
            }
            RellenarGrid();
        }
        private void LimpiarLabels()
        {
            lblRecibirTitulo.Text = string.Empty;
            lblRecibirAutor.Text = string.Empty;
            lblRecibirGenero.Text = string.Empty;
            lblRecibirDisponibilidad.Text = string.Empty;
            
        }
        private void btnSolicitarLibro_Click(object sender, EventArgs e)
        {
            lblMensajeUsuario.Text = string.Empty;

            if (libroPrestar == null)
            {
                lblMensajeUsuario.Text = "Error: El libro no se encuentra en la biblioteca.";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
                return;
            }

            if (!libroPrestar.Disponible)
            {
                if (_biblioteca.UsuarioActual is Lector lectorPrestamo)
                {
                    SolicitudEspera nuevaSolicitud = new SolicitudEspera(lectorPrestamo, libroPrestar);
                    _biblioteca.AgregarALaListaDeEspera(nuevaSolicitud); 
                }

                lblMensajeUsuario.Text = "El libro ya está prestado. Ha sido agregado a la lista de espera.";
                lblMensajeUsuario.ForeColor = Color.FromArgb(230, 165, 36); 
                return;
            }

            // Si el libro está disponible, realiza la solicitud del libro
            if (_biblioteca.UsuarioActual is Lector lectorSolicitante)
            {
                _biblioteca.SolicitarLibro(lectorSolicitante, libroPrestar);
                libroPrestar.ContadorPrestamos++;
                lblMensajeUsuario.Text = $"El libro '{libroPrestar.Titulo}' ha sido prestado exitosamente.";
                lblMensajeUsuario.ForeColor = Color.Green; // Color de éxito
            }
        }
        private void RellenarGrid()
        {
            var librosBiblioteca = _biblioteca.MostrarLibros();

            if (librosBiblioteca != null && librosBiblioteca.Any())
            {
                foreach (var l in librosBiblioteca)
                {
                    int rowIndex = datosLibros.Rows.Add();
                    DataGridViewRow row = datosLibros.Rows[rowIndex];
                    row.Cells[0].Value = l.ISBN;
                    row.Cells[1].Value = l.Titulo;
                    row.Cells[2].Value = l.Autor;
                    row.Cells[3].Value = l.Genero;
                    row.Cells[4].Value = l.Disponible ? "Disponible" : "No Disponible";
                }
            }
            else
            {
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "No hay préstamos activos.";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
            }
        }

        //Boton no hace nada :v
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
