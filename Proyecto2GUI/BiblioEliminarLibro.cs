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
        Libro libroBuscado;
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
            lblRecibirDisponibilidad.Text = String.Empty;
        }

        private void btnBuscarLibro_Click_1(object sender, EventArgs e)
        {
            if (_biblioteca.LibroExistente(RecibirBuscar.Text))
            {
                libroBuscado = _biblioteca.BuscarLibroISBN(RecibirBuscar.Text);
                lblISBN.Text = libroBuscado.ISBN;
                lblRecibirTitulo.Text = libroBuscado.Titulo;
                lblRecibirAutor.Text = libroBuscado.Autor;
                lblRecibirDisponibilidad.Text = libroBuscado.Disponible ? "Disponible" : "No disponible";
                lblMensajeUsuario.Visible = false;
            }
            else
            {
                LimpiarSalidaDatos();
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "El libro no se encontró.";
                lblMensajeUsuario.ForeColor = Color.Red;
            }
        }


        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (libroBuscado != null)
            {
                bool eliminado = _biblioteca.EliminarLibro(libroBuscado);

                if (eliminado)
                {
                    LimpiarSalidaDatos();
                    lblMensajeUsuario.Visible = true;
                    lblMensajeUsuario.Text = "Libro eliminado: " + libroBuscado.Titulo;
                    lblMensajeUsuario.ForeColor = Color.DarkRed;

                }
                else
                {
                    lblMensajeUsuario.Visible = true;
                    lblMensajeUsuario.Text = "Error al eliminar el libro. Puede que no exista en la lista.";
                    lblMensajeUsuario.ForeColor = Color.Red;
                }
            }
            else
            {
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "Error. Campos Vacíos";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarSalidaDatos();
            libroBuscado = null;
        }
    }
}
