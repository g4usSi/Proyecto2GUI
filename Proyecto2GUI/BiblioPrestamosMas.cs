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

    public partial class BiblioPrestamosMas : Form
    {
        Biblioteca _biblioteca;
        public BiblioPrestamosMas(Biblioteca biblioteca)
        {

            _biblioteca = biblioteca;
            InitializeComponent();
            RellenarGrid();
        }
        private void RellenarGrid()
        {
            datosLibrosBiblio.Rows.Clear();

            var librosBiblioteca = _biblioteca.MostrarLibros();

            if (librosBiblioteca != null)
            {
                foreach (var l in librosBiblioteca)
                {
                    int rowIndex = datosLibrosBiblio.Rows.Add();
                    DataGridViewRow row = datosLibrosBiblio.Rows[rowIndex];
                    row.Cells[0].Value = l.ISBN;
                    row.Cells[1].Value = l.Titulo;
                    row.Cells[2].Value = l.Genero;
                    row.Cells[3].Value = l.Disponible;
                    row.Cells[4].Value = l.ContadorPrestamos;
                }

                lblMensajeUsuario.Visible = false;
            }
            else
            {
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "No hay libros en la Biblioteca.";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
            }

        }

    }
}
