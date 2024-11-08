namespace Proyecto2GUI
{
    partial class mainFormLector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormLector));
            panelMenuPrincipal = new Panel();
            btnCerrarSesion = new Button();
            panel2 = new Panel();
            BotonDevolverUsuario = new Button();
            BotonPrestarLibro = new Button();
            panel1 = new Panel();
            lblTituloApp = new Label();
            barraTitulo = new Panel();
            tituloBarraBibliotecario = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelChildForm = new Panel();
            lblBienvenidaUser = new Label();
            lblBienvenida = new Label();
            btnDeshacer = new Button();
            lblMensajeDeshacer = new Label();
            panelMenuPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            panelMenuPrincipal.BackColor = Color.FromArgb(184, 149, 93);
            panelMenuPrincipal.Controls.Add(btnCerrarSesion);
            panelMenuPrincipal.Controls.Add(panel2);
            panelMenuPrincipal.Controls.Add(BotonDevolverUsuario);
            panelMenuPrincipal.Controls.Add(BotonPrestarLibro);
            panelMenuPrincipal.Controls.Add(panel1);
            panelMenuPrincipal.Dock = DockStyle.Left;
            panelMenuPrincipal.Location = new Point(0, 65);
            panelMenuPrincipal.Name = "panelMenuPrincipal";
            panelMenuPrincipal.Size = new Size(280, 715);
            panelMenuPrincipal.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 628);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(20, 0, 48, 0);
            btnCerrarSesion.Size = new Size(280, 60);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 688);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 27);
            panel2.TabIndex = 10;
            // 
            // BotonDevolverUsuario
            // 
            BotonDevolverUsuario.Cursor = Cursors.Hand;
            BotonDevolverUsuario.Dock = DockStyle.Top;
            BotonDevolverUsuario.FlatAppearance.BorderSize = 0;
            BotonDevolverUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            BotonDevolverUsuario.FlatStyle = FlatStyle.Flat;
            BotonDevolverUsuario.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            BotonDevolverUsuario.Image = (Image)resources.GetObject("BotonDevolverUsuario.Image");
            BotonDevolverUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            BotonDevolverUsuario.Location = new Point(0, 210);
            BotonDevolverUsuario.Name = "BotonDevolverUsuario";
            BotonDevolverUsuario.Padding = new Padding(20, 0, 31, 0);
            BotonDevolverUsuario.Size = new Size(280, 60);
            BotonDevolverUsuario.TabIndex = 3;
            BotonDevolverUsuario.Text = "Devolver Libro";
            BotonDevolverUsuario.TextAlign = ContentAlignment.MiddleRight;
            BotonDevolverUsuario.UseVisualStyleBackColor = true;
            BotonDevolverUsuario.Click += BotonDevolverUsuario_Click;
            // 
            // BotonPrestarLibro
            // 
            BotonPrestarLibro.Cursor = Cursors.Hand;
            BotonPrestarLibro.Dock = DockStyle.Top;
            BotonPrestarLibro.FlatAppearance.BorderSize = 0;
            BotonPrestarLibro.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            BotonPrestarLibro.FlatStyle = FlatStyle.Flat;
            BotonPrestarLibro.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            BotonPrestarLibro.Image = (Image)resources.GetObject("BotonPrestarLibro.Image");
            BotonPrestarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            BotonPrestarLibro.Location = new Point(0, 150);
            BotonPrestarLibro.Name = "BotonPrestarLibro";
            BotonPrestarLibro.Padding = new Padding(20, 0, 48, 0);
            BotonPrestarLibro.Size = new Size(280, 60);
            BotonPrestarLibro.TabIndex = 1;
            BotonPrestarLibro.Text = "Prestar Libro";
            BotonPrestarLibro.TextAlign = ContentAlignment.MiddleRight;
            BotonPrestarLibro.UseVisualStyleBackColor = true;
            BotonPrestarLibro.Click += BotonGestionLibros_Click;
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
            lblTituloApp.Font = new Font("Aston Script Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloApp.Location = new Point(8, 38);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(264, 83);
            lblTituloApp.TabIndex = 6;
            lblTituloApp.Text = "Biblioteca";
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
            barraTitulo.TabIndex = 2;
            barraTitulo.MouseDown += barraTitulo_MouseDown;
            // 
            // tituloBarraBibliotecario
            // 
            tituloBarraBibliotecario.AutoSize = true;
            tituloBarraBibliotecario.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloBarraBibliotecario.ForeColor = Color.Transparent;
            tituloBarraBibliotecario.Location = new Point(678, 19);
            tituloBarraBibliotecario.Name = "tituloBarraBibliotecario";
            tituloBarraBibliotecario.Size = new Size(67, 27);
            tituloBarraBibliotecario.TabIndex = 3;
            tituloBarraBibliotecario.Text = "Lector";
            tituloBarraBibliotecario.MouseDown += tituloBarraBibliotecario_MouseDown;
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
            // panelChildForm
            // 
            panelChildForm.Controls.Add(lblBienvenidaUser);
            panelChildForm.Controls.Add(lblBienvenida);
            panelChildForm.Location = new Point(332, 129);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1000, 600);
            panelChildForm.TabIndex = 4;
            // 
            // lblBienvenidaUser
            // 
            lblBienvenidaUser.Dock = DockStyle.Top;
            lblBienvenidaUser.Font = new Font("Aston Script Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenidaUser.Location = new Point(0, 77);
            lblBienvenidaUser.Name = "lblBienvenidaUser";
            lblBienvenidaUser.Size = new Size(1000, 78);
            lblBienvenidaUser.TabIndex = 10;
            lblBienvenidaUser.Text = "Mensaje";
            lblBienvenidaUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Dock = DockStyle.Top;
            lblBienvenida.Font = new Font("Aston Script Bold", 22F, FontStyle.Bold);
            lblBienvenida.Location = new Point(0, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(1000, 77);
            lblBienvenida.TabIndex = 9;
            lblBienvenida.Text = "Bienvenid@: ";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDeshacer
            // 
            btnDeshacer.BackColor = Color.Goldenrod;
            btnDeshacer.Cursor = Cursors.Hand;
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 165, 36);
            btnDeshacer.FlatStyle = FlatStyle.Flat;
            btnDeshacer.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            btnDeshacer.Image = (Image)resources.GetObject("btnDeshacer.Image");
            btnDeshacer.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeshacer.Location = new Point(280, 735);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Padding = new Padding(5, 0, 10, 0);
            btnDeshacer.Size = new Size(164, 45);
            btnDeshacer.TabIndex = 11;
            btnDeshacer.Text = "Deshacer";
            btnDeshacer.TextAlign = ContentAlignment.MiddleRight;
            btnDeshacer.UseVisualStyleBackColor = false;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // lblMensajeDeshacer
            // 
            lblMensajeDeshacer.Dock = DockStyle.Bottom;
            lblMensajeDeshacer.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeDeshacer.Location = new Point(280, 735);
            lblMensajeDeshacer.Name = "lblMensajeDeshacer";
            lblMensajeDeshacer.Size = new Size(1100, 45);
            lblMensajeDeshacer.TabIndex = 12;
            lblMensajeDeshacer.Text = "mensaje";
            lblMensajeDeshacer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainFormLector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 780);
            Controls.Add(btnDeshacer);
            Controls.Add(lblMensajeDeshacer);
            Controls.Add(panelChildForm);
            Controls.Add(panelMenuPrincipal);
            Controls.Add(barraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainFormLector";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainFormLector";
            panelMenuPrincipal.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            barraTitulo.ResumeLayout(false);
            barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelChildForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuPrincipal;
        private Button BotonDevolverUsuario;
        private Button BotonPrestarLibro;
        private Panel panel1;
        private Label lblTituloApp;
        private Panel barraTitulo;
        private Label tituloBarraBibliotecario;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private Button btnCerrarSesion;
        private Panel panel2;
        private Panel panelChildForm;
        private Label lblBienvenidaUser;
        private Label lblBienvenida;
        private Button btnDeshacer;
        private Label lblMensajeDeshacer;
    }
}