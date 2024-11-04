using Proyecto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Proyecto2GUI
{
    public partial class mainFormBibliotecario : Form
    {
        private Biblioteca _biblioteca;

        public mainFormBibliotecario(Biblioteca biblioteca)
        {
            InitializeComponent();
            _biblioteca = biblioteca;

            FormBorderStyle = FormBorderStyle.None;

            // Crear una región con esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            int redondeo = 10;
            Rectangle rect = this.ClientRectangle;

            // Agregar los segmentos curvos y rectos
            path.AddArc(rect.X, rect.Y, redondeo * 2, redondeo * 2, 180, 90);
            path.AddLine(rect.X + redondeo, rect.Y, rect.Right - redondeo, rect.Y);
            path.AddArc(rect.Right - redondeo * 2, rect.Y, redondeo * 2, redondeo * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + redondeo, rect.Right, rect.Bottom - redondeo);
            path.AddArc(rect.Right - redondeo * 2, rect.Bottom - redondeo * 2, redondeo * 2, redondeo * 2, 0, 90);
            path.AddLine(rect.Right - redondeo, rect.Bottom, rect.X + redondeo, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - redondeo * 2, redondeo * 2, redondeo * 2, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void brraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
