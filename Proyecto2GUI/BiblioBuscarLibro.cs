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
    public partial class BiblioBuscarLibro : Form
    {
        Biblioteca _bibliotecaActual;
        DataTable _dataLibrosEncontrados;
        public BiblioBuscarLibro(Biblioteca biblioteca)
        {
            _bibliotecaActual = biblioteca;   
            InitializeComponent();
            lblMensajeUsuario.Text = String.Empty;
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            _dataLibrosEncontrados = new DataTable();

            _dataLibrosEncontrados.Columns.Add("ISBN");
            _dataLibrosEncontrados.Columns.Add("Titulo");
            _dataLibrosEncontrados.Columns.Add("Autor");
            _dataLibrosEncontrados.Columns.Add("Disponibilidad");
            TablaLibrosBuscados.DataSource = _dataLibrosEncontrados;
            Consultar();
            Limpiar();
        }

        private void Consultar()
        {
            lblMensajeUsuario.Text = String.Empty;

            var librosEncontrados = _bibliotecaActual.BuscarLibrosPorTituloOAutor(RecibirBuscar.Text);

            if (librosEncontrados == null || !librosEncontrados.Any())
            {
                lblMensajeUsuario.Text = "No se encontraron resultados para la búsqueda.";
                return;
            }

            _dataLibrosEncontrados.Rows.Clear();

            foreach (var item in librosEncontrados)
            {
                DataRow fila = _dataLibrosEncontrados.NewRow();
                fila["ISBN"] = item.ISBN;
                fila["Titulo"] = item.Titulo;
                fila["Autor"] = item.Autor;
                fila["Disponibilidad"] = item.Disponible ? "Disponible" : "No Disponible";

                _dataLibrosEncontrados.Rows.Add(fila);
            }
        }

        private void Limpiar()
        {
            RecibirBuscar.Text = String.Empty;
        }
    }
}
