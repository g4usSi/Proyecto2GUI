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
    public partial class mainFormBibliotecario : Form
    {
        private Biblioteca _biblioteca;

        public mainFormBibliotecario(Biblioteca biblioteca)
        {
            InitializeComponent();
            _biblioteca = biblioteca;
        }

    }
}
