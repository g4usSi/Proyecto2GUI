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
            if(_bibliotecaActual.BuscarLibrosPorTituloOAutor(RecibirBuscar.Text) == null)
            {
                MessageBox.Show("No hay conincidencias", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in _bibliotecaActual.BuscarLibrosPorTituloOAutor(RecibirBuscar.Text))
            {
                DataRow fila = _dataLibrosEncontrados.NewRow();
                fila["ISBN"] = item.ISBN;
                fila["Titulo"] = item.Titulo;
                fila["Autor"] = item.Autor;
                fila["Disponibilidad"] = item.Disponible ? "Disponible" : "No Disponible";

                // Agregar la fila a la tabla de datos
                _dataLibrosEncontrados.Rows.Add(fila);
            }
        }
        private void Limpiar()
        {
            RecibirBuscar.Text = "";
        }
    }
}
