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
        public BiblioEliminarLibro(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
            InitializeComponent();

        }
        private void LimpiarSalidaDatos()
        {
            lblISBN.Text = String.Empty;
            lblRecibirTitulo.Text = String.Empty;
            lblRecibirAutor.Text = String.Empty;
            lblRecibirDisponibilidad.Text = "";
        }

        private void btnBuscarLibro_Click_1(object sender, EventArgs e)
        {
            if (_biblioteca.LibroExistente(RecibirBuscar.Text))
            {
                Libro libroBuscado = _biblioteca.BuscarLibroISBN(RecibirBuscar.Text);
                lblISBN.Text = libroBuscado.ISBN;
                lblRecibirTitulo.Text = libroBuscado.Titulo;
                lblRecibirAutor.Text = libroBuscado.Autor;
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

        }
    }
}
