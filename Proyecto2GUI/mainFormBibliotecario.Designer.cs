namespace Proyecto2GUI
{
    partial class mainFormBibliotecario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormBibliotecario));
            brraTitulo = new Panel();
            tituloBarraBibliotecario = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            pnelMenu = new Panel();
            button6 = new Button();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            btnMostrarEstadisticas = new Button();
            btnMostrarPrestamos = new Button();
            btnGenerarInform = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            btnEditElimUsuario = new Button();
            btnRegUsuario = new Button();
            btnGestionUsers = new Button();
            panel1 = new Panel();
            panel7 = new Panel();
            btnDelBook = new Button();
            btnAddBook = new Button();
            btnFindBook = new Button();
            btnLibros = new Button();
            lblTituloApp = new Label();
            imgLogo = new PictureBox();
            brraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            pnelMenu.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // brraTitulo
            // 
            brraTitulo.BackColor = Color.FromArgb(49, 53, 56);
            brraTitulo.Controls.Add(tituloBarraBibliotecario);
            brraTitulo.Controls.Add(btnMinimizar);
            brraTitulo.Controls.Add(btnCerrar);
            brraTitulo.Dock = DockStyle.Top;
            brraTitulo.Location = new Point(0, 0);
            brraTitulo.Name = "brraTitulo";
            brraTitulo.Size = new Size(1380, 65);
            brraTitulo.TabIndex = 0;
            brraTitulo.MouseDown += brraTitulo_MouseDown;
            // 
            // tituloBarraBibliotecario
            // 
            tituloBarraBibliotecario.AutoSize = true;
            tituloBarraBibliotecario.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloBarraBibliotecario.ForeColor = Color.Transparent;
            tituloBarraBibliotecario.Location = new Point(604, 17);
            tituloBarraBibliotecario.Name = "tituloBarraBibliotecario";
            tituloBarraBibliotecario.Size = new Size(123, 27);
            tituloBarraBibliotecario.TabIndex = 2;
            tituloBarraBibliotecario.Text = "Bibliotecario";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1271, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 40);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 9;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1328, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 8;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnelMenu
            // 
            pnelMenu.BackColor = Color.FromArgb(184, 149, 93);
            pnelMenu.Controls.Add(button6);
            pnelMenu.Controls.Add(panel6);
            pnelMenu.Controls.Add(panel5);
            pnelMenu.Controls.Add(panel4);
            pnelMenu.Controls.Add(btnGenerarInform);
            pnelMenu.Controls.Add(panel3);
            pnelMenu.Controls.Add(panel2);
            pnelMenu.Controls.Add(btnGestionUsers);
            pnelMenu.Controls.Add(panel1);
            pnelMenu.Controls.Add(panel7);
            pnelMenu.Controls.Add(btnLibros);
            pnelMenu.Controls.Add(lblTituloApp);
            pnelMenu.Controls.Add(imgLogo);
            pnelMenu.Dock = DockStyle.Left;
            pnelMenu.Location = new Point(0, 65);
            pnelMenu.Name = "pnelMenu";
            pnelMenu.Size = new Size(280, 715);
            pnelMenu.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(230, 165, 36);
            button6.Dock = DockStyle.Bottom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(0, 643);
            button6.Name = "button6";
            button6.Size = new Size(280, 42);
            button6.TabIndex = 2;
            button6.Text = "Cerrar Sesion";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 685);
            panel6.Name = "panel6";
            panel6.Size = new Size(280, 30);
            panel6.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(230, 165, 36);
            panel5.Location = new Point(0, 483);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 59);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMostrarEstadisticas);
            panel4.Controls.Add(btnMostrarPrestamos);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 542);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 85);
            panel4.TabIndex = 2;
            // 
            // btnMostrarEstadisticas
            // 
            btnMostrarEstadisticas.BackColor = Color.FromArgb(230, 165, 36);
            btnMostrarEstadisticas.Dock = DockStyle.Top;
            btnMostrarEstadisticas.FlatAppearance.BorderSize = 0;
            btnMostrarEstadisticas.FlatStyle = FlatStyle.Flat;
            btnMostrarEstadisticas.Image = (Image)resources.GetObject("btnMostrarEstadisticas.Image");
            btnMostrarEstadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarEstadisticas.Location = new Point(0, 40);
            btnMostrarEstadisticas.Name = "btnMostrarEstadisticas";
            btnMostrarEstadisticas.Padding = new Padding(50, 0, 89, 0);
            btnMostrarEstadisticas.Size = new Size(280, 40);
            btnMostrarEstadisticas.TabIndex = 1;
            btnMostrarEstadisticas.Text = "Estadisticas";
            btnMostrarEstadisticas.TextAlign = ContentAlignment.MiddleRight;
            btnMostrarEstadisticas.UseVisualStyleBackColor = false;
            btnMostrarEstadisticas.Click += btnMostrarEstadisticas_Click;
            // 
            // btnMostrarPrestamos
            // 
            btnMostrarPrestamos.BackColor = Color.FromArgb(230, 165, 36);
            btnMostrarPrestamos.Dock = DockStyle.Top;
            btnMostrarPrestamos.FlatAppearance.BorderSize = 0;
            btnMostrarPrestamos.FlatStyle = FlatStyle.Flat;
            btnMostrarPrestamos.Image = (Image)resources.GetObject("btnMostrarPrestamos.Image");
            btnMostrarPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarPrestamos.Location = new Point(0, 0);
            btnMostrarPrestamos.Name = "btnMostrarPrestamos";
            btnMostrarPrestamos.Padding = new Padding(50, 0, 45, 0);
            btnMostrarPrestamos.Size = new Size(280, 40);
            btnMostrarPrestamos.TabIndex = 0;
            btnMostrarPrestamos.Text = "Prestamos Activos";
            btnMostrarPrestamos.TextAlign = ContentAlignment.MiddleRight;
            btnMostrarPrestamos.UseVisualStyleBackColor = false;
            btnMostrarPrestamos.Click += btnMostrarPrestamos_Click;
            // 
            // btnGenerarInform
            // 
            btnGenerarInform.Dock = DockStyle.Top;
            btnGenerarInform.FlatAppearance.BorderSize = 0;
            btnGenerarInform.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 155, 66);
            btnGenerarInform.FlatStyle = FlatStyle.Flat;
            btnGenerarInform.Font = new Font("Segoe UI", 11F);
            btnGenerarInform.Image = (Image)resources.GetObject("btnGenerarInform.Image");
            btnGenerarInform.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerarInform.Location = new Point(0, 482);
            btnGenerarInform.Name = "btnGenerarInform";
            btnGenerarInform.Padding = new Padding(15, 0, 0, 0);
            btnGenerarInform.Size = new Size(280, 60);
            btnGenerarInform.TabIndex = 11;
            btnGenerarInform.Text = "Generar Informes";
            btnGenerarInform.UseVisualStyleBackColor = true;
            btnGenerarInform.Click += btnGenerarInform_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(230, 165, 36);
            panel3.Location = new Point(0, 335);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 59);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEditElimUsuario);
            panel2.Controls.Add(btnRegUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 87);
            panel2.TabIndex = 7;
            // 
            // btnEditElimUsuario
            // 
            btnEditElimUsuario.BackColor = Color.FromArgb(230, 165, 36);
            btnEditElimUsuario.Dock = DockStyle.Top;
            btnEditElimUsuario.FlatAppearance.BorderSize = 0;
            btnEditElimUsuario.FlatStyle = FlatStyle.Flat;
            btnEditElimUsuario.Image = (Image)resources.GetObject("btnEditElimUsuario.Image");
            btnEditElimUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditElimUsuario.Location = new Point(0, 40);
            btnEditElimUsuario.Name = "btnEditElimUsuario";
            btnEditElimUsuario.Padding = new Padding(50, 0, 71, 0);
            btnEditElimUsuario.Size = new Size(280, 40);
            btnEditElimUsuario.TabIndex = 1;
            btnEditElimUsuario.Text = "Editar Usuario";
            btnEditElimUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnEditElimUsuario.UseVisualStyleBackColor = false;
            btnEditElimUsuario.Click += btnEditElimUsuario_Click;
            // 
            // btnRegUsuario
            // 
            btnRegUsuario.BackColor = Color.FromArgb(230, 165, 36);
            btnRegUsuario.Dock = DockStyle.Top;
            btnRegUsuario.FlatAppearance.BorderSize = 0;
            btnRegUsuario.FlatStyle = FlatStyle.Flat;
            btnRegUsuario.Image = (Image)resources.GetObject("btnRegUsuario.Image");
            btnRegUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegUsuario.Location = new Point(0, 0);
            btnRegUsuario.Name = "btnRegUsuario";
            btnRegUsuario.Padding = new Padding(50, 0, 50, 0);
            btnRegUsuario.Size = new Size(280, 40);
            btnRegUsuario.TabIndex = 0;
            btnRegUsuario.Text = "Registrar Usuario";
            btnRegUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnRegUsuario.UseVisualStyleBackColor = false;
            btnRegUsuario.Click += btnRegUsuario_Click;
            // 
            // btnGestionUsers
            // 
            btnGestionUsers.BackgroundImageLayout = ImageLayout.Zoom;
            btnGestionUsers.Cursor = Cursors.Hand;
            btnGestionUsers.Dock = DockStyle.Top;
            btnGestionUsers.FlatAppearance.BorderSize = 0;
            btnGestionUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 155, 66);
            btnGestionUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 155, 66);
            btnGestionUsers.FlatStyle = FlatStyle.Flat;
            btnGestionUsers.Font = new Font("Segoe UI", 11F);
            btnGestionUsers.Image = (Image)resources.GetObject("btnGestionUsers.Image");
            btnGestionUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionUsers.Location = new Point(0, 335);
            btnGestionUsers.Name = "btnGestionUsers";
            btnGestionUsers.Padding = new Padding(15, 0, 0, 0);
            btnGestionUsers.Size = new Size(280, 60);
            btnGestionUsers.TabIndex = 7;
            btnGestionUsers.Text = "Gestion Usuarios";
            btnGestionUsers.UseVisualStyleBackColor = true;
            btnGestionUsers.Click += btnGestionUsers_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 165, 36);
            panel1.Location = new Point(0, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(13, 59);
            panel1.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(202, 155, 66);
            panel7.Controls.Add(btnDelBook);
            panel7.Controls.Add(btnAddBook);
            panel7.Controls.Add(btnFindBook);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 213);
            panel7.Name = "panel7";
            panel7.Size = new Size(280, 122);
            panel7.TabIndex = 10;
            // 
            // btnDelBook
            // 
            btnDelBook.BackColor = Color.FromArgb(230, 165, 36);
            btnDelBook.Dock = DockStyle.Top;
            btnDelBook.FlatAppearance.BorderSize = 0;
            btnDelBook.FlatStyle = FlatStyle.Flat;
            btnDelBook.Image = (Image)resources.GetObject("btnDelBook.Image");
            btnDelBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelBook.Location = new Point(0, 80);
            btnDelBook.Name = "btnDelBook";
            btnDelBook.Padding = new Padding(50, 0, 70, 0);
            btnDelBook.Size = new Size(280, 40);
            btnDelBook.TabIndex = 4;
            btnDelBook.Text = "Eliminar Libro";
            btnDelBook.TextAlign = ContentAlignment.MiddleRight;
            btnDelBook.UseVisualStyleBackColor = false;
            btnDelBook.Click += btnDelBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(230, 165, 36);
            btnAddBook.Dock = DockStyle.Top;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Image = (Image)resources.GetObject("btnAddBook.Image");
            btnAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBook.Location = new Point(0, 40);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Padding = new Padding(50, 0, 71, 0);
            btnAddBook.Size = new Size(280, 40);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Agregar Libro";
            btnAddBook.TextAlign = ContentAlignment.MiddleRight;
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnFindBook
            // 
            btnFindBook.BackColor = Color.FromArgb(230, 165, 36);
            btnFindBook.Dock = DockStyle.Top;
            btnFindBook.FlatAppearance.BorderSize = 0;
            btnFindBook.FlatStyle = FlatStyle.Flat;
            btnFindBook.Image = (Image)resources.GetObject("btnFindBook.Image");
            btnFindBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnFindBook.Location = new Point(0, 0);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.Padding = new Padding(50, 0, 82, 0);
            btnFindBook.Size = new Size(280, 40);
            btnFindBook.TabIndex = 3;
            btnFindBook.Text = "Buscar Libro";
            btnFindBook.TextAlign = ContentAlignment.MiddleRight;
            btnFindBook.UseVisualStyleBackColor = false;
            // 
            // btnLibros
            // 
            btnLibros.BackgroundImageLayout = ImageLayout.Zoom;
            btnLibros.Cursor = Cursors.Hand;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 155, 66);
            btnLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(202, 155, 66);
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 12F);
            btnLibros.Image = (Image)resources.GetObject("btnLibros.Image");
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(0, 153);
            btnLibros.Name = "btnLibros";
            btnLibros.Padding = new Padding(15, 0, 0, 0);
            btnLibros.Size = new Size(280, 60);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Gestion Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // lblTituloApp
            // 
            lblTituloApp.AutoSize = true;
            lblTituloApp.Font = new Font("Aston Script Bold", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloApp.Location = new Point(27, 41);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(221, 69);
            lblTituloApp.TabIndex = 5;
            lblTituloApp.Text = "Biblioteca";
            // 
            // imgLogo
            // 
            imgLogo.Dock = DockStyle.Top;
            imgLogo.Location = new Point(0, 0);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(280, 153);
            imgLogo.TabIndex = 1;
            imgLogo.TabStop = false;
            // 
            // mainFormBibliotecario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1380, 780);
            Controls.Add(pnelMenu);
            Controls.Add(brraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainFormBibliotecario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainFormBibliotecario";
            brraTitulo.ResumeLayout(false);
            brraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            pnelMenu.ResumeLayout(false);
            pnelMenu.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel brraTitulo;
        private Panel pnelMenu;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Button btnLibros;
        private PictureBox imgLogo;
        private Label lblTituloApp;
        private Label tituloBarraBibliotecario;
        private Panel panel1;
        private Button btnAddBook;
        private Button btnDelBook;
        private Button btnFindBook;
        private Panel panel2;
        private Button btnGestionUsers;
        private Panel panel7;
        private Button btnRegUsuario;
        private Button btnEditElimUsuario;
        private Panel panel3;
        private Panel panel4;
        private Button btnMostrarPrestamos;
        private Button btnGenerarInform;
        private Button btnMostrarEstadisticas;
        private Panel panel5;
        private Panel panel6;
        private Button button6;
    }
}