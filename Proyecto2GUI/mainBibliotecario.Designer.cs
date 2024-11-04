namespace Proyecto2GUI
{
    partial class mainBibliotecario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainBibliotecario));
            barraTitulo = new Panel();
            tituloBarraBibliotecario = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelMenuPrincipal = new Panel();
            PanelGenInformes = new Panel();
            btnEstadisticas = new Button();
            btnPrestamos = new Button();
            BotonGenInformes = new Button();
            PanelGestUsuarios = new Panel();
            btnEditarUsuario = new Button();
            btnRegistrarUsuario = new Button();
            BotonGestLibros = new Button();
            PanelSubGestLibros = new Panel();
            btnEliminarLibro = new Button();
            btnBuscarLibro = new Button();
            btnRegistrarLibro = new Button();
            BotonGestionLibros = new Button();
            panel1 = new Panel();
            lblTituloApp = new Label();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelMenuPrincipal.SuspendLayout();
            PanelGenInformes.SuspendLayout();
            PanelGestUsuarios.SuspendLayout();
            PanelSubGestLibros.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(49, 53, 56);
            barraTitulo.Controls.Add(tituloBarraBibliotecario);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(1380, 65);
            barraTitulo.TabIndex = 0;
            barraTitulo.Paint += barraTitulo_Paint;
            // 
            // tituloBarraBibliotecario
            // 
            tituloBarraBibliotecario.AutoSize = true;
            tituloBarraBibliotecario.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloBarraBibliotecario.ForeColor = Color.Transparent;
            tituloBarraBibliotecario.Location = new Point(618, 19);
            tituloBarraBibliotecario.Name = "tituloBarraBibliotecario";
            tituloBarraBibliotecario.Size = new Size(123, 27);
            tituloBarraBibliotecario.TabIndex = 3;
            tituloBarraBibliotecario.Text = "Bibliotecario";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1270, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 40);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 11;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1327, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 10;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panelMenuPrincipal
            // 
            panelMenuPrincipal.BackColor = Color.FromArgb(184, 149, 93);
            panelMenuPrincipal.Controls.Add(PanelGenInformes);
            panelMenuPrincipal.Controls.Add(BotonGenInformes);
            panelMenuPrincipal.Controls.Add(PanelGestUsuarios);
            panelMenuPrincipal.Controls.Add(BotonGestLibros);
            panelMenuPrincipal.Controls.Add(PanelSubGestLibros);
            panelMenuPrincipal.Controls.Add(BotonGestionLibros);
            panelMenuPrincipal.Controls.Add(panel1);
            panelMenuPrincipal.Dock = DockStyle.Left;
            panelMenuPrincipal.Location = new Point(0, 65);
            panelMenuPrincipal.Name = "panelMenuPrincipal";
            panelMenuPrincipal.Size = new Size(280, 715);
            panelMenuPrincipal.TabIndex = 1;
            // 
            // PanelGenInformes
            // 
            PanelGenInformes.BackColor = Color.FromArgb(240, 211, 155);
            PanelGenInformes.Controls.Add(btnEstadisticas);
            PanelGenInformes.Controls.Add(btnPrestamos);
            PanelGenInformes.Dock = DockStyle.Top;
            PanelGenInformes.Location = new Point(0, 542);
            PanelGenInformes.Name = "PanelGenInformes";
            PanelGenInformes.Size = new Size(280, 87);
            PanelGenInformes.TabIndex = 6;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.BackColor = Color.FromArgb(230, 165, 36);
            btnEstadisticas.Cursor = Cursors.Hand;
            btnEstadisticas.Dock = DockStyle.Top;
            btnEstadisticas.FlatAppearance.BorderSize = 0;
            btnEstadisticas.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnEstadisticas.Image = (Image)resources.GetObject("btnEstadisticas.Image");
            btnEstadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstadisticas.Location = new Point(0, 40);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Padding = new Padding(60, 0, 0, 0);
            btnEstadisticas.Size = new Size(280, 40);
            btnEstadisticas.TabIndex = 1;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.TextAlign = ContentAlignment.MiddleRight;
            btnEstadisticas.UseVisualStyleBackColor = false;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.FromArgb(230, 165, 36);
            btnPrestamos.Cursor = Cursors.Hand;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnPrestamos.Image = (Image)resources.GetObject("btnPrestamos.Image");
            btnPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.Location = new Point(0, 0);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Padding = new Padding(60, 0, 0, 0);
            btnPrestamos.Size = new Size(280, 40);
            btnPrestamos.TabIndex = 0;
            btnPrestamos.Text = "Prestamos Activos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleRight;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // BotonGenInformes
            // 
            BotonGenInformes.Cursor = Cursors.Hand;
            BotonGenInformes.Dock = DockStyle.Top;
            BotonGenInformes.FlatAppearance.BorderSize = 0;
            BotonGenInformes.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            BotonGenInformes.FlatStyle = FlatStyle.Flat;
            BotonGenInformes.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            BotonGenInformes.Image = (Image)resources.GetObject("BotonGenInformes.Image");
            BotonGenInformes.ImageAlign = ContentAlignment.MiddleLeft;
            BotonGenInformes.Location = new Point(0, 482);
            BotonGenInformes.Name = "BotonGenInformes";
            BotonGenInformes.Padding = new Padding(20, 0, 15, 0);
            BotonGenInformes.Size = new Size(280, 60);
            BotonGenInformes.TabIndex = 5;
            BotonGenInformes.Text = "Generar Informes";
            BotonGenInformes.TextAlign = ContentAlignment.MiddleRight;
            BotonGenInformes.UseVisualStyleBackColor = true;
            BotonGenInformes.Click += BotonGenInformes_Click;
            // 
            // PanelGestUsuarios
            // 
            PanelGestUsuarios.BackColor = Color.FromArgb(240, 211, 155);
            PanelGestUsuarios.Controls.Add(btnEditarUsuario);
            PanelGestUsuarios.Controls.Add(btnRegistrarUsuario);
            PanelGestUsuarios.Dock = DockStyle.Top;
            PanelGestUsuarios.Location = new Point(0, 395);
            PanelGestUsuarios.Name = "PanelGestUsuarios";
            PanelGestUsuarios.Size = new Size(280, 87);
            PanelGestUsuarios.TabIndex = 4;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.FromArgb(230, 165, 36);
            btnEditarUsuario.Cursor = Cursors.Hand;
            btnEditarUsuario.Dock = DockStyle.Top;
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnEditarUsuario.Image = (Image)resources.GetObject("btnEditarUsuario.Image");
            btnEditarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarUsuario.Location = new Point(0, 40);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Padding = new Padding(60, 0, 0, 0);
            btnEditarUsuario.Size = new Size(280, 40);
            btnEditarUsuario.TabIndex = 1;
            btnEditarUsuario.Text = "Editar Usuario";
            btnEditarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.BackColor = Color.FromArgb(230, 165, 36);
            btnRegistrarUsuario.Cursor = Cursors.Hand;
            btnRegistrarUsuario.Dock = DockStyle.Top;
            btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarUsuario.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnRegistrarUsuario.Image = (Image)resources.GetObject("btnRegistrarUsuario.Image");
            btnRegistrarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarUsuario.Location = new Point(0, 0);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Padding = new Padding(60, 0, 0, 0);
            btnRegistrarUsuario.Size = new Size(280, 40);
            btnRegistrarUsuario.TabIndex = 0;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // BotonGestLibros
            // 
            BotonGestLibros.Cursor = Cursors.Hand;
            BotonGestLibros.Dock = DockStyle.Top;
            BotonGestLibros.FlatAppearance.BorderSize = 0;
            BotonGestLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            BotonGestLibros.FlatStyle = FlatStyle.Flat;
            BotonGestLibros.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            BotonGestLibros.Image = (Image)resources.GetObject("BotonGestLibros.Image");
            BotonGestLibros.ImageAlign = ContentAlignment.MiddleLeft;
            BotonGestLibros.Location = new Point(0, 335);
            BotonGestLibros.Name = "BotonGestLibros";
            BotonGestLibros.Padding = new Padding(20, 0, 20, 0);
            BotonGestLibros.Size = new Size(280, 60);
            BotonGestLibros.TabIndex = 3;
            BotonGestLibros.Text = "Gestion Usuarios";
            BotonGestLibros.TextAlign = ContentAlignment.MiddleRight;
            BotonGestLibros.UseVisualStyleBackColor = true;
            BotonGestLibros.Click += BotonGestLibros_Click;
            // 
            // PanelSubGestLibros
            // 
            PanelSubGestLibros.BackColor = Color.FromArgb(240, 211, 155);
            PanelSubGestLibros.Controls.Add(btnEliminarLibro);
            PanelSubGestLibros.Controls.Add(btnBuscarLibro);
            PanelSubGestLibros.Controls.Add(btnRegistrarLibro);
            PanelSubGestLibros.Dock = DockStyle.Top;
            PanelSubGestLibros.Location = new Point(0, 210);
            PanelSubGestLibros.Name = "PanelSubGestLibros";
            PanelSubGestLibros.Size = new Size(280, 125);
            PanelSubGestLibros.TabIndex = 2;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.BackColor = Color.FromArgb(230, 165, 36);
            btnEliminarLibro.Cursor = Cursors.Hand;
            btnEliminarLibro.Dock = DockStyle.Top;
            btnEliminarLibro.FlatAppearance.BorderSize = 0;
            btnEliminarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnEliminarLibro.FlatStyle = FlatStyle.Flat;
            btnEliminarLibro.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnEliminarLibro.Image = (Image)resources.GetObject("btnEliminarLibro.Image");
            btnEliminarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarLibro.Location = new Point(0, 80);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Padding = new Padding(60, 0, 55, 0);
            btnEliminarLibro.Size = new Size(280, 40);
            btnEliminarLibro.TabIndex = 2;
            btnEliminarLibro.Text = "Eliminar Libro";
            btnEliminarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarLibro.UseVisualStyleBackColor = false;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnBuscarLibro
            // 
            btnBuscarLibro.BackColor = Color.FromArgb(230, 165, 36);
            btnBuscarLibro.Cursor = Cursors.Hand;
            btnBuscarLibro.Dock = DockStyle.Top;
            btnBuscarLibro.FlatAppearance.BorderSize = 0;
            btnBuscarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnBuscarLibro.FlatStyle = FlatStyle.Flat;
            btnBuscarLibro.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnBuscarLibro.Image = (Image)resources.GetObject("btnBuscarLibro.Image");
            btnBuscarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarLibro.Location = new Point(0, 40);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Padding = new Padding(60, 0, 66, 0);
            btnBuscarLibro.Size = new Size(280, 40);
            btnBuscarLibro.TabIndex = 1;
            btnBuscarLibro.Text = "Buscar Libro";
            btnBuscarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarLibro.UseVisualStyleBackColor = false;
            btnBuscarLibro.Click += btnBuscarLibro_Click;
            // 
            // btnRegistrarLibro
            // 
            btnRegistrarLibro.BackColor = Color.FromArgb(230, 165, 36);
            btnRegistrarLibro.BackgroundImageLayout = ImageLayout.None;
            btnRegistrarLibro.Cursor = Cursors.Hand;
            btnRegistrarLibro.Dock = DockStyle.Top;
            btnRegistrarLibro.FlatAppearance.BorderSize = 0;
            btnRegistrarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnRegistrarLibro.FlatStyle = FlatStyle.Flat;
            btnRegistrarLibro.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold);
            btnRegistrarLibro.Image = (Image)resources.GetObject("btnRegistrarLibro.Image");
            btnRegistrarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarLibro.Location = new Point(0, 0);
            btnRegistrarLibro.Name = "btnRegistrarLibro";
            btnRegistrarLibro.Padding = new Padding(60, 0, 55, 0);
            btnRegistrarLibro.Size = new Size(280, 40);
            btnRegistrarLibro.TabIndex = 0;
            btnRegistrarLibro.Text = "Agregar Libro";
            btnRegistrarLibro.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarLibro.UseVisualStyleBackColor = false;
            btnRegistrarLibro.Click += btnRegistrarLibro_Click;
            // 
            // BotonGestionLibros
            // 
            BotonGestionLibros.Cursor = Cursors.Hand;
            BotonGestionLibros.Dock = DockStyle.Top;
            BotonGestionLibros.FlatAppearance.BorderSize = 0;
            BotonGestionLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            BotonGestionLibros.FlatStyle = FlatStyle.Flat;
            BotonGestionLibros.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            BotonGestionLibros.Image = (Image)resources.GetObject("BotonGestionLibros.Image");
            BotonGestionLibros.ImageAlign = ContentAlignment.MiddleLeft;
            BotonGestionLibros.Location = new Point(0, 150);
            BotonGestionLibros.Name = "BotonGestionLibros";
            BotonGestionLibros.Padding = new Padding(20, 0, 40, 0);
            BotonGestionLibros.Size = new Size(280, 60);
            BotonGestionLibros.TabIndex = 1;
            BotonGestionLibros.Text = "Gestion Libros";
            BotonGestionLibros.TextAlign = ContentAlignment.MiddleRight;
            BotonGestionLibros.UseVisualStyleBackColor = true;
            BotonGestionLibros.Click += BotonGestionLibros_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTituloApp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 150);
            panel1.TabIndex = 0;
            // 
            // lblTituloApp
            // 
            lblTituloApp.AutoSize = true;
            lblTituloApp.Font = new Font("Aston Script Bold", 22F, FontStyle.Bold);
            lblTituloApp.Location = new Point(17, 38);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(246, 77);
            lblTituloApp.TabIndex = 6;
            lblTituloApp.Text = "Biblioteca";
            // 
            // mainBibliotecario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1380, 780);
            Controls.Add(panelMenuPrincipal);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainBibliotecario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainBibliotecario";
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelMenuPrincipal.ResumeLayout(false);
            PanelGenInformes.ResumeLayout(false);
            PanelGestUsuarios.ResumeLayout(false);
            PanelSubGestLibros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel barraTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Label tituloBarraBibliotecario;
        private Panel panelMenuPrincipal;
        private Panel panel1;
        private Button BotonGestionLibros;
        private Panel PanelSubGestLibros;
        private Button btnRegistrarLibro;
        private Button btnEliminarLibro;
        private Button btnBuscarLibro;
        private Label lblTituloApp;
        private Panel PanelGestUsuarios;
        private Button btnEditarUsuario;
        private Button btnRegistrarUsuario;
        private Button BotonGestLibros;
        private Panel PanelGenInformes;
        private Button btnEstadisticas;
        private Button btnPrestamos;
        private Button BotonGenInformes;
    }
}