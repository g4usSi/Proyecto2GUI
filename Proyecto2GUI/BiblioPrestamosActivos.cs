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
    public partial class BiblioPrestamosActivos : Form
    {
        Biblioteca _biblioteca;
        public BiblioPrestamosActivos(Biblioteca biblioteca)
        {
            _biblioteca = biblioteca;
            InitializeComponent();
            RellenarGrid();
        }
        private void RellenarGrid()
        {
            datosPrestamos.Rows.Clear();

            var prestamosActivos = _biblioteca.MostrarPrestamosActivos();

            if (prestamosActivos != null && prestamosActivos.Any())
            {
                foreach (var p in prestamosActivos)
                {
                    int rowIndex = datosPrestamos.Rows.Add();
                    DataGridViewRow row = datosPrestamos.Rows[rowIndex];
                    row.Cells[0].Value = p.LectorPrestamo.Name;
                    row.Cells[1].Value = p.LibroPrestado.ISBN;
                    row.Cells[2].Value = p.LibroPrestado.Titulo;
                    row.Cells[3].Value = p.FechaPrestamo;
                }

                lblMensajeUsuario.Visible = false;
            }
            else
            {
                lblMensajeUsuario.Visible = true;
                lblMensajeUsuario.Text = "No hay préstamos activos.";
                lblMensajeUsuario.ForeColor = Color.DarkRed;
            }

        }


    }
}
