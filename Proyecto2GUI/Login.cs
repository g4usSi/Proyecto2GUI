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
    public partial class Login : Form
    {
        private Biblioteca _biblioteca;

        public Login(Biblioteca biblioteca)
        {
            InitializeComponent();
            _biblioteca = biblioteca;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("No ha ingresado datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (_biblioteca.IniciarSesion(txtNombre.Text, txtPassword.Text))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //var mainForm = new MainForm(_biblioteca);  // Pasar _biblioteca si es necesario
                //mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void NuevoUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("No ha ingresado datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }

            if(_biblioteca.IniciarSesion(txtNombre.Text, txtPassword.Text))
            {

            }



        }
        */

    }
}
